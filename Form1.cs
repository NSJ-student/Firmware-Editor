﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Firmware_Editor
{
    public partial class Form1 : Form
    {
        UInt32[] l_ulCRCtable;
        OpenFileDialog open_dialog;
        SaveFileDialog save_dialog;
        byte[] workingData;
        byte[] referenceData;
        BackgroundWorker LoadWorker;
        WorkArg userArg;
        bool cancelCheck;
        int mismatchedNumber;


        public Form1()
        {
            InitializeComponent();

            l_ulCRCtable = new UInt32[256];
            makeCRC_32_Table(0x04C11DB7);

            open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Bin Files(*.bin)|*.bin";
            save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Bin Files(*.bin)|*.bin";

            userArg = new WorkArg();

            LoadWorker = new BackgroundWorker();
            LoadWorker.WorkerReportsProgress = true;
            LoadWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(MakeComponentsComplete);
            LoadWorker.DoWork += new DoWorkEventHandler(MakeComponents);
            LoadWorker.ProgressChanged += new ProgressChangedEventHandler(UpdateProgressBar);

            cancelCheck = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateProgressBar(object obj, ProgressChangedEventArgs arg)
        {
            progressCheckFixedArea.Value = arg.ProgressPercentage;
        }

        private void MakeComponents(object obj, DoWorkEventArgs arg)
        {
            mismatchedNumber = 0;
            WorkArg args = (WorkArg)arg.Argument;
            Color textcolor = Color.Black;
            Color prev_color = Color.Black;
            string text = "";
            UInt32 refresh_cnt = 0;

            for (int pos = 0; pos < 0x00020000; pos++)
            {
                if(cancelCheck)
                {
                    cancelCheck = false;
                    arg.Cancel = true;
                    break;
                }
                if(cbShowDifference.Checked)
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
                                txtCompareResult.SelectionColor = userArg.textColor;
                                txtCompareResult.AppendText(userArg.textContent);
                                txtMismatchedNumber.Text = mismatchedNumber.ToString();
                            }));
                            prev_color = textcolor;
                            refresh_cnt = 0;
                            text = "";
                        }

                        text += (pos & 0xFFFFFFF0).ToString("X8") + ": ";
                        LoadWorker.ReportProgress((int)(pos * 100 / 0x00020000));
                    }

                    if (referenceData[pos] != workingData[pos])
                    {
                        mismatchedNumber++;
                        textcolor = Color.Red;
                    }
                    else
                    {
                        textcolor = Color.Black;
                    }

                    if(prev_color != textcolor)
                    {
                        args.setProperty(prev_color, text);
                        this.Invoke(new Action(() =>
                        {
                            txtCompareResult.SelectionColor = userArg.textColor;
                            txtCompareResult.AppendText(userArg.textContent);
                            txtMismatchedNumber.Text = mismatchedNumber.ToString();
                        }));
                        prev_color = textcolor;
                        refresh_cnt = 0;
                        text = "";
                    }

                    text += workingData[pos].ToString("X2") + " ";

                    if(refresh_cnt > 128)
                    {
                        args.setProperty(textcolor, text);
                        this.Invoke(new Action(() =>
                        {
                            txtCompareResult.SelectionColor = userArg.textColor;
                            txtCompareResult.AppendText(userArg.textContent);
                            txtMismatchedNumber.Text = mismatchedNumber.ToString();
                        }));
                        refresh_cnt = 0;
                        text = "";
                    }
                }
                else
                {
                    if (referenceData[pos] != workingData[pos])
                    {
                        mismatchedNumber++;
                    }
                }

            }

            if (cbShowDifference.Checked)
            {
                args.setProperty(textcolor, text);
                this.Invoke(new Action(() =>
                {
                    txtCompareResult.SelectionColor = userArg.textColor;
                    txtCompareResult.AppendText(userArg.textContent);
                }));
            }
            LoadWorker.ReportProgress(100);
        }

        private void MakeComponentsComplete(object obj, RunWorkerCompletedEventArgs arg)
        {
            btnCheckFixedArea.Enabled = true;
            txtMismatchedNumber.Text = mismatchedNumber.ToString();
        }

        private void btnOpenFirmware_Click(object sender, EventArgs e)
        {
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

        private void btnCheckFixedArea_Click(object sender, EventArgs e)
        {
            if((referenceData.Length > 0) && (workingData.Length > 0))
            {
                int start_pos = Convert.ToInt32(txtFixedArea.Text, 16);
                int end_pos = Convert.ToInt32(txtUpdateArea.Text, 16);

                if(referenceData.Length < (end_pos-start_pos))
                {
                    MessageBox.Show("reference data length is too short");
                    return;
                }

                if (workingData.Length < (end_pos - start_pos))
                {
                    MessageBox.Show("working data length is too short");
                    return;
                }

                progressCheckFixedArea.Value = 0;
                txtCompareResult.Clear();
                userArg.setProperty(referenceData.Length, start_pos, end_pos);
                LoadWorker.RunWorkerAsync(userArg);
                btnCheckFixedArea.Enabled = false;
            }
            else
            {
                MessageBox.Show("no comparable data");
            }
        }

        private void btnCancelCheck_Click(object sender, EventArgs e)
        {
            cancelCheck = true;
        }
        private void btnSaveUpdateArea_Click(object sender, EventArgs e)
        {
            int end_pos = Convert.ToInt32(txtUpdateArea.Text, 16);

            if (workingData.Length < end_pos)
            {
                MessageBox.Show("working data length is too short");
                return;
            }

            if (DialogResult.OK == save_dialog.ShowDialog())
            {
                FileStream file = File.Create(save_dialog.FileName);
                BinaryWriter writer = new BinaryWriter(file);

                writer.Write(workingData, end_pos, workingData.Length - end_pos);

                writer.Close();
                file.Close();
            }
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
                    c = ((c & V)>0) ? ((c << 1) ^ 0x04c11db7) : (c << 1);
                l_ulCRCtable[i] = c;
            }

        }

        UInt32 update_CRC_32(UInt32 p_ulCRC, byte[] p_cpBuffer, int p_uiLen)
        {
            UInt32 crc = p_ulCRC;
            UInt32 pos = 0;

	        while ((p_uiLen--)>0)
	        {
		        crc = (crc << 8) ^ l_ulCRCtable[((crc >> 24) ^ p_cpBuffer[pos]) & 255];
		        pos++;
	        }
	        return crc;
        }

        private void btnCRC32_Click(object sender, EventArgs e)
        {
            int end_pos = Convert.ToInt32(txtUpdateArea.Text, 16);

            if (workingData.Length < end_pos)
            {
                MessageBox.Show("working data length is too short");
                return;
            }

            UInt32 result = update_CRC_32(0, workingData, workingData.Length);
            txtCRC32.Text = result.ToString("X8");
        }
    }

    public class WorkArg
    {
        int _start_addr;
        int _end_addr;
        int _length;
        Color _textColor;
        string _tmpString;

        public WorkArg()
        {
            _textColor = Color.Black;
        }
        public int fileLength
        {
            get { return _length; }
        }
        public int startAddr
        {
            get { return _start_addr; }
        }
        public int endAddr
        {
            get { return _end_addr; }
        }
        public Color textColor
        {
            get { return _textColor; }
        }
        public string textContent
        {
            get { return _tmpString; }
        }
        public void setProperty(int length, int start_addr, int end_addr)
        {
            _length = length;
            _start_addr = start_addr;
            _end_addr = end_addr;
        }
        public void setProperty(Color color, string str_input)
        {
            _textColor = color;
            _tmpString = str_input;
        }
    }
}
