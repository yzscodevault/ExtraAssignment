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
    public partial class SumLess100 : Form
    {
        SelectAFunction SelectAFunction = new SelectAFunction();
        string numberPattern = @"^\-?\d+\.?\d+$";
        //string numberPattern = @"^-?\d+(\.\d+)?*$";@"^-?\d*(\.\d+)?*$"
        public SumLess100()
        {
            InitializeComponent();
        }

        private void SumLess100_Load(object sender, EventArgs e)
        {
            cmbxSumLess100GoToOther.DataSource = SelectAFunction.selectfunctionArray;
        }

        private void txbxSumLess100Num1_TextChanged(object sender, EventArgs e)
        {
            txbxSumLess100Result.Clear();
        }
        private void txbxSumLess100Num2_TextChanged(object sender, EventArgs e)
        {
            txbxSumLess100Result.Clear();
        }

        private void btnSumLess_Click(object sender, EventArgs e)
        {
            
            if ((Regex.IsMatch(txbxSumLess100Num1.Text, numberPattern)) && (Regex.IsMatch(txbxSumLess100Num2.Text, numberPattern)))
            {
                try
                {
                    decimal i = Convert.ToDecimal(txbxSumLess100Num1.Text);
                    decimal j = Convert.ToDecimal(txbxSumLess100Num2.Text);
                    bool r = ((i + j) < 100);
                    txbxSumLess100Result.Text = Convert.ToString(r);
                }
                catch (OverflowException oorex) { MessageBox.Show($"{oorex.Message}", "The number is too large!"); }
            }
            else if (!Regex.IsMatch(txbxSumLess100Num1.Text, numberPattern))
            {
                MessageBox.Show("Numbers only contain digits, retry for the first number!", "Format Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbxSumLess100Num1.Clear();
            }
            else if (!Regex.IsMatch(txbxSumLess100Num2.Text, numberPattern))
            {
                MessageBox.Show("Numbers only contain digits, retry for the second number!", "Format Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbxSumLess100Num2.Clear();
            }
            else if ((txbxSumLess100Num1.Text == "") || (txbxSumLess100Num2.Text == ""))
            {
                MessageBox.Show("Both numbers must be provided to perform this function!", "Empty Field Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linklblSumLess100GoMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMainMenu formMainMenu = new formMainMenu();
            this.Visible = false;
            formMainMenu.Show();
        }

        private void linklblSumLess100Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.OnFormClosing();
            Application.Exit();
        }

        private void OnFormClosing()
        {
            SelectAFunction.onClosingMsg();
        }

        private void cmbxSumLess100GoToOther_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFunctionIndex = cmbxSumLess100GoToOther.SelectedIndex;
            if (selectedFunctionIndex > 0 && selectedFunctionIndex < 9 && selectedFunctionIndex != 3)
            {
                this.Visible = false;
                SelectAFunction.SelectFunction(selectedFunctionIndex);
            }
            else if (selectedFunctionIndex == 3)
            {
                MessageBox.Show("Please select other functions by using the drop down menu to procede!", "Forgot to make a selection?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
