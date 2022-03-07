using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ExtraAssignment
{
    public partial class IntMin2Sec : Form
    {
        SelectAFunction SelectAFunction = new SelectAFunction();
        public IntMin2Sec()
        {
            InitializeComponent();
        }

        private void IntMin2Sec_Load(object sender, EventArgs e)
        {
            cmbxSelectFunctionMn2Sc.DataSource = SelectAFunction.selectfunctionArray;
        }

        private void txbxUserInputMn2Sc_TextChanged(object sender, EventArgs e)
        {
            txbxResultMn2Sc.Clear();
        }

        private void btnShowResultMn2Sc_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txbxUserInputMn2Sc.Text, @"^\d+$"))
            {
                try { long inputNum = Convert.ToInt64(txbxUserInputMn2Sc.Text);
                    if (inputNum > 1) { txbxResultMn2Sc.Text = $"{inputNum} minutes are {Convert.ToString(inputNum * 60)} seconds."; }
                    else if (inputNum == 1) { txbxResultMn2Sc.Text = $"{inputNum} minute are {Convert.ToString(inputNum * 60)} seconds."; }
                    else { txbxResultMn2Sc.Text = $"{inputNum} minute is {Convert.ToString(inputNum * 60)} second."; }
                }
                catch (OverflowException oorex) { MessageBox.Show($"{oorex.Message}", "The number is too large!"); }
            }
            else { MessageBox.Show("Please enter only positive integer!", "Input Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } 
        }

        private void linklblMainPageMn2Sc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMainMenu formMainMenu = new formMainMenu();
            formMainMenu.Visible = true;
            this.Visible = false;
        }

        private void linklblExitProgramMn2Sc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.OnFormClosing();
            Application.Exit();
        }

        private void OnFormClosing()
        {
            SelectAFunction.onClosingMsg();
        }

        private void cmbxSelectFunctionMn2Sc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFunctionIndex = cmbxSelectFunctionMn2Sc.SelectedIndex;
            if (selectedFunctionIndex > 0 && selectedFunctionIndex < 9 && selectedFunctionIndex != 1)
            {
                this.Visible = false;
                SelectAFunction.SelectFunction(selectedFunctionIndex);
            }
            else if (selectedFunctionIndex == 1)
            {
                MessageBox.Show("Please select other functions by using the drop down menu to procede!", "Forgot to make a selection?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
