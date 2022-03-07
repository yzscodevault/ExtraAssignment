
namespace ExtraAssignment
{
    partial class SumLess100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SumLess100));
            this.lblSumLess100 = new System.Windows.Forms.Label();
            this.txbxSumLess100Num1 = new System.Windows.Forms.TextBox();
            this.txbxSumLess100Num2 = new System.Windows.Forms.TextBox();
            this.txbxSumLess100Result = new System.Windows.Forms.TextBox();
            this.lblSumLessNum1 = new System.Windows.Forms.Label();
            this.lblSumLessNum2 = new System.Windows.Forms.Label();
            this.btnSumLessResult = new System.Windows.Forms.Button();
            this.linklblSumLess100GoMain = new System.Windows.Forms.LinkLabel();
            this.linklblSumLess100Exit = new System.Windows.Forms.LinkLabel();
            this.cmbxSumLess100GoToOther = new System.Windows.Forms.ComboBox();
            this.lblSumLess100GoToOther = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblSumLess100
            // 
            this.lblSumLess100.AutoEllipsis = true;
            this.lblSumLess100.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSumLess100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumLess100.Location = new System.Drawing.Point(48, 64);
            this.lblSumLess100.Name = "lblSumLess100";
            this.lblSumLess100.Size = new System.Drawing.Size(441, 147);
            this.lblSumLess100.TabIndex = 0;
            this.lblSumLess100.Text = resources.GetString("lblSumLess100.Text");
            // 
            // txbxSumLess100Num1
            // 
            this.txbxSumLess100Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxSumLess100Num1.Location = new System.Drawing.Point(51, 280);
            this.txbxSumLess100Num1.Name = "txbxSumLess100Num1";
            this.txbxSumLess100Num1.Size = new System.Drawing.Size(123, 21);
            this.txbxSumLess100Num1.TabIndex = 2;
            this.txbxSumLess100Num1.TextChanged += new System.EventHandler(this.txbxSumLess100Num1_TextChanged);
            // 
            // txbxSumLess100Num2
            // 
            this.txbxSumLess100Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbxSumLess100Num2.Location = new System.Drawing.Point(51, 349);
            this.txbxSumLess100Num2.Name = "txbxSumLess100Num2";
            this.txbxSumLess100Num2.Size = new System.Drawing.Size(123, 21);
            this.txbxSumLess100Num2.TabIndex = 3;
            this.txbxSumLess100Num2.TextChanged += new System.EventHandler(this.txbxSumLess100Num2_TextChanged);
            // 
            // txbxSumLess100Result
            // 
            this.txbxSumLess100Result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbxSumLess100Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbxSumLess100Result.Location = new System.Drawing.Point(280, 334);
            this.txbxSumLess100Result.Name = "txbxSumLess100Result";
            this.txbxSumLess100Result.ReadOnly = true;
            this.txbxSumLess100Result.Size = new System.Drawing.Size(118, 23);
            this.txbxSumLess100Result.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txbxSumLess100Result, "click button \"Show Result\" to see the result");
            // 
            // lblSumLessNum1
            // 
            this.lblSumLessNum1.AutoSize = true;
            this.lblSumLessNum1.Location = new System.Drawing.Point(48, 252);
            this.lblSumLessNum1.Name = "lblSumLessNum1";
            this.lblSumLessNum1.Size = new System.Drawing.Size(94, 13);
            this.lblSumLessNum1.TabIndex = 4;
            this.lblSumLessNum1.Text = "Enter First Number";
            // 
            // lblSumLessNum2
            // 
            this.lblSumLessNum2.AutoSize = true;
            this.lblSumLessNum2.Location = new System.Drawing.Point(51, 324);
            this.lblSumLessNum2.Name = "lblSumLessNum2";
            this.lblSumLessNum2.Size = new System.Drawing.Size(112, 13);
            this.lblSumLessNum2.TabIndex = 5;
            this.lblSumLessNum2.Text = "Enter Second Number";
            // 
            // btnSumLessResult
            // 
            this.btnSumLessResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumLessResult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSumLessResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSumLessResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSumLessResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSumLessResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSumLessResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSumLessResult.Location = new System.Drawing.Point(280, 295);
            this.btnSumLessResult.Name = "btnSumLessResult";
            this.btnSumLessResult.Size = new System.Drawing.Size(118, 23);
            this.btnSumLessResult.TabIndex = 5;
            this.btnSumLessResult.Text = "Show Result";
            this.btnSumLessResult.UseVisualStyleBackColor = true;
            this.btnSumLessResult.Click += new System.EventHandler(this.btnSumLess_Click);
            // 
            // linklblSumLess100GoMain
            // 
            this.linklblSumLess100GoMain.AutoSize = true;
            this.linklblSumLess100GoMain.Location = new System.Drawing.Point(27, 19);
            this.linklblSumLess100GoMain.Name = "linklblSumLess100GoMain";
            this.linklblSumLess100GoMain.Size = new System.Drawing.Size(58, 13);
            this.linklblSumLess100GoMain.TabIndex = 6;
            this.linklblSumLess100GoMain.TabStop = true;
            this.linklblSumLess100GoMain.Text = "Main Page";
            this.toolTip1.SetToolTip(this.linklblSumLess100GoMain, "Go to Main page");
            this.linklblSumLess100GoMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSumLess100GoMain_LinkClicked);
            // 
            // linklblSumLess100Exit
            // 
            this.linklblSumLess100Exit.AutoSize = true;
            this.linklblSumLess100Exit.Location = new System.Drawing.Point(438, 19);
            this.linklblSumLess100Exit.Name = "linklblSumLess100Exit";
            this.linklblSumLess100Exit.Size = new System.Drawing.Size(66, 13);
            this.linklblSumLess100Exit.TabIndex = 7;
            this.linklblSumLess100Exit.TabStop = true;
            this.linklblSumLess100Exit.Text = "Exit Program";
            this.toolTip1.SetToolTip(this.linklblSumLess100Exit, "Exit");
            this.linklblSumLess100Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSumLess100Exit_LinkClicked);
            // 
            // cmbxSumLess100GoToOther
            // 
            this.cmbxSumLess100GoToOther.FormattingEnabled = true;
            this.cmbxSumLess100GoToOther.Location = new System.Drawing.Point(157, 16);
            this.cmbxSumLess100GoToOther.Name = "cmbxSumLess100GoToOther";
            this.cmbxSumLess100GoToOther.Size = new System.Drawing.Size(256, 21);
            this.cmbxSumLess100GoToOther.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbxSumLess100GoToOther, "Explore other functions");
            this.cmbxSumLess100GoToOther.SelectedIndexChanged += new System.EventHandler(this.cmbxSumLess100GoToOther_SelectedIndexChanged);
            // 
            // lblSumLess100GoToOther
            // 
            this.lblSumLess100GoToOther.AutoSize = true;
            this.lblSumLess100GoToOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumLess100GoToOther.Location = new System.Drawing.Point(108, 19);
            this.lblSumLess100GoToOther.Name = "lblSumLess100GoToOther";
            this.lblSumLess100GoToOther.Size = new System.Drawing.Size(43, 15);
            this.lblSumLess100GoToOther.TabIndex = 10;
            this.lblSumLess100GoToOther.Text = "Go To:";
            this.toolTip1.SetToolTip(this.lblSumLess100GoToOther, "Explore other functions");
            // 
            // SumLess100
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 387);
            this.Controls.Add(this.lblSumLess100GoToOther);
            this.Controls.Add(this.cmbxSumLess100GoToOther);
            this.Controls.Add(this.linklblSumLess100Exit);
            this.Controls.Add(this.linklblSumLess100GoMain);
            this.Controls.Add(this.btnSumLessResult);
            this.Controls.Add(this.lblSumLessNum2);
            this.Controls.Add(this.lblSumLessNum1);
            this.Controls.Add(this.txbxSumLess100Result);
            this.Controls.Add(this.txbxSumLess100Num2);
            this.Controls.Add(this.txbxSumLess100Num1);
            this.Controls.Add(this.lblSumLess100);
            this.Name = "SumLess100";
            this.Text = "SumLess100";
            this.Load += new System.EventHandler(this.SumLess100_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSumLess100;
        private System.Windows.Forms.TextBox txbxSumLess100Num1;
        private System.Windows.Forms.TextBox txbxSumLess100Num2;
        private System.Windows.Forms.TextBox txbxSumLess100Result;
        private System.Windows.Forms.Label lblSumLessNum1;
        private System.Windows.Forms.Label lblSumLessNum2;
        private System.Windows.Forms.Button btnSumLessResult;
        private System.Windows.Forms.LinkLabel linklblSumLess100GoMain;
        private System.Windows.Forms.LinkLabel linklblSumLess100Exit;
        private System.Windows.Forms.ComboBox cmbxSumLess100GoToOther;
        private System.Windows.Forms.Label lblSumLess100GoToOther;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}