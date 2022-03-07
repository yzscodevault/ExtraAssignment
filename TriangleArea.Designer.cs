
namespace ExtraAssignment
{
    partial class TriangleArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleArea));
            this.txbxResultTriAr = new System.Windows.Forms.TextBox();
            this.txbxUserInputTriBaseTriAr = new System.Windows.Forms.TextBox();
            this.btnShowResultTriAr = new System.Windows.Forms.Button();
            this.lblUserInputTriBaseTriAr = new System.Windows.Forms.Label();
            this.lblQTriAr = new System.Windows.Forms.Label();
            this.lblCurrentQTriAr = new System.Windows.Forms.Label();
            this.cmbxSelectFunctionTriAr = new System.Windows.Forms.ComboBox();
            this.lblGoToTriAr = new System.Windows.Forms.Label();
            this.linklblExitProgramTriAr = new System.Windows.Forms.LinkLabel();
            this.linklblMainPageTriAr = new System.Windows.Forms.LinkLabel();
            this.lblUserInputTriHgtTriAr = new System.Windows.Forms.Label();
            this.txbxUserInputTriHgtTriAr = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txbxResultTriAr
            // 
            this.txbxResultTriAr.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbxResultTriAr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxResultTriAr.Location = new System.Drawing.Point(323, 229);
            this.txbxResultTriAr.Multiline = true;
            this.txbxResultTriAr.Name = "txbxResultTriAr";
            this.txbxResultTriAr.ReadOnly = true;
            this.txbxResultTriAr.Size = new System.Drawing.Size(216, 60);
            this.txbxResultTriAr.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txbxResultTriAr, "click button \"Calculate Area\" to see the result");
            // 
            // txbxUserInputTriBaseTriAr
            // 
            this.txbxUserInputTriBaseTriAr.Location = new System.Drawing.Point(323, 86);
            this.txbxUserInputTriBaseTriAr.Name = "txbxUserInputTriBaseTriAr";
            this.txbxUserInputTriBaseTriAr.Size = new System.Drawing.Size(200, 20);
            this.txbxUserInputTriBaseTriAr.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txbxUserInputTriBaseTriAr, "Integer or decimal");
            this.txbxUserInputTriBaseTriAr.TextChanged += new System.EventHandler(this.txbxUserInputTriBaseTriAr_TextChanged);
            // 
            // btnShowResultTriAr
            // 
            this.btnShowResultTriAr.Location = new System.Drawing.Point(323, 186);
            this.btnShowResultTriAr.Name = "btnShowResultTriAr";
            this.btnShowResultTriAr.Size = new System.Drawing.Size(87, 23);
            this.btnShowResultTriAr.TabIndex = 3;
            this.btnShowResultTriAr.Text = "Calculate Area";
            this.btnShowResultTriAr.UseVisualStyleBackColor = true;
            this.btnShowResultTriAr.Click += new System.EventHandler(this.btnShowResultTriAr_Click);
            // 
            // lblUserInputTriBaseTriAr
            // 
            this.lblUserInputTriBaseTriAr.AutoSize = true;
            this.lblUserInputTriBaseTriAr.Location = new System.Drawing.Point(320, 64);
            this.lblUserInputTriBaseTriAr.Name = "lblUserInputTriBaseTriAr";
            this.lblUserInputTriBaseTriAr.Size = new System.Drawing.Size(202, 13);
            this.lblUserInputTriBaseTriAr.TabIndex = 8;
            this.lblUserInputTriBaseTriAr.Text = "Please enter positive number for the base";
            this.toolTip1.SetToolTip(this.lblUserInputTriBaseTriAr, "Integer or decimal");
            // 
            // lblQTriAr
            // 
            this.lblQTriAr.AutoEllipsis = true;
            this.lblQTriAr.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblQTriAr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQTriAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQTriAr.Location = new System.Drawing.Point(23, 86);
            this.lblQTriAr.Name = "lblQTriAr";
            this.lblQTriAr.Size = new System.Drawing.Size(265, 203);
            this.lblQTriAr.TabIndex = 7;
            this.lblQTriAr.Text = resources.GetString("lblQTriAr.Text");
            // 
            // lblCurrentQTriAr
            // 
            this.lblCurrentQTriAr.AutoSize = true;
            this.lblCurrentQTriAr.Location = new System.Drawing.Point(20, 64);
            this.lblCurrentQTriAr.Name = "lblCurrentQTriAr";
            this.lblCurrentQTriAr.Size = new System.Drawing.Size(86, 13);
            this.lblCurrentQTriAr.TabIndex = 6;
            this.lblCurrentQTriAr.Text = "Current Question";
            // 
            // cmbxSelectFunctionTriAr
            // 
            this.cmbxSelectFunctionTriAr.FormattingEnabled = true;
            this.cmbxSelectFunctionTriAr.ItemHeight = 13;
            this.cmbxSelectFunctionTriAr.Location = new System.Drawing.Point(143, 19);
            this.cmbxSelectFunctionTriAr.Name = "cmbxSelectFunctionTriAr";
            this.cmbxSelectFunctionTriAr.Size = new System.Drawing.Size(310, 21);
            this.cmbxSelectFunctionTriAr.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbxSelectFunctionTriAr, "Explore other functions");
            this.cmbxSelectFunctionTriAr.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectFunctionTriAr_SelectedIndexChanged);
            // 
            // lblGoToTriAr
            // 
            this.lblGoToTriAr.AutoSize = true;
            this.lblGoToTriAr.Location = new System.Drawing.Point(97, 22);
            this.lblGoToTriAr.Name = "lblGoToTriAr";
            this.lblGoToTriAr.Size = new System.Drawing.Size(40, 13);
            this.lblGoToTriAr.TabIndex = 10;
            this.lblGoToTriAr.Text = "Go To:";
            this.toolTip1.SetToolTip(this.lblGoToTriAr, "Explore other functions");
            // 
            // linklblExitProgramTriAr
            // 
            this.linklblExitProgramTriAr.AutoSize = true;
            this.linklblExitProgramTriAr.Location = new System.Drawing.Point(473, 22);
            this.linklblExitProgramTriAr.Name = "linklblExitProgramTriAr";
            this.linklblExitProgramTriAr.Size = new System.Drawing.Size(66, 13);
            this.linklblExitProgramTriAr.TabIndex = 6;
            this.linklblExitProgramTriAr.TabStop = true;
            this.linklblExitProgramTriAr.Text = "Exit Program";
            this.toolTip1.SetToolTip(this.linklblExitProgramTriAr, "Exit");
            this.linklblExitProgramTriAr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblExitProgramTriAr_LinkClicked);
            // 
            // linklblMainPageTriAr
            // 
            this.linklblMainPageTriAr.AutoSize = true;
            this.linklblMainPageTriAr.Location = new System.Drawing.Point(20, 22);
            this.linklblMainPageTriAr.Name = "linklblMainPageTriAr";
            this.linklblMainPageTriAr.Size = new System.Drawing.Size(58, 13);
            this.linklblMainPageTriAr.TabIndex = 5;
            this.linklblMainPageTriAr.TabStop = true;
            this.linklblMainPageTriAr.Text = "Main Page";
            this.toolTip1.SetToolTip(this.linklblMainPageTriAr, "Go to Main page");
            this.linklblMainPageTriAr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblMainPageTriAr_LinkClicked);
            // 
            // lblUserInputTriHgtTriAr
            // 
            this.lblUserInputTriHgtTriAr.AutoSize = true;
            this.lblUserInputTriHgtTriAr.Location = new System.Drawing.Point(320, 126);
            this.lblUserInputTriHgtTriAr.Name = "lblUserInputTriHgtTriAr";
            this.lblUserInputTriHgtTriAr.Size = new System.Drawing.Size(208, 13);
            this.lblUserInputTriHgtTriAr.TabIndex = 8;
            this.lblUserInputTriHgtTriAr.Text = "Please enter positive number for the height";
            this.toolTip1.SetToolTip(this.lblUserInputTriHgtTriAr, "Integer or decimal");
            // 
            // txbxUserInputTriHgtTriAr
            // 
            this.txbxUserInputTriHgtTriAr.Location = new System.Drawing.Point(323, 148);
            this.txbxUserInputTriHgtTriAr.Name = "txbxUserInputTriHgtTriAr";
            this.txbxUserInputTriHgtTriAr.Size = new System.Drawing.Size(200, 20);
            this.txbxUserInputTriHgtTriAr.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txbxUserInputTriHgtTriAr, "Integer or decimal");
            this.txbxUserInputTriHgtTriAr.TextChanged += new System.EventHandler(this.txbxUserInputTriHgtTriAr_TextChanged);
            // 
            // TriangleArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 326);
            this.Controls.Add(this.txbxResultTriAr);
            this.Controls.Add(this.txbxUserInputTriHgtTriAr);
            this.Controls.Add(this.txbxUserInputTriBaseTriAr);
            this.Controls.Add(this.lblUserInputTriHgtTriAr);
            this.Controls.Add(this.btnShowResultTriAr);
            this.Controls.Add(this.lblUserInputTriBaseTriAr);
            this.Controls.Add(this.lblQTriAr);
            this.Controls.Add(this.lblCurrentQTriAr);
            this.Controls.Add(this.cmbxSelectFunctionTriAr);
            this.Controls.Add(this.lblGoToTriAr);
            this.Controls.Add(this.linklblExitProgramTriAr);
            this.Controls.Add(this.linklblMainPageTriAr);
            this.Name = "TriangleArea";
            this.Text = "TriangleArea";
            this.Load += new System.EventHandler(this.TriangleArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxResultTriAr;
        private System.Windows.Forms.TextBox txbxUserInputTriBaseTriAr;
        private System.Windows.Forms.Button btnShowResultTriAr;
        private System.Windows.Forms.Label lblUserInputTriBaseTriAr;
        private System.Windows.Forms.Label lblQTriAr;
        private System.Windows.Forms.Label lblCurrentQTriAr;
        private System.Windows.Forms.ComboBox cmbxSelectFunctionTriAr;
        private System.Windows.Forms.Label lblGoToTriAr;
        private System.Windows.Forms.LinkLabel linklblExitProgramTriAr;
        private System.Windows.Forms.LinkLabel linklblMainPageTriAr;
        private System.Windows.Forms.Label lblUserInputTriHgtTriAr;
        private System.Windows.Forms.TextBox txbxUserInputTriHgtTriAr;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}