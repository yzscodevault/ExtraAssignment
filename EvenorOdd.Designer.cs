
namespace ExtraAssignment
{
    partial class EvenorOdd
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
            this.linklblMainPageEvenorOdd = new System.Windows.Forms.LinkLabel();
            this.cmbxSelectFunctionEvenorOdd = new System.Windows.Forms.ComboBox();
            this.linklblExitProgramEvenorOdd = new System.Windows.Forms.LinkLabel();
            this.lblGoToEvenorOdd = new System.Windows.Forms.Label();
            this.lblCurrentQuestionEvenorOdd = new System.Windows.Forms.Label();
            this.lblUserInputEvenorOdd = new System.Windows.Forms.Label();
            this.txbxUserInputEvenorOdd = new System.Windows.Forms.TextBox();
            this.btnShowResultEvenorOdd = new System.Windows.Forms.Button();
            this.lblCurrentQEvnorOdd = new System.Windows.Forms.Label();
            this.txbxResultEvenorOdd = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // linklblMainPageEvenorOdd
            // 
            this.linklblMainPageEvenorOdd.AutoSize = true;
            this.linklblMainPageEvenorOdd.Location = new System.Drawing.Point(17, 31);
            this.linklblMainPageEvenorOdd.Name = "linklblMainPageEvenorOdd";
            this.linklblMainPageEvenorOdd.Size = new System.Drawing.Size(58, 13);
            this.linklblMainPageEvenorOdd.TabIndex = 4;
            this.linklblMainPageEvenorOdd.TabStop = true;
            this.linklblMainPageEvenorOdd.Text = "Main Page";
            this.toolTip1.SetToolTip(this.linklblMainPageEvenorOdd, "Go to Main page");
            this.linklblMainPageEvenorOdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblMainPageEvenorOdd_LinkClicked);
            // 
            // cmbxSelectFunctionEvenorOdd
            // 
            this.cmbxSelectFunctionEvenorOdd.FormattingEnabled = true;
            this.cmbxSelectFunctionEvenorOdd.Location = new System.Drawing.Point(133, 28);
            this.cmbxSelectFunctionEvenorOdd.Name = "cmbxSelectFunctionEvenorOdd";
            this.cmbxSelectFunctionEvenorOdd.Size = new System.Drawing.Size(321, 21);
            this.cmbxSelectFunctionEvenorOdd.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbxSelectFunctionEvenorOdd, "Explore other functions");
            this.cmbxSelectFunctionEvenorOdd.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectFunctionEvenorOdd_SelectedIndexChanged);
            // 
            // linklblExitProgramEvenorOdd
            // 
            this.linklblExitProgramEvenorOdd.AutoSize = true;
            this.linklblExitProgramEvenorOdd.Location = new System.Drawing.Point(481, 31);
            this.linklblExitProgramEvenorOdd.Name = "linklblExitProgramEvenorOdd";
            this.linklblExitProgramEvenorOdd.Size = new System.Drawing.Size(66, 13);
            this.linklblExitProgramEvenorOdd.TabIndex = 5;
            this.linklblExitProgramEvenorOdd.TabStop = true;
            this.linklblExitProgramEvenorOdd.Text = "Exit Program";
            this.toolTip1.SetToolTip(this.linklblExitProgramEvenorOdd, "Exit");
            this.linklblExitProgramEvenorOdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblExitProgramEvenorOdd_LinkClicked);
            // 
            // lblGoToEvenorOdd
            // 
            this.lblGoToEvenorOdd.AutoSize = true;
            this.lblGoToEvenorOdd.Location = new System.Drawing.Point(89, 31);
            this.lblGoToEvenorOdd.Name = "lblGoToEvenorOdd";
            this.lblGoToEvenorOdd.Size = new System.Drawing.Size(40, 13);
            this.lblGoToEvenorOdd.TabIndex = 3;
            this.lblGoToEvenorOdd.Text = "Go To:";
            this.toolTip1.SetToolTip(this.lblGoToEvenorOdd, "Explore other functions");
            // 
            // lblCurrentQuestionEvenorOdd
            // 
            this.lblCurrentQuestionEvenorOdd.AutoSize = true;
            this.lblCurrentQuestionEvenorOdd.Location = new System.Drawing.Point(22, 88);
            this.lblCurrentQuestionEvenorOdd.Name = "lblCurrentQuestionEvenorOdd";
            this.lblCurrentQuestionEvenorOdd.Size = new System.Drawing.Size(86, 13);
            this.lblCurrentQuestionEvenorOdd.TabIndex = 4;
            this.lblCurrentQuestionEvenorOdd.Text = "Current Question";
            // 
            // lblUserInputEvenorOdd
            // 
            this.lblUserInputEvenorOdd.AutoSize = true;
            this.lblUserInputEvenorOdd.Location = new System.Drawing.Point(333, 88);
            this.lblUserInputEvenorOdd.Name = "lblUserInputEvenorOdd";
            this.lblUserInputEvenorOdd.Size = new System.Drawing.Size(153, 13);
            this.lblUserInputEvenorOdd.TabIndex = 6;
            this.lblUserInputEvenorOdd.Text = "Please enter a desired number:";
            this.toolTip1.SetToolTip(this.lblUserInputEvenorOdd, "Integer or decimal, even decimal always considered as odd");
            // 
            // txbxUserInputEvenorOdd
            // 
            this.txbxUserInputEvenorOdd.Location = new System.Drawing.Point(336, 108);
            this.txbxUserInputEvenorOdd.Name = "txbxUserInputEvenorOdd";
            this.txbxUserInputEvenorOdd.Size = new System.Drawing.Size(196, 20);
            this.txbxUserInputEvenorOdd.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txbxUserInputEvenorOdd, "Integer or decimal, even decimal always considered as odd");
            this.txbxUserInputEvenorOdd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnShowResultEvenorOdd
            // 
            this.btnShowResultEvenorOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowResultEvenorOdd.Location = new System.Drawing.Point(336, 140);
            this.btnShowResultEvenorOdd.Name = "btnShowResultEvenorOdd";
            this.btnShowResultEvenorOdd.Size = new System.Drawing.Size(90, 23);
            this.btnShowResultEvenorOdd.TabIndex = 10;
            this.btnShowResultEvenorOdd.Text = "Show Result";
            this.btnShowResultEvenorOdd.UseVisualStyleBackColor = true;
            this.btnShowResultEvenorOdd.Click += new System.EventHandler(this.btnShowResultEvenorOdd_Click);
            // 
            // lblCurrentQEvnorOdd
            // 
            this.lblCurrentQEvnorOdd.AutoEllipsis = true;
            this.lblCurrentQEvnorOdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCurrentQEvnorOdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentQEvnorOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentQEvnorOdd.Location = new System.Drawing.Point(25, 108);
            this.lblCurrentQEvnorOdd.Name = "lblCurrentQEvnorOdd";
            this.lblCurrentQEvnorOdd.Size = new System.Drawing.Size(274, 159);
            this.lblCurrentQEvnorOdd.TabIndex = 11;
            this.lblCurrentQEvnorOdd.Text = "6. Write a C# Sharp program to check whether a given number is even or odd. \r\n\r\nT" +
    "est Data : 15\r\n\r\nExpected Output :\r\n15 is an odd integer";
            // 
            // txbxResultEvenorOdd
            // 
            this.txbxResultEvenorOdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbxResultEvenorOdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxResultEvenorOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbxResultEvenorOdd.Location = new System.Drawing.Point(336, 169);
            this.txbxResultEvenorOdd.Multiline = true;
            this.txbxResultEvenorOdd.Name = "txbxResultEvenorOdd";
            this.txbxResultEvenorOdd.ReadOnly = true;
            this.txbxResultEvenorOdd.Size = new System.Drawing.Size(196, 98);
            this.txbxResultEvenorOdd.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txbxResultEvenorOdd, "click button \"Show Result\" to see the result");
            // 
            // EvenorOdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 310);
            this.Controls.Add(this.lblCurrentQEvnorOdd);
            this.Controls.Add(this.btnShowResultEvenorOdd);
            this.Controls.Add(this.txbxResultEvenorOdd);
            this.Controls.Add(this.txbxUserInputEvenorOdd);
            this.Controls.Add(this.lblUserInputEvenorOdd);
            this.Controls.Add(this.lblCurrentQuestionEvenorOdd);
            this.Controls.Add(this.lblGoToEvenorOdd);
            this.Controls.Add(this.linklblExitProgramEvenorOdd);
            this.Controls.Add(this.cmbxSelectFunctionEvenorOdd);
            this.Controls.Add(this.linklblMainPageEvenorOdd);
            this.Name = "EvenorOdd";
            this.Text = "EvenorOdd";
            this.Load += new System.EventHandler(this.EvenorOdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblMainPageEvenorOdd;
        private System.Windows.Forms.ComboBox cmbxSelectFunctionEvenorOdd;
        private System.Windows.Forms.LinkLabel linklblExitProgramEvenorOdd;
        private System.Windows.Forms.Label lblGoToEvenorOdd;
        private System.Windows.Forms.Label lblCurrentQuestionEvenorOdd;
        private System.Windows.Forms.Label lblUserInputEvenorOdd;
        private System.Windows.Forms.TextBox txbxUserInputEvenorOdd;
        private System.Windows.Forms.Button btnShowResultEvenorOdd;
        private System.Windows.Forms.Label lblCurrentQEvnorOdd;
        private System.Windows.Forms.TextBox txbxResultEvenorOdd;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}