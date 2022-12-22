
namespace Firmware_Editor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCompareStartAddr = new System.Windows.Forms.TextBox();
            this.btnCRC32 = new System.Windows.Forms.Button();
            this.txtCRC32 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbShowDifference = new System.Windows.Forms.CheckBox();
            this.txtCompareResult = new System.Windows.Forms.RichTextBox();
            this.btnSaveUpdateArea = new System.Windows.Forms.Button();
            this.btnCompareDatas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompareStopAddr = new System.Windows.Forms.TextBox();
            this.txtFirmwareBinPath = new System.Windows.Forms.TextBox();
            this.btnOpenFirmware = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReferencePath = new System.Windows.Forms.TextBox();
            this.btnOpenReference = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listMismatch = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSelectedIndex = new System.Windows.Forms.Label();
            this.txtReferenceVal = new System.Windows.Forms.TextBox();
            this.txtOriginalVal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.workPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtMismatchedNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customCompareRange = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.txtElfFilePath = new System.Windows.Forms.TextBox();
            this.btnLoadELF = new System.Windows.Forms.Button();
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabELF = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabElfParse = new System.Windows.Forms.TabControl();
            this.tabElfHeader = new System.Windows.Forms.TabPage();
            this.dgvElfHeader = new System.Windows.Forms.DataGridView();
            this.colElfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colElfContents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSectionHeader = new System.Windows.Forms.TabPage();
            this.dgvSectionHeader = new System.Windows.Forms.DataGridView();
            this.colSectionIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionFlags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProgramHeader = new System.Windows.Forms.TabPage();
            this.dgvProgramHeader = new System.Windows.Forms.DataGridView();
            this.colProgramType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgramOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgramVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgramPhyAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgramFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgramMemorySize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgramFlags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbElfHeader = new System.Windows.Forms.RichTextBox();
            this.tabFirmwareBinary = new System.Windows.Forms.TabPage();
            this.cbMakeFileSizeFormat = new System.Windows.Forms.CheckBox();
            this.txtMakeFileSize = new System.Windows.Forms.TextBox();
            this.panelMakePadding = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnMakeBinary = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBinaryNamePrefix = new System.Windows.Forms.TextBox();
            this.cbBinaryPadding = new System.Windows.Forms.CheckBox();
            this.dgvMakeBinary = new System.Windows.Forms.DataGridView();
            this.colMakeSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMakeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMakeOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMakeAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMakeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCompare = new System.Windows.Forms.TabPage();
            this.tabParameter = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOpenConfig = new System.Windows.Forms.Button();
            this.btnParseConfig = new System.Windows.Forms.Button();
            this.txtConfigPath = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressWork = new System.Windows.Forms.ToolStripProgressBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.workPanel.SuspendLayout();
            this.customCompareRange.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMainControl.SuspendLayout();
            this.tabELF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabElfParse.SuspendLayout();
            this.tabElfHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElfHeader)).BeginInit();
            this.tabSectionHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectionHeader)).BeginInit();
            this.tabProgramHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramHeader)).BeginInit();
            this.tabFirmwareBinary.SuspendLayout();
            this.panelMakePadding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMakeBinary)).BeginInit();
            this.tabCompare.SuspendLayout();
            this.tabParameter.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCompareStartAddr
            // 
            this.txtCompareStartAddr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCompareStartAddr.Location = new System.Drawing.Point(3, 3);
            this.txtCompareStartAddr.Name = "txtCompareStartAddr";
            this.txtCompareStartAddr.Size = new System.Drawing.Size(65, 21);
            this.txtCompareStartAddr.TabIndex = 1;
            this.txtCompareStartAddr.Text = "0";
            this.txtCompareStartAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCRC32
            // 
            this.btnCRC32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCRC32.Location = new System.Drawing.Point(167, 44);
            this.btnCRC32.Name = "btnCRC32";
            this.btnCRC32.Size = new System.Drawing.Size(94, 23);
            this.btnCRC32.TabIndex = 11;
            this.btnCRC32.Text = "CRC32";
            this.btnCRC32.UseVisualStyleBackColor = true;
            this.btnCRC32.Click += new System.EventHandler(this.btnCRC32_Click);
            // 
            // txtCRC32
            // 
            this.txtCRC32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCRC32.Location = new System.Drawing.Point(97, 44);
            this.txtCRC32.Name = "txtCRC32";
            this.txtCRC32.ReadOnly = true;
            this.txtCRC32.Size = new System.Drawing.Size(64, 21);
            this.txtCRC32.TabIndex = 10;
            this.txtCRC32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mismatched";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbShowDifference
            // 
            this.cbShowDifference.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbShowDifference.AutoSize = true;
            this.cbShowDifference.Checked = true;
            this.cbShowDifference.CheckState = System.Windows.Forms.CheckState.Checked;
            this.workPanel.SetColumnSpan(this.cbShowDifference, 2);
            this.cbShowDifference.Location = new System.Drawing.Point(467, 75);
            this.cbShowDifference.Name = "cbShowDifference";
            this.cbShowDifference.Size = new System.Drawing.Size(78, 16);
            this.cbShowDifference.TabIndex = 8;
            this.cbShowDifference.Text = "hexaview";
            this.cbShowDifference.UseVisualStyleBackColor = true;
            // 
            // txtCompareResult
            // 
            this.workPanel.SetColumnSpan(this.txtCompareResult, 6);
            this.txtCompareResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompareResult.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompareResult.Location = new System.Drawing.Point(14, 99);
            this.txtCompareResult.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCompareResult.Name = "txtCompareResult";
            this.txtCompareResult.ReadOnly = true;
            this.txtCompareResult.Size = new System.Drawing.Size(530, 288);
            this.txtCompareResult.TabIndex = 5;
            this.txtCompareResult.Text = "";
            this.txtCompareResult.WordWrap = false;
            // 
            // btnSaveUpdateArea
            // 
            this.btnSaveUpdateArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveUpdateArea.Location = new System.Drawing.Point(451, 13);
            this.btnSaveUpdateArea.Name = "btnSaveUpdateArea";
            this.btnSaveUpdateArea.Size = new System.Drawing.Size(94, 25);
            this.btnSaveUpdateArea.TabIndex = 4;
            this.btnSaveUpdateArea.Text = "Save";
            this.btnSaveUpdateArea.UseVisualStyleBackColor = true;
            this.btnSaveUpdateArea.Click += new System.EventHandler(this.btnSaveUpdateArea_Click);
            // 
            // btnCompareDatas
            // 
            this.btnCompareDatas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompareDatas.Location = new System.Drawing.Point(351, 13);
            this.btnCompareDatas.Name = "btnCompareDatas";
            this.btnCompareDatas.Size = new System.Drawing.Size(94, 25);
            this.btnCompareDatas.TabIndex = 4;
            this.btnCompareDatas.Text = "Compare";
            this.btnCompareDatas.UseVisualStyleBackColor = true;
            this.btnCompareDatas.Click += new System.EventHandler(this.btnCompareDatas_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Range (hex)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCompareStopAddr
            // 
            this.txtCompareStopAddr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCompareStopAddr.Location = new System.Drawing.Point(94, 3);
            this.txtCompareStopAddr.Name = "txtCompareStopAddr";
            this.txtCompareStopAddr.Size = new System.Drawing.Size(65, 21);
            this.txtCompareStopAddr.TabIndex = 1;
            this.txtCompareStopAddr.Text = "18000";
            this.txtCompareStopAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirmwareBinPath
            // 
            this.txtFirmwareBinPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirmwareBinPath.Location = new System.Drawing.Point(112, 9);
            this.txtFirmwareBinPath.Name = "txtFirmwareBinPath";
            this.txtFirmwareBinPath.ReadOnly = true;
            this.txtFirmwareBinPath.Size = new System.Drawing.Size(373, 21);
            this.txtFirmwareBinPath.TabIndex = 3;
            // 
            // btnOpenFirmware
            // 
            this.btnOpenFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFirmware.Location = new System.Drawing.Point(491, 8);
            this.btnOpenFirmware.Name = "btnOpenFirmware";
            this.btnOpenFirmware.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFirmware.TabIndex = 4;
            this.btnOpenFirmware.Text = "OPEN";
            this.btnOpenFirmware.UseVisualStyleBackColor = true;
            this.btnOpenFirmware.Click += new System.EventHandler(this.btnOpenFirmware_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Firmware Binary";
            // 
            // txtReferencePath
            // 
            this.txtReferencePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReferencePath.Location = new System.Drawing.Point(112, 38);
            this.txtReferencePath.Name = "txtReferencePath";
            this.txtReferencePath.ReadOnly = true;
            this.txtReferencePath.Size = new System.Drawing.Size(373, 21);
            this.txtReferencePath.TabIndex = 3;
            // 
            // btnOpenReference
            // 
            this.btnOpenReference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenReference.Location = new System.Drawing.Point(491, 37);
            this.btnOpenReference.Name = "btnOpenReference";
            this.btnOpenReference.Size = new System.Drawing.Size(75, 23);
            this.btnOpenReference.TabIndex = 4;
            this.btnOpenReference.Text = "OPEN";
            this.btnOpenReference.UseVisualStyleBackColor = true;
            this.btnOpenReference.Click += new System.EventHandler(this.btnOpenReference_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Compare Binary";
            // 
            // listMismatch
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.listMismatch, 2);
            this.listMismatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMismatch.FormattingEnabled = true;
            this.listMismatch.ItemHeight = 12;
            this.listMismatch.Location = new System.Drawing.Point(3, 26);
            this.listMismatch.Name = "listMismatch";
            this.listMismatch.Size = new System.Drawing.Size(265, 390);
            this.listMismatch.TabIndex = 6;
            this.listMismatch.SelectedIndexChanged += new System.EventHandler(this.listMismatch_SelectedIndexChanged);
            this.listMismatch.DoubleClick += new System.EventHandler(this.listMismatch_DoubleClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "Selected";
            // 
            // lblSelectedIndex
            // 
            this.lblSelectedIndex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSelectedIndex.AutoSize = true;
            this.lblSelectedIndex.Location = new System.Drawing.Point(76, 8);
            this.lblSelectedIndex.Name = "lblSelectedIndex";
            this.lblSelectedIndex.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblSelectedIndex.Size = new System.Drawing.Size(16, 12);
            this.lblSelectedIndex.TabIndex = 8;
            this.lblSelectedIndex.Text = "0";
            this.lblSelectedIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReferenceVal
            // 
            this.txtReferenceVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReferenceVal.Location = new System.Drawing.Point(76, 449);
            this.txtReferenceVal.Name = "txtReferenceVal";
            this.txtReferenceVal.ReadOnly = true;
            this.txtReferenceVal.Size = new System.Drawing.Size(192, 21);
            this.txtReferenceVal.TabIndex = 9;
            // 
            // txtOriginalVal
            // 
            this.txtOriginalVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOriginalVal.Location = new System.Drawing.Point(76, 422);
            this.txtOriginalVal.Name = "txtOriginalVal";
            this.txtOriginalVal.ReadOnly = true;
            this.txtOriginalVal.Size = new System.Drawing.Size(192, 21);
            this.txtOriginalVal.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 426);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "Original";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 453);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(67, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "Reference";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFirmwareBinPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtReferencePath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenFirmware, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenReference, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.workPanel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 473);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // workPanel
            // 
            this.workPanel.ColumnCount = 6;
            this.tableLayoutPanel1.SetColumnSpan(this.workPanel, 3);
            this.workPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.workPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.workPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.workPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.workPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.workPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.workPanel.Controls.Add(this.label3, 0, 0);
            this.workPanel.Controls.Add(this.label7, 0, 2);
            this.workPanel.Controls.Add(this.txtMismatchedNumber, 1, 2);
            this.workPanel.Controls.Add(this.txtCRC32, 1, 1);
            this.workPanel.Controls.Add(this.txtCompareResult, 0, 3);
            this.workPanel.Controls.Add(this.label1, 0, 1);
            this.workPanel.Controls.Add(this.btnCRC32, 2, 1);
            this.workPanel.Controls.Add(this.cbShowDifference, 4, 2);
            this.workPanel.Controls.Add(this.customCompareRange, 1, 0);
            this.workPanel.Controls.Add(this.btnSaveUpdateArea, 5, 0);
            this.workPanel.Controls.Add(this.btnCompareDatas, 4, 0);
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel.Location = new System.Drawing.Point(8, 66);
            this.workPanel.Name = "workPanel";
            this.workPanel.Padding = new System.Windows.Forms.Padding(10);
            this.workPanel.RowCount = 4;
            this.workPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.workPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.workPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.workPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.workPanel.Size = new System.Drawing.Size(558, 399);
            this.workPanel.TabIndex = 13;
            // 
            // txtMismatchedNumber
            // 
            this.txtMismatchedNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMismatchedNumber.Location = new System.Drawing.Point(97, 73);
            this.txtMismatchedNumber.Name = "txtMismatchedNumber";
            this.txtMismatchedNumber.ReadOnly = true;
            this.txtMismatchedNumber.Size = new System.Drawing.Size(64, 21);
            this.txtMismatchedNumber.TabIndex = 10;
            this.txtMismatchedNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "CRC32 (hex)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customCompareRange
            // 
            this.workPanel.SetColumnSpan(this.customCompareRange, 2);
            this.customCompareRange.Controls.Add(this.txtCompareStartAddr);
            this.customCompareRange.Controls.Add(this.label5);
            this.customCompareRange.Controls.Add(this.txtCompareStopAddr);
            this.customCompareRange.Location = new System.Drawing.Point(97, 13);
            this.customCompareRange.Name = "customCompareRange";
            this.customCompareRange.Size = new System.Drawing.Size(164, 25);
            this.customCompareRange.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "~";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtReferenceVal, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtOriginalVal, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.listMismatch, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSelectedIndex, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(271, 473);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(849, 473);
            this.splitContainer1.SplitterDistance = 574;
            this.splitContainer1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Load ELF";
            // 
            // txtElfFilePath
            // 
            this.txtElfFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtElfFilePath.Location = new System.Drawing.Point(76, 4);
            this.txtElfFilePath.Name = "txtElfFilePath";
            this.txtElfFilePath.ReadOnly = true;
            this.txtElfFilePath.Size = new System.Drawing.Size(705, 21);
            this.txtElfFilePath.TabIndex = 16;
            // 
            // btnLoadELF
            // 
            this.btnLoadELF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLoadELF.Location = new System.Drawing.Point(787, 4);
            this.btnLoadELF.Name = "btnLoadELF";
            this.btnLoadELF.Size = new System.Drawing.Size(75, 21);
            this.btnLoadELF.TabIndex = 17;
            this.btnLoadELF.Text = "OPEN";
            this.btnLoadELF.UseVisualStyleBackColor = true;
            this.btnLoadELF.Click += new System.EventHandler(this.btnLoadELF_Click);
            // 
            // tabMainControl
            // 
            this.tabMainControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMainControl.Controls.Add(this.tabELF);
            this.tabMainControl.Controls.Add(this.tabFirmwareBinary);
            this.tabMainControl.Controls.Add(this.tabCompare);
            this.tabMainControl.Controls.Add(this.tabParameter);
            this.tabMainControl.Enabled = false;
            this.tabMainControl.ItemSize = new System.Drawing.Size(100, 20);
            this.tabMainControl.Location = new System.Drawing.Point(5, 36);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(857, 501);
            this.tabMainControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMainControl.TabIndex = 20;
            // 
            // tabELF
            // 
            this.tabELF.Controls.Add(this.splitContainer2);
            this.tabELF.Location = new System.Drawing.Point(4, 24);
            this.tabELF.Name = "tabELF";
            this.tabELF.Padding = new System.Windows.Forms.Padding(3);
            this.tabELF.Size = new System.Drawing.Size(849, 473);
            this.tabELF.TabIndex = 0;
            this.tabELF.Text = "ELF Parser";
            this.tabELF.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabElfParse);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtbElfHeader);
            this.splitContainer2.Size = new System.Drawing.Size(843, 467);
            this.splitContainer2.SplitterDistance = 526;
            this.splitContainer2.TabIndex = 1;
            // 
            // tabElfParse
            // 
            this.tabElfParse.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabElfParse.Controls.Add(this.tabElfHeader);
            this.tabElfParse.Controls.Add(this.tabSectionHeader);
            this.tabElfParse.Controls.Add(this.tabProgramHeader);
            this.tabElfParse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabElfParse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabElfParse.ItemSize = new System.Drawing.Size(120, 30);
            this.tabElfParse.Location = new System.Drawing.Point(0, 0);
            this.tabElfParse.Name = "tabElfParse";
            this.tabElfParse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabElfParse.SelectedIndex = 0;
            this.tabElfParse.Size = new System.Drawing.Size(526, 467);
            this.tabElfParse.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabElfParse.TabIndex = 0;
            this.tabElfParse.SelectedIndexChanged += new System.EventHandler(this.tabElfParse_SelectedIndexChanged);
            // 
            // tabElfHeader
            // 
            this.tabElfHeader.Controls.Add(this.dgvElfHeader);
            this.tabElfHeader.Location = new System.Drawing.Point(4, 4);
            this.tabElfHeader.Name = "tabElfHeader";
            this.tabElfHeader.Padding = new System.Windows.Forms.Padding(3);
            this.tabElfHeader.Size = new System.Drawing.Size(518, 429);
            this.tabElfHeader.TabIndex = 0;
            this.tabElfHeader.Text = "ELF Header";
            this.tabElfHeader.UseVisualStyleBackColor = true;
            // 
            // dgvElfHeader
            // 
            this.dgvElfHeader.AllowUserToAddRows = false;
            this.dgvElfHeader.AllowUserToDeleteRows = false;
            this.dgvElfHeader.AllowUserToResizeColumns = false;
            this.dgvElfHeader.AllowUserToResizeRows = false;
            this.dgvElfHeader.ColumnHeadersHeight = 30;
            this.dgvElfHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colElfName,
            this.colElfContents});
            this.dgvElfHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvElfHeader.Location = new System.Drawing.Point(3, 3);
            this.dgvElfHeader.MultiSelect = false;
            this.dgvElfHeader.Name = "dgvElfHeader";
            this.dgvElfHeader.ReadOnly = true;
            this.dgvElfHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvElfHeader.RowHeadersVisible = false;
            this.dgvElfHeader.RowTemplate.Height = 23;
            this.dgvElfHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElfHeader.Size = new System.Drawing.Size(512, 423);
            this.dgvElfHeader.TabIndex = 0;
            // 
            // colElfName
            // 
            this.colElfName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colElfName.HeaderText = "Name";
            this.colElfName.Name = "colElfName";
            this.colElfName.ReadOnly = true;
            this.colElfName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colElfName.Width = 45;
            // 
            // colElfContents
            // 
            this.colElfContents.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colElfContents.HeaderText = "Contents";
            this.colElfContents.Name = "colElfContents";
            this.colElfContents.ReadOnly = true;
            this.colElfContents.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabSectionHeader
            // 
            this.tabSectionHeader.Controls.Add(this.dgvSectionHeader);
            this.tabSectionHeader.Location = new System.Drawing.Point(4, 4);
            this.tabSectionHeader.Name = "tabSectionHeader";
            this.tabSectionHeader.Padding = new System.Windows.Forms.Padding(3);
            this.tabSectionHeader.Size = new System.Drawing.Size(518, 429);
            this.tabSectionHeader.TabIndex = 1;
            this.tabSectionHeader.Text = "Section Header";
            this.tabSectionHeader.UseVisualStyleBackColor = true;
            // 
            // dgvSectionHeader
            // 
            this.dgvSectionHeader.AllowUserToAddRows = false;
            this.dgvSectionHeader.AllowUserToDeleteRows = false;
            this.dgvSectionHeader.AllowUserToResizeColumns = false;
            this.dgvSectionHeader.AllowUserToResizeRows = false;
            this.dgvSectionHeader.ColumnHeadersHeight = 30;
            this.dgvSectionHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSectionIndex,
            this.colSectionName,
            this.colSectionType,
            this.colSectionFlags,
            this.colSectionVA,
            this.colSectionOffset,
            this.colSectionSize,
            this.colSectionLink});
            this.dgvSectionHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSectionHeader.Location = new System.Drawing.Point(3, 3);
            this.dgvSectionHeader.MultiSelect = false;
            this.dgvSectionHeader.Name = "dgvSectionHeader";
            this.dgvSectionHeader.ReadOnly = true;
            this.dgvSectionHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSectionHeader.RowHeadersVisible = false;
            this.dgvSectionHeader.RowTemplate.Height = 23;
            this.dgvSectionHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSectionHeader.Size = new System.Drawing.Size(512, 423);
            this.dgvSectionHeader.TabIndex = 1;
            // 
            // colSectionIndex
            // 
            this.colSectionIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSectionIndex.HeaderText = "Index";
            this.colSectionIndex.Name = "colSectionIndex";
            this.colSectionIndex.ReadOnly = true;
            this.colSectionIndex.Width = 61;
            // 
            // colSectionName
            // 
            this.colSectionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSectionName.HeaderText = "Name";
            this.colSectionName.Name = "colSectionName";
            this.colSectionName.ReadOnly = true;
            this.colSectionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSectionName.Width = 45;
            // 
            // colSectionType
            // 
            this.colSectionType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSectionType.HeaderText = "Type";
            this.colSectionType.Name = "colSectionType";
            this.colSectionType.ReadOnly = true;
            this.colSectionType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSectionType.Width = 40;
            // 
            // colSectionFlags
            // 
            this.colSectionFlags.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSectionFlags.HeaderText = "Flags";
            this.colSectionFlags.Name = "colSectionFlags";
            this.colSectionFlags.ReadOnly = true;
            this.colSectionFlags.Width = 61;
            // 
            // colSectionVA
            // 
            this.colSectionVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSectionVA.HeaderText = "Virtual Address";
            this.colSectionVA.Name = "colSectionVA";
            this.colSectionVA.ReadOnly = true;
            this.colSectionVA.Width = 106;
            // 
            // colSectionOffset
            // 
            this.colSectionOffset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSectionOffset.HeaderText = "Offset";
            this.colSectionOffset.Name = "colSectionOffset";
            this.colSectionOffset.ReadOnly = true;
            this.colSectionOffset.Width = 62;
            // 
            // colSectionSize
            // 
            this.colSectionSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSectionSize.HeaderText = "Size";
            this.colSectionSize.Name = "colSectionSize";
            this.colSectionSize.ReadOnly = true;
            this.colSectionSize.Width = 55;
            // 
            // colSectionLink
            // 
            this.colSectionLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSectionLink.HeaderText = "Link";
            this.colSectionLink.Name = "colSectionLink";
            this.colSectionLink.ReadOnly = true;
            this.colSectionLink.Width = 53;
            // 
            // tabProgramHeader
            // 
            this.tabProgramHeader.Controls.Add(this.dgvProgramHeader);
            this.tabProgramHeader.Location = new System.Drawing.Point(4, 4);
            this.tabProgramHeader.Name = "tabProgramHeader";
            this.tabProgramHeader.Size = new System.Drawing.Size(518, 429);
            this.tabProgramHeader.TabIndex = 2;
            this.tabProgramHeader.Text = "Program Header";
            this.tabProgramHeader.UseVisualStyleBackColor = true;
            // 
            // dgvProgramHeader
            // 
            this.dgvProgramHeader.AllowUserToAddRows = false;
            this.dgvProgramHeader.AllowUserToDeleteRows = false;
            this.dgvProgramHeader.AllowUserToResizeColumns = false;
            this.dgvProgramHeader.AllowUserToResizeRows = false;
            this.dgvProgramHeader.ColumnHeadersHeight = 30;
            this.dgvProgramHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProgramType,
            this.colProgramOffset,
            this.colProgramVA,
            this.colProgramPhyAddr,
            this.colProgramFileSize,
            this.colProgramMemorySize,
            this.colProgramFlags});
            this.dgvProgramHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProgramHeader.Location = new System.Drawing.Point(0, 0);
            this.dgvProgramHeader.MultiSelect = false;
            this.dgvProgramHeader.Name = "dgvProgramHeader";
            this.dgvProgramHeader.ReadOnly = true;
            this.dgvProgramHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvProgramHeader.RowHeadersVisible = false;
            this.dgvProgramHeader.RowTemplate.Height = 23;
            this.dgvProgramHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgramHeader.Size = new System.Drawing.Size(518, 429);
            this.dgvProgramHeader.TabIndex = 2;
            // 
            // colProgramType
            // 
            this.colProgramType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProgramType.HeaderText = "Type";
            this.colProgramType.Name = "colProgramType";
            this.colProgramType.ReadOnly = true;
            this.colProgramType.Width = 59;
            // 
            // colProgramOffset
            // 
            this.colProgramOffset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProgramOffset.HeaderText = "Offset";
            this.colProgramOffset.Name = "colProgramOffset";
            this.colProgramOffset.ReadOnly = true;
            this.colProgramOffset.Width = 62;
            // 
            // colProgramVA
            // 
            this.colProgramVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProgramVA.HeaderText = "Virtual Address";
            this.colProgramVA.Name = "colProgramVA";
            this.colProgramVA.ReadOnly = true;
            this.colProgramVA.Width = 106;
            // 
            // colProgramPhyAddr
            // 
            this.colProgramPhyAddr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProgramPhyAddr.HeaderText = "Physical Address";
            this.colProgramPhyAddr.Name = "colProgramPhyAddr";
            this.colProgramPhyAddr.ReadOnly = true;
            this.colProgramPhyAddr.Width = 119;
            // 
            // colProgramFileSize
            // 
            this.colProgramFileSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProgramFileSize.HeaderText = "File Size";
            this.colProgramFileSize.Name = "colProgramFileSize";
            this.colProgramFileSize.ReadOnly = true;
            this.colProgramFileSize.Width = 73;
            // 
            // colProgramMemorySize
            // 
            this.colProgramMemorySize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProgramMemorySize.HeaderText = "Memory Size";
            this.colProgramMemorySize.Name = "colProgramMemorySize";
            this.colProgramMemorySize.ReadOnly = true;
            this.colProgramMemorySize.Width = 97;
            // 
            // colProgramFlags
            // 
            this.colProgramFlags.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProgramFlags.HeaderText = "Flags";
            this.colProgramFlags.Name = "colProgramFlags";
            this.colProgramFlags.ReadOnly = true;
            this.colProgramFlags.Width = 61;
            // 
            // rtbElfHeader
            // 
            this.rtbElfHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbElfHeader.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rtbElfHeader.Location = new System.Drawing.Point(0, 0);
            this.rtbElfHeader.Name = "rtbElfHeader";
            this.rtbElfHeader.Size = new System.Drawing.Size(313, 467);
            this.rtbElfHeader.TabIndex = 0;
            this.rtbElfHeader.Text = "";
            this.rtbElfHeader.WordWrap = false;
            // 
            // tabFirmwareBinary
            // 
            this.tabFirmwareBinary.Controls.Add(this.cbMakeFileSizeFormat);
            this.tabFirmwareBinary.Controls.Add(this.txtMakeFileSize);
            this.tabFirmwareBinary.Controls.Add(this.panelMakePadding);
            this.tabFirmwareBinary.Controls.Add(this.label14);
            this.tabFirmwareBinary.Controls.Add(this.label16);
            this.tabFirmwareBinary.Controls.Add(this.label12);
            this.tabFirmwareBinary.Controls.Add(this.btnMakeBinary);
            this.tabFirmwareBinary.Controls.Add(this.label11);
            this.tabFirmwareBinary.Controls.Add(this.txtBinaryNamePrefix);
            this.tabFirmwareBinary.Controls.Add(this.cbBinaryPadding);
            this.tabFirmwareBinary.Controls.Add(this.dgvMakeBinary);
            this.tabFirmwareBinary.Location = new System.Drawing.Point(4, 24);
            this.tabFirmwareBinary.Name = "tabFirmwareBinary";
            this.tabFirmwareBinary.Padding = new System.Windows.Forms.Padding(3);
            this.tabFirmwareBinary.Size = new System.Drawing.Size(849, 473);
            this.tabFirmwareBinary.TabIndex = 1;
            this.tabFirmwareBinary.Text = "Make Binary";
            this.tabFirmwareBinary.UseVisualStyleBackColor = true;
            // 
            // cbMakeFileSizeFormat
            // 
            this.cbMakeFileSizeFormat.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMakeFileSizeFormat.AutoSize = true;
            this.cbMakeFileSizeFormat.Location = new System.Drawing.Point(716, 140);
            this.cbMakeFileSizeFormat.Name = "cbMakeFileSizeFormat";
            this.cbMakeFileSizeFormat.Size = new System.Drawing.Size(47, 22);
            this.cbMakeFileSizeFormat.TabIndex = 32;
            this.cbMakeFileSizeFormat.Text = "BYTE";
            this.cbMakeFileSizeFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMakeFileSizeFormat.UseVisualStyleBackColor = true;
            this.cbMakeFileSizeFormat.CheckedChanged += new System.EventHandler(this.cbMakeFileSizeFormat_CheckedChanged);
            // 
            // txtMakeFileSize
            // 
            this.txtMakeFileSize.Location = new System.Drawing.Point(591, 142);
            this.txtMakeFileSize.Name = "txtMakeFileSize";
            this.txtMakeFileSize.ReadOnly = true;
            this.txtMakeFileSize.Size = new System.Drawing.Size(118, 21);
            this.txtMakeFileSize.TabIndex = 31;
            this.txtMakeFileSize.Text = "0";
            this.txtMakeFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelMakePadding
            // 
            this.panelMakePadding.Controls.Add(this.label13);
            this.panelMakePadding.Controls.Add(this.label15);
            this.panelMakePadding.Controls.Add(this.numericUpDown1);
            this.panelMakePadding.Controls.Add(this.textBox1);
            this.panelMakePadding.Enabled = false;
            this.panelMakePadding.Location = new System.Drawing.Point(655, 38);
            this.panelMakePadding.Name = "panelMakePadding";
            this.panelMakePadding.Size = new System.Drawing.Size(136, 69);
            this.panelMakePadding.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "Padding";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 12);
            this.label15.TabIndex = 27;
            this.label15.Text = "Count";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(60, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 21);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 21);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(522, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "Enable Padding";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(522, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 12);
            this.label16.TabIndex = 23;
            this.label16.Text = "File Size";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(522, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "File Name";
            // 
            // btnMakeBinary
            // 
            this.btnMakeBinary.Location = new System.Drawing.Point(716, 184);
            this.btnMakeBinary.Name = "btnMakeBinary";
            this.btnMakeBinary.Size = new System.Drawing.Size(75, 23);
            this.btnMakeBinary.TabIndex = 22;
            this.btnMakeBinary.Text = "Generate";
            this.btnMakeBinary.UseVisualStyleBackColor = true;
            this.btnMakeBinary.Click += new System.EventHandler(this.btnMakeBinary_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(17, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "Select Area for Binary";
            // 
            // txtBinaryNamePrefix
            // 
            this.txtBinaryNamePrefix.Location = new System.Drawing.Point(591, 186);
            this.txtBinaryNamePrefix.Name = "txtBinaryNamePrefix";
            this.txtBinaryNamePrefix.Size = new System.Drawing.Size(119, 21);
            this.txtBinaryNamePrefix.TabIndex = 18;
            // 
            // cbBinaryPadding
            // 
            this.cbBinaryPadding.AutoSize = true;
            this.cbBinaryPadding.Location = new System.Drawing.Point(622, 47);
            this.cbBinaryPadding.Name = "cbBinaryPadding";
            this.cbBinaryPadding.Size = new System.Drawing.Size(15, 14);
            this.cbBinaryPadding.TabIndex = 16;
            this.cbBinaryPadding.UseVisualStyleBackColor = true;
            this.cbBinaryPadding.CheckedChanged += new System.EventHandler(this.cbBinaryPadding_CheckedChanged);
            // 
            // dgvMakeBinary
            // 
            this.dgvMakeBinary.AllowUserToAddRows = false;
            this.dgvMakeBinary.AllowUserToDeleteRows = false;
            this.dgvMakeBinary.AllowUserToResizeColumns = false;
            this.dgvMakeBinary.AllowUserToResizeRows = false;
            this.dgvMakeBinary.ColumnHeadersHeight = 30;
            this.dgvMakeBinary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMakeSelect,
            this.colMakeName,
            this.colMakeOffset,
            this.colMakeAddr,
            this.colMakeSize});
            this.dgvMakeBinary.Location = new System.Drawing.Point(19, 38);
            this.dgvMakeBinary.Name = "dgvMakeBinary";
            this.dgvMakeBinary.RowHeadersVisible = false;
            this.dgvMakeBinary.RowTemplate.Height = 23;
            this.dgvMakeBinary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMakeBinary.Size = new System.Drawing.Size(481, 168);
            this.dgvMakeBinary.TabIndex = 14;
            this.dgvMakeBinary.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMakeBinary_CellValueChanged);
            // 
            // colMakeSelect
            // 
            this.colMakeSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMakeSelect.HeaderText = "Sel";
            this.colMakeSelect.Name = "colMakeSelect";
            this.colMakeSelect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMakeSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMakeSelect.Width = 48;
            // 
            // colMakeName
            // 
            this.colMakeName.HeaderText = "Name";
            this.colMakeName.Name = "colMakeName";
            this.colMakeName.ReadOnly = true;
            // 
            // colMakeOffset
            // 
            this.colMakeOffset.HeaderText = "Offset";
            this.colMakeOffset.Name = "colMakeOffset";
            this.colMakeOffset.ReadOnly = true;
            // 
            // colMakeAddr
            // 
            this.colMakeAddr.HeaderText = "Address";
            this.colMakeAddr.Name = "colMakeAddr";
            this.colMakeAddr.ReadOnly = true;
            // 
            // colMakeSize
            // 
            this.colMakeSize.HeaderText = "Size";
            this.colMakeSize.Name = "colMakeSize";
            this.colMakeSize.ReadOnly = true;
            // 
            // tabCompare
            // 
            this.tabCompare.Controls.Add(this.splitContainer1);
            this.tabCompare.Location = new System.Drawing.Point(4, 24);
            this.tabCompare.Name = "tabCompare";
            this.tabCompare.Size = new System.Drawing.Size(849, 473);
            this.tabCompare.TabIndex = 2;
            this.tabCompare.Text = "Compare";
            this.tabCompare.UseVisualStyleBackColor = true;
            // 
            // tabParameter
            // 
            this.tabParameter.Controls.Add(this.tableLayoutPanel3);
            this.tabParameter.Location = new System.Drawing.Point(4, 24);
            this.tabParameter.Name = "tabParameter";
            this.tabParameter.Size = new System.Drawing.Size(849, 473);
            this.tabParameter.TabIndex = 3;
            this.tabParameter.Text = "Parameter";
            this.tabParameter.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.dgvInformation, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnOpenConfig, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnParseConfig, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtConfigPath, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(443, 26);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(232, 403);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dgvInformation
            // 
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colContents});
            this.tableLayoutPanel3.SetColumnSpan(this.dgvInformation, 2);
            this.dgvInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInformation.Location = new System.Drawing.Point(3, 29);
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInformation.RowHeadersVisible = false;
            this.dgvInformation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvInformation.RowTemplate.Height = 23;
            this.dgvInformation.Size = new System.Drawing.Size(226, 342);
            this.dgvInformation.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colContents
            // 
            this.colContents.HeaderText = "Contents";
            this.colContents.Name = "colContents";
            this.colContents.ReadOnly = true;
            // 
            // btnOpenConfig
            // 
            this.btnOpenConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenConfig.Location = new System.Drawing.Point(154, 3);
            this.btnOpenConfig.Name = "btnOpenConfig";
            this.btnOpenConfig.Size = new System.Drawing.Size(75, 23);
            this.btnOpenConfig.TabIndex = 2;
            this.btnOpenConfig.Text = "Open";
            this.btnOpenConfig.UseVisualStyleBackColor = true;
            // 
            // btnParseConfig
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.btnParseConfig, 2);
            this.btnParseConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnParseConfig.Enabled = false;
            this.btnParseConfig.Location = new System.Drawing.Point(3, 377);
            this.btnParseConfig.Name = "btnParseConfig";
            this.btnParseConfig.Size = new System.Drawing.Size(226, 23);
            this.btnParseConfig.TabIndex = 3;
            this.btnParseConfig.Text = "Get Config";
            this.btnParseConfig.UseVisualStyleBackColor = true;
            // 
            // txtConfigPath
            // 
            this.txtConfigPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfigPath.Location = new System.Drawing.Point(3, 3);
            this.txtConfigPath.Name = "txtConfigPath";
            this.txtConfigPath.ReadOnly = true;
            this.txtConfigPath.Size = new System.Drawing.Size(145, 21);
            this.txtConfigPath.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressWork});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(865, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressWork
            // 
            this.progressWork.Name = "progressWork";
            this.progressWork.Size = new System.Drawing.Size(100, 16);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.txtElfFilePath, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnLoadELF, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(865, 30);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 562);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabMainControl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Edit Firmware Binary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.workPanel.ResumeLayout(false);
            this.workPanel.PerformLayout();
            this.customCompareRange.ResumeLayout(false);
            this.customCompareRange.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMainControl.ResumeLayout(false);
            this.tabELF.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabElfParse.ResumeLayout(false);
            this.tabElfHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElfHeader)).EndInit();
            this.tabSectionHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSectionHeader)).EndInit();
            this.tabProgramHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramHeader)).EndInit();
            this.tabFirmwareBinary.ResumeLayout(false);
            this.tabFirmwareBinary.PerformLayout();
            this.panelMakePadding.ResumeLayout(false);
            this.panelMakePadding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMakeBinary)).EndInit();
            this.tabCompare.ResumeLayout(false);
            this.tabParameter.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCompareStartAddr;
        private System.Windows.Forms.TextBox txtFirmwareBinPath;
        private System.Windows.Forms.Button btnOpenFirmware;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompareStopAddr;
        private System.Windows.Forms.Button btnSaveUpdateArea;
        private System.Windows.Forms.Button btnCompareDatas;
        private System.Windows.Forms.TextBox txtReferencePath;
        private System.Windows.Forms.Button btnOpenReference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtCompareResult;
        private System.Windows.Forms.CheckBox cbShowDifference;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCRC32;
        private System.Windows.Forms.Button btnCRC32;
        private System.Windows.Forms.ListBox listMismatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSelectedIndex;
        private System.Windows.Forms.TextBox txtReferenceVal;
        private System.Windows.Forms.TextBox txtOriginalVal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel workPanel;
        private System.Windows.Forms.TextBox txtMismatchedNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtElfFilePath;
        private System.Windows.Forms.Button btnLoadELF;
        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabELF;
        private System.Windows.Forms.TabPage tabFirmwareBinary;
        private System.Windows.Forms.TabPage tabCompare;
        private System.Windows.Forms.TabPage tabParameter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressWork;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContents;
        private System.Windows.Forms.Button btnOpenConfig;
        private System.Windows.Forms.Button btnParseConfig;
        private System.Windows.Forms.TextBox txtConfigPath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TabControl tabElfParse;
        private System.Windows.Forms.TabPage tabElfHeader;
        private System.Windows.Forms.TabPage tabSectionHeader;
        private System.Windows.Forms.TabPage tabProgramHeader;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox rtbElfHeader;
        private System.Windows.Forms.DataGridView dgvElfHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colElfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colElfContents;
        private System.Windows.Forms.DataGridView dgvSectionHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionFlags;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionLink;
        private System.Windows.Forms.DataGridView dgvProgramHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramPhyAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramMemorySize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramFlags;
        private System.Windows.Forms.FlowLayoutPanel customCompareRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMakeBinary;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMakeSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMakeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMakeOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMakeAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMakeSize;
        private System.Windows.Forms.CheckBox cbBinaryPadding;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBinaryNamePrefix;
        private System.Windows.Forms.Button btnMakeBinary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelMakePadding;
        private System.Windows.Forms.CheckBox cbMakeFileSizeFormat;
        private System.Windows.Forms.TextBox txtMakeFileSize;
        private System.Windows.Forms.Label label16;
    }
}

