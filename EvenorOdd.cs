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
    public partial class EvenorOdd : Form
    {
        SelectAFunction SelectAFunction=new SelectAFunction();
        public EvenorOdd()
        {
            InitializeComponent();
        }

        private void EvenorOdd_Load(object sender, EventArgs e)
        {
            cmbxSelectFunctionEvenorOdd.DataSource = SelectAFunction.selectfunctionArray;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txbxResultEvenorOdd.Clear();
        }

        private void btnShowResultEvenorOdd_Click(object sender, EventArgs e)
        {
            bool chkInputisDigi = (Regex.IsMatch(txbxUserInputEvenorOdd.Text, @"^\d+(\.)??\d+$"));
            if (chkInputisDigi)
            {
                try
                {
                    decimal inputNumber = Convert.ToDecimal(txbxUserInputEvenorOdd.Text);
                    if (inputNumber % 2 == 0)
                    {
                        txbxResultEvenorOdd.Text = txbxUserInputEvenorOdd.Text + " is an Even number.";
                    }
                    else
                    {
                        txbxResultEvenorOdd.Text = txbxUserInputEvenorOdd.Text + " is an Odd number.";
                    }
                }
                catch (OverflowException oorex) { MessageBox.Show($"{oorex.Message}", "The number is too large!"); }
            }
            else
            {
                MessageBox.Show("Please enter a valid number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbxSelectFunctionEvenorOdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFunctionIndex = cmbxSelectFunctionEvenorOdd.SelectedIndex;
            if (selectedFunctionIndex > 0 && selectedFunctionIndex < 9 && selectedFunctionIndex!=6)
            {
                this.Visible = false;
                SelectAFunction.SelectFunction(selectedFunctionIndex);
            }
            else if (selectedFunctionIndex == 6)
            {
                MessageBox.Show("Please select other functions by using the drop down menu to procede!", "Forgot to make a selection?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linklblMainPageEvenorOdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMainMenu formMainMenu = new formMainMenu();
            formMainMenu.Visible = true;
            this.Visible = false;
        }

        private void linklblExitProgramEvenorOdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
