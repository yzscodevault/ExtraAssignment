using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraAssignment
{
    public partial class formMainMenu : Form
    {
        SelectAFunction SelectAFunction = new SelectAFunction();

        public formMainMenu()
        {
            InitializeComponent();
        }

        private void formMainMenu_Load(object sender, EventArgs e)
        {
            cmbxMainMenuSelectFunction.DataSource = SelectAFunction.selectfunctionArray;
        }

        private void cmbxMainMenuSelectFunction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMainMenuStartFunction_Click(object sender, EventArgs e)
        {
            if (cmbxMainMenuSelectFunction.SelectedIndex != 0)
            {
                this.Visible = false;
                SelectAFunction.SelectFunction(cmbxMainMenuSelectFunction.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please make a selection by using the drop down menu to procede!", "Forgot to make a selection?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMainMenuCancelSelection_Click(object sender, EventArgs e)
        {
            cmbxMainMenuSelectFunction.SelectedItem = SelectAFunction.selectfunctionArray[0];
        }

        private void btnMainMenuExit_Click(object sender, EventArgs e)
        {
            this.OnFormClosing();
            this.Close();
        }

        private void OnFormClosing()
        {
            SelectAFunction.onClosingMsg();
        }

        private void linklblMainMenuContactUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.linklblMainMenuContactUs.LinkVisited = true;//if want to change the color for the link visited
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/yang-zhang-1318a6228/");//hardcode
        }

        private void linklblMainMenuEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Mailto:zhangmssa@outlook.com");//if want to send email
        }
    }
}
