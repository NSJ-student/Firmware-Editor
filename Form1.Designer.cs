
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFixedArea = new System.Windows.Forms.TextBox();
            this.workPanel = new System.Windows.Forms.Panel();
            this.progressCheckFixedArea = new System.Windows.Forms.ProgressBar();
            this.txtCompareResult = new System.Windows.Forms.RichTextBox();
            this.btnSaveUpdateArea = new System.Windows.Forms.Button();
            this.btnCheckFixedArea = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateArea = new System.Windows.Forms.TextBox();
            this.txtFirmwareBinPath = new System.Windows.Forms.TextBox();
            this.btnOpenFirmware = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReferencePath = new System.Windows.Forms.TextBox();
            this.btnOpenReference = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelCheck = new System.Windows.Forms.Button();
            this.cbShowDifference = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMismatchedNumber = new System.Windows.Forms.TextBox();
            this.workPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "0x";
            // 
            // txtFixedArea
            // 
            this.txtFixedArea.Location = new System.Drawing.Point(136, 12);
            this.txtFixedArea.Name = "txtFixedArea";
            this.txtFixedArea.Size = new System.Drawing.Size(73, 21);
            this.txtFixedArea.TabIndex = 1;
            this.txtFixedArea.Text = "0";
            this.txtFixedArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // workPanel
            // 
            this.workPanel.Controls.Add(this.txtMismatchedNumber);
            this.workPanel.Controls.Add(this.label7);
            this.workPanel.Controls.Add(this.cbShowDifference);
            this.workPanel.Controls.Add(this.btnCancelCheck);
            this.workPanel.Controls.Add(this.progressCheckFixedArea);
            this.workPanel.Controls.Add(this.txtCompareResult);
            this.workPanel.Controls.Add(this.btnSaveUpdateArea);
            this.workPanel.Controls.Add(this.btnCheckFixedArea);
            this.workPanel.Controls.Add(this.label4);
            this.workPanel.Controls.Add(this.label3);
            this.workPanel.Controls.Add(this.label5);
            this.workPanel.Controls.Add(this.label1);
            this.workPanel.Controls.Add(this.txtUpdateArea);
            this.workPanel.Controls.Add(this.txtFixedArea);
            this.workPanel.Enabled = false;
            this.workPanel.Location = new System.Drawing.Point(14, 81);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(596, 265);
            this.workPanel.TabIndex = 2;
            // 
            // progressCheckFixedArea
            // 
            this.progressCheckFixedArea.Location = new System.Drawing.Point(215, 11);
            this.progressCheckFixedArea.Name = "progressCheckFixedArea";
            this.progressCheckFixedArea.Size = new System.Drawing.Size(163, 23);
            this.progressCheckFixedArea.TabIndex = 6;
            // 
            // txtCompareResult
            // 
            this.txtCompareResult.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompareResult.Location = new System.Drawing.Point(18, 115);
            this.txtCompareResult.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCompareResult.Name = "txtCompareResult";
            this.txtCompareResult.ReadOnly = true;
            this.txtCompareResult.Size = new System.Drawing.Size(562, 136);
            this.txtCompareResult.TabIndex = 5;
            this.txtCompareResult.Text = "";
            this.txtCompareResult.WordWrap = false;
            // 
            // btnSaveUpdateArea
            // 
            this.btnSaveUpdateArea.Location = new System.Drawing.Point(384, 43);
            this.btnSaveUpdateArea.Name = "btnSaveUpdateArea";
            this.btnSaveUpdateArea.Size = new System.Drawing.Size(196, 25);
            this.btnSaveUpdateArea.TabIndex = 4;
            this.btnSaveUpdateArea.Text = "Save Update Area";
            this.btnSaveUpdateArea.UseVisualStyleBackColor = true;
            this.btnSaveUpdateArea.Click += new System.EventHandler(this.btnSaveUpdateArea_Click);
            // 
            // btnCheckFixedArea
            // 
            this.btnCheckFixedArea.Location = new System.Drawing.Point(384, 9);
            this.btnCheckFixedArea.Name = "btnCheckFixedArea";
            this.btnCheckFixedArea.Size = new System.Drawing.Size(119, 25);
            this.btnCheckFixedArea.TabIndex = 4;
            this.btnCheckFixedArea.Text = "Check Fixed Area";
            this.btnCheckFixedArea.UseVisualStyleBackColor = true;
            this.btnCheckFixedArea.Click += new System.EventHandler(this.btnCheckFixedArea_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Update Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fixed Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "0x";
            // 
            // txtUpdateArea
            // 
            this.txtUpdateArea.Location = new System.Drawing.Point(136, 46);
            this.txtUpdateArea.Name = "txtUpdateArea";
            this.txtUpdateArea.Size = new System.Drawing.Size(73, 21);
            this.txtUpdateArea.TabIndex = 1;
            this.txtUpdateArea.Text = "20000";
            this.txtUpdateArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirmwareBinPath
            // 
            this.txtFirmwareBinPath.Location = new System.Drawing.Point(150, 12);
            this.txtFirmwareBinPath.Name = "txtFirmwareBinPath";
            this.txtFirmwareBinPath.ReadOnly = true;
            this.txtFirmwareBinPath.Size = new System.Drawing.Size(379, 21);
            this.txtFirmwareBinPath.TabIndex = 3;
            // 
            // btnOpenFirmware
            // 
            this.btnOpenFirmware.Location = new System.Drawing.Point(535, 10);
            this.btnOpenFirmware.Name = "btnOpenFirmware";
            this.btnOpenFirmware.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFirmware.TabIndex = 4;
            this.btnOpenFirmware.Text = "OPEN";
            this.btnOpenFirmware.UseVisualStyleBackColor = true;
            this.btnOpenFirmware.Click += new System.EventHandler(this.btnOpenFirmware_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Open Firmware Binary";
            // 
            // txtReferencePath
            // 
            this.txtReferencePath.Location = new System.Drawing.Point(150, 44);
            this.txtReferencePath.Name = "txtReferencePath";
            this.txtReferencePath.ReadOnly = true;
            this.txtReferencePath.Size = new System.Drawing.Size(379, 21);
            this.txtReferencePath.TabIndex = 3;
            // 
            // btnOpenReference
            // 
            this.btnOpenReference.Location = new System.Drawing.Point(535, 42);
            this.btnOpenReference.Name = "btnOpenReference";
            this.btnOpenReference.Size = new System.Drawing.Size(75, 23);
            this.btnOpenReference.TabIndex = 4;
            this.btnOpenReference.Text = "OPEN";
            this.btnOpenReference.UseVisualStyleBackColor = true;
            this.btnOpenReference.Click += new System.EventHandler(this.btnOpenReference_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Refence Binary";
            // 
            // btnCancelCheck
            // 
            this.btnCancelCheck.Location = new System.Drawing.Point(509, 9);
            this.btnCancelCheck.Name = "btnCancelCheck";
            this.btnCancelCheck.Size = new System.Drawing.Size(71, 25);
            this.btnCancelCheck.TabIndex = 7;
            this.btnCancelCheck.Text = "Cancel";
            this.btnCancelCheck.UseVisualStyleBackColor = true;
            this.btnCancelCheck.Click += new System.EventHandler(this.btnCancelCheck_Click);
            // 
            // cbShowDifference
            // 
            this.cbShowDifference.AutoSize = true;
            this.cbShowDifference.Checked = true;
            this.cbShowDifference.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowDifference.Location = new System.Drawing.Point(525, 87);
            this.cbShowDifference.Name = "cbShowDifference";
            this.cbShowDifference.Size = new System.Drawing.Size(55, 16);
            this.cbShowDifference.TabIndex = 8;
            this.cbShowDifference.Text = "show";
            this.cbShowDifference.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mismatched Number: ";
            // 
            // txtMismatchedNumber
            // 
            this.txtMismatchedNumber.Location = new System.Drawing.Point(156, 85);
            this.txtMismatchedNumber.Name = "txtMismatchedNumber";
            this.txtMismatchedNumber.ReadOnly = true;
            this.txtMismatchedNumber.Size = new System.Drawing.Size(100, 21);
            this.txtMismatchedNumber.TabIndex = 10;
            this.txtMismatchedNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 358);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOpenReference);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReferencePath);
            this.Controls.Add(this.btnOpenFirmware);
            this.Controls.Add(this.txtFirmwareBinPath);
            this.Controls.Add(this.workPanel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Edit Firmware Binary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.workPanel.ResumeLayout(false);
            this.workPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFixedArea;
        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.TextBox txtFirmwareBinPath;
        private System.Windows.Forms.Button btnOpenFirmware;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateArea;
        private System.Windows.Forms.Button btnSaveUpdateArea;
        private System.Windows.Forms.Button btnCheckFixedArea;
        private System.Windows.Forms.TextBox txtReferencePath;
        private System.Windows.Forms.Button btnOpenReference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtCompareResult;
        private System.Windows.Forms.ProgressBar progressCheckFixedArea;
        private System.Windows.Forms.Button btnCancelCheck;
        private System.Windows.Forms.CheckBox cbShowDifference;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMismatchedNumber;
    }
}

