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
    public partial class RvrStringCase : Form
    {
        SelectAFunction SelectAFunction = new SelectAFunction();
        public RvrStringCase()
        {
            InitializeComponent();
        }

        private void RvrStringCase_Load(object sender, EventArgs e)
        {
            cmbxSelectFunctionRvsSqcNCase.DataSource = SelectAFunction.selectfunctionArray;
        }

        private void txbxUserInpuRvsSqcNCase_TextChanged(object sender, EventArgs e)
        {
            txbxResultRvsSqcNCase.Clear();
        }

        private void btnShowResultRvsSqcNCase_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txbxUserInpuRvsSqcNCase.Text, @"[\w+\s*]")&&(!string.IsNullOrWhiteSpace(txbxUserInpuRvsSqcNCase.Text)))
            {
                try
                {
                    char[] inputArray = txbxUserInpuRvsSqcNCase.Text.ToCharArray();
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        if (char.IsUpper(inputArray[i]))
                        {
                            inputArray[i]=char.ToLower(inputArray[i]);
                        }
                        else
                        {
                            inputArray[i] = char.ToUpper(inputArray[i]);
                        }
                    }
                    //txbxResultRvsSqcNCase.Text = string.Join("", inputArray.Reverse());//if also want to reverse the sequence
                    txbxResultRvsSqcNCase.Text = string.Join("", inputArray);
                }
                catch (OverflowException oorex) { MessageBox.Show($"{oorex.Message}", "The string is too long!"); }
            }
            else { MessageBox.Show("Please enter only letters with or withour spaces!", "Input Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmbxSelectFunctionRvsSqcNCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFunctionIndex = cmbxSelectFunctionRvsSqcNCase.SelectedIndex;
            if (selectedFunctionIndex > 0 && selectedFunctionIndex < 9 && selectedFunctionIndex != 5)
            {
                this.Visible = false;
                SelectAFunction.SelectFunction(selectedFunctionIndex);
            }
            else if (selectedFunctionIndex == 5)
            {
                MessageBox.Show("Please select other functions by using the drop down menu to procede!", "Forgot to make a selection?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linklblMainPageRvsSqcNCase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMainMenu formMainMenu = new formMainMenu();
            formMainMenu.Visible = true;
            this.Visible = false;
        }

        private void linklblExitProgramRvsSqcNCase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.OnFormClosing();
            Application.Exit();
        }

        private void OnFormClosing()
        {
            SelectAFunction.onClosingMsg();
        }
    }
}
