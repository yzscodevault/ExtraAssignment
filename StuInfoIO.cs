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
    public partial class StuInfoIO : Form
    {
        SelectAFunction SelectAFunction = new SelectAFunction();
        public StuInfoIO()
        {
            InitializeComponent();
        }

        private void StuInfoIO_Load(object sender, EventArgs e)
        {
            cmbxSelectFunctionStuInfoIO.DataSource = SelectAFunction.selectfunctionArray;
        }

        private void btnShowResultStuInfoIO_Click(object sender, EventArgs e)
        {
            string rllInptStr= txbxRllNoStuInfoIO.Text;
            string nameInptStr= txbxNameStuInfoIO.Text;
            string physicsMkInptStr= txbxPhysicsMkStuInfoIO.Text;
            string chemistryMkInptStr= txbxChemistryMkStuInfoIO.Text;
            string cmpAppMkInptStr= txbxCompAppMkStuInfoIO.Text;
            bool validrll = Regex.IsMatch(rllInptStr, @"[1-9]");
            bool validname = Regex.IsMatch(nameInptStr, @"^[a-zA-z]+(\s[a-zA-z]+)*\.?$");
            bool validphysics = Regex.IsMatch(physicsMkInptStr, @"^\d+(\.[0-9][0-9]?)?$");
            bool validchem = Regex.IsMatch(chemistryMkInptStr, @"^\d+(\.[0-9][0-9]?)?$");
            bool validCompApp = Regex.IsMatch(cmpAppMkInptStr, @"^\d+(\.[0-9][0-9]?)?$");
            bool allValiFormat = validrll & validname & validphysics & validchem & validCompApp;
            if (allValiFormat)
            {
                try
                {
                    decimal physicsMk = Convert.ToDecimal(physicsMkInptStr);
                    decimal chemistryMk = Convert.ToDecimal(chemistryMkInptStr);
                    decimal cmpAppMk = Convert.ToDecimal(cmpAppMkInptStr);
                    validphysics = physicsMk < 101;
                    validchem = chemistryMk < 101;
                    validCompApp = cmpAppMk < 101;
                    bool allValidScore = (validphysics & validchem & validCompApp);
                    StringBuilder txbxrsltSB = new StringBuilder();
                    if (allValidScore)
                    {
                        decimal total = physicsMk + chemistryMk + cmpAppMk;
                        decimal percentage = Math.Round(total / 3, 2);
                        String division;
                        if (percentage < 26m) { division = "Forth"; }
                        else if (percentage < 51m) { division = "Third"; }
                        else if (percentage < 76m) { division = "Second"; }
                        else { division = "First"; }
                        txbxrsltSB.AppendLine($"Roll No : {rllInptStr}");
                        txbxrsltSB.AppendLine($"Name of Student : {nameInptStr}");
                        txbxrsltSB.AppendLine($"Marks in Physics : {physicsMk}");
                        txbxrsltSB.AppendLine($"Marks in Chemistry : {chemistryMk}");
                        txbxrsltSB.AppendLine($"Marks in Computer Application : {cmpAppMk}");
                        txbxrsltSB.AppendLine($"Total Marks = {total}");
                        txbxrsltSB.AppendLine($"Percentage = {percentage}");
                        txbxrsltSB.AppendLine($"Division = {division}");
                        txbxResultStuInfoIO.Text = txbxrsltSB.ToString();
                    }
                    else { MessageBox.Show("Please enter valid scores! Scores are 0-100 with optional 2 decimal points", "Invalid Marks Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch (OverflowException oorex) { MessageBox.Show($"{oorex.Message}", "The value is too big!"); }
            }
            else { MessageBox.Show("Please input values with correct format!", "Input Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void txbxRllNoStuInfoIO_TextChanged(object sender, EventArgs e)
        {
            txbxResultStuInfoIO.Clear();
        }

        private void txbxNameStuInfoIO_TextChanged(object sender, EventArgs e)
        {
            txbxResultStuInfoIO.Clear();
        }

        private void txbxPhysicsMkStuInfoIO_TextChanged(object sender, EventArgs e)
        {
            txbxResultStuInfoIO.Clear();
        }

        private void txbxChemistryMkStuInfoIO_TextChanged(object sender, EventArgs e)
        {
            txbxResultStuInfoIO.Clear();
        }

        private void txbxCompAppMkStuInfoIO_TextChanged(object sender, EventArgs e)
        {
            txbxResultStuInfoIO.Clear();
        }

        private void cmbxSelectFunctionStuInfoIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFunctionIndex = cmbxSelectFunctionStuInfoIO.SelectedIndex;
            if (selectedFunctionIndex > 0 && selectedFunctionIndex < 9 && selectedFunctionIndex != 7)
            {
                this.Visible = false;
                SelectAFunction.SelectFunction(selectedFunctionIndex);
            }
            else if (selectedFunctionIndex == 7)
            {
                MessageBox.Show("Please select other functions by using the drop down menu to procede!", "Forgot to make a selection?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linklblMainPageStuInfoIO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMainMenu formMainMenu = new formMainMenu();
            formMainMenu.Visible = true;
            this.Visible = false;
        }

        private void linklblExitProgramStuInfoIO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
