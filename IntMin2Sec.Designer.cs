
namespace ExtraAssignment
{
    partial class IntMin2Sec
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
            this.linklblMainPageMn2Sc = new System.Windows.Forms.LinkLabel();
            this.linklblExitProgramMn2Sc = new System.Windows.Forms.LinkLabel();
            this.lblGoToMn2Sc = new System.Windows.Forms.Label();
            this.cmbxSelectFunctionMn2Sc = new System.Windows.Forms.ComboBox();
            this.lblCurrentQMn2Sc = new System.Windows.Forms.Label();
            this.lblQMn2Sc = new System.Windows.Forms.Label();
            this.lblUserInputMn2Sc = new System.Windows.Forms.Label();
            this.btnShowResultMn2Sc = new System.Windows.Forms.Button();
            this.txbxUserInputMn2Sc = new System.Windows.Forms.TextBox();
            this.txbxResultMn2Sc = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // linklblMainPageMn2Sc
            // 
            this.linklblMainPageMn2Sc.AutoSize = true;
            this.linklblMainPageMn2Sc.Location = new System.Drawing.Point(26, 31);
            this.linklblMainPageMn2Sc.Name = "linklblMainPageMn2Sc";
            this.linklblMainPageMn2Sc.Size = new System.Drawing.Size(58, 13);
            this.linklblMainPageMn2Sc.TabIndex = 4;
            this.linklblMainPageMn2Sc.TabStop = true;
            this.linklblMainPageMn2Sc.Text = "Main Page";
            this.toolTip1.SetToolTip(this.linklblMainPageMn2Sc, "Go to Main page");
            this.linklblMainPageMn2Sc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblMainPageMn2Sc_LinkClicked);
            // 
            // linklblExitProgramMn2Sc
            // 
            this.linklblExitProgramMn2Sc.AutoSize = true;
            this.linklblExitProgramMn2Sc.Location = new System.Drawing.Point(479, 31);
            this.linklblExitProgramMn2Sc.Name = "linklblExitProgramMn2Sc";
            this.linklblExitProgramMn2Sc.Size = new System.Drawing.Size(66, 13);
            this.linklblExitProgramMn2Sc.TabIndex = 5;
            this.linklblExitProgramMn2Sc.TabStop = true;
            this.linklblExitProgramMn2Sc.Text = "Exit Program";
            this.toolTip1.SetToolTip(this.linklblExitProgramMn2Sc, "Exit");
            this.linklblExitProgramMn2Sc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblExitProgramMn2Sc_LinkClicked);
            // 
            // lblGoToMn2Sc
            // 
            this.lblGoToMn2Sc.AutoSize = true;
            this.lblGoToMn2Sc.Location = new System.Drawing.Point(103, 31);
            this.lblGoToMn2Sc.Name = "lblGoToMn2Sc";
            this.lblGoToMn2Sc.Size = new System.Drawing.Size(40, 13);
            this.lblGoToMn2Sc.TabIndex = 6;
            this.lblGoToMn2Sc.Text = "Go To:";
            this.toolTip1.SetToolTip(this.lblGoToMn2Sc, "Explore other functions");
            // 
            // cmbxSelectFunctionMn2Sc
            // 
            this.cmbxSelectFunctionMn2Sc.FormattingEnabled = true;
            this.cmbxSelectFunctionMn2Sc.Location = new System.Drawing.Point(149, 28);
            this.cmbxSelectFunctionMn2Sc.Name = "cmbxSelectFunctionMn2Sc";
            this.cmbxSelectFunctionMn2Sc.Size = new System.Drawing.Size(310, 21);
            this.cmbxSelectFunctionMn2Sc.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbxSelectFunctionMn2Sc, "Explore other functions");
            this.cmbxSelectFunctionMn2Sc.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectFunctionMn2Sc_SelectedIndexChanged);
            // 
            // lblCurrentQMn2Sc
            // 
            this.lblCurrentQMn2Sc.AutoSize = true;
            this.lblCurrentQMn2Sc.Location = new System.Drawing.Point(26, 73);
            this.lblCurrentQMn2Sc.Name = "lblCurrentQMn2Sc";
            this.lblCurrentQMn2Sc.Size = new System.Drawing.Size(86, 13);
            this.lblCurrentQMn2Sc.TabIndex = 7;
            this.lblCurrentQMn2Sc.Text = "Current Question";
            // 
            // lblQMn2Sc
            // 
            this.lblQMn2Sc.AutoEllipsis = true;
            this.lblQMn2Sc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblQMn2Sc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQMn2Sc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQMn2Sc.Location = new System.Drawing.Point(29, 95);
            this.lblQMn2Sc.Name = "lblQMn2Sc";
            this.lblQMn2Sc.Size = new System.Drawing.Size(265, 203);
            this.lblQMn2Sc.TabIndex = 8;
            this.lblQMn2Sc.Text = "1. Write a function that takes an integer minutes and converts it to seconds.\r\n\r\n" +
    "\r\nExamples\r\n\r\nconvert(5) ➞ 300\r\n\r\nconvert(3) ➞ 180\r\n\r\nconvert(2) ➞ 120";
            // 
            // lblUserInputMn2Sc
            // 
            this.lblUserInputMn2Sc.AutoSize = true;
            this.lblUserInputMn2Sc.Location = new System.Drawing.Point(326, 73);
            this.lblUserInputMn2Sc.Name = "lblUserInputMn2Sc";
            this.lblUserInputMn2Sc.Size = new System.Drawing.Size(200, 13);
            this.lblUserInputMn2Sc.TabIndex = 9;
            this.lblUserInputMn2Sc.Text = "Please enter positive integer for minute(s)";
            this.toolTip1.SetToolTip(this.lblUserInputMn2Sc, "Positive integer");
            // 
            // btnShowResultMn2Sc
            // 
            this.btnShowResultMn2Sc.Location = new System.Drawing.Point(329, 130);
            this.btnShowResultMn2Sc.Name = "btnShowResultMn2Sc";
            this.btnShowResultMn2Sc.Size = new System.Drawing.Size(130, 23);
            this.btnShowResultMn2Sc.TabIndex = 2;
            this.btnShowResultMn2Sc.Text = "How many seconds?";
            this.btnShowResultMn2Sc.UseVisualStyleBackColor = true;
            this.btnShowResultMn2Sc.Click += new System.EventHandler(this.btnShowResultMn2Sc_Click);
            // 
            // txbxUserInputMn2Sc
            // 
            this.txbxUserInputMn2Sc.Location = new System.Drawing.Point(329, 95);
            this.txbxUserInputMn2Sc.Name = "txbxUserInputMn2Sc";
            this.txbxUserInputMn2Sc.Size = new System.Drawing.Size(200, 20);
            this.txbxUserInputMn2Sc.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txbxUserInputMn2Sc, "Positive integer only");
            this.txbxUserInputMn2Sc.TextChanged += new System.EventHandler(this.txbxUserInputMn2Sc_TextChanged);
            // 
            // txbxResultMn2Sc
            // 
            this.txbxResultMn2Sc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbxResultMn2Sc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxResultMn2Sc.Location = new System.Drawing.Point(329, 168);
            this.txbxResultMn2Sc.Multiline = true;
            this.txbxResultMn2Sc.Name = "txbxResultMn2Sc";
            this.txbxResultMn2Sc.ReadOnly = true;
            this.txbxResultMn2Sc.Size = new System.Drawing.Size(216, 130);
            this.txbxResultMn2Sc.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txbxResultMn2Sc, "click button \"How many seconds?\" to see the result");
            // 
            // IntMin2Sec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 330);
            this.Controls.Add(this.txbxResultMn2Sc);
            this.Controls.Add(this.txbxUserInputMn2Sc);
            this.Controls.Add(this.btnShowResultMn2Sc);
            this.Controls.Add(this.lblUserInputMn2Sc);
            this.Controls.Add(this.lblQMn2Sc);
            this.Controls.Add(this.lblCurrentQMn2Sc);
            this.Controls.Add(this.cmbxSelectFunctionMn2Sc);
            this.Controls.Add(this.lblGoToMn2Sc);
            this.Controls.Add(this.linklblExitProgramMn2Sc);
            this.Controls.Add(this.linklblMainPageMn2Sc);
            this.Name = "IntMin2Sec";
            this.Text = "IntMin2Sec";
            this.Load += new System.EventHandler(this.IntMin2Sec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblMainPageMn2Sc;
        private System.Windows.Forms.LinkLabel linklblExitProgramMn2Sc;
        private System.Windows.Forms.Label lblGoToMn2Sc;
        private System.Windows.Forms.ComboBox cmbxSelectFunctionMn2Sc;
        private System.Windows.Forms.Label lblCurrentQMn2Sc;
        private System.Windows.Forms.Label lblQMn2Sc;
        private System.Windows.Forms.Label lblUserInputMn2Sc;
        private System.Windows.Forms.Button btnShowResultMn2Sc;
        private System.Windows.Forms.TextBox txbxUserInputMn2Sc;
        private System.Windows.Forms.TextBox txbxResultMn2Sc;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}