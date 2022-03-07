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
    public partial class NumifPalindrome : Form
    {
        SelectAFunction SelectAFunction = new SelectAFunction();
        public NumifPalindrome()
        {
            InitializeComponent();
        }

        private void NumifPalindrome_Load(object sender, EventArgs e)
        {
            cmbxSelectFunctionPalindrome.DataSource = SelectAFunction.selectfunctionArray;
        }

        private void txbxUserInputPalindrome_TextChanged(object sender, EventArgs e)
        {
            txbxResultPalindrome.Clear();
        }

        private void btnShowResultPalindrome_Click(object sender, EventArgs e)
        {
            char[] inputCharArray = txbxUserInputPalindrome.Text.ToCharArray();
            if (Regex.IsMatch(txbxUserInputPalindrome.Text, @"^[0-9]+$"))
            {
                try
                {
                    long userInputNum = Convert.ToInt64(txbxUserInputPalindrome.Text);
                    int arrayLength = inputCharArray.Length;
                    int i = 0;
                    foreach (char c in inputCharArray)
                    {
                        if (inputCharArray[i] == inputCharArray[arrayLength - 1 - i]) { i++; }
                    }
                    if (i == arrayLength)
                    { txbxResultPalindrome.Text = $"{txbxUserInputPalindrome.Text} is a Palindrome : True"; }
                    else
                    { txbxResultPalindrome.Text = $"{txbxUserInputPalindrome.Text} is a Palindrome : False"; }
                }
                catch (OverflowException oorex) { MessageBox.Show($"{oorex.Message}", "The number is too large!"); }
            }
            else
            { MessageBox.Show("Please enter only positive integer!", "Input Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            inputCharArray = null;
        }

        private void cmbxSelectFunctionPalindrome_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFunctionIndex = cmbxSelectFunctionPalindrome.SelectedIndex;
            if (selectedFunctionIndex > 0 && selectedFunctionIndex < 9 && selectedFunctionIndex != 4)
            {
                this.Visible = false;
                SelectAFunction.SelectFunction(selectedFunctionIndex);
            }
            else if (selectedFunctionIndex == 4)
            {
                MessageBox.Show("Please select other functions by using the drop down menu to procede!", "Forgot to make a selection?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linklblMainPagePalindrome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMainMenu formMainMenu = new formMainMenu();
            formMainMenu.Visible = true;
            this.Visible = false;
        }

        private void linklblExitProgramPalindrome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.OnFormClosing();
            Application.Exit();
        }

        private void OnFormClosing()
        {
            SelectAFunction.onClosingMsg();
        }
        private void txbxResultPalindrome_TextChanged(object sender, EventArgs e)
        {}
    }
}
