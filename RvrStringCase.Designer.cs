
namespace ExtraAssignment
{
    partial class RvrStringCase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RvrStringCase));
            this.txbxResultRvsSqcNCase = new System.Windows.Forms.TextBox();
            this.txbxUserInpuRvsSqcNCase = new System.Windows.Forms.TextBox();
            this.btnShowResultRvsSqcNCase = new System.Windows.Forms.Button();
            this.lblUserInputRvsSqcNCase = new System.Windows.Forms.Label();
            this.lblQRvsSqcNCase = new System.Windows.Forms.Label();
            this.lblCurrentQRvsSqcNCase = new System.Windows.Forms.Label();
            this.cmbxSelectFunctionRvsSqcNCase = new System.Windows.Forms.ComboBox();
            this.lblGoToRvsSqcNCase = new System.Windows.Forms.Label();
            this.linklblExitProgramRvsSqcNCase = new System.Windows.Forms.LinkLabel();
            this.linklblMainPageRvsSqcNCase = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txbxResultRvsSqcNCase
            // 
            this.txbxResultRvsSqcNCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbxResultRvsSqcNCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxResultRvsSqcNCase.Location = new System.Drawing.Point(326, 163);
            this.txbxResultRvsSqcNCase.Multiline = true;
            this.txbxResultRvsSqcNCase.Name = "txbxResultRvsSqcNCase";
            this.txbxResultRvsSqcNCase.ReadOnly = true;
            this.txbxResultRvsSqcNCase.Size = new System.Drawing.Size(216, 130);
            this.txbxResultRvsSqcNCase.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txbxResultRvsSqcNCase, "click button \"Reverse\" to see the result");
            // 
            // txbxUserInpuRvsSqcNCase
            // 
            this.txbxUserInpuRvsSqcNCase.Location = new System.Drawing.Point(326, 90);
            this.txbxUserInpuRvsSqcNCase.Name = "txbxUserInpuRvsSqcNCase";
            this.txbxUserInpuRvsSqcNCase.Size = new System.Drawing.Size(200, 20);
            this.txbxUserInpuRvsSqcNCase.TabIndex = 1;
            this.txbxUserInpuRvsSqcNCase.TextChanged += new System.EventHandler(this.txbxUserInpuRvsSqcNCase_TextChanged);
            // 
            // btnShowResultRvsSqcNCase
            // 
            this.btnShowResultRvsSqcNCase.Location = new System.Drawing.Point(326, 125);
            this.btnShowResultRvsSqcNCase.Name = "btnShowResultRvsSqcNCase";
            this.btnShowResultRvsSqcNCase.Size = new System.Drawing.Size(74, 23);
            this.btnShowResultRvsSqcNCase.TabIndex = 2;
            this.btnShowResultRvsSqcNCase.Text = "Reverse";
            this.btnShowResultRvsSqcNCase.UseVisualStyleBackColor = true;
            this.btnShowResultRvsSqcNCase.Click += new System.EventHandler(this.btnShowResultRvsSqcNCase_Click);
            // 
            // lblUserInputRvsSqcNCase
            // 
            this.lblUserInputRvsSqcNCase.AutoSize = true;
            this.lblUserInputRvsSqcNCase.Location = new System.Drawing.Point(323, 68);
            this.lblUserInputRvsSqcNCase.Name = "lblUserInputRvsSqcNCase";
            this.lblUserInputRvsSqcNCase.Size = new System.Drawing.Size(112, 13);
            this.lblUserInputRvsSqcNCase.TabIndex = 8;
            this.lblUserInputRvsSqcNCase.Text = "Please enter the string";
            // 
            // lblQRvsSqcNCase
            // 
            this.lblQRvsSqcNCase.AutoEllipsis = true;
            this.lblQRvsSqcNCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblQRvsSqcNCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQRvsSqcNCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQRvsSqcNCase.Location = new System.Drawing.Point(26, 90);
            this.lblQRvsSqcNCase.Name = "lblQRvsSqcNCase";
            this.lblQRvsSqcNCase.Size = new System.Drawing.Size(265, 203);
            this.lblQRvsSqcNCase.TabIndex = 7;
            this.lblQRvsSqcNCase.Text = resources.GetString("lblQRvsSqcNCase.Text");
            // 
            // lblCurrentQRvsSqcNCase
            // 
            this.lblCurrentQRvsSqcNCase.AutoSize = true;
            this.lblCurrentQRvsSqcNCase.Location = new System.Drawing.Point(23, 68);
            this.lblCurrentQRvsSqcNCase.Name = "lblCurrentQRvsSqcNCase";
            this.lblCurrentQRvsSqcNCase.Size = new System.Drawing.Size(86, 13);
            this.lblCurrentQRvsSqcNCase.TabIndex = 6;
            this.lblCurrentQRvsSqcNCase.Text = "Current Question";
            // 
            // cmbxSelectFunctionRvsSqcNCase
            // 
            this.cmbxSelectFunctionRvsSqcNCase.FormattingEnabled = true;
            this.cmbxSelectFunctionRvsSqcNCase.ItemHeight = 13;
            this.cmbxSelectFunctionRvsSqcNCase.Location = new System.Drawing.Point(146, 23);
            this.cmbxSelectFunctionRvsSqcNCase.Name = "cmbxSelectFunctionRvsSqcNCase";
            this.cmbxSelectFunctionRvsSqcNCase.Size = new System.Drawing.Size(310, 21);
            this.cmbxSelectFunctionRvsSqcNCase.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbxSelectFunctionRvsSqcNCase, "Explore other functions");
            this.cmbxSelectFunctionRvsSqcNCase.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectFunctionRvsSqcNCase_SelectedIndexChanged);
            // 
            // lblGoToRvsSqcNCase
            // 
            this.lblGoToRvsSqcNCase.AutoSize = true;
            this.lblGoToRvsSqcNCase.Location = new System.Drawing.Point(100, 26);
            this.lblGoToRvsSqcNCase.Name = "lblGoToRvsSqcNCase";
            this.lblGoToRvsSqcNCase.Size = new System.Drawing.Size(40, 13);
            this.lblGoToRvsSqcNCase.TabIndex = 10;
            this.lblGoToRvsSqcNCase.Text = "Go To:";
            this.toolTip1.SetToolTip(this.lblGoToRvsSqcNCase, "Explore other functions");
            // 
            // linklblExitProgramRvsSqcNCase
            // 
            this.linklblExitProgramRvsSqcNCase.AutoSize = true;
            this.linklblExitProgramRvsSqcNCase.Location = new System.Drawing.Point(476, 26);
            this.linklblExitProgramRvsSqcNCase.Name = "linklblExitProgramRvsSqcNCase";
            this.linklblExitProgramRvsSqcNCase.Size = new System.Drawing.Size(66, 13);
            this.linklblExitProgramRvsSqcNCase.TabIndex = 5;
            this.linklblExitProgramRvsSqcNCase.TabStop = true;
            this.linklblExitProgramRvsSqcNCase.Text = "Exit Program";
            this.toolTip1.SetToolTip(this.linklblExitProgramRvsSqcNCase, "Exit");
            this.linklblExitProgramRvsSqcNCase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblExitProgramRvsSqcNCase_LinkClicked);
            // 
            // linklblMainPageRvsSqcNCase
            // 
            this.linklblMainPageRvsSqcNCase.AutoSize = true;
            this.linklblMainPageRvsSqcNCase.Location = new System.Drawing.Point(23, 26);
            this.linklblMainPageRvsSqcNCase.Name = "linklblMainPageRvsSqcNCase";
            this.linklblMainPageRvsSqcNCase.Size = new System.Drawing.Size(58, 13);
            this.linklblMainPageRvsSqcNCase.TabIndex = 4;
            this.linklblMainPageRvsSqcNCase.TabStop = true;
            this.linklblMainPageRvsSqcNCase.Text = "Main Page";
            this.toolTip1.SetToolTip(this.linklblMainPageRvsSqcNCase, "Go to Main page");
            this.linklblMainPageRvsSqcNCase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblMainPageRvsSqcNCase_LinkClicked);
            // 
            // RvrStringCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 331);
            this.Controls.Add(this.txbxResultRvsSqcNCase);
            this.Controls.Add(this.txbxUserInpuRvsSqcNCase);
            this.Controls.Add(this.btnShowResultRvsSqcNCase);
            this.Controls.Add(this.lblUserInputRvsSqcNCase);
            this.Controls.Add(this.lblQRvsSqcNCase);
            this.Controls.Add(this.lblCurrentQRvsSqcNCase);
            this.Controls.Add(this.cmbxSelectFunctionRvsSqcNCase);
            this.Controls.Add(this.lblGoToRvsSqcNCase);
            this.Controls.Add(this.linklblExitProgramRvsSqcNCase);
            this.Controls.Add(this.linklblMainPageRvsSqcNCase);
            this.Name = "RvrStringCase";
            this.Text = "RvrStringCase";
            this.Load += new System.EventHandler(this.RvrStringCase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxResultRvsSqcNCase;
        private System.Windows.Forms.TextBox txbxUserInpuRvsSqcNCase;
        private System.Windows.Forms.Button btnShowResultRvsSqcNCase;
        private System.Windows.Forms.Label lblUserInputRvsSqcNCase;
        private System.Windows.Forms.Label lblQRvsSqcNCase;
        private System.Windows.Forms.Label lblCurrentQRvsSqcNCase;
        private System.Windows.Forms.ComboBox cmbxSelectFunctionRvsSqcNCase;
        private System.Windows.Forms.Label lblGoToRvsSqcNCase;
        private System.Windows.Forms.LinkLabel linklblExitProgramRvsSqcNCase;
        private System.Windows.Forms.LinkLabel linklblMainPageRvsSqcNCase;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}