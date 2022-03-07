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
    public partial class TriangleArea : Form
    {
        SelectAFunction SelectAFunction = new SelectAFunction();
        public TriangleArea()
        {
            InitializeComponent();
        }

        private void TriangleArea_Load(object sender, EventArgs e)
        {
            cmbxSelectFunctionTriAr.DataSource = SelectAFunction.selectfunctionArray;
        }

        private void txbxUserInputTriBaseTriAr_TextChanged(object sender, EventArgs e)
        {
            txbxResultTriAr.Clear();
        }

        private void txbxUserInputTriHgtTriAr_TextChanged(object sender, EventArgs e)
        {
            txbxResultTriAr.Clear();
        }

        private void btnShowResultTriAr_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(txbxUserInputTriHgtTriAr.Text, @"^\d+(.\d+)?$")) &(Regex.IsMatch(txbxUserInputTriBaseTriAr.Text, @"^\d+(.\d+)?$")))
            {
                try
                {
                    decimal inputHght = Convert.ToDecimal(txbxUserInputTriHgtTriAr.Text);
                    decimal inputBase = Convert.ToDecimal(txbxUserInputTriBaseTriAr.Text);
                    txbxResultTriAr.Text = Convert.ToString($"The area of the triangle is {inputBase * inputHght / 2}");
                }
                catch (OverflowException oorex) { MessageBox.Show($"{oorex.Message}", "The number is too large!"); }
            }
            else { MessageBox.Show("Please enter only digits for height and base of the triangle!", "Input Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmbxSelectFunctionTriAr_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFunctionIndex = cmbxSelectFunctionTriAr.SelectedIndex;
            if (selectedFunctionIndex > 0 && selectedFunctionIndex < 9 && selectedFunctionIndex != 2)
            {
                this.Visible = false;
                SelectAFunction.SelectFunction(selectedFunctionIndex);
            }
            else if (selectedFunctionIndex == 2)
            {
                MessageBox.Show("Please select other functions by using the drop down menu to procede!", "Forgot to make a selection?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linklblMainPageTriAr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMainMenu formMainMenu = new formMainMenu();
            formMainMenu.Visible = true;
            this.Visible = false;
        }

        private void linklblExitProgramTriAr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
