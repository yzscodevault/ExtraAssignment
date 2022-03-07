
namespace ExtraAssignment
{
    partial class formMainMenu
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
            this.lblMainMenuHeading = new System.Windows.Forms.Label();
            this.lblMainMenuSelectFunction = new System.Windows.Forms.Label();
            this.cmbxMainMenuSelectFunction = new System.Windows.Forms.ComboBox();
            this.btnMainMenuStartFunction = new System.Windows.Forms.Button();
            this.btnMainMenuCancelSelection = new System.Windows.Forms.Button();
            this.linklblMainMenuLinkedIn = new System.Windows.Forms.LinkLabel();
            this.btnMainMenuExit = new System.Windows.Forms.Button();
            this.linklblMainMenuEmail = new System.Windows.Forms.LinkLabel();
            this.toolTip1MainPage = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblMainMenuHeading
            // 
            this.lblMainMenuHeading.AutoSize = true;
            this.lblMainMenuHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMainMenuHeading.Location = new System.Drawing.Point(15, 25);
            this.lblMainMenuHeading.Name = "lblMainMenuHeading";
            this.lblMainMenuHeading.Size = new System.Drawing.Size(763, 46);
            this.lblMainMenuHeading.TabIndex = 0;
            this.lblMainMenuHeading.Text = "Welcome to Kaleidoscope of Functions!";
            this.lblMainMenuHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMainMenuSelectFunction
            // 
            this.lblMainMenuSelectFunction.AutoSize = true;
            this.lblMainMenuSelectFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMainMenuSelectFunction.Location = new System.Drawing.Point(185, 137);
            this.lblMainMenuSelectFunction.Name = "lblMainMenuSelectFunction";
            this.lblMainMenuSelectFunction.Size = new System.Drawing.Size(373, 31);
            this.lblMainMenuSelectFunction.TabIndex = 1;
            this.lblMainMenuSelectFunction.Text = "Please choose one function";
            // 
            // cmbxMainMenuSelectFunction
            // 
            this.cmbxMainMenuSelectFunction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxMainMenuSelectFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbxMainMenuSelectFunction.FormattingEnabled = true;
            this.cmbxMainMenuSelectFunction.Location = new System.Drawing.Point(89, 206);
            this.cmbxMainMenuSelectFunction.Name = "cmbxMainMenuSelectFunction";
            this.cmbxMainMenuSelectFunction.Size = new System.Drawing.Size(567, 28);
            this.cmbxMainMenuSelectFunction.TabIndex = 1;
            this.toolTip1MainPage.SetToolTip(this.cmbxMainMenuSelectFunction, "Explore different functions");
            this.cmbxMainMenuSelectFunction.SelectedIndexChanged += new System.EventHandler(this.cmbxMainMenuSelectFunction_SelectedIndexChanged);
            // 
            // btnMainMenuStartFunction
            // 
            this.btnMainMenuStartFunction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenuStartFunction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMainMenuStartFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMainMenuStartFunction.Location = new System.Drawing.Point(191, 256);
            this.btnMainMenuStartFunction.Name = "btnMainMenuStartFunction";
            this.btnMainMenuStartFunction.Size = new System.Drawing.Size(103, 44);
            this.btnMainMenuStartFunction.TabIndex = 2;
            this.btnMainMenuStartFunction.Text = "Start";
            this.toolTip1MainPage.SetToolTip(this.btnMainMenuStartFunction, "Go to selected function");
            this.btnMainMenuStartFunction.UseVisualStyleBackColor = true;
            this.btnMainMenuStartFunction.Click += new System.EventHandler(this.btnMainMenuStartFunction_Click);
            // 
            // btnMainMenuCancelSelection
            // 
            this.btnMainMenuCancelSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenuCancelSelection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMainMenuCancelSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMainMenuCancelSelection.Location = new System.Drawing.Point(455, 256);
            this.btnMainMenuCancelSelection.Name = "btnMainMenuCancelSelection";
            this.btnMainMenuCancelSelection.Size = new System.Drawing.Size(103, 44);
            this.btnMainMenuCancelSelection.TabIndex = 3;
            this.btnMainMenuCancelSelection.Text = "Cancel";
            this.toolTip1MainPage.SetToolTip(this.btnMainMenuCancelSelection, "Not the function I wanted");
            this.btnMainMenuCancelSelection.UseVisualStyleBackColor = true;
            this.btnMainMenuCancelSelection.Click += new System.EventHandler(this.btnMainMenuCancelSelection_Click);
            // 
            // linklblMainMenuLinkedIn
            // 
            this.linklblMainMenuLinkedIn.AutoSize = true;
            this.linklblMainMenuLinkedIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklblMainMenuLinkedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linklblMainMenuLinkedIn.Location = new System.Drawing.Point(17, 367);
            this.linklblMainMenuLinkedIn.Name = "linklblMainMenuLinkedIn";
            this.linklblMainMenuLinkedIn.Size = new System.Drawing.Size(98, 15);
            this.linklblMainMenuLinkedIn.TabIndex = 4;
            this.linklblMainMenuLinkedIn.TabStop = true;
            this.linklblMainMenuLinkedIn.Text = "Visit My LinkedIn";
            this.toolTip1MainPage.SetToolTip(this.linklblMainMenuLinkedIn, "Go to my LinkedIn page");
            this.linklblMainMenuLinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblMainMenuContactUs_LinkClicked);
            // 
            // btnMainMenuExit
            // 
            this.btnMainMenuExit.AutoSize = true;
            this.btnMainMenuExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMainMenuExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenuExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMainMenuExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMainMenuExit.Location = new System.Drawing.Point(703, 357);
            this.btnMainMenuExit.Name = "btnMainMenuExit";
            this.btnMainMenuExit.Size = new System.Drawing.Size(75, 25);
            this.btnMainMenuExit.TabIndex = 5;
            this.btnMainMenuExit.Text = "Exit";
            this.toolTip1MainPage.SetToolTip(this.btnMainMenuExit, "Exit the program");
            this.btnMainMenuExit.UseVisualStyleBackColor = false;
            this.btnMainMenuExit.Click += new System.EventHandler(this.btnMainMenuExit_Click);
            // 
            // linklblMainMenuEmail
            // 
            this.linklblMainMenuEmail.AutoSize = true;
            this.linklblMainMenuEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklblMainMenuEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linklblMainMenuEmail.Location = new System.Drawing.Point(121, 367);
            this.linklblMainMenuEmail.Name = "linklblMainMenuEmail";
            this.linklblMainMenuEmail.Size = new System.Drawing.Size(60, 15);
            this.linklblMainMenuEmail.TabIndex = 6;
            this.linklblMainMenuEmail.TabStop = true;
            this.linklblMainMenuEmail.Text = "Email Me";
            this.toolTip1MainPage.SetToolTip(this.linklblMainMenuEmail, "Any questions or comments?");
            this.linklblMainMenuEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblMainMenuEmail_LinkClicked);
            // 
            // formMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.linklblMainMenuEmail);
            this.Controls.Add(this.btnMainMenuExit);
            this.Controls.Add(this.linklblMainMenuLinkedIn);
            this.Controls.Add(this.btnMainMenuCancelSelection);
            this.Controls.Add(this.btnMainMenuStartFunction);
            this.Controls.Add(this.cmbxMainMenuSelectFunction);
            this.Controls.Add(this.lblMainMenuSelectFunction);
            this.Controls.Add(this.lblMainMenuHeading);
            this.Name = "formMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.formMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenuHeading;
        private System.Windows.Forms.Label lblMainMenuSelectFunction;
        private System.Windows.Forms.ComboBox cmbxMainMenuSelectFunction;
        private System.Windows.Forms.Button btnMainMenuStartFunction;
        private System.Windows.Forms.Button btnMainMenuCancelSelection;
        private System.Windows.Forms.LinkLabel linklblMainMenuLinkedIn;
        private System.Windows.Forms.Button btnMainMenuExit;
        private System.Windows.Forms.LinkLabel linklblMainMenuEmail;
        private System.Windows.Forms.ToolTip toolTip1MainPage;
    }
}

