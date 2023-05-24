using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Text;

namespace Firmware_Editor
{
    public partial class Form1 : Form
    {
        UInt32[] l_ulCRCtable;
        // ELF Parser Tab
        byte[] elfData;
        List<ElfHeader> listElfHeader;
        List<SectionHeader> listSectionHeader;
        List<ProgramHeader> listProgramHeader;
        BackgroundWorker WorkerElfParse;
        string elfDataTempString;
        string sectionDataTempString;
        string programDataTempString;
        // Make Binary Tab
        List<BinaryGenArg> listBinaryArea;
        int genBinaryStartPhAddr;
        int genBinarySize;
        byte[] genBinaryData;
        // Compare Tab
        byte[] workingData;
        byte[] referenceData;
        BackgroundWorker WorkerBinaryComare;
        CompareWorkArg compareArg;
        bool compareCancel;
        int mismatchedCount;
        // Combine Tab
        byte[] combineBinaryData;


        public Form1()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.magic_wand1;

            l_ulCRCtable = new UInt32[256];
            makeCRC_32_Table(0x04C11DB7);

            // Compare Tab
            compareArg = new CompareWorkArg();
            compareCancel = false;
            WorkerBinaryComare = new BackgroundWorker();
            WorkerBinaryComare.WorkerReportsProgress = true;
            WorkerBinaryComare.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompareDatas_Work_Complete);
            WorkerBinaryComare.DoWork += new DoWorkEventHandler(CompareDatas_Work);
            WorkerBinaryComare.ProgressChanged += new ProgressChangedEventHandler(UpdateProgressBar);

            // Make Binary Tab
            listBinaryArea = new List<BinaryGenArg>();
            genBinaryStartPhAddr = 0;
            genBinarySize = 0;

            // ELF Parser Tab
            listElfHeader = new List<ElfHeader>();
            listSectionHeader = new List<SectionHeader>();
            listProgramHeader = new List<ProgramHeader>();

            WorkerElfParse = new BackgroundWorker();
            WorkerElfParse.WorkerReportsProgress = true;
            WorkerElfParse.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ElfParse_Work_Complete);
            WorkerElfParse.DoWork += new DoWorkEventHandler(ElfParse_Work);
            WorkerElfParse.ProgressChanged += new ProgressChangedEventHandler(UpdateProgressBar);

            dgvCombineBinaries.Columns[0].ValueType = ((int)0).GetType();

            // Etc Tab
            cbEtcEtcExtractDisplayFormat.Checked = true;
            nEtcExtractStartAddr.Hexadecimal = cbEtcEtcExtractDisplayFormat.Checked;
            nEtcExtractLength.Hexadecimal = cbEtcEtcExtractDisplayFormat.Checked;
            if (cbEtcEtcExtractDisplayFormat.Checked)
            {
                cbEtcEtcExtractDisplayFormat.Text = "HEX";
            }
            else
            {
                cbEtcEtcExtractDisplayFormat.Text = "DEC";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateProgressBar(object obj, ProgressChangedEventArgs arg)
        {
            progressWork.Value = arg.ProgressPercentage;
        }

        ////////////////////////////////////////
        // Compare Tab
        ////////////////////////////////////////

        private void CompareDatas_Work(object obj, DoWorkEventArgs arg)
        {
            mismatchedCount = 0;
            CompareWorkArg args = (CompareWorkArg)arg.Argument;
            Color textcolor = Color.Black;
            Color prev_color = Color.Black;
            string text = "";
            UInt32 refresh_cnt = 0;

            for (int pos = 0; pos < compareArg.textSize; pos++)
            {
                if (compareCancel)
                {
                    compareCancel = false;
                    arg.Cancel = true;
                    break;
                }
                if (cbShowDifference.Checked)
                {
                    refresh_cnt++;
                    if ((pos % 16) == 0)
                    {
                        if (pos != 0)
                        {
                            text += "\n";
                        }

                        text += (pos & 0xFFFFFFF0).ToString("X8") + ": ";
                        WorkerBinaryComare.ReportProgress((int)(pos * 100 / compareArg.textSize));
                    }

                    if (referenceData[pos] != workingData[pos])
                    {
                        mismatchedCount++;
                        textcolor = Color.Red;
                    }
                    else
                    {
                        textcolor = Color.Black;
                    }

                    if (prev_color != textcolor)
                    {
                        args.setProperty(prev_color, text);
                        if (textcolor == Color.Red)
                        {
                            args.startAddr = pos;
                        }
                        this.Invoke(new Action(() =>
                        {
                            if (compareArg.textColor == Color.Red)
                            {
                                listMismatch.Items.Add("0x" + compareArg.startAddr.ToString("X8"));
                            }
                            txtCompareResult.SelectionColor = compareArg.textColor;
                            txtCompareResult.AppendText(compareArg.textContent);
                            nMismatchedNumber.Value = mismatchedCount;
                        }));
                        prev_color = textcolor;
                        refresh_cnt = 0;
                        text = "";
                    }

                    text += workingData[pos].ToString("X2") + " ";

                    if (refresh_cnt > 128)
                    {
                        args.setProperty(textcolor, text);
                        this.Invoke(new Action(() =>
                        {
                            txtCompareResult.SelectionColor = compareArg.textColor;
                            txtCompareResult.AppendText(compareArg.textContent);
                            nMismatchedNumber.Value = mismatchedCount;
                        }));
                        refresh_cnt = 0;
                        text = "";
                    }
                }
                else
                {
                    if (referenceData[pos] != workingData[pos])
                    {
                        mismatchedCount++;
                    }
                }

            }

            if (cbShowDifference.Checked)
            {
                args.setProperty(textcolor, text);
                this.Invoke(new Action(() =>
                {
                    txtCompareResult.SelectionColor = compareArg.textColor;
                    txtCompareResult.AppendText(compareArg.textContent);
                }));
            }
            WorkerBinaryComare.ReportProgress(100);
        }

        private void CompareDatas_Work_Complete(object obj, RunWorkerCompletedEventArgs arg)
        {
            btnCompareDatas.Text = "Compare";
            nMismatchedNumber.Value = mismatchedCount;
        }

        private void btnOpenFirmware_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Bin Files(*.bin)|*.bin";

            if (DialogResult.OK == open_dialog.ShowDialog())
            {
                txtFirmwareBinPath.Text = open_dialog.FileName;
                txtFirmwareBinPath.Select(txtFirmwareBinPath.Text.Length, 0);

                workPanel.Enabled = true;

                FileStream file = File.OpenRead(open_dialog.FileName);
                BinaryReader reader = new BinaryReader(file);

                workingData = new byte[file.Length];
                reader.Read(workingData, 0, (int)file.Length);

                if (referenceData != null)
                {
                    nCompareStopAddr.Value = Math.Min(file.Length, referenceData.Length);
                }
                else
                {
                    nCompareStopAddr.Value = file.Length;
                }

                reader.Close();
                file.Close();

            }
        }

        private void btnOpenReference_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Bin Files(*.bin)|*.bin";

            if (DialogResult.OK == open_dialog.ShowDialog())
            {
                txtReferencePath.Text = open_dialog.FileName;
                txtReferencePath.Select(txtReferencePath.Text.Length, 0);

                FileStream file = File.OpenRead(open_dialog.FileName);
                BinaryReader reader = new BinaryReader(file);

                referenceData = new byte[file.Length];
                reader.Read(referenceData, 0, (int)file.Length);

                if(workingData != null)
                {
                    nCompareStopAddr.Value = Math.Min(file.Length, workingData.Length);
                }
                else
                {
                    nCompareStopAddr.Value = file.Length;
                }

                reader.Close();
                file.Close();

            }
        }

        private void btnCompareDatas_Click(object sender, EventArgs e)
        {
            if (WorkerBinaryComare.IsBusy)
            {
                compareCancel = true;
                return;
            }

            if ((referenceData == null) || (workingData == null))
            {
                return;
            }
            if ((referenceData.Length > 0) && (workingData.Length > 0))
            {
                int start_pos = (int)nCompareStartAddr.Value;
                int end_pos = (int)nCompareStopAddr.Value;

                if (referenceData.Length < (end_pos - start_pos))
                {
                    MessageBox.Show("reference data length is too short");
                    return;
                }

                if (workingData.Length < (end_pos - start_pos))
                {
                    MessageBox.Show("working data length is too short");
                    return;
                }

                lblCompareOriginFile.Text = Path.GetFileName(txtFirmwareBinPath.Text);
                lblCompareRefFile.Text = Path.GetFileName(txtReferencePath.Text);

                compareArg.textSize = end_pos;
                progressWork.Value = 0;
                txtCompareResult.Clear();
                listMismatch.Items.Clear();
                WorkerBinaryComare.RunWorkerAsync(compareArg);
                btnCompareDatas.Text = "Cancel";
            }
            else
            {
                MessageBox.Show("no comparable data");
            }
        }

        private void btnSaveUpdateArea_Click(object sender, EventArgs e)
        {
            int end_pos = (int)nCompareStopAddr.Value;

            if (workingData == null)
            {
                return;
            }
            if (workingData.Length < end_pos)
            {
                MessageBox.Show("working data length is too short");
                return;
            }

            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Bin Files(*.bin)|*.bin";

            if (DialogResult.OK == save_dialog.ShowDialog())
            {
                FileStream file = File.Create(save_dialog.FileName);
                BinaryWriter writer = new BinaryWriter(file);

                writer.Write(workingData, end_pos, workingData.Length - end_pos);

                writer.Close();
                file.Close();
            }
        }

        private void listMismatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedIndex.Text = listMismatch.SelectedIndex.ToString();
        }
 
        private void listMismatch_DoubleClick(object sender, EventArgs e)
        {
            int start_pos = Convert.ToInt32(listMismatch.SelectedItems[0].ToString(), 16);

            txtCompareResult.SelectionStart = txtCompareResult.Find(txtCompareResult.Lines[start_pos >> 4]);
            txtCompareResult.ScrollToCaret();

            string original_text = "";
            string reference_text = "";
            for (int pos = start_pos; pos < compareArg.textSize; pos++)
            {
                if (referenceData[pos] != workingData[pos])
                {
                    original_text += workingData[pos].ToString("X2") + " ";
                    reference_text += referenceData[pos].ToString("X2") + " ";
                }
                else
                {
                    break;
                }
            }

            txtOriginalVal.Text = original_text;
            txtReferenceVal.Text = reference_text;
        }

        private void cbCompareAddrFormat_CheckedChanged(object sender, EventArgs e)
        {
            nCompareStartAddr.Hexadecimal = !cbCompareAddrFormat.Checked;
            nCompareStopAddr.Hexadecimal = !cbCompareAddrFormat.Checked;
            if(cbCompareAddrFormat.Checked)
            {
                cbCompareAddrFormat.Text = "DEC";
            }
            else
            {
                cbCompareAddrFormat.Text = "HEX";
            }
        }

        ////////////////////////////////////////
        // ELF Parser Tab
        ////////////////////////////////////////

        private void btnLoadELF_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_elf = new OpenFileDialog();
            open_elf.Filter = "ELF File(*.elf)|*.elf";

            if (DialogResult.OK == open_elf.ShowDialog())
            {
                txtElfFilePath.Text = open_elf.FileName;
                txtElfFilePath.Select(txtElfFilePath.Text.Length, 0);

                tabElfParse.Enabled = true;

                FileStream file = File.OpenRead(open_elf.FileName);
                BinaryReader reader = new BinaryReader(file);

                if (file.Length < 52)
                {
                    MessageBox.Show("too short elf header");
                    return;
                }

                elfData = new byte[file.Length];
                reader.Read(elfData, 0, (int)file.Length);

                reader.Close();
                file.Close();

                listBinaryArea.Clear();
                txtBinaryNamePrefix.Text = Path.GetFileNameWithoutExtension(open_elf.FileName);
                progressWork.Value = 0;
                rtbElfHeader.Clear();
                dgvElfHeader.Rows.Clear();
                dgvSectionHeader.Rows.Clear();
                dgvProgramHeader.Rows.Clear();
                dgvMakeBinary.Rows.Clear();
                WorkerElfParse.RunWorkerAsync();
            }
        }

        private void ElfParse_Work(object obj, DoWorkEventArgs arg)
        {
            string temp = "";
            int section_offset;
            int section_entry_size;
            int section_entry_counts;
            int program_offset;
            int program_entry_size;
            int program_entry_counts;
            int string_index;
            // Parse ELF Header
            listElfHeader.Clear();

            ElfHeader component = new ElfHeader("Magic", 
                String.Format("{0:X2} {1:X2} {2:X2} {3:X2}", 
                elfData[0], elfData[1], elfData[2], elfData[3]));
            listElfHeader.Add(component);

            component = new ElfHeader("Class", (elfData[4] == 1)?"32-bit":"64-bit");
            listElfHeader.Add(component);

            component = new ElfHeader("Encoding", (elfData[5] == 1) ? "Little Endian" : "Big Endian");
            listElfHeader.Add(component);

            component = new ElfHeader("ELF Version", elfData[6]);
            listElfHeader.Add(component);

            component = new ElfHeader("OS ABI", elfData[7]);
            listElfHeader.Add(component);

            component = new ElfHeader("ABI Version", elfData[8]);
            listElfHeader.Add(component);

            switch (elfData[0x10])
            {
                case 0: temp = "0 (No file type)"; break;
                case 1: temp = "1 (Relocatable file)"; break;
                case 2: temp = "2 (Executable file)"; break;
                case 3: temp = "3 (Shared object file)"; break;
                case 4: temp = "4 (Core file)"; break;
                default: temp = "0x" + String.Format("X2", elfData[0x10]); break;
            }
            component = new ElfHeader("Type", temp);
            listElfHeader.Add(component);

            switch (elfData[0x12])
            {
                case 0x02: temp = "0x02 (SPARC)"; break;
                case 0x03: temp = "0x03 (x86)"; break;
                case 0x08: temp = "0x08 (MIPS)"; break;
                case 0x14: temp = "0x14 (Power PC)"; break;
                case 0x28: temp = "0x28 (ARM)"; break;
                case 0x3E: temp = "0x3E (x86-64)"; break;
                case 0xB7: temp = "0xB7 (AArch64)"; break;
                default: temp = "0x" + String.Format("X2", elfData[0x12]); break;
            }
            component = new ElfHeader("Machine", temp);
            listElfHeader.Add(component);

            component = new ElfHeader("Entry", BitConverter.ToInt32(elfData, 0x18), false);
            listElfHeader.Add(component);

            program_offset = BitConverter.ToInt32(elfData, 0x1C);
            component = new ElfHeader("PH Offset", program_offset, false);
            listElfHeader.Add(component);

            section_offset = BitConverter.ToInt32(elfData, 0x20);
            component = new ElfHeader("SH Offset", section_offset, false);
            listElfHeader.Add(component);

            component = new ElfHeader("Flags", BitConverter.ToInt32(elfData, 0x24), false);
            listElfHeader.Add(component);

            component = new ElfHeader("Header Size", BitConverter.ToInt16(elfData, 0x28));
            listElfHeader.Add(component);

            program_entry_size = BitConverter.ToInt16(elfData, 0x2A);
            component = new ElfHeader("PH Entry Size", program_entry_size);
            listElfHeader.Add(component);

            program_entry_counts = BitConverter.ToInt16(elfData, 0x2C);
            component = new ElfHeader("PH Entries", program_entry_counts);
            listElfHeader.Add(component);

            section_entry_size = BitConverter.ToInt16(elfData, 0x2E);
            component = new ElfHeader("SH Entry Size", section_entry_size);
            listElfHeader.Add(component);

            section_entry_counts = BitConverter.ToInt16(elfData, 0x30);
            component = new ElfHeader("SH Entries", section_entry_counts);
            listElfHeader.Add(component);

            string_index = BitConverter.ToInt16(elfData, 0x32);
            component = new ElfHeader("String Index", string_index);
            listElfHeader.Add(component);

            elfDataTempString = "";
            for (int pos = 0; pos < 52; pos++)
            {
                if ((pos % 16) == 0)
                {
                    if (pos != 0)
                    {
                        elfDataTempString += "\n";
                    }

                    elfDataTempString += (pos & 0xFFFFFFF0).ToString("X8") + ": ";
                    WorkerElfParse.ReportProgress((int)(pos * 100 / 52));

                }

                elfDataTempString += elfData[pos].ToString("X2") + " ";

            }

            // Parse Section Header
            listSectionHeader.Clear();

            int shstrtab = BitConverter.ToInt32(elfData, section_offset + (string_index * section_entry_size) + 16);
            for (int cnt=0; cnt<section_entry_counts; cnt++)
            {
                SectionHeader s_component = new SectionHeader(elfData, section_offset + cnt * section_entry_size, section_entry_size);
                s_component.setSectionName(elfData, shstrtab);
                listSectionHeader.Add(s_component);
            }

            sectionDataTempString = "";
            for (int pos = 0; pos < (section_entry_counts * section_entry_size); pos++)
            {
                if ((pos % 16) == 0)
                {
                    if (pos != 0)
                    {
                        sectionDataTempString += "\n";
                    }

                    sectionDataTempString += (pos & 0xFFFFFFF0).ToString("X8") + ": ";
                    WorkerElfParse.ReportProgress((int)(pos * 100 / (section_entry_counts * section_entry_size)));

                }

                sectionDataTempString += elfData[section_offset + pos].ToString("X2") + " ";
            }

            // Parse Program Header
            listProgramHeader.Clear();

            for (int cnt = 0; cnt < program_entry_counts; cnt++)
            {
                ProgramHeader p_component = new ProgramHeader(elfData, program_offset + (cnt * program_entry_size), program_entry_size);
                listProgramHeader.Add(p_component);
            }

            programDataTempString = "";
            for (int pos = 0; pos < (program_entry_counts * program_entry_size); pos++)
            {
                if ((pos % 16) == 0)
                {
                    if (pos != 0)
                    {
                        programDataTempString += "\n";
                    }

                    programDataTempString += (pos & 0xFFFFFFF0).ToString("X8") + ": ";
                    WorkerElfParse.ReportProgress((int)(pos * 100 / (program_entry_counts * program_entry_size)));
                }

                programDataTempString += elfData[program_offset + pos].ToString("X2") + " ";
            }

            // Update UI
            this.Invoke(new Action(() =>
            {
                dgvElfHeader.Rows.Clear();
                dgvSectionHeader.Rows.Clear();
                dgvProgramHeader.Rows.Clear();
                dgvMakeBinary.Rows.Clear();

                foreach (ElfHeader header in listElfHeader)
                {
                    dgvElfHeader.Rows.Add(header.name, header.str_value);
                }

                int index = 0;
                foreach (SectionHeader header in listSectionHeader)
                {
                    dgvSectionHeader.Rows.Add(index.ToString(),
                        header.name, header.type, header.flags,
                        header.virtual_address, header.offset, header.size, header.link);
                    index++;
                    if ((header.Type == 1) || (header.Type == 9) || (header.Type == 0x70000001))
                    {
                        int v_addr = Convert.ToInt32(header.virtual_address, 16);
                        if(v_addr!=0)
                        {
                            dgvMakeBinary.Rows.Add(false,
                                header.name, header.offset, header.virtual_address, "", header.size);
                        }
                    }
                }

                foreach (ProgramHeader header in listProgramHeader)
                {
                    dgvProgramHeader.Rows.Add(
                        header.type, header.offset, header.virtual_address,
                        header.physical_address, header.file_size, header.memory_size, header.flags);
                }

                foreach (DataGridViewRow row in dgvMakeBinary.Rows)
                {
                    DataGridViewCheckBoxCell sel = row.Cells[0] as DataGridViewCheckBoxCell;
                    string va_addr = row.Cells[3].Value.ToString();
                    int v_addr = Convert.ToInt32(va_addr, 16);
                    ProgramHeader ph = listProgramHeader.Find(x => (Convert.ToInt32(x.virtual_address, 16) == v_addr));
                    if(ph==null)
                    {
                        continue;
                    }
                    int p_addr = Convert.ToInt32(ph.physical_address, 16);
                    
                    row.Cells[4].Value = "0x" + p_addr.ToString("X8");
                }
            }));

            WorkerElfParse.ReportProgress(100);
        }

        private void ElfParse_Work_Complete(object obj, RunWorkerCompletedEventArgs arg)
        {
            if (tabElfParse.SelectedIndex == 0)
            {
                rtbElfHeader.Clear();
                rtbElfHeader.AppendText(elfDataTempString);
            }
            else if (tabElfParse.SelectedIndex == 1)
            {
                rtbElfHeader.Clear();
                rtbElfHeader.AppendText(sectionDataTempString);
            }
            else if (tabElfParse.SelectedIndex == 2)
            {
                rtbElfHeader.Clear();
                rtbElfHeader.AppendText(programDataTempString);
            }
        }

        private void tabElfParse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabElfParse.SelectedIndex == 0)
            {
                rtbElfHeader.Clear();
                rtbElfHeader.AppendText(elfDataTempString);
            }
            else if(tabElfParse.SelectedIndex == 1)
            {
                rtbElfHeader.Clear();
                rtbElfHeader.AppendText(sectionDataTempString);
            }
            else if (tabElfParse.SelectedIndex == 2)
            {
                rtbElfHeader.Clear();
                rtbElfHeader.AppendText(programDataTempString);
            }
        }

        ////////////////////////////////////////
        // Make Binary Tab
        ////////////////////////////////////////

        private int calculateGenerateBinarySize()
        {
            int size = 0;
            int start_addr = 0x7FFFFFFF;
            int end_addr = 0;
            int end_size = 0;

            foreach (BinaryGenArg arg in listBinaryArea)
            {
                if (arg.PhysicalAddress <= start_addr)
                {
                    start_addr = arg.PhysicalAddress;
                }
                if (arg.PhysicalAddress >= end_addr)
                {
                    end_addr = arg.PhysicalAddress;
                    end_size = arg.Size;
                }
            }

            if (end_addr < start_addr)
            {
                return 0;
            }

            size = (end_addr - start_addr) + end_size;
            genBinaryStartPhAddr = start_addr;
            nEndOffsetCrc32.Minimum = size;
            nMakeBinarySize.Minimum = size;
            return size;
        }

        private bool makeGenDataBuffer()
        {
            genBinarySize = calculateGenerateBinarySize();
            if (genBinarySize == 0)
            {
                return false;
            }

            int binary_size = (int)nMakeBinarySize.Value;
            if (cbSectionCRC1.Checked)
            {
                binary_size += 4;
            }
            if (cbSectionCRC2.Checked)
            {
                binary_size += 4;
            }

            genBinaryData = Enumerable.Repeat((byte)nMakeBinaryFill.Value, binary_size).ToArray();

            foreach (DataGridViewRow row in dgvMakeBinary.Rows)
            {
                DataGridViewCheckBoxCell sel = row.Cells[0] as DataGridViewCheckBoxCell;

                if ((bool)sel.Value)
                {
                    string offset = row.Cells[2].Value.ToString();
                    int i_offset = Convert.ToInt32(offset, 16);
                    string ph_addr = row.Cells[4].Value.ToString();
                    int ip_addr = Convert.ToInt32(ph_addr, 16);
                    string size = row.Cells[5].Value.ToString();
                    int i_size = Convert.ToInt32(size);

                    int dest_pos = ip_addr - genBinaryStartPhAddr;
                    if (dest_pos < 0)
                    {
                        continue;
                    }
                    Array.Copy(elfData, i_offset, genBinaryData, dest_pos, i_size);
                }
            }

            return true;
        }

        private void btnMakeBinary_Click(object sender, EventArgs e)
        {
            if(genBinarySize == 0)
            {
                MessageBox.Show("no selected area");
                return;
            }

            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Title = "Save Binary";
            save_dialog.AddExtension = true;
            save_dialog.DefaultExt = "bin";
            save_dialog.Filter = "Bin File(*.bin)|*.bin";
            save_dialog.FileName = txtBinaryNamePrefix.Text;

            if (DialogResult.OK == save_dialog.ShowDialog())
            {
                FileStream file = File.Create(save_dialog.FileName);
                BinaryWriter writer = new BinaryWriter(file);

                if (makeGenDataBuffer())
                {
                    int file_size = (int)nMakeBinarySize.Value;
                    if (cbSectionCRC1.Checked)
                    {
                        int offset = file_size;
                        UInt32 value = Convert.ToUInt32(txtSectionCRC1Value.Text, 16);
                        byte[] converted = BitConverter.GetBytes(value);
                        genBinaryData[offset + 0] = converted[0];
                        genBinaryData[offset + 1] = converted[1];
                        genBinaryData[offset + 2] = converted[2];
                        genBinaryData[offset + 3] = converted[3];
                        file_size += 4;
                    }
                    if (cbSectionCRC2.Checked)
                    {
                        int offset = file_size;
                        UInt32 value = Convert.ToUInt32(txtSectionCRC2Value.Text, 16);
                        byte[] converted = BitConverter.GetBytes(value);
                        genBinaryData[offset + 0] = converted[0];
                        genBinaryData[offset + 1] = converted[1];
                        genBinaryData[offset + 2] = converted[2];
                        genBinaryData[offset + 3] = converted[3];
                        file_size += 4;
                    }

                    writer.Write(genBinaryData, 0, file_size);
                }
                else
                {
                    MessageBox.Show("fail to make data");
                }

                writer.Close();
                file.Close();
                MessageBox.Show("Complete!!");
            }

        }

        private void dgvMakeBinary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMakeBinary.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvMakeBinary_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                return;
            }
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewCheckBoxCell sel = dgvMakeBinary.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;
            if(dgvMakeBinary.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
            {
                sel.Value = false;
                return;
            }
            if (dgvMakeBinary.Rows[e.RowIndex].Cells[3].Value.ToString() == "")
            {
                sel.Value = false;
                return;
            }
            if (dgvMakeBinary.Rows[e.RowIndex].Cells[5].Value.ToString() == "")
            {
                sel.Value = false;
                return;
            }
            string offset = dgvMakeBinary.Rows[e.RowIndex].Cells[2].Value.ToString();
            string va_addr = dgvMakeBinary.Rows[e.RowIndex].Cells[3].Value.ToString();
            string size = dgvMakeBinary.Rows[e.RowIndex].Cells[5].Value.ToString();

            int i_offset = Convert.ToInt32(offset, 16);
            int v_addr = Convert.ToInt32(va_addr, 16);
            ProgramHeader ph = listProgramHeader.Find(x => (Convert.ToInt32(x.virtual_address, 16) == v_addr));
            if(ph == null)
            {
                sel.Value = false;
                return;
            }
            int p_addr = Convert.ToInt32(ph.physical_address, 16);
            int i_size = Convert.ToInt32(size);

            if ((bool)sel.Value)
            {
                listBinaryArea.Add(new BinaryGenArg(i_offset, v_addr, p_addr, i_size));
            }
            else
            {
                BinaryGenArg exist = listBinaryArea.Find(x => (x.PhysicalAddress == p_addr));
                listBinaryArea.Remove(exist);
            }

            if(makeGenDataBuffer())
            {
                nEndOffsetCrc32.Maximum = genBinarySize;
                nEndOffsetCrc32.Value = genBinarySize;
                nMakeBinarySize.Value = genBinarySize;
                if (cbMakeFileSizeFormat.Checked)
                {
                    cbMakeFileSizeFormat.Text = "KB";
                    double converted = (double)genBinarySize / (double)1024;
                    txtMakeFileSize.Text = converted.ToString("N2");
                }
                else
                {
                    cbMakeFileSizeFormat.Text = "BYTE";
                    txtMakeFileSize.Text = genBinarySize.ToString("N0");
                }
            }
        }

        private void cbBinaryPadding_CheckedChanged(object sender, EventArgs e)
        {
            panelMakePadding.Enabled = cbBinaryPadding.Checked;
        }

        private void cbMakeFileSizeFormat_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMakeFileSizeFormat.Checked)
            {
                cbMakeFileSizeFormat.Text = "KB";
                double converted = (double)genBinarySize / (double)1024;
                txtMakeFileSize.Text = converted.ToString("N2");
            }
            else
            {
                cbMakeFileSizeFormat.Text = "BYTE";
                txtMakeFileSize.Text = genBinarySize.ToString("N0");
            }
        }

        private void btnCalcultaeCrc32_Click(object sender, EventArgs e)
        {
            int start_pos = (int)nStartOffsetCrc32.Value;
            int end_pos = (int)nEndOffsetCrc32.Value;

            if (end_pos <= start_pos)
            {
                MessageBox.Show("invalid range");
                return;
            }

            if (makeGenDataBuffer())
            {
                UInt32 result = update_CRC_32(0, genBinaryData, start_pos, end_pos - start_pos);
                nResultCrc32.Value = result;
                txtSectionCRC1Value.Text = result.ToString("X8");
            }
        }

        private void cbBinarySizeEnable_CheckedChanged(object sender, EventArgs e)
        {
            nMakeBinarySize.Enabled = cbBinarySizeEnable.Checked;
        }

        private void cbDisplayFormat_CheckedChanged(object sender, EventArgs e)
        {
            nMakeBinarySize.Hexadecimal = cbDisplayFormat.Checked;
            nStartOffsetCrc32.Hexadecimal = cbDisplayFormat.Checked;
            nEndOffsetCrc32.Hexadecimal = cbDisplayFormat.Checked;
            if (cbDisplayFormat.Checked)
            {
                cbDisplayFormat.Text = "HEX";
            }
            else
            {
                cbDisplayFormat.Text = "DEC";
            }
        }

        ////////////////////////////////////////
        // Combine Tab
        ////////////////////////////////////////

        private int calculateCombineBinarySize()
        {
            int start_addr = 0;
            int end_addr = 0;

            foreach (DataGridViewRow row in dgvCombineBinaries.Rows)
            {
                string offset = row.Cells[0].Value.ToString();
                int i_offset = Convert.ToInt32(offset, 16);

                string size = row.Cells[2].Value.ToString();
                int i_size = Convert.ToInt32(size);

                if (i_offset < end_addr)
                {
                    return 0;
                }

                if (row.Index == 0)
                {
                    start_addr = i_offset;
                }
                end_addr = i_offset + i_size - 1;
            }

            if (end_addr < start_addr)
            {
                return 0;
            }

            int total_size = end_addr + 1;
            txtCombineBinarySize.Text = total_size.ToString();
            return total_size;
        }

        private bool makeCombineDataBuffer()
        {
            int combineBinarySize = calculateCombineBinarySize();
            if (combineBinarySize == 0)
            {
                return false;
            }

            combineBinaryData = Enumerable.Repeat((byte)nMakeCombineBinaryFill.Value, combineBinarySize).ToArray();

            ///////////// copy bootloader
            DataGridViewRow row_bootloader = dgvCombineBinaries.Rows[0];
            string offset1 = row_bootloader.Cells[0].Value.ToString();
            int i_offset1 = Convert.ToInt32(offset1, 16);

            string size1 = row_bootloader.Cells[2].Value.ToString();
            int i_size1 = Convert.ToInt32(size1);

            string file_path1 = row_bootloader.Cells[3].Value.ToString();

            FileStream file1 = File.OpenRead(file_path1);
            BinaryReader reader1 = new BinaryReader(file1);

            byte[] data1 = new byte[file1.Length];
            reader1.Read(data1, 0, (int)file1.Length);

            Array.Copy(data1, 0, combineBinaryData, i_offset1, i_size1);

            ///////////// copy firmware
            DataGridViewRow row_firmware = dgvCombineBinaries.Rows[1];
            string offset2 = row_firmware.Cells[0].Value.ToString();
            int i_offset2 = Convert.ToInt32(offset2, 16);

            string size2 = row_firmware.Cells[2].Value.ToString();
            int i_size2 = Convert.ToInt32(size2);

            string file_path2 = row_firmware.Cells[3].Value.ToString();

            FileStream file2 = File.OpenRead(file_path2);
            BinaryReader reader2 = new BinaryReader(file2);

            byte[] data2 = new byte[file2.Length];
            reader2.Read(data2, 0, (int)file2.Length);

            Array.Copy(data2, 0, combineBinaryData, i_offset2, i_size2);


            if (cbCombineAddParameter.Checked)
            {
                // calculate CRC32
                int firmware_size = i_size2 - 4;
                UInt32 result = update_CRC_32(0, data2, 0, i_size2 - 4);

                combineBinaryData[0x2000] = (byte)((firmware_size >> 0) & 0xFF);
                combineBinaryData[0x2001] = (byte)((firmware_size >> 8) & 0xFF);
                combineBinaryData[0x2002] = (byte)((firmware_size >> 16) & 0xFF);
                combineBinaryData[0x2003] = (byte)((firmware_size >> 24) & 0xFF);
                combineBinaryData[0x2004] = (byte)((result >> 0) & 0xFF);
                combineBinaryData[0x2005] = (byte)((result >> 8) & 0xFF);
                combineBinaryData[0x2006] = (byte)((result >> 16) & 0xFF);
                combineBinaryData[0x2007] = (byte)((result >> 24) & 0xFF);
            }

            if (cbOverrideBinary.Checked)
            {
                int override_offset = Convert.ToInt32(txtOverrideOffset.Text, 16);
                byte[] override_data = KeyParser.HexStringToHexByte(txtOverrideBinary.Text);
                if (override_data != null)
                {
                    if((override_offset + override_data.Length) > combineBinaryData.Length)
                    {
                        byte[]  tmp = new byte[override_offset + override_data.Length];
                        Array.Copy(tmp, 0, combineBinaryData, 0, combineBinaryData.Length);
                        combineBinaryData = tmp;
                    }
                    Array.Copy(override_data, 0, combineBinaryData, override_offset, override_data.Length);
                }
            }

            return true;
        }

        private void BtnAddBootloader_Click(object sender, EventArgs e)
        {
            OpenFileDialog load_bin = new OpenFileDialog();
            load_bin.Filter = "BIN File(*.bin)|*.bin";
            load_bin.Multiselect = false;

            if (DialogResult.OK == load_bin.ShowDialog())
            {
                FileStream file = File.OpenRead(load_bin.FileName);
                dgvCombineBinaries.Rows.Insert(0,
                    0,
                    load_bin.SafeFileName,
                    file.Length,
                    load_bin.FileName
                );
                file.Close();
                btnAddBootloader.Enabled = false;
            }
        }

        private void btnAddUserFirmware_Click(object sender, EventArgs e)
        {
            OpenFileDialog load_bin = new OpenFileDialog();
            load_bin.Filter = "BIN File(*.bin)|*.bin";
            load_bin.Multiselect = false;

            if (DialogResult.OK == load_bin.ShowDialog())
            {
                FileStream file = File.OpenRead(load_bin.FileName);
                dgvCombineBinaries.Rows.Insert(1,
                    "20000",
                    load_bin.SafeFileName,
                    file.Length,
                    load_bin.FileName
                );
                file.Close();
                btnAddUserFirmware.Enabled = false;
            }
        }

        private void btnRemoveBinary_Click(object sender, EventArgs e)
        {
            dgvCombineBinaries.Rows.Clear();
            btnAddUserFirmware.Enabled = true;
            btnAddBootloader.Enabled = true;
        }

        private void cbOverrideBinary_CheckedChanged(object sender, EventArgs e)
        {
            gbOverrideCombineBin.Enabled = cbOverrideBinary.Checked;
        }

        private void btnMakeCombineBinary_Click(object sender, EventArgs e)
        {
            if (dgvCombineBinaries.Rows.Count != 2)
            {
                return;
            }
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Title = "Save Binary";
            save_dialog.AddExtension = true;
            save_dialog.DefaultExt = "bin";
            save_dialog.Filter = "Bin File(*.bin)|*.bin";
            save_dialog.FileName = txtCombineBinaryNamePrefix.Text;

            if (DialogResult.OK == save_dialog.ShowDialog())
            {
                FileStream file = File.Create(save_dialog.FileName);
                BinaryWriter writer = new BinaryWriter(file);

                if (makeCombineDataBuffer())
                {
                    writer.Write(combineBinaryData, 0, combineBinaryData.Length);
                }
                else
                {
                    MessageBox.Show("fail to combine data");
                }

                writer.Close();
                file.Close();
                MessageBox.Show("Complete!!");
            }

        }

        ////////////////////////////////////////
        // Extract Tab
        ////////////////////////////////////////

        private void cbExtractDisplayFormat_CheckedChanged(object sender, EventArgs e)
        {
            nEtcExtractStartAddr.Hexadecimal = cbEtcEtcExtractDisplayFormat.Checked;
            nEtcExtractLength.Hexadecimal = cbEtcEtcExtractDisplayFormat.Checked;
            if (cbEtcEtcExtractDisplayFormat.Checked)
            {
                cbEtcEtcExtractDisplayFormat.Text = "HEX";
            }
            else
            {
                cbEtcEtcExtractDisplayFormat.Text = "DEC";
            }
        }
        
        private void btnOpenExtractFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_bin = new OpenFileDialog();
            open_bin.Filter = "BIN File(*.bin)|*.bin";

            if (DialogResult.OK == open_bin.ShowDialog())
            {
                txtEtcExtractFilePath.Text = open_bin.FileName;
            }
        }

        private void btnExtractFile_Click(object sender, EventArgs e)
        {
            if(txtEtcExtractFilePath.Text == "")
            {
                return;
            }
            if (nEtcExtractLength.Value == 0)
            {
                return;
            }

            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Title = "Save Binary";
            save_dialog.AddExtension = true;
            save_dialog.DefaultExt = "bin";
            save_dialog.Filter = "Bin File(*.bin)|*.bin";

            if (DialogResult.OK == save_dialog.ShowDialog())
            {
                FileStream file_r = File.OpenRead(txtEtcExtractFilePath.Text);
                BinaryReader reader = new BinaryReader(file_r);

                int i_offset = (int)nEtcExtractStartAddr.Value;
                int i_length = (int)nEtcExtractLength.Value;

                if ((i_offset < file_r.Length) &&
                    (i_offset + i_length <= file_r.Length))
                {
                    byte[] readAll = new byte[file_r.Length];
                    reader.Read(readAll, 0, (int)file_r.Length);

                    byte[] readData = new byte[i_length];

                    Array.Copy(readAll, i_offset, readData, 0, i_length);

                    FileStream file_w = File.Create(save_dialog.FileName);
                    BinaryWriter writer = new BinaryWriter(file_w);

                    writer.Write(readData, 0, i_length);

                    writer.Close();
                    file_w.Close();
                }

                reader.Close();
                file_r.Close();
                MessageBox.Show("Complete!!");
            }
        }

        private void btnEtcOpenCrc32Firmware_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_bin = new OpenFileDialog();
            open_bin.Filter = "BIN File(*.bin)|*.bin";

            if (DialogResult.OK == open_bin.ShowDialog())
            {
                txtEtcCrc32FirmwarePath.Text = open_bin.FileName;
            }
        }

        private void btnEtcGenerateCrc32Firmware_Click(object sender, EventArgs e)
        {
            if (txtEtcCrc32FirmwarePath.Text == "")
            {
                return;
            }

            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Title = "Save Binary";
            save_dialog.AddExtension = true;
            save_dialog.DefaultExt = "bin";
            save_dialog.Filter = "Bin File(*.bin)|*.bin";

            if (DialogResult.OK == save_dialog.ShowDialog())
            {
                // read
                FileStream file_r = File.OpenRead(txtEtcCrc32FirmwarePath.Text);
                BinaryReader reader = new BinaryReader(file_r);

                byte[] readAll = new byte[file_r.Length];
                reader.Read(readAll, 0, (int)file_r.Length);

                // copy
                int aligned_size = (int)file_r.Length;
                if (file_r.Length % 4 > 0)
                {
                    aligned_size += (4- (int)(file_r.Length % 4));
                }

                byte[] copy_data = new byte[aligned_size + 4];

                Array.Copy(readAll, 0, copy_data, 0, file_r.Length);

                // calculate CRC32
                UInt32 result = update_CRC_32(0, copy_data, 0, aligned_size);
                lblEtcCrc32Result.Text = result.ToString("X8");

                copy_data[aligned_size]   = (byte)((result >> 0) & 0xFF);
                copy_data[aligned_size+1] = (byte)((result >> 8) & 0xFF);
                copy_data[aligned_size+2] = (byte)((result >> 16) & 0xFF);
                copy_data[aligned_size+3] = (byte)((result >> 24) & 0xFF);

                // save
                FileStream file_w = File.Create(save_dialog.FileName);
                BinaryWriter writer = new BinaryWriter(file_w);

                writer.Write(copy_data, 0, aligned_size + 4);

                writer.Close();
                file_w.Close();

                reader.Close();
                file_r.Close();

                MessageBox.Show("Complete!!");
            }
        }

        ////////////////////////////////////////
        // User Function
        ////////////////////////////////////////

        private void makeCRC_32_Table(UInt32 polynomial)
        {
            const UInt32 V = (0x80000000);
            UInt32 i, j;
            UInt32 c;

            l_ulCRCtable[0] = 0;

            for (i = 0; i < 256; i++)
            {
                for (c = i << 24, j = 8; j > 0; --j)
                    c = ((c & V) > 0) ? ((c << 1) ^ 0x04c11db7) : (c << 1);
                l_ulCRCtable[i] = c;
            }

        }

        UInt32 update_CRC_32(UInt32 p_ulCRC, byte[] p_cpBuffer, int offset, int p_uiLen)
        {
            UInt32 crc = p_ulCRC;
            UInt32 pos = 0;

            while ((p_uiLen--) > 0)
            {
                crc = (crc << 8) ^ l_ulCRCtable[((crc >> 24) ^ p_cpBuffer[pos+ offset]) & 255];
                pos++;
            }
            return crc;
        }

    }

    public class CompareWorkArg
    {
        int _start_addr;
        int _text_size;
        Color _textColor;
        string _tmpString;

        public CompareWorkArg()
        {
            _textColor = Color.Black;
        }
        public int textSize
        {
            set { _text_size = value; }
            get { return _text_size; }
        }
        public int startAddr
        {
            set { _start_addr = value; }
            get { return _start_addr; }
        }
        public Color textColor
        {
            get { return _textColor; }
        }
        public string textContent
        {
            get { return _tmpString; }
        }
        public void setProperty(Color color, string str_input)
        {
            _textColor = color;
            _tmpString = str_input;
        }
    }

    public class ElfHeader
    {
        public string name;
        public string str_value;
        public int int_value;

        public ElfHeader(string _name, int _val, bool is_dec = true)
        {
            name = _name;
            int_value = _val;
            if(is_dec)
            {
                str_value = _val.ToString();
            }
            else
            {
                str_value = "0x" + _val.ToString("X8");
            }
        }
        public ElfHeader(string _name, char _val, bool is_dec = true)
        {
            name = _name;
            int_value = _val;
            if (is_dec)
            {
                str_value = _val.ToString();
            }
            else
            {
                str_value = "0x" + ((int)_val).ToString("X2");
            }
        }
        public ElfHeader(string _name, short _val, bool is_dec = true)
        {
            name = _name;
            int_value = _val;
            if (is_dec)
            {
                str_value = _val.ToString();
            }
            else
            {
                str_value = "0x" + _val.ToString("X4");
            }
        }
        public ElfHeader(string _name, string _val)
        {
            name = _name;
            str_value = _val;
        }
    }

    public class SectionHeader
    {
        public string name;
        public string type;
        public string flags;
        public string virtual_address;
        public string offset;
        public string size;
        public string link;
        private int name_offset;
        private uint int_type;
        private int int_flags;

        public uint Type
        {
            get
            {
                return int_type;
            }
        }
        public int Flags
        {
            get
            {
                return int_flags;
            }
        }

        public override string ToString()
        {
            return name;
        }
        public SectionHeader(byte[] section_header, int in_offset, int in_size)
        {
            name_offset = BitConverter.ToInt32(section_header, in_offset + 0);
            name = "0x" + name_offset.ToString("X8");
            int_type = BitConverter.ToUInt32(section_header, in_offset + 4);
            type = sectionType(int_type);
            int_flags = BitConverter.ToInt32(section_header, in_offset + 8);
            flags = sectionFlag(int_flags);
            int i_va = BitConverter.ToInt32(section_header, in_offset + 12);
            virtual_address = "0x" + i_va.ToString("X8");
            int i_offset = BitConverter.ToInt32(section_header, in_offset + 16);
            offset = "0x" + i_offset.ToString("X8");
            int i_size = BitConverter.ToInt32(section_header, in_offset + 20);
            size = i_size.ToString();
            int i_link = BitConverter.ToInt32(section_header, in_offset + 24);
            link = i_link.ToString();
            /*
            int i_info = BitConverter.ToInt32(section_header, in_offset + 28);
            name = "0x" + String.Format("X8", i_info);
            int i_addr_align = BitConverter.ToInt32(section_header, in_offset + 32);
            name = "0x" + String.Format("X8", i_addr_align);
            int i_entry_size = BitConverter.ToInt32(section_header, in_offset + 36);
            name = "0x" + String.Format("X8", i_entry_size);
            */
        }

        public void setSectionName(byte[] shstrtab, int in_offset)
        {
            name = System.Text.Encoding.ASCII.GetString(
                shstrtab, 
                in_offset + name_offset, 
                strlen(shstrtab, in_offset + name_offset, 64));
        }

        private int strlen(byte[] shstrtab, int in_offset, int max_len)
        {
            int cnt = 0;
            for (cnt = 0; cnt < max_len; cnt++)
            {
                if(shstrtab[in_offset+cnt]==0)
                {
                    return cnt;
                }
            }

            return cnt;
        }

        private string sectionFlag(int flags)
        {
            string result = "";

            if((flags&0x01)>0)
            {
                result += "Write";
            }
            if ((flags & 0x04) > 0)
            {
                if (result.Length > 0)
                {
                    result += ", ";
                }
                result += "Exec";
            }
            if ((flags & 0x02) > 0)
            {
                if(result.Length>0)
                {
                    result += ", ";
                }
                result += "Alloc";
            }

            return result;
        }

        private string sectionType(uint type)
        {
            switch(type)
            {
                case 0: return "NULL";
                case 1: return "PROGBITS";
                case 2: return "SYMTAB";
                case 3: return "STRTAB";
                case 4: return "RELA";
                case 5: return "HASH";
                case 6: return "DYNAMIC";
                case 7: return "NOTE";
                case 8: return "NOBITS";
                case 9: return "REL";
                case 10: return "SHLIB";
                case 11: return "DYNSYM";
                case 0x70000000: return "LOPROC";
                case 0x7fffffff: return "HIPROC";
                case 0x80000000: return "LOUSER";
                case 0xffffffff: return "HIUSER";
                default: return "0x" + type.ToString("X8");
            }
        }
    }

    public class ProgramHeader
    {
        public string type;
        public string offset;
        public string virtual_address;
        public string physical_address;
        public string file_size;
        public string memory_size;
        public string flags;

        public ProgramHeader(byte[] program_header, int in_offset, int size)
        {
            uint i_type = BitConverter.ToUInt32(program_header, in_offset + 0);
            type = programType(i_type);
            int i_offset = BitConverter.ToInt32(program_header, in_offset + 4);
            offset = "0x" + i_offset.ToString("X8");
            int i_va = BitConverter.ToInt32(program_header, in_offset + 8);
            virtual_address = "0x" + i_va.ToString("X8");
            int i_pa = BitConverter.ToInt32(program_header, in_offset + 12);
            physical_address = "0x" + i_pa.ToString("X8");
            int i_size = BitConverter.ToInt32(program_header, in_offset + 16);
            file_size = i_size.ToString();
            int i_msize = BitConverter.ToInt32(program_header, in_offset + 20);
            memory_size = i_msize.ToString();
            int i_flags = BitConverter.ToInt32(program_header, in_offset + 24);
            flags = programFlag(i_flags);
        }

        private string programFlag(int flags)
        {
            string result = "";

            if ((flags & 0x01) > 0)
            {
                result += "Exec";
            }
            if ((flags & 0x02) > 0)
            {
                if (result.Length > 0)
                {
                    result += ", ";
                }
                result += "Write";
            }
            if ((flags & 0x04) > 0)
            {
                if (result.Length > 0)
                {
                    result += ", ";
                }
                result += "Read";
            }

            return result;
        }

        private string programType(uint type)
        {
            switch (type)
            {
                case 0: return "NULL";
                case 1: return "LOAD";
                case 2: return "DYNAMIC";
                case 3: return "INTERP";
                case 4: return "NOTE";
                case 5: return "SHLIB";
                case 6: return "PHDR";
                case 0x6ffffffa: return "LOSUNW";
                case 0x6ffffffb: return "SUNWBSS";
                case 0x6ffffffc: return "SUNWSTACK";
                case 0x6fffffff: return "HISUNW";
                case 0x70000000: return "LOPROC";
                case 0x7fffffff: return "HIPROC";
                default: return "0x" + type.ToString("X8");
            }
        }
    }

    public class BinaryGenArg
    {
        int _offset;
        int _virtual_addr;
        int _physical_addr;
        int _size;

        public BinaryGenArg(int offset, int v_addr, int p_addr, int size)
        {
            _offset = offset;
            _virtual_addr = v_addr;
            _physical_addr = p_addr;
            _size = size;
        }
        public int Offset
        {
            get { return _offset; }
        }
        public int VirtualAddress
        {
            get { return _virtual_addr; }
        }
        public int PhysicalAddress
        {
            get { return _physical_addr; }
        }
        public int Size
        {
            get { return _size; }
        }
    }

    static class KeyParser
    {
        public static bool IsHex(char c)
        {
            if (('0' <= c) && (c <= '9'))
            {
                return true;
            }
            if (('a' <= c) && (c <= 'f'))
            {
                return true;
            }
            if (('A' <= c) && (c <= 'F'))
            {
                return true;
            }
            if (c == ' ')
            {
                return true;
            }
            if (c == '\b')
            {
                return true;
            }
            return false;
        }
        public static byte[] HexStringToHexByte(string input)
        {
            try
            {
                string[] spt = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<byte> list = new List<byte>();

                foreach (string item in spt)
                {
                    if (item.Length > 2)
                    {
                        for (int i = 0; i < (item.Length + 1) / 2; i++)
                        {
                            int length = 2;
                            if (item.Length % 2 == 1)
                            {
                                if (i * 2 == item.Length - 1)
                                {
                                    length = 1;
                                }
                            }
                            string sub = item.Substring(i * 2, length);
                            list.Add(Convert.ToByte(sub, 16));
                        }
                    }
                    else
                    {
                        list.Add(Convert.ToByte(item, 16));
                    }
                }

                return list.ToArray();
            }
            catch
            {
                return null;
            }
        }
        public static byte[] AsciiStringToHexByte(string input)
        {
            try
            {
                string AsciiString = Regex.Unescape(input);
                byte[] Msg = Encoding.Default.GetBytes(AsciiString);

                return Msg;
            }
            catch
            {
                return null;
            }
        }
        public static string AnyByteToHexString(byte[] input)
        {
            string msg = "";
            foreach (byte item in input)
            {
                msg += item.ToString("X2") + " ";
            }

            if (msg.Length == 0)
                return null;
            else
                return msg;
        }
        public static string AnyByteToAsciiString(byte[] input)
        {
            string msg = "";
            foreach (byte item in input)
            {
                char character = Convert.ToChar(item);
                msg += ToEscapedString(character);
            }

            if (msg.Length == 0)
                return null;
            else
                return msg;
        }
        public static string AsciiStringToHexString(string Ascii)
        {
            string text = Regex.Unescape(Ascii);
            string toHex = "";
            foreach (char item in text)
            {
                byte integer = Convert.ToByte(item);
                toHex += integer.ToString("X2") + " ";
            }

            return toHex;
        }
        public static string HexStringToAsciiString(string Hex)
        {
            string[] chars = Hex.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string toAscii = "";
            foreach (string item in chars)
            {
                int integer = Convert.ToInt32(item, 16);
                char character = Convert.ToChar(integer);
                toAscii += ToEscapedString(character);
            }
            return toAscii;
        }
        public static string ToEscapedString(char input)
        {
            switch (input)
            {
                case '\0': return "\\n";
                case '\a': return "\\a";
                case '\b': return "\\b";
                case '\f': return "\\f";
                case '\n': return "\\n";
                case '\t': return "\\t";
                case '\v': return "\\v";
                default:
                    {
                        if (input < ' ')
                            return Regex.Escape(input.ToString());
                        else
                            return input.ToString();
                    }
            }
        }
    }
}
