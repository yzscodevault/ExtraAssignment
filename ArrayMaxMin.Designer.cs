
namespace ExtraAssignment
{
    partial class ArrayMaxMin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrayMaxMin));
            this.linklblMainFormArrayMaxMin = new System.Windows.Forms.LinkLabel();
            this.linklblExitArrayMacMin = new System.Windows.Forms.LinkLabel();
            this.cmbxSelectFunctionArraryMaxMin = new System.Windows.Forms.ComboBox();
            this.lblGotoFunctionArrayMaxMin = new System.Windows.Forms.Label();
            this.lblUserInputArraryMaxMin = new System.Windows.Forms.Label();
            this.txbxUserInputArrayMaxMin = new System.Windows.Forms.TextBox();
            this.txbxResultArrayMaxMin = new System.Windows.Forms.TextBox();
            this.btnShowResultArrayMaxMin = new System.Windows.Forms.Button();
            this.lblCurrentQArraryMaxMin = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblQuestionArrayMaxMin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linklblMainFormArrayMaxMin
            // 
            this.linklblMainFormArrayMaxMin.AutoSize = true;
            this.linklblMainFormArrayMaxMin.Location = new System.Drawing.Point(22, 42);
            this.linklblMainFormArrayMaxMin.Name = "linklblMainFormArrayMaxMin";
            this.linklblMainFormArrayMaxMin.Size = new System.Drawing.Size(58, 13);
            this.linklblMainFormArrayMaxMin.TabIndex = 0;
            this.linklblMainFormArrayMaxMin.TabStop = true;
            this.linklblMainFormArrayMaxMin.Text = "Main Page";
            this.toolTip1.SetToolTip(this.linklblMainFormArrayMaxMin, "Go to Main page");
            this.linklblMainFormArrayMaxMin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblMainFormArrayMaxMin_LinkClicked);
            // 
            // linklblExitArrayMacMin
            // 
            this.linklblExitArrayMacMin.AutoSize = true;
            this.linklblExitArrayMacMin.Location = new System.Drawing.Point(636, 42);
            this.linklblExitArrayMacMin.Name = "linklblExitArrayMacMin";
            this.linklblExitArrayMacMin.Size = new System.Drawing.Size(66, 13);
            this.linklblExitArrayMacMin.TabIndex = 1;
            this.linklblExitArrayMacMin.TabStop = true;
            this.linklblExitArrayMacMin.Text = "Exit Program";
            this.toolTip1.SetToolTip(this.linklblExitArrayMacMin, "Exit");
            this.linklblExitArrayMacMin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblExitArrayMacMin_LinkClicked);
            // 
            // cmbxSelectFunctionArraryMaxMin
            // 
            this.cmbxSelectFunctionArraryMaxMin.FormattingEnabled = true;
            this.cmbxSelectFunctionArraryMaxMin.Location = new System.Drawing.Point(201, 39);
            this.cmbxSelectFunctionArraryMaxMin.Name = "cmbxSelectFunctionArraryMaxMin";
            this.cmbxSelectFunctionArraryMaxMin.Size = new System.Drawing.Size(373, 21);
            this.cmbxSelectFunctionArraryMaxMin.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cmbxSelectFunctionArraryMaxMin, "Explore other functions");
            this.cmbxSelectFunctionArraryMaxMin.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectFunctionArraryMaxMin_SelectedIndexChanged);
            // 
            // lblGotoFunctionArrayMaxMin
            // 
            this.lblGotoFunctionArrayMaxMin.AutoSize = true;
            this.lblGotoFunctionArrayMaxMin.Location = new System.Drawing.Point(139, 42);
            this.lblGotoFunctionArrayMaxMin.Name = "lblGotoFunctionArrayMaxMin";
            this.lblGotoFunctionArrayMaxMin.Size = new System.Drawing.Size(40, 13);
            this.lblGotoFunctionArrayMaxMin.TabIndex = 3;
            this.lblGotoFunctionArrayMaxMin.Text = "Go To:";
            this.toolTip1.SetToolTip(this.lblGotoFunctionArrayMaxMin, "Explore other functions");
            // 
            // lblUserInputArraryMaxMin
            // 
            this.lblUserInputArraryMaxMin.AutoSize = true;
            this.lblUserInputArraryMaxMin.Location = new System.Drawing.Point(360, 97);
            this.lblUserInputArraryMaxMin.Name = "lblUserInputArraryMaxMin";
            this.lblUserInputArraryMaxMin.Size = new System.Drawing.Size(210, 13);
            this.lblUserInputArraryMaxMin.TabIndex = 0;
            this.lblUserInputArraryMaxMin.Text = "Please enter only positive numbers w/o dot";
            this.toolTip1.SetToolTip(this.lblUserInputArraryMaxMin, "Decimals format here as when dot and number combination:");
            // 
            // txbxUserInputArrayMaxMin
            // 
            this.txbxUserInputArrayMaxMin.Location = new System.Drawing.Point(363, 113);
            this.txbxUserInputArrayMaxMin.Name = "txbxUserInputArrayMaxMin";
            this.txbxUserInputArrayMaxMin.Size = new System.Drawing.Size(339, 20);
            this.txbxUserInputArrayMaxMin.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txbxUserInputArrayMaxMin, resources.GetString("txbxUserInputArrayMaxMin.ToolTip"));
            this.txbxUserInputArrayMaxMin.TextChanged += new System.EventHandler(this.txbxUserInputArrayMaxMin_TextChanged);
            this.txbxUserInputArrayMaxMin.Validating += new System.ComponentModel.CancelEventHandler(this.txbxUserInputArrayMaxMin_Validating);
            // 
            // txbxResultArrayMaxMin
            // 
            this.txbxResultArrayMaxMin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbxResultArrayMaxMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxResultArrayMaxMin.Location = new System.Drawing.Point(363, 173);
            this.txbxResultArrayMaxMin.Multiline = true;
            this.txbxResultArrayMaxMin.Name = "txbxResultArrayMaxMin";
            this.txbxResultArrayMaxMin.Size = new System.Drawing.Size(339, 241);
            this.txbxResultArrayMaxMin.TabIndex = 2;
            this.txbxResultArrayMaxMin.Text = resources.GetString("txbxResultArrayMaxMin.Text");
            this.toolTip1.SetToolTip(this.txbxResultArrayMaxMin, "click button \"Show Result\" to see the result");
            this.txbxResultArrayMaxMin.TextChanged += new System.EventHandler(this.txbxResultArrayMaxMin_TextChanged);
            // 
            // btnShowResultArrayMaxMin
            // 
            this.btnShowResultArrayMaxMin.Location = new System.Drawing.Point(363, 144);
            this.btnShowResultArrayMaxMin.Name = "btnShowResultArrayMaxMin";
            this.btnShowResultArrayMaxMin.Size = new System.Drawing.Size(75, 23);
            this.btnShowResultArrayMaxMin.TabIndex = 5;
            this.btnShowResultArrayMaxMin.Text = "Show Result";
            this.toolTip1.SetToolTip(this.btnShowResultArrayMaxMin, "Decimals format here as when dot and number combination:");
            this.btnShowResultArrayMaxMin.UseVisualStyleBackColor = true;
            this.btnShowResultArrayMaxMin.Click += new System.EventHandler(this.btnShowResultArrayMaxMin_Click);
            // 
            // lblCurrentQArraryMaxMin
            // 
            this.lblCurrentQArraryMaxMin.AutoSize = true;
            this.lblCurrentQArraryMaxMin.Location = new System.Drawing.Point(22, 97);
            this.lblCurrentQArraryMaxMin.Name = "lblCurrentQArraryMaxMin";
            this.lblCurrentQArraryMaxMin.Size = new System.Drawing.Size(86, 13);
            this.lblCurrentQArraryMaxMin.TabIndex = 6;
            this.lblCurrentQArraryMaxMin.Text = "Current Question";
            // 
            // lblQuestionArrayMaxMin
            // 
            this.lblQuestionArrayMaxMin.AutoEllipsis = true;
            this.lblQuestionArrayMaxMin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblQuestionArrayMaxMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestionArrayMaxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuestionArrayMaxMin.Location = new System.Drawing.Point(22, 113);
            this.lblQuestionArrayMaxMin.Name = "lblQuestionArrayMaxMin";
            this.lblQuestionArrayMaxMin.Size = new System.Drawing.Size(317, 301);
            this.lblQuestionArrayMaxMin.TabIndex = 7;
            this.lblQuestionArrayMaxMin.Text = resources.GetString("lblQuestionArrayMaxMin.Text");
            // 
            // ArrayMaxMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.lblQuestionArrayMaxMin);
            this.Controls.Add(this.lblCurrentQArraryMaxMin);
            this.Controls.Add(this.btnShowResultArrayMaxMin);
            this.Controls.Add(this.txbxResultArrayMaxMin);
            this.Controls.Add(this.txbxUserInputArrayMaxMin);
            this.Controls.Add(this.lblGotoFunctionArrayMaxMin);
            this.Controls.Add(this.lblUserInputArraryMaxMin);
            this.Controls.Add(this.cmbxSelectFunctionArraryMaxMin);
            this.Controls.Add(this.linklblExitArrayMacMin);
            this.Controls.Add(this.linklblMainFormArrayMaxMin);
            this.Name = "ArrayMaxMin";
            this.Text = "ArrayMaxMin";
            this.Load += new System.EventHandler(this.ArrayMaxMin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblMainFormArrayMaxMin;
        private System.Windows.Forms.LinkLabel linklblExitArrayMacMin;
        private System.Windows.Forms.ComboBox cmbxSelectFunctionArraryMaxMin;
        private System.Windows.Forms.Label lblGotoFunctionArrayMaxMin;
        private System.Windows.Forms.Label lblUserInputArraryMaxMin;
        private System.Windows.Forms.TextBox txbxUserInputArrayMaxMin;
        private System.Windows.Forms.TextBox txbxResultArrayMaxMin;
        private System.Windows.Forms.Button btnShowResultArrayMaxMin;
        private System.Windows.Forms.Label lblCurrentQArraryMaxMin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblQuestionArrayMaxMin;
    }
}