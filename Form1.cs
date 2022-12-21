using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Generic;

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
        // Compare Tab
        byte[] workingData;
        byte[] referenceData;
        BackgroundWorker WorkerBinaryComare;
        CompareWorkArg compareArg;
        bool compareCancel;
        int mismatchedCount;


        public Form1()
        {
            InitializeComponent();

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

            // ELF Parser Tab
            listElfHeader = new List<ElfHeader>();
            listSectionHeader = new List<ElfHeader>();
            listProgramHeader = new List<ElfHeader>();

            WorkerElfParse = new BackgroundWorker();
            WorkerElfParse.WorkerReportsProgress = true;
            WorkerElfParse.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ElfParse_Work_Complete);
            WorkerElfParse.DoWork += new DoWorkEventHandler(ElfParse_Work);
            WorkerElfParse.ProgressChanged += new ProgressChangedEventHandler(UpdateProgressBar);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateProgressBar(object obj, ProgressChangedEventArgs arg)
        {
            progressWork.Value = arg.ProgressPercentage;
        }

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

                        textcolor = Color.Black;

                        if (prev_color != textcolor)
                        {
                            args.setProperty(textcolor, text);
                            this.Invoke(new Action(() =>
                            {
                                if (compareArg.textColor == Color.Red)
                                {
                                    listMismatch.Items.Add("0x" + compareArg.startAddr.ToString("X8"));
                                }
                                txtCompareResult.SelectionColor = compareArg.textColor;
                                txtCompareResult.AppendText(compareArg.textContent);
                                txtMismatchedNumber.Text = mismatchedCount.ToString();
                            }));
                            prev_color = textcolor;
                            refresh_cnt = 0;
                            text = "";
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
                            txtMismatchedNumber.Text = mismatchedCount.ToString();
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
                            txtMismatchedNumber.Text = mismatchedCount.ToString();
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
            txtMismatchedNumber.Text = mismatchedCount.ToString();
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
                int start_pos = Convert.ToInt32(txtFixedArea.Text, 16);
                int end_pos = Convert.ToInt32(txtUpdateArea.Text, 16);

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
            int end_pos = Convert.ToInt32(txtUpdateArea.Text, 16);

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

        UInt32 update_CRC_32(UInt32 p_ulCRC, byte[] p_cpBuffer, int p_uiLen)
        {
            UInt32 crc = p_ulCRC;
            UInt32 pos = 0;

            while ((p_uiLen--) > 0)
            {
                crc = (crc << 8) ^ l_ulCRCtable[((crc >> 24) ^ p_cpBuffer[pos]) & 255];
                pos++;
            }
            return crc;
        }

        private void btnCRC32_Click(object sender, EventArgs e)
        {
            int end_pos = Convert.ToInt32(txtUpdateArea.Text, 16);

            if (workingData == null)
            {
                return;
            }
            if (workingData.Length < end_pos)
            {
                MessageBox.Show("working data length is too short");
                return;
            }

            UInt32 result = update_CRC_32(0, workingData, workingData.Length);
            txtCRC32.Text = result.ToString("X8");
        }

        private void btnOpenConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_config = new OpenFileDialog();
            open_config.Filter = "Config File(*.xml)|*.xml";

            if (DialogResult.OK == open_config.ShowDialog())
            {
                txtConfigPath.Text = open_config.FileName;
                txtConfigPath.Select(txtConfigPath.Text.Length, 0);

                btnParseConfig.Enabled = true;
            }
        }

        private void btnParseConfig_Click(object sender, EventArgs e)
        {
            LoadConfig(txtConfigPath.Text);
        }

        private bool LoadConfig(string config_path)
        {
            if ((config_path == null) || (config_path == ""))
            {
                return false;
            }

            try
            {
                if (File.Exists(config_path))
                {
                    string local_dir = System.IO.Path.GetDirectoryName(config_path);
                    Console.WriteLine(String.Format("    base dir: {0}", local_dir));

                    var xdoc = XDocument.Load(config_path);

                    dgvInformation.Rows.Clear();
                    var xelements = xdoc.Root.Elements("element");
                    //dgvInformation.RowCount = 0;
                    foreach (var xList in xelements)
                    {
                        XElement element;

                        element = xList.Element("name");
                        if (element == null)
                        {
                            continue;
                        }
                        string name = element.Value;

                        element = xList.Element("contents");
                        if (element == null)
                        {
                            continue;
                        }
                        string contents = element.Value;

                        dgvInformation.Rows.Add(name, contents);
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        /// <summary>
        /// Load ELF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadELF_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_elf = new OpenFileDialog();
            open_elf.Filter = "ELF File(*.elf)|*.elf";

            if (DialogResult.OK == open_elf.ShowDialog())
            {
                txtElfFilePath.Text = open_elf.FileName;
                txtElfFilePath.Select(txtElfFilePath.Text.Length, 0);

                tabMainControl.Enabled = true;

                FileStream file = File.OpenRead(open_elf.FileName);
                BinaryReader reader = new BinaryReader(file);

                if (file.Length < 52)
                {
                    MessageBox.Show("too short elf header");
                    return;
                }

                elfData = new byte[file.Length];
                reader.Read(elfData, 0, (int)file.Length);

                progressWork.Value = 0;
                rtbElfHeader.Clear();
                dgvElfHeader.Rows.Clear();
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
            // Parse ELF Header
            listElfHeader.Clear();

            ElfHeader component = new ElfHeader("Magic", 
                String.Format("{0:X2} {1:X2} {2:X2} {2:X2}", 
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

            component = new ElfHeader("String Index", BitConverter.ToInt16(elfData, 0x32));
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

            this.Invoke(new Action(() =>
            {
                rtbElfHeader.AppendText(elfDataTempString);
                dgvElfHeader.Rows.Clear();
                foreach (ElfHeader header in listElfHeader)
                {
                    dgvElfHeader.Rows.Add(header.name, header.str_value);
                }
            }));

            // Parse Section Header
            for(int cnt=0; cnt<section_entry_counts; cnt++)
            {
                SectionHeader s_component = new SectionHeader(elfData, cnt* section_entry_size, section_entry_size);
                listSectionHeader.Add(s_component);
            }

            // Parse Program Header
            for (int cnt = 0; cnt < program_entry_counts; cnt++)
            {
                SectionHeader s_component = new SectionHeader(elfData, cnt * program_entry_size, program_entry_size);
                listSectionHeader.Add(s_component);
            }

            WorkerElfParse.ReportProgress(100);
        }

        private void ElfParse_Work_Complete(object obj, RunWorkerCompletedEventArgs arg)
        {

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

        public SectionHeader(byte[] section_header, int offset, int size)
        {
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

        public ProgramHeader(byte[] program_header, int offset, int size)
        {
        }
    }
}
