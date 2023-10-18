
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.cbShowDifference = new System.Windows.Forms.CheckBox();
            this.btnSaveUpdateArea = new System.Windows.Forms.Button();
            this.btnCompareDatas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.lblCompareOriginFile = new System.Windows.Forms.Label();
            this.lblCompareRefFile = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.workPanel = new System.Windows.Forms.TableLayoutPanel();
            this.customCompareRange = new System.Windows.Forms.FlowLayoutPanel();
            this.nCompareStartAddr = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nCompareStopAddr = new System.Windows.Forms.NumericUpDown();
            this.cbCompareAddrFormat = new System.Windows.Forms.CheckBox();
            this.nMismatchedNumber = new System.Windows.Forms.NumericUpDown();
            this.txtCompareResult = new System.Windows.Forms.RichTextBox();
            this.txtCompareHeader = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.txtElfFilePath = new System.Windows.Forms.TextBox();
            this.btnLoadELF = new System.Windows.Forms.Button();
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabELF = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
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
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nResultCrc32 = new System.Windows.Forms.NumericUpDown();
            this.nEndOffsetCrc32 = new System.Windows.Forms.NumericUpDown();
            this.nStartOffsetCrc32 = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbSectionCRC1 = new System.Windows.Forms.CheckBox();
            this.cbSectionCRC2 = new System.Windows.Forms.CheckBox();
            this.btnCalcultaeCrc32 = new System.Windows.Forms.Button();
            this.cbBinaryPadding = new System.Windows.Forms.CheckBox();
            this.panelMakePadding = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSectionCRC1Value = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSectionCRC2Value = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nMakeBinarySize = new System.Windows.Forms.NumericUpDown();
            this.nMakeBinaryFill = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBinaryNamePrefix = new System.Windows.Forms.TextBox();
            this.btnMakeBinary = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbBinarySizeEnable = new System.Windows.Forms.CheckBox();
            this.cbMakeFileSizeFormat = new System.Windows.Forms.CheckBox();
            this.cbDisplayFormat = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvMakeBinary = new System.Windows.Forms.DataGridView();
            this.colMakeSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMakeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMakeOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMakeVAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMakePAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMakeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMakeFileSize = new System.Windows.Forms.TextBox();
            this.tabCompare = new System.Windows.Forms.TabPage();
            this.tabCombine = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbOverrideCombineBin = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtOverrideOffset = new System.Windows.Forms.TextBox();
            this.txtOverrideBinary = new System.Windows.Forms.TextBox();
            this.cbCombineAddParameter = new System.Windows.Forms.CheckBox();
            this.cbOverrideBinary = new System.Windows.Forms.CheckBox();
            this.nMakeCombineBinaryFill = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCombineBinarySize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCombineBinaryNamePrefix = new System.Windows.Forms.TextBox();
            this.btnMakeCombineBinary = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveBinary = new System.Windows.Forms.Button();
            this.dgvCombineBinaries = new System.Windows.Forms.DataGridView();
            this.colOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBinPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddBootloader = new System.Windows.Forms.Button();
            this.btnAddUserFirmware = new System.Windows.Forms.Button();
            this.tabExtract = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCalculateCrc32 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCrc32TestResult = new System.Windows.Forms.Label();
            this.nCrc32Size = new System.Windows.Forms.NumericUpDown();
            this.nCrc32StartOffset = new System.Windows.Forms.NumericUpDown();
            this.lblEtcCrc32Result = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtEtcCrc32FirmwarePath = new System.Windows.Forms.TextBox();
            this.btnEtcOpenCrc32Firmware = new System.Windows.Forms.Button();
            this.btnEtcGenerateCrc32Firmware = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.nEtcExtractStartAddr = new System.Windows.Forms.NumericUpDown();
            this.nEtcExtractLength = new System.Windows.Forms.NumericUpDown();
            this.txtEtcExtractFilePath = new System.Windows.Forms.TextBox();
            this.cbEtcEtcExtractDisplayFormat = new System.Windows.Forms.CheckBox();
            this.btnEtcOpenExtractFile = new System.Windows.Forms.Button();
            this.btnEtcExtractFile = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressWork = new System.Windows.Forms.ToolStripProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.workPanel.SuspendLayout();
            this.customCompareRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCompareStartAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCompareStopAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMismatchedNumber)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMainControl.SuspendLayout();
            this.tabELF.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nResultCrc32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEndOffsetCrc32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStartOffsetCrc32)).BeginInit();
            this.panelMakePadding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMakeBinarySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMakeBinaryFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMakeBinary)).BeginInit();
            this.tabCompare.SuspendLayout();
            this.tabCombine.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbOverrideCombineBin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMakeCombineBinaryFill)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombineBinaries)).BeginInit();
            this.tabExtract.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCrc32Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCrc32StartOffset)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEtcExtractStartAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEtcExtractLength)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 12);
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
            this.cbShowDifference.Location = new System.Drawing.Point(416, 46);
            this.cbShowDifference.Name = "cbShowDifference";
            this.cbShowDifference.Size = new System.Drawing.Size(78, 16);
            this.cbShowDifference.TabIndex = 8;
            this.cbShowDifference.Text = "hexaview";
            this.cbShowDifference.UseVisualStyleBackColor = true;
            // 
            // btnSaveUpdateArea
            // 
            this.btnSaveUpdateArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveUpdateArea.Location = new System.Drawing.Point(400, 13);
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
            this.btnCompareDatas.Location = new System.Drawing.Point(300, 13);
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
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Range";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirmwareBinPath
            // 
            this.txtFirmwareBinPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirmwareBinPath.Location = new System.Drawing.Point(112, 10);
            this.txtFirmwareBinPath.Name = "txtFirmwareBinPath";
            this.txtFirmwareBinPath.ReadOnly = true;
            this.txtFirmwareBinPath.Size = new System.Drawing.Size(322, 21);
            this.txtFirmwareBinPath.TabIndex = 3;
            // 
            // btnOpenFirmware
            // 
            this.btnOpenFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFirmware.Location = new System.Drawing.Point(440, 8);
            this.btnOpenFirmware.Name = "btnOpenFirmware";
            this.btnOpenFirmware.Size = new System.Drawing.Size(75, 25);
            this.btnOpenFirmware.TabIndex = 4;
            this.btnOpenFirmware.Text = "OPEN";
            this.btnOpenFirmware.UseVisualStyleBackColor = true;
            this.btnOpenFirmware.Click += new System.EventHandler(this.btnOpenFirmware_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Firmware Binary";
            // 
            // txtReferencePath
            // 
            this.txtReferencePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReferencePath.Location = new System.Drawing.Point(112, 41);
            this.txtReferencePath.Name = "txtReferencePath";
            this.txtReferencePath.ReadOnly = true;
            this.txtReferencePath.Size = new System.Drawing.Size(322, 21);
            this.txtReferencePath.TabIndex = 3;
            // 
            // btnOpenReference
            // 
            this.btnOpenReference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenReference.Location = new System.Drawing.Point(440, 39);
            this.btnOpenReference.Name = "btnOpenReference";
            this.btnOpenReference.Size = new System.Drawing.Size(75, 25);
            this.btnOpenReference.TabIndex = 4;
            this.btnOpenReference.Text = "OPEN";
            this.btnOpenReference.UseVisualStyleBackColor = true;
            this.btnOpenReference.Click += new System.EventHandler(this.btnOpenReference_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 45);
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
            this.listMismatch.Size = new System.Drawing.Size(245, 376);
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
            this.txtReferenceVal.Location = new System.Drawing.Point(76, 435);
            this.txtReferenceVal.Name = "txtReferenceVal";
            this.txtReferenceVal.ReadOnly = true;
            this.txtReferenceVal.Size = new System.Drawing.Size(172, 21);
            this.txtReferenceVal.TabIndex = 9;
            // 
            // txtOriginalVal
            // 
            this.txtOriginalVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOriginalVal.Location = new System.Drawing.Point(76, 408);
            this.txtOriginalVal.Name = "txtOriginalVal";
            this.txtOriginalVal.ReadOnly = true;
            this.txtOriginalVal.Size = new System.Drawing.Size(172, 21);
            this.txtOriginalVal.TabIndex = 9;
            // 
            // lblCompareOriginFile
            // 
            this.lblCompareOriginFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCompareOriginFile.AutoSize = true;
            this.lblCompareOriginFile.Location = new System.Drawing.Point(3, 412);
            this.lblCompareOriginFile.Margin = new System.Windows.Forms.Padding(3);
            this.lblCompareOriginFile.Name = "lblCompareOriginFile";
            this.lblCompareOriginFile.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblCompareOriginFile.Size = new System.Drawing.Size(53, 12);
            this.lblCompareOriginFile.TabIndex = 10;
            this.lblCompareOriginFile.Text = "Original";
            // 
            // lblCompareRefFile
            // 
            this.lblCompareRefFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCompareRefFile.AutoSize = true;
            this.lblCompareRefFile.Location = new System.Drawing.Point(3, 439);
            this.lblCompareRefFile.Margin = new System.Windows.Forms.Padding(3);
            this.lblCompareRefFile.Name = "lblCompareRefFile";
            this.lblCompareRefFile.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblCompareRefFile.Size = new System.Drawing.Size(67, 12);
            this.lblCompareRefFile.TabIndex = 11;
            this.lblCompareRefFile.Text = "Reference";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 459);
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
            this.workPanel.Controls.Add(this.label7, 0, 1);
            this.workPanel.Controls.Add(this.cbShowDifference, 4, 1);
            this.workPanel.Controls.Add(this.customCompareRange, 1, 0);
            this.workPanel.Controls.Add(this.btnSaveUpdateArea, 5, 0);
            this.workPanel.Controls.Add(this.btnCompareDatas, 4, 0);
            this.workPanel.Controls.Add(this.nMismatchedNumber, 1, 1);
            this.workPanel.Controls.Add(this.txtCompareResult, 0, 3);
            this.workPanel.Controls.Add(this.txtCompareHeader, 0, 2);
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel.Location = new System.Drawing.Point(8, 70);
            this.workPanel.Name = "workPanel";
            this.workPanel.Padding = new System.Windows.Forms.Padding(10);
            this.workPanel.RowCount = 2;
            this.workPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.workPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.workPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.workPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.workPanel.Size = new System.Drawing.Size(507, 381);
            this.workPanel.TabIndex = 13;
            // 
            // customCompareRange
            // 
            this.workPanel.SetColumnSpan(this.customCompareRange, 3);
            this.customCompareRange.Controls.Add(this.nCompareStartAddr);
            this.customCompareRange.Controls.Add(this.label5);
            this.customCompareRange.Controls.Add(this.nCompareStopAddr);
            this.customCompareRange.Controls.Add(this.cbCompareAddrFormat);
            this.customCompareRange.Location = new System.Drawing.Point(94, 13);
            this.customCompareRange.Name = "customCompareRange";
            this.customCompareRange.Size = new System.Drawing.Size(175, 25);
            this.customCompareRange.TabIndex = 13;
            // 
            // nCompareStartAddr
            // 
            this.nCompareStartAddr.Hexadecimal = true;
            this.nCompareStartAddr.Location = new System.Drawing.Point(3, 3);
            this.nCompareStartAddr.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nCompareStartAddr.Name = "nCompareStartAddr";
            this.nCompareStartAddr.Size = new System.Drawing.Size(70, 21);
            this.nCompareStartAddr.TabIndex = 4;
            this.nCompareStartAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "~";
            // 
            // nCompareStopAddr
            // 
            this.nCompareStopAddr.Hexadecimal = true;
            this.nCompareStopAddr.Location = new System.Drawing.Point(99, 3);
            this.nCompareStopAddr.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nCompareStopAddr.Name = "nCompareStopAddr";
            this.nCompareStopAddr.Size = new System.Drawing.Size(70, 21);
            this.nCompareStopAddr.TabIndex = 5;
            this.nCompareStopAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbCompareAddrFormat
            // 
            this.cbCompareAddrFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCompareAddrFormat.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCompareAddrFormat.AutoSize = true;
            this.cbCompareAddrFormat.Location = new System.Drawing.Point(3, 30);
            this.cbCompareAddrFormat.Name = "cbCompareAddrFormat";
            this.cbCompareAddrFormat.Size = new System.Drawing.Size(39, 22);
            this.cbCompareAddrFormat.TabIndex = 3;
            this.cbCompareAddrFormat.Text = "HEX";
            this.cbCompareAddrFormat.UseVisualStyleBackColor = true;
            this.cbCompareAddrFormat.CheckedChanged += new System.EventHandler(this.cbCompareAddrFormat_CheckedChanged);
            // 
            // nMismatchedNumber
            // 
            this.nMismatchedNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nMismatchedNumber.Location = new System.Drawing.Point(94, 44);
            this.nMismatchedNumber.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nMismatchedNumber.Name = "nMismatchedNumber";
            this.nMismatchedNumber.Size = new System.Drawing.Size(64, 21);
            this.nMismatchedNumber.TabIndex = 14;
            this.nMismatchedNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCompareResult
            // 
            this.workPanel.SetColumnSpan(this.txtCompareResult, 6);
            this.txtCompareResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompareResult.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompareResult.Location = new System.Drawing.Point(14, 95);
            this.txtCompareResult.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCompareResult.Name = "txtCompareResult";
            this.txtCompareResult.ReadOnly = true;
            this.txtCompareResult.Size = new System.Drawing.Size(479, 274);
            this.txtCompareResult.TabIndex = 5;
            this.txtCompareResult.Text = "";
            this.txtCompareResult.WordWrap = false;
            // 
            // txtCompareHeader
            // 
            this.workPanel.SetColumnSpan(this.txtCompareHeader, 6);
            this.txtCompareHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompareHeader.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtCompareHeader.Location = new System.Drawing.Point(14, 70);
            this.txtCompareHeader.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCompareHeader.Name = "txtCompareHeader";
            this.txtCompareHeader.ReadOnly = true;
            this.txtCompareHeader.Size = new System.Drawing.Size(479, 21);
            this.txtCompareHeader.TabIndex = 15;
            this.txtCompareHeader.Text = "        | 00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblCompareOriginFile, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtReferenceVal, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblCompareRefFile, 0, 3);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(251, 459);
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
            this.splitContainer1.Size = new System.Drawing.Size(778, 459);
            this.splitContainer1.SplitterDistance = 523;
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
            this.txtElfFilePath.Size = new System.Drawing.Size(612, 21);
            this.txtElfFilePath.TabIndex = 16;
            // 
            // btnLoadELF
            // 
            this.btnLoadELF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLoadELF.Location = new System.Drawing.Point(694, 4);
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
            this.tabMainControl.Controls.Add(this.tabCombine);
            this.tabMainControl.Controls.Add(this.tabExtract);
            this.tabMainControl.ItemSize = new System.Drawing.Size(100, 20);
            this.tabMainControl.Location = new System.Drawing.Point(0, 0);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(786, 487);
            this.tabMainControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMainControl.TabIndex = 20;
            // 
            // tabELF
            // 
            this.tabELF.Controls.Add(this.tableLayoutPanel4);
            this.tabELF.Controls.Add(this.splitContainer2);
            this.tabELF.Location = new System.Drawing.Point(4, 24);
            this.tabELF.Name = "tabELF";
            this.tabELF.Padding = new System.Windows.Forms.Padding(3);
            this.tabELF.Size = new System.Drawing.Size(778, 459);
            this.tabELF.TabIndex = 0;
            this.tabELF.Text = "ELF Parser";
            this.tabELF.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(772, 30);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(3, 34);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabElfParse);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtbElfHeader);
            this.splitContainer2.Size = new System.Drawing.Size(777, 429);
            this.splitContainer2.SplitterDistance = 483;
            this.splitContainer2.TabIndex = 1;
            // 
            // tabElfParse
            // 
            this.tabElfParse.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabElfParse.Controls.Add(this.tabElfHeader);
            this.tabElfParse.Controls.Add(this.tabSectionHeader);
            this.tabElfParse.Controls.Add(this.tabProgramHeader);
            this.tabElfParse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabElfParse.Enabled = false;
            this.tabElfParse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabElfParse.ItemSize = new System.Drawing.Size(120, 30);
            this.tabElfParse.Location = new System.Drawing.Point(0, 0);
            this.tabElfParse.Name = "tabElfParse";
            this.tabElfParse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabElfParse.SelectedIndex = 0;
            this.tabElfParse.Size = new System.Drawing.Size(483, 429);
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
            this.tabElfHeader.Size = new System.Drawing.Size(475, 391);
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
            this.dgvElfHeader.RowHeadersWidth = 51;
            this.dgvElfHeader.RowTemplate.Height = 23;
            this.dgvElfHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElfHeader.Size = new System.Drawing.Size(469, 385);
            this.dgvElfHeader.TabIndex = 0;
            // 
            // colElfName
            // 
            this.colElfName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colElfName.HeaderText = "Name";
            this.colElfName.MinimumWidth = 6;
            this.colElfName.Name = "colElfName";
            this.colElfName.ReadOnly = true;
            this.colElfName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colElfName.Width = 45;
            // 
            // colElfContents
            // 
            this.colElfContents.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colElfContents.HeaderText = "Contents";
            this.colElfContents.MinimumWidth = 6;
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
            this.tabSectionHeader.Size = new System.Drawing.Size(475, 391);
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
            this.dgvSectionHeader.RowHeadersWidth = 51;
            this.dgvSectionHeader.RowTemplate.Height = 23;
            this.dgvSectionHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSectionHeader.Size = new System.Drawing.Size(469, 385);
            this.dgvSectionHeader.TabIndex = 1;
            // 
            // colSectionIndex
            // 
            this.colSectionIndex.HeaderText = "Index";
            this.colSectionIndex.MinimumWidth = 6;
            this.colSectionIndex.Name = "colSectionIndex";
            this.colSectionIndex.ReadOnly = true;
            this.colSectionIndex.Width = 50;
            // 
            // colSectionName
            // 
            this.colSectionName.HeaderText = "Name";
            this.colSectionName.MinimumWidth = 6;
            this.colSectionName.Name = "colSectionName";
            this.colSectionName.ReadOnly = true;
            this.colSectionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSectionName.Width = 125;
            // 
            // colSectionType
            // 
            this.colSectionType.HeaderText = "Type";
            this.colSectionType.MinimumWidth = 6;
            this.colSectionType.Name = "colSectionType";
            this.colSectionType.ReadOnly = true;
            this.colSectionType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSectionType.Width = 80;
            // 
            // colSectionFlags
            // 
            this.colSectionFlags.HeaderText = "Flags";
            this.colSectionFlags.MinimumWidth = 6;
            this.colSectionFlags.Name = "colSectionFlags";
            this.colSectionFlags.ReadOnly = true;
            this.colSectionFlags.Width = 80;
            // 
            // colSectionVA
            // 
            this.colSectionVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSectionVA.HeaderText = "Virtual Address";
            this.colSectionVA.MinimumWidth = 6;
            this.colSectionVA.Name = "colSectionVA";
            this.colSectionVA.ReadOnly = true;
            this.colSectionVA.Width = 106;
            // 
            // colSectionOffset
            // 
            this.colSectionOffset.HeaderText = "Offset";
            this.colSectionOffset.MinimumWidth = 6;
            this.colSectionOffset.Name = "colSectionOffset";
            this.colSectionOffset.ReadOnly = true;
            this.colSectionOffset.Width = 125;
            // 
            // colSectionSize
            // 
            this.colSectionSize.HeaderText = "Size";
            this.colSectionSize.MinimumWidth = 6;
            this.colSectionSize.Name = "colSectionSize";
            this.colSectionSize.ReadOnly = true;
            this.colSectionSize.Width = 60;
            // 
            // colSectionLink
            // 
            this.colSectionLink.HeaderText = "Link";
            this.colSectionLink.MinimumWidth = 6;
            this.colSectionLink.Name = "colSectionLink";
            this.colSectionLink.ReadOnly = true;
            this.colSectionLink.Width = 60;
            // 
            // tabProgramHeader
            // 
            this.tabProgramHeader.Controls.Add(this.dgvProgramHeader);
            this.tabProgramHeader.Location = new System.Drawing.Point(4, 4);
            this.tabProgramHeader.Name = "tabProgramHeader";
            this.tabProgramHeader.Size = new System.Drawing.Size(475, 391);
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
            this.dgvProgramHeader.RowHeadersWidth = 51;
            this.dgvProgramHeader.RowTemplate.Height = 23;
            this.dgvProgramHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgramHeader.Size = new System.Drawing.Size(475, 391);
            this.dgvProgramHeader.TabIndex = 2;
            // 
            // colProgramType
            // 
            this.colProgramType.HeaderText = "Type";
            this.colProgramType.MinimumWidth = 6;
            this.colProgramType.Name = "colProgramType";
            this.colProgramType.ReadOnly = true;
            this.colProgramType.Width = 80;
            // 
            // colProgramOffset
            // 
            this.colProgramOffset.HeaderText = "Offset";
            this.colProgramOffset.MinimumWidth = 6;
            this.colProgramOffset.Name = "colProgramOffset";
            this.colProgramOffset.ReadOnly = true;
            this.colProgramOffset.Width = 125;
            // 
            // colProgramVA
            // 
            this.colProgramVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProgramVA.HeaderText = "Virtual Address";
            this.colProgramVA.MinimumWidth = 6;
            this.colProgramVA.Name = "colProgramVA";
            this.colProgramVA.ReadOnly = true;
            this.colProgramVA.Width = 106;
            // 
            // colProgramPhyAddr
            // 
            this.colProgramPhyAddr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProgramPhyAddr.HeaderText = "Physical Address";
            this.colProgramPhyAddr.MinimumWidth = 6;
            this.colProgramPhyAddr.Name = "colProgramPhyAddr";
            this.colProgramPhyAddr.ReadOnly = true;
            this.colProgramPhyAddr.Width = 119;
            // 
            // colProgramFileSize
            // 
            this.colProgramFileSize.HeaderText = "File Size";
            this.colProgramFileSize.MinimumWidth = 6;
            this.colProgramFileSize.Name = "colProgramFileSize";
            this.colProgramFileSize.ReadOnly = true;
            this.colProgramFileSize.Width = 80;
            // 
            // colProgramMemorySize
            // 
            this.colProgramMemorySize.HeaderText = "Memory Size";
            this.colProgramMemorySize.MinimumWidth = 6;
            this.colProgramMemorySize.Name = "colProgramMemorySize";
            this.colProgramMemorySize.ReadOnly = true;
            this.colProgramMemorySize.Width = 125;
            // 
            // colProgramFlags
            // 
            this.colProgramFlags.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProgramFlags.HeaderText = "Flags";
            this.colProgramFlags.MinimumWidth = 6;
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
            this.rtbElfHeader.Size = new System.Drawing.Size(290, 429);
            this.rtbElfHeader.TabIndex = 0;
            this.rtbElfHeader.Text = "";
            this.rtbElfHeader.WordWrap = false;
            // 
            // tabFirmwareBinary
            // 
            this.tabFirmwareBinary.Controls.Add(this.label23);
            this.tabFirmwareBinary.Controls.Add(this.groupBox2);
            this.tabFirmwareBinary.Controls.Add(this.label16);
            this.tabFirmwareBinary.Controls.Add(this.groupBox1);
            this.tabFirmwareBinary.Controls.Add(this.cbMakeFileSizeFormat);
            this.tabFirmwareBinary.Controls.Add(this.cbDisplayFormat);
            this.tabFirmwareBinary.Controls.Add(this.label11);
            this.tabFirmwareBinary.Controls.Add(this.dgvMakeBinary);
            this.tabFirmwareBinary.Controls.Add(this.txtMakeFileSize);
            this.tabFirmwareBinary.Location = new System.Drawing.Point(4, 24);
            this.tabFirmwareBinary.Name = "tabFirmwareBinary";
            this.tabFirmwareBinary.Padding = new System.Windows.Forms.Padding(3);
            this.tabFirmwareBinary.Size = new System.Drawing.Size(778, 459);
            this.tabFirmwareBinary.TabIndex = 1;
            this.tabFirmwareBinary.Text = "Make Binary";
            this.tabFirmwareBinary.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(435, 260);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 12);
            this.label23.TabIndex = 40;
            this.label23.Text = "Display Format: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Location = new System.Drawing.Point(19, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(402, 201);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.76101F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.23899F));
            this.tableLayoutPanel5.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbSectionCRC1, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.cbSectionCRC2, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.btnCalcultaeCrc32, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbBinaryPadding, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.panelMakePadding, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(396, 181);
            this.tableLayoutPanel5.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nResultCrc32);
            this.panel1.Controls.Add(this.nEndOffsetCrc32);
            this.panel1.Controls.Add(this.nStartOffsetCrc32);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(128, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 64);
            this.panel1.TabIndex = 36;
            // 
            // nResultCrc32
            // 
            this.nResultCrc32.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nResultCrc32.Hexadecimal = true;
            this.nResultCrc32.Location = new System.Drawing.Point(66, 35);
            this.nResultCrc32.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nResultCrc32.Name = "nResultCrc32";
            this.nResultCrc32.ReadOnly = true;
            this.nResultCrc32.Size = new System.Drawing.Size(120, 21);
            this.nResultCrc32.TabIndex = 40;
            this.nResultCrc32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nEndOffsetCrc32
            // 
            this.nEndOffsetCrc32.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nEndOffsetCrc32.Location = new System.Drawing.Point(160, 7);
            this.nEndOffsetCrc32.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nEndOffsetCrc32.Name = "nEndOffsetCrc32";
            this.nEndOffsetCrc32.Size = new System.Drawing.Size(71, 21);
            this.nEndOffsetCrc32.TabIndex = 40;
            this.nEndOffsetCrc32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nEndOffsetCrc32.ThousandsSeparator = true;
            // 
            // nStartOffsetCrc32
            // 
            this.nStartOffsetCrc32.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nStartOffsetCrc32.Location = new System.Drawing.Point(66, 7);
            this.nStartOffsetCrc32.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nStartOffsetCrc32.Name = "nStartOffsetCrc32";
            this.nStartOffsetCrc32.Size = new System.Drawing.Size(71, 21);
            this.nStartOffsetCrc32.TabIndex = 40;
            this.nStartOffsetCrc32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nStartOffsetCrc32.ThousandsSeparator = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 12);
            this.label19.TabIndex = 37;
            this.label19.Text = "Result: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 12);
            this.label18.TabIndex = 37;
            this.label18.Text = "Range: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(143, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 37;
            this.label17.Text = "-";
            // 
            // cbSectionCRC1
            // 
            this.cbSectionCRC1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSectionCRC1.AutoSize = true;
            this.cbSectionCRC1.Location = new System.Drawing.Point(3, 117);
            this.cbSectionCRC1.Name = "cbSectionCRC1";
            this.cbSectionCRC1.Size = new System.Drawing.Size(92, 16);
            this.cbSectionCRC1.TabIndex = 16;
            this.cbSectionCRC1.Text = "Set CRC (1)";
            this.cbSectionCRC1.UseVisualStyleBackColor = true;
            // 
            // cbSectionCRC2
            // 
            this.cbSectionCRC2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSectionCRC2.AutoSize = true;
            this.cbSectionCRC2.Location = new System.Drawing.Point(3, 154);
            this.cbSectionCRC2.Name = "cbSectionCRC2";
            this.cbSectionCRC2.Size = new System.Drawing.Size(92, 16);
            this.cbSectionCRC2.TabIndex = 16;
            this.cbSectionCRC2.Text = "Set CRC (2)";
            this.cbSectionCRC2.UseVisualStyleBackColor = true;
            // 
            // btnCalcultaeCrc32
            // 
            this.btnCalcultaeCrc32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalcultaeCrc32.Location = new System.Drawing.Point(3, 3);
            this.btnCalcultaeCrc32.Name = "btnCalcultaeCrc32";
            this.btnCalcultaeCrc32.Size = new System.Drawing.Size(119, 64);
            this.btnCalcultaeCrc32.TabIndex = 35;
            this.btnCalcultaeCrc32.Text = "CRC32";
            this.btnCalcultaeCrc32.UseVisualStyleBackColor = true;
            this.btnCalcultaeCrc32.Click += new System.EventHandler(this.btnCalcultaeCrc32_Click);
            // 
            // cbBinaryPadding
            // 
            this.cbBinaryPadding.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbBinaryPadding.AutoSize = true;
            this.cbBinaryPadding.Enabled = false;
            this.cbBinaryPadding.Location = new System.Drawing.Point(3, 80);
            this.cbBinaryPadding.Name = "cbBinaryPadding";
            this.cbBinaryPadding.Size = new System.Drawing.Size(70, 16);
            this.cbBinaryPadding.TabIndex = 16;
            this.cbBinaryPadding.Text = "Padding";
            this.cbBinaryPadding.UseVisualStyleBackColor = true;
            this.cbBinaryPadding.CheckedChanged += new System.EventHandler(this.cbBinaryPadding_CheckedChanged);
            // 
            // panelMakePadding
            // 
            this.panelMakePadding.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelMakePadding.Controls.Add(this.label13);
            this.panelMakePadding.Controls.Add(this.textBox1);
            this.panelMakePadding.Controls.Add(this.label15);
            this.panelMakePadding.Controls.Add(this.numericUpDown1);
            this.panelMakePadding.Enabled = false;
            this.panelMakePadding.Location = new System.Drawing.Point(128, 73);
            this.panelMakePadding.Name = "panelMakePadding";
            this.panelMakePadding.Size = new System.Drawing.Size(265, 30);
            this.panelMakePadding.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "Padding";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(60, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 21);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(128, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 12);
            this.label15.TabIndex = 27;
            this.label15.Text = "Count";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown1.Location = new System.Drawing.Point(172, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 21);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSectionCRC1Value);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(128, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 31);
            this.panel2.TabIndex = 40;
            // 
            // txtSectionCRC1Value
            // 
            this.txtSectionCRC1Value.Location = new System.Drawing.Point(42, 4);
            this.txtSectionCRC1Value.Name = "txtSectionCRC1Value";
            this.txtSectionCRC1Value.Size = new System.Drawing.Size(100, 21);
            this.txtSectionCRC1Value.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 12);
            this.label14.TabIndex = 40;
            this.label14.Text = "CRC";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSectionCRC2Value);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(128, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 31);
            this.panel3.TabIndex = 41;
            // 
            // txtSectionCRC2Value
            // 
            this.txtSectionCRC2Value.Location = new System.Drawing.Point(42, 4);
            this.txtSectionCRC2Value.Name = "txtSectionCRC2Value";
            this.txtSectionCRC2Value.Size = new System.Drawing.Size(100, 21);
            this.txtSectionCRC2Value.TabIndex = 42;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 12);
            this.label21.TabIndex = 40;
            this.label21.Text = "CRC";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(420, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 12);
            this.label16.TabIndex = 23;
            this.label16.Text = "Selected Size";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nMakeBinarySize);
            this.groupBox1.Controls.Add(this.nMakeBinaryFill);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtBinaryNamePrefix);
            this.groupBox1.Controls.Add(this.btnMakeBinary);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbBinarySizeEnable);
            this.groupBox1.Location = new System.Drawing.Point(427, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 147);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Binary";
            // 
            // nMakeBinarySize
            // 
            this.nMakeBinarySize.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nMakeBinarySize.Enabled = false;
            this.nMakeBinarySize.Location = new System.Drawing.Point(92, 29);
            this.nMakeBinarySize.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nMakeBinarySize.Name = "nMakeBinarySize";
            this.nMakeBinarySize.Size = new System.Drawing.Size(119, 21);
            this.nMakeBinarySize.TabIndex = 40;
            this.nMakeBinarySize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nMakeBinarySize.ThousandsSeparator = true;
            // 
            // nMakeBinaryFill
            // 
            this.nMakeBinaryFill.Hexadecimal = true;
            this.nMakeBinaryFill.Location = new System.Drawing.Point(92, 57);
            this.nMakeBinaryFill.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nMakeBinaryFill.Name = "nMakeBinaryFill";
            this.nMakeBinaryFill.Size = new System.Drawing.Size(119, 21);
            this.nMakeBinaryFill.TabIndex = 40;
            this.nMakeBinaryFill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 12);
            this.label22.TabIndex = 29;
            this.label22.Text = "Fill";
            // 
            // txtBinaryNamePrefix
            // 
            this.txtBinaryNamePrefix.Location = new System.Drawing.Point(92, 85);
            this.txtBinaryNamePrefix.Name = "txtBinaryNamePrefix";
            this.txtBinaryNamePrefix.Size = new System.Drawing.Size(119, 21);
            this.txtBinaryNamePrefix.TabIndex = 18;
            // 
            // btnMakeBinary
            // 
            this.btnMakeBinary.Location = new System.Drawing.Point(18, 112);
            this.btnMakeBinary.Name = "btnMakeBinary";
            this.btnMakeBinary.Size = new System.Drawing.Size(193, 23);
            this.btnMakeBinary.TabIndex = 22;
            this.btnMakeBinary.Text = "Generate";
            this.btnMakeBinary.UseVisualStyleBackColor = true;
            this.btnMakeBinary.Click += new System.EventHandler(this.btnMakeBinary_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "File Name";
            // 
            // cbBinarySizeEnable
            // 
            this.cbBinarySizeEnable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbBinarySizeEnable.AutoSize = true;
            this.cbBinarySizeEnable.Location = new System.Drawing.Point(18, 30);
            this.cbBinarySizeEnable.Name = "cbBinarySizeEnable";
            this.cbBinarySizeEnable.Size = new System.Drawing.Size(74, 16);
            this.cbBinarySizeEnable.TabIndex = 16;
            this.cbBinarySizeEnable.Text = "Edit Size";
            this.cbBinarySizeEnable.UseVisualStyleBackColor = true;
            this.cbBinarySizeEnable.CheckedChanged += new System.EventHandler(this.cbBinarySizeEnable_CheckedChanged);
            // 
            // cbMakeFileSizeFormat
            // 
            this.cbMakeFileSizeFormat.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMakeFileSizeFormat.AutoSize = true;
            this.cbMakeFileSizeFormat.Location = new System.Drawing.Point(610, 12);
            this.cbMakeFileSizeFormat.Name = "cbMakeFileSizeFormat";
            this.cbMakeFileSizeFormat.Size = new System.Drawing.Size(47, 22);
            this.cbMakeFileSizeFormat.TabIndex = 32;
            this.cbMakeFileSizeFormat.Text = "BYTE";
            this.cbMakeFileSizeFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMakeFileSizeFormat.UseVisualStyleBackColor = true;
            this.cbMakeFileSizeFormat.CheckedChanged += new System.EventHandler(this.cbMakeFileSizeFormat_CheckedChanged);
            // 
            // cbDisplayFormat
            // 
            this.cbDisplayFormat.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbDisplayFormat.AutoSize = true;
            this.cbDisplayFormat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbDisplayFormat.Location = new System.Drawing.Point(539, 255);
            this.cbDisplayFormat.Name = "cbDisplayFormat";
            this.cbDisplayFormat.Size = new System.Drawing.Size(40, 22);
            this.cbDisplayFormat.TabIndex = 32;
            this.cbDisplayFormat.Text = "DEC";
            this.cbDisplayFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbDisplayFormat.UseVisualStyleBackColor = false;
            this.cbDisplayFormat.CheckedChanged += new System.EventHandler(this.cbDisplayFormat_CheckedChanged);
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
            this.colMakeVAddr,
            this.colMakePAddr,
            this.colMakeSize});
            this.dgvMakeBinary.Location = new System.Drawing.Point(19, 38);
            this.dgvMakeBinary.Name = "dgvMakeBinary";
            this.dgvMakeBinary.RowHeadersVisible = false;
            this.dgvMakeBinary.RowHeadersWidth = 51;
            this.dgvMakeBinary.RowTemplate.Height = 23;
            this.dgvMakeBinary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMakeBinary.Size = new System.Drawing.Size(638, 191);
            this.dgvMakeBinary.TabIndex = 14;
            this.dgvMakeBinary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMakeBinary_CellContentClick);
            this.dgvMakeBinary.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMakeBinary_CellValueChanged);
            // 
            // colMakeSelect
            // 
            this.colMakeSelect.HeaderText = "Sel";
            this.colMakeSelect.MinimumWidth = 6;
            this.colMakeSelect.Name = "colMakeSelect";
            this.colMakeSelect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMakeSelect.Width = 35;
            // 
            // colMakeName
            // 
            this.colMakeName.HeaderText = "Name";
            this.colMakeName.MinimumWidth = 6;
            this.colMakeName.Name = "colMakeName";
            this.colMakeName.ReadOnly = true;
            this.colMakeName.Width = 125;
            // 
            // colMakeOffset
            // 
            this.colMakeOffset.HeaderText = "Offset";
            this.colMakeOffset.MinimumWidth = 6;
            this.colMakeOffset.Name = "colMakeOffset";
            this.colMakeOffset.ReadOnly = true;
            this.colMakeOffset.Width = 125;
            // 
            // colMakeVAddr
            // 
            this.colMakeVAddr.HeaderText = "Virtual Address";
            this.colMakeVAddr.MinimumWidth = 6;
            this.colMakeVAddr.Name = "colMakeVAddr";
            this.colMakeVAddr.ReadOnly = true;
            this.colMakeVAddr.Width = 120;
            // 
            // colMakePAddr
            // 
            this.colMakePAddr.HeaderText = "Physical Address";
            this.colMakePAddr.MinimumWidth = 6;
            this.colMakePAddr.Name = "colMakePAddr";
            this.colMakePAddr.ReadOnly = true;
            this.colMakePAddr.Width = 120;
            // 
            // colMakeSize
            // 
            this.colMakeSize.HeaderText = "Size";
            this.colMakeSize.MinimumWidth = 6;
            this.colMakeSize.Name = "colMakeSize";
            this.colMakeSize.ReadOnly = true;
            this.colMakeSize.Width = 80;
            // 
            // txtMakeFileSize
            // 
            this.txtMakeFileSize.Location = new System.Drawing.Point(509, 12);
            this.txtMakeFileSize.Name = "txtMakeFileSize";
            this.txtMakeFileSize.ReadOnly = true;
            this.txtMakeFileSize.Size = new System.Drawing.Size(95, 21);
            this.txtMakeFileSize.TabIndex = 31;
            this.txtMakeFileSize.Text = "0";
            this.txtMakeFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabCompare
            // 
            this.tabCompare.Controls.Add(this.splitContainer1);
            this.tabCompare.Location = new System.Drawing.Point(4, 24);
            this.tabCompare.Name = "tabCompare";
            this.tabCompare.Size = new System.Drawing.Size(778, 459);
            this.tabCompare.TabIndex = 2;
            this.tabCompare.Text = "Compare";
            this.tabCompare.UseVisualStyleBackColor = true;
            // 
            // tabCombine
            // 
            this.tabCombine.Controls.Add(this.groupBox3);
            this.tabCombine.Controls.Add(this.tableLayoutPanel6);
            this.tabCombine.Location = new System.Drawing.Point(4, 24);
            this.tabCombine.Name = "tabCombine";
            this.tabCombine.Padding = new System.Windows.Forms.Padding(3);
            this.tabCombine.Size = new System.Drawing.Size(778, 459);
            this.tabCombine.TabIndex = 4;
            this.tabCombine.Text = "Combine";
            this.tabCombine.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbOverrideCombineBin);
            this.groupBox3.Controls.Add(this.cbCombineAddParameter);
            this.groupBox3.Controls.Add(this.cbOverrideBinary);
            this.groupBox3.Controls.Add(this.nMakeCombineBinaryFill);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtCombineBinarySize);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtCombineBinaryNamePrefix);
            this.groupBox3.Controls.Add(this.btnMakeCombineBinary);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(15, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 166);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generate Binary";
            // 
            // gbOverrideCombineBin
            // 
            this.gbOverrideCombineBin.Controls.Add(this.label24);
            this.gbOverrideCombineBin.Controls.Add(this.label20);
            this.gbOverrideCombineBin.Controls.Add(this.txtOverrideOffset);
            this.gbOverrideCombineBin.Controls.Add(this.txtOverrideBinary);
            this.gbOverrideCombineBin.Enabled = false;
            this.gbOverrideCombineBin.Location = new System.Drawing.Point(256, 33);
            this.gbOverrideCombineBin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOverrideCombineBin.Name = "gbOverrideCombineBin";
            this.gbOverrideCombineBin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOverrideCombineBin.Size = new System.Drawing.Size(192, 80);
            this.gbOverrideCombineBin.TabIndex = 42;
            this.gbOverrideCombineBin.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 49);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 19;
            this.label24.Text = "Binary";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 12);
            this.label20.TabIndex = 19;
            this.label20.Text = "Offset";
            // 
            // txtOverrideOffset
            // 
            this.txtOverrideOffset.Enabled = false;
            this.txtOverrideOffset.Location = new System.Drawing.Point(60, 20);
            this.txtOverrideOffset.Name = "txtOverrideOffset";
            this.txtOverrideOffset.Size = new System.Drawing.Size(119, 21);
            this.txtOverrideOffset.TabIndex = 18;
            // 
            // txtOverrideBinary
            // 
            this.txtOverrideBinary.Enabled = false;
            this.txtOverrideBinary.Location = new System.Drawing.Point(60, 46);
            this.txtOverrideBinary.Name = "txtOverrideBinary";
            this.txtOverrideBinary.Size = new System.Drawing.Size(119, 21);
            this.txtOverrideBinary.TabIndex = 18;
            // 
            // cbCombineAddParameter
            // 
            this.cbCombineAddParameter.AutoSize = true;
            this.cbCombineAddParameter.Location = new System.Drawing.Point(18, 131);
            this.cbCombineAddParameter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCombineAddParameter.Name = "cbCombineAddParameter";
            this.cbCombineAddParameter.Size = new System.Drawing.Size(108, 16);
            this.cbCombineAddParameter.TabIndex = 41;
            this.cbCombineAddParameter.Text = "Add Parameter";
            this.cbCombineAddParameter.UseVisualStyleBackColor = true;
            this.cbCombineAddParameter.CheckedChanged += new System.EventHandler(this.cbOverrideBinary_CheckedChanged);
            // 
            // cbOverrideBinary
            // 
            this.cbOverrideBinary.AutoSize = true;
            this.cbOverrideBinary.Location = new System.Drawing.Point(256, 19);
            this.cbOverrideBinary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOverrideBinary.Name = "cbOverrideBinary";
            this.cbOverrideBinary.Size = new System.Drawing.Size(109, 16);
            this.cbOverrideBinary.TabIndex = 41;
            this.cbOverrideBinary.Text = "Override (HEX)";
            this.cbOverrideBinary.UseVisualStyleBackColor = true;
            this.cbOverrideBinary.CheckedChanged += new System.EventHandler(this.cbOverrideBinary_CheckedChanged);
            // 
            // nMakeCombineBinaryFill
            // 
            this.nMakeCombineBinaryFill.Hexadecimal = true;
            this.nMakeCombineBinaryFill.Location = new System.Drawing.Point(92, 59);
            this.nMakeCombineBinaryFill.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nMakeCombineBinaryFill.Name = "nMakeCombineBinaryFill";
            this.nMakeCombineBinaryFill.Size = new System.Drawing.Size(118, 21);
            this.nMakeCombineBinaryFill.TabIndex = 40;
            this.nMakeCombineBinaryFill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "Size";
            // 
            // txtCombineBinarySize
            // 
            this.txtCombineBinarySize.Location = new System.Drawing.Point(92, 28);
            this.txtCombineBinarySize.Name = "txtCombineBinarySize";
            this.txtCombineBinarySize.ReadOnly = true;
            this.txtCombineBinarySize.Size = new System.Drawing.Size(119, 21);
            this.txtCombineBinarySize.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "Fill";
            // 
            // txtCombineBinaryNamePrefix
            // 
            this.txtCombineBinaryNamePrefix.Location = new System.Drawing.Point(92, 90);
            this.txtCombineBinaryNamePrefix.Name = "txtCombineBinaryNamePrefix";
            this.txtCombineBinaryNamePrefix.Size = new System.Drawing.Size(119, 21);
            this.txtCombineBinaryNamePrefix.TabIndex = 18;
            this.txtCombineBinaryNamePrefix.Text = "COMBINE";
            // 
            // btnMakeCombineBinary
            // 
            this.btnMakeCombineBinary.Location = new System.Drawing.Point(131, 127);
            this.btnMakeCombineBinary.Name = "btnMakeCombineBinary";
            this.btnMakeCombineBinary.Size = new System.Drawing.Size(317, 23);
            this.btnMakeCombineBinary.TabIndex = 22;
            this.btnMakeCombineBinary.Text = "Generate";
            this.btnMakeCombineBinary.UseVisualStyleBackColor = true;
            this.btnMakeCombineBinary.Click += new System.EventHandler(this.btnMakeCombineBinary_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "File Name";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.btnRemoveBinary, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.dgvCombineBinaries, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnAddBootloader, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnAddUserFirmware, 1, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(15, 17);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(741, 210);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // btnRemoveBinary
            // 
            this.btnRemoveBinary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveBinary.Location = new System.Drawing.Point(497, 184);
            this.btnRemoveBinary.Name = "btnRemoveBinary";
            this.btnRemoveBinary.Size = new System.Drawing.Size(241, 23);
            this.btnRemoveBinary.TabIndex = 40;
            this.btnRemoveBinary.Text = "Remove All Binaries";
            this.btnRemoveBinary.UseVisualStyleBackColor = true;
            this.btnRemoveBinary.Click += new System.EventHandler(this.btnRemoveBinary_Click);
            // 
            // dgvCombineBinaries
            // 
            this.dgvCombineBinaries.AllowUserToAddRows = false;
            this.dgvCombineBinaries.AllowUserToDeleteRows = false;
            this.dgvCombineBinaries.AllowUserToOrderColumns = true;
            this.dgvCombineBinaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCombineBinaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCombineBinaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOffset,
            this.colFileName,
            this.colSize,
            this.colBinPath});
            this.tableLayoutPanel6.SetColumnSpan(this.dgvCombineBinaries, 3);
            this.dgvCombineBinaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCombineBinaries.Location = new System.Drawing.Point(3, 3);
            this.dgvCombineBinaries.Name = "dgvCombineBinaries";
            this.dgvCombineBinaries.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCombineBinaries.RowHeadersVisible = false;
            this.dgvCombineBinaries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCombineBinaries.RowTemplate.Height = 23;
            this.dgvCombineBinaries.Size = new System.Drawing.Size(735, 175);
            this.dgvCombineBinaries.TabIndex = 1;
            // 
            // colOffset
            // 
            this.colOffset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colOffset.HeaderText = "Offset(Hex)";
            this.colOffset.MinimumWidth = 6;
            this.colOffset.Name = "colOffset";
            this.colOffset.Width = 94;
            // 
            // colFileName
            // 
            this.colFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFileName.HeaderText = "File Name";
            this.colFileName.MinimumWidth = 6;
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            this.colFileName.Width = 88;
            // 
            // colSize
            // 
            this.colSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSize.HeaderText = "Size(Dec)";
            this.colSize.MinimumWidth = 6;
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            this.colSize.Width = 87;
            // 
            // colBinPath
            // 
            this.colBinPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBinPath.HeaderText = "Path";
            this.colBinPath.MinimumWidth = 6;
            this.colBinPath.Name = "colBinPath";
            this.colBinPath.ReadOnly = true;
            this.colBinPath.Width = 55;
            // 
            // btnAddBootloader
            // 
            this.btnAddBootloader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBootloader.Location = new System.Drawing.Point(3, 184);
            this.btnAddBootloader.Name = "btnAddBootloader";
            this.btnAddBootloader.Size = new System.Drawing.Size(241, 23);
            this.btnAddBootloader.TabIndex = 3;
            this.btnAddBootloader.Text = "Add Bootloader";
            this.btnAddBootloader.UseVisualStyleBackColor = true;
            this.btnAddBootloader.Click += new System.EventHandler(this.BtnAddBootloader_Click);
            // 
            // btnAddUserFirmware
            // 
            this.btnAddUserFirmware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddUserFirmware.Location = new System.Drawing.Point(250, 183);
            this.btnAddUserFirmware.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUserFirmware.Name = "btnAddUserFirmware";
            this.btnAddUserFirmware.Size = new System.Drawing.Size(241, 25);
            this.btnAddUserFirmware.TabIndex = 41;
            this.btnAddUserFirmware.Text = "Add User Firmware";
            this.btnAddUserFirmware.UseVisualStyleBackColor = true;
            this.btnAddUserFirmware.Click += new System.EventHandler(this.btnAddUserFirmware_Click);
            // 
            // tabExtract
            // 
            this.tabExtract.Controls.Add(this.groupBox5);
            this.tabExtract.Controls.Add(this.groupBox4);
            this.tabExtract.Location = new System.Drawing.Point(4, 24);
            this.tabExtract.Name = "tabExtract";
            this.tabExtract.Padding = new System.Windows.Forms.Padding(3);
            this.tabExtract.Size = new System.Drawing.Size(778, 459);
            this.tabExtract.TabIndex = 5;
            this.tabExtract.Text = "ETC";
            this.tabExtract.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCalculateCrc32);
            this.groupBox5.Controls.Add(this.panel4);
            this.groupBox5.Controls.Add(this.lblEtcCrc32Result);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.txtEtcCrc32FirmwarePath);
            this.groupBox5.Controls.Add(this.btnEtcOpenCrc32Firmware);
            this.groupBox5.Controls.Add(this.btnEtcGenerateCrc32Firmware);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Location = new System.Drawing.Point(17, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(399, 213);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CRC32 Firmware";
            // 
            // btnCalculateCrc32
            // 
            this.btnCalculateCrc32.Location = new System.Drawing.Point(301, 75);
            this.btnCalculateCrc32.Name = "btnCalculateCrc32";
            this.btnCalculateCrc32.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateCrc32.TabIndex = 37;
            this.btnCalculateCrc32.Text = "Calculate";
            this.btnCalculateCrc32.UseVisualStyleBackColor = true;
            this.btnCalculateCrc32.Click += new System.EventHandler(this.btnCalculateCrc32_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCrc32TestResult);
            this.panel4.Controls.Add(this.nCrc32Size);
            this.panel4.Controls.Add(this.nCrc32StartOffset);
            this.panel4.Location = new System.Drawing.Point(103, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 59);
            this.panel4.TabIndex = 36;
            // 
            // lblCrc32TestResult
            // 
            this.lblCrc32TestResult.AutoSize = true;
            this.lblCrc32TestResult.Location = new System.Drawing.Point(85, 9);
            this.lblCrc32TestResult.Name = "lblCrc32TestResult";
            this.lblCrc32TestResult.Size = new System.Drawing.Size(24, 12);
            this.lblCrc32TestResult.TabIndex = 6;
            this.lblCrc32TestResult.Text = "0x0";
            // 
            // nCrc32Size
            // 
            this.nCrc32Size.Hexadecimal = true;
            this.nCrc32Size.Location = new System.Drawing.Point(3, 32);
            this.nCrc32Size.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nCrc32Size.Name = "nCrc32Size";
            this.nCrc32Size.Size = new System.Drawing.Size(63, 21);
            this.nCrc32Size.TabIndex = 7;
            this.nCrc32Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nCrc32StartOffset
            // 
            this.nCrc32StartOffset.Hexadecimal = true;
            this.nCrc32StartOffset.Location = new System.Drawing.Point(3, 5);
            this.nCrc32StartOffset.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nCrc32StartOffset.Name = "nCrc32StartOffset";
            this.nCrc32StartOffset.Size = new System.Drawing.Size(63, 21);
            this.nCrc32StartOffset.TabIndex = 7;
            this.nCrc32StartOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEtcCrc32Result
            // 
            this.lblEtcCrc32Result.AutoSize = true;
            this.lblEtcCrc32Result.Location = new System.Drawing.Point(101, 163);
            this.lblEtcCrc32Result.Name = "lblEtcCrc32Result";
            this.lblEtcCrc32Result.Size = new System.Drawing.Size(24, 12);
            this.lblEtcCrc32Result.TabIndex = 6;
            this.lblEtcCrc32Result.Text = "0x0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(18, 39);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 12);
            this.label28.TabIndex = 2;
            this.label28.Text = "Original File";
            // 
            // txtEtcCrc32FirmwarePath
            // 
            this.txtEtcCrc32FirmwarePath.Location = new System.Drawing.Point(103, 36);
            this.txtEtcCrc32FirmwarePath.Name = "txtEtcCrc32FirmwarePath";
            this.txtEtcCrc32FirmwarePath.ReadOnly = true;
            this.txtEtcCrc32FirmwarePath.Size = new System.Drawing.Size(191, 21);
            this.txtEtcCrc32FirmwarePath.TabIndex = 0;
            // 
            // btnEtcOpenCrc32Firmware
            // 
            this.btnEtcOpenCrc32Firmware.Location = new System.Drawing.Point(301, 34);
            this.btnEtcOpenCrc32Firmware.Name = "btnEtcOpenCrc32Firmware";
            this.btnEtcOpenCrc32Firmware.Size = new System.Drawing.Size(75, 23);
            this.btnEtcOpenCrc32Firmware.TabIndex = 1;
            this.btnEtcOpenCrc32Firmware.Text = "Open";
            this.btnEtcOpenCrc32Firmware.UseVisualStyleBackColor = true;
            this.btnEtcOpenCrc32Firmware.Click += new System.EventHandler(this.btnEtcOpenCrc32Firmware_Click);
            // 
            // btnEtcGenerateCrc32Firmware
            // 
            this.btnEtcGenerateCrc32Firmware.Location = new System.Drawing.Point(301, 160);
            this.btnEtcGenerateCrc32Firmware.Name = "btnEtcGenerateCrc32Firmware";
            this.btnEtcGenerateCrc32Firmware.Size = new System.Drawing.Size(75, 22);
            this.btnEtcGenerateCrc32Firmware.TabIndex = 5;
            this.btnEtcGenerateCrc32Firmware.Text = "Generate";
            this.btnEtcGenerateCrc32Firmware.UseVisualStyleBackColor = true;
            this.btnEtcGenerateCrc32Firmware.Click += new System.EventHandler(this.btnEtcGenerateCrc32Firmware_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 82);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 12);
            this.label30.TabIndex = 2;
            this.label30.Text = "CRC32 TEST";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 163);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 12);
            this.label29.TabIndex = 2;
            this.label29.Text = "CRC32";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.nEtcExtractStartAddr);
            this.groupBox4.Controls.Add(this.nEtcExtractLength);
            this.groupBox4.Controls.Add(this.txtEtcExtractFilePath);
            this.groupBox4.Controls.Add(this.cbEtcEtcExtractDisplayFormat);
            this.groupBox4.Controls.Add(this.btnEtcOpenExtractFile);
            this.groupBox4.Controls.Add(this.btnEtcExtractFile);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Location = new System.Drawing.Point(17, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 155);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extract Binary";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 39);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 12);
            this.label27.TabIndex = 2;
            this.label27.Text = "Original File";
            // 
            // nEtcExtractStartAddr
            // 
            this.nEtcExtractStartAddr.Location = new System.Drawing.Point(95, 80);
            this.nEtcExtractStartAddr.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nEtcExtractStartAddr.Name = "nEtcExtractStartAddr";
            this.nEtcExtractStartAddr.Size = new System.Drawing.Size(153, 21);
            this.nEtcExtractStartAddr.TabIndex = 34;
            this.nEtcExtractStartAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nEtcExtractLength
            // 
            this.nEtcExtractLength.Location = new System.Drawing.Point(95, 107);
            this.nEtcExtractLength.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nEtcExtractLength.Name = "nEtcExtractLength";
            this.nEtcExtractLength.Size = new System.Drawing.Size(153, 21);
            this.nEtcExtractLength.TabIndex = 34;
            this.nEtcExtractLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEtcExtractFilePath
            // 
            this.txtEtcExtractFilePath.Location = new System.Drawing.Point(95, 36);
            this.txtEtcExtractFilePath.Name = "txtEtcExtractFilePath";
            this.txtEtcExtractFilePath.ReadOnly = true;
            this.txtEtcExtractFilePath.Size = new System.Drawing.Size(199, 21);
            this.txtEtcExtractFilePath.TabIndex = 0;
            // 
            // cbEtcEtcExtractDisplayFormat
            // 
            this.cbEtcEtcExtractDisplayFormat.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbEtcEtcExtractDisplayFormat.AutoSize = true;
            this.cbEtcEtcExtractDisplayFormat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbEtcEtcExtractDisplayFormat.Location = new System.Drawing.Point(254, 80);
            this.cbEtcEtcExtractDisplayFormat.Name = "cbEtcEtcExtractDisplayFormat";
            this.cbEtcEtcExtractDisplayFormat.Size = new System.Drawing.Size(40, 22);
            this.cbEtcEtcExtractDisplayFormat.TabIndex = 33;
            this.cbEtcEtcExtractDisplayFormat.Text = "DEC";
            this.cbEtcEtcExtractDisplayFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbEtcEtcExtractDisplayFormat.UseVisualStyleBackColor = false;
            this.cbEtcEtcExtractDisplayFormat.CheckedChanged += new System.EventHandler(this.cbExtractDisplayFormat_CheckedChanged);
            // 
            // btnEtcOpenExtractFile
            // 
            this.btnEtcOpenExtractFile.Location = new System.Drawing.Point(301, 34);
            this.btnEtcOpenExtractFile.Name = "btnEtcOpenExtractFile";
            this.btnEtcOpenExtractFile.Size = new System.Drawing.Size(75, 23);
            this.btnEtcOpenExtractFile.TabIndex = 1;
            this.btnEtcOpenExtractFile.Text = "Open";
            this.btnEtcOpenExtractFile.UseVisualStyleBackColor = true;
            this.btnEtcOpenExtractFile.Click += new System.EventHandler(this.btnOpenExtractFile_Click);
            // 
            // btnEtcExtractFile
            // 
            this.btnEtcExtractFile.Location = new System.Drawing.Point(301, 80);
            this.btnEtcExtractFile.Name = "btnEtcExtractFile";
            this.btnEtcExtractFile.Size = new System.Drawing.Size(75, 46);
            this.btnEtcExtractFile.TabIndex = 5;
            this.btnEtcExtractFile.Text = "Generate";
            this.btnEtcExtractFile.UseVisualStyleBackColor = true;
            this.btnEtcExtractFile.Click += new System.EventHandler(this.btnExtractFile_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 83);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 12);
            this.label25.TabIndex = 2;
            this.label25.Text = "Start Addr";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 114);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 12);
            this.label26.TabIndex = 3;
            this.label26.Text = "Length";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressWork});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressWork
            // 
            this.progressWork.Name = "progressWork";
            this.progressWork.Size = new System.Drawing.Size(100, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 512);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabMainControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.nCompareStartAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCompareStopAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMismatchedNumber)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMainControl.ResumeLayout(false);
            this.tabELF.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nResultCrc32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEndOffsetCrc32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStartOffsetCrc32)).EndInit();
            this.panelMakePadding.ResumeLayout(false);
            this.panelMakePadding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMakeBinarySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMakeBinaryFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMakeBinary)).EndInit();
            this.tabCompare.ResumeLayout(false);
            this.tabCombine.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbOverrideCombineBin.ResumeLayout(false);
            this.gbOverrideCombineBin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMakeCombineBinaryFill)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombineBinaries)).EndInit();
            this.tabExtract.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCrc32Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCrc32StartOffset)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEtcExtractStartAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEtcExtractLength)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFirmwareBinPath;
        private System.Windows.Forms.Button btnOpenFirmware;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveUpdateArea;
        private System.Windows.Forms.Button btnCompareDatas;
        private System.Windows.Forms.TextBox txtReferencePath;
        private System.Windows.Forms.Button btnOpenReference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbShowDifference;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listMismatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSelectedIndex;
        private System.Windows.Forms.TextBox txtReferenceVal;
        private System.Windows.Forms.TextBox txtOriginalVal;
        private System.Windows.Forms.Label lblCompareOriginFile;
        private System.Windows.Forms.Label lblCompareRefFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel workPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtElfFilePath;
        private System.Windows.Forms.Button btnLoadELF;
        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabELF;
        private System.Windows.Forms.TabPage tabFirmwareBinary;
        private System.Windows.Forms.TabPage tabCompare;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressWork;
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
        private System.Windows.Forms.DataGridView dgvProgramHeader;
        private System.Windows.Forms.FlowLayoutPanel customCompareRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMakeBinary;
        private System.Windows.Forms.CheckBox cbBinaryPadding;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBinaryNamePrefix;
        private System.Windows.Forms.Button btnMakeBinary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbMakeFileSizeFormat;
        private System.Windows.Forms.TextBox txtMakeFileSize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCalcultaeCrc32;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox cbSectionCRC1;
        private System.Windows.Forms.CheckBox cbSectionCRC2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox cbBinarySizeEnable;
        private System.Windows.Forms.NumericUpDown nMakeBinaryFill;
        private System.Windows.Forms.NumericUpDown nMakeBinarySize;
        private System.Windows.Forms.NumericUpDown nEndOffsetCrc32;
        private System.Windows.Forms.NumericUpDown nStartOffsetCrc32;
        private System.Windows.Forms.CheckBox cbDisplayFormat;
        private System.Windows.Forms.FlowLayoutPanel panelMakePadding;
        private System.Windows.Forms.NumericUpDown nResultCrc32;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMakeSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMakeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMakeOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMakeVAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMakePAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMakeSize;
        private System.Windows.Forms.CheckBox cbCompareAddrFormat;
        private System.Windows.Forms.NumericUpDown nCompareStartAddr;
        private System.Windows.Forms.NumericUpDown nCompareStopAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionFlags;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramPhyAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramMemorySize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramFlags;
        private System.Windows.Forms.NumericUpDown nMismatchedNumber;
        private System.Windows.Forms.TabPage tabCombine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridView dgvCombineBinaries;
        private System.Windows.Forms.Button btnAddBootloader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBinPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nMakeCombineBinaryFill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCombineBinaryNamePrefix;
        private System.Windows.Forms.Button btnMakeCombineBinary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCombineBinarySize;
        private System.Windows.Forms.Button btnRemoveBinary;
        private System.Windows.Forms.TextBox txtSectionCRC1Value;
        private System.Windows.Forms.TextBox txtSectionCRC2Value;
        private System.Windows.Forms.Button btnAddUserFirmware;
        private System.Windows.Forms.CheckBox cbOverrideBinary;
        private System.Windows.Forms.TextBox txtOverrideOffset;
        private System.Windows.Forms.TextBox txtOverrideBinary;
        private System.Windows.Forms.GroupBox gbOverrideCombineBin;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabExtract;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnEtcOpenExtractFile;
        private System.Windows.Forms.TextBox txtEtcExtractFilePath;
        private System.Windows.Forms.Button btnEtcExtractFile;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox cbEtcEtcExtractDisplayFormat;
        private System.Windows.Forms.RichTextBox txtCompareResult;
        private System.Windows.Forms.RichTextBox txtCompareHeader;
        private System.Windows.Forms.NumericUpDown nEtcExtractLength;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nEtcExtractStartAddr;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtEtcCrc32FirmwarePath;
        private System.Windows.Forms.Button btnEtcOpenCrc32Firmware;
        private System.Windows.Forms.Button btnEtcGenerateCrc32Firmware;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblEtcCrc32Result;
        private System.Windows.Forms.CheckBox cbCombineAddParameter;
        private System.Windows.Forms.Label lblCrc32TestResult;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown nCrc32Size;
        private System.Windows.Forms.NumericUpDown nCrc32StartOffset;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCalculateCrc32;
    }
}

