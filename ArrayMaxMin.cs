using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class ArrayMaxMin : Form
    {
        SelectAFunction SelectAFunction = new SelectAFunction();
        StringBuilder eachNumber = new StringBuilder("");
        ArrayList numbers = new ArrayList();
        ArrayList ouputArray = new ArrayList();
        StringBuilder outputSBuilder = new StringBuilder("");

        public ArrayMaxMin()
        {
            InitializeComponent();
            
        }

        private void ArrayMaxMin_Load(object sender, EventArgs e)
        {
            cmbxSelectFunctionArraryMaxMin.DataSource = SelectAFunction.selectfunctionArray;
        }

        private void txbxUserInputArrayMaxMin_Validating(object sender, CancelEventArgs e)
        {
        }

        private void cmbxSelectFunctionArraryMaxMin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFunctionIndex = cmbxSelectFunctionArraryMaxMin.SelectedIndex;
            if (selectedFunctionIndex > 0 && selectedFunctionIndex < 8)
            {
                this.Visible = false;
                SelectAFunction.SelectFunction(selectedFunctionIndex);
            }
            else if(selectedFunctionIndex==8)
            {
                MessageBox.Show("Please select other functions by using the drop down menu to procede!", "Forgot to make a selection?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linklblMainFormArrayMaxMin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMainMenu formMainMenu = new formMainMenu();
            this.Visible = false;
            formMainMenu.Show();
        }

        private void linklblExitArrayMacMin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.OnFormClosing();
            Application.Exit();
            ClearInput();
        }

        private void OnFormClosing()
        {
            SelectAFunction.onClosingMsg();
        }

        private void txbxUserInputArrayMaxMin_TextChanged(object sender, EventArgs e)
        {
            ClearInput();
        }
        public void ClearInput()
        {
            txbxResultArrayMaxMin.Clear();
            eachNumber.Clear();
            numbers.Clear();
            outputSBuilder.Clear();
        }

        private void btnShowResultArrayMaxMin_Click(object sender, EventArgs e)
        {
            ClearInput();
            string userInput = txbxUserInputArrayMaxMin.Text;
            try{int inputLength = userInput.Length;
            int numofDots = 0;
            string builder2arraylist = "";//stringbuilder is mutable that its newly assigned value would overwrite the previous value which all have the same position. When added to arraylist, each of stringbuilder would have the same value, which is the last value
            #region input validation and store data into arraylist
            for (int userInputStringIndex = 0; userInputStringIndex < inputLength; userInputStringIndex++)//validate if current is a digit or dot *dotdigit considered as 0.number only if dot is at the beginning of the input string or after a space
            {
                if (userInputStringIndex < inputLength - 2)//current char position check, needed in case of decimal by the end of inout string
                {
                    if (char.IsDigit(userInput[userInputStringIndex]))
                    {
                        if (char.IsDigit(userInput[userInputStringIndex + 1]))
                        {
                            eachNumber.Append(userInput[userInputStringIndex]);
                        }
                        else if ((userInput[userInputStringIndex + 1] == '.') && (char.IsDigit(userInput[userInputStringIndex + 2])))
                        {
                            if (userInput[0]=='.') { numofDots = 1; }//for situation .56.7
                            if (numofDots ==0)
                            {
                                eachNumber.Append(userInput[userInputStringIndex]);
                                eachNumber.Append(userInput[userInputStringIndex + 1]);
                                userInputStringIndex++;
                                numofDots=1;
                            }
                            else
                            {
                                eachNumber.Append(userInput[userInputStringIndex]);
                                builder2arraylist = eachNumber.ToString();
                                numbers.Add(builder2arraylist);
                                eachNumber = new StringBuilder("0.");
                                userInputStringIndex++;
                            }
                        }
                        else if ((userInput[userInputStringIndex + 1] == '.') && (!char.IsDigit(userInput[userInputStringIndex + 2])))
                        {
                            eachNumber.Append(userInput[userInputStringIndex]);
                            builder2arraylist = eachNumber.ToString();
                            numbers.Add(builder2arraylist);
                            userInputStringIndex++;
                            numofDots = 0;
                            eachNumber.Clear();
                        }
                        else
                        {
                            eachNumber.Append(userInput[userInputStringIndex]);
                            builder2arraylist = eachNumber.ToString();
                            numbers.Add(builder2arraylist);
                            numofDots = 0;
                            eachNumber.Clear();
                        }
                    }
                    else if ((userInput[userInputStringIndex] == '.') && (char.IsDigit(userInput[userInputStringIndex + 1])) && ((userInputStringIndex == 0) || (userInput[userInputStringIndex - 1] == ' ')))
                    {
                        eachNumber.Append('0').Append(userInput[userInputStringIndex]);
                        if (userInputStringIndex != 0) { numofDots = 1; }
                    }
                }
                else if (userInputStringIndex == inputLength - 2)
                {
                    if (char.IsDigit(userInput[userInputStringIndex]))
                    {
                        if (char.IsDigit(userInput[userInputStringIndex + 1]))
                        {
                            eachNumber.Append(userInput[userInputStringIndex]);
                        }
                        else
                        {
                            eachNumber.Append(userInput[userInputStringIndex]);
                            builder2arraylist = eachNumber.ToString();
                            numbers.Add(builder2arraylist);
                            eachNumber.Clear();
                        }
                    }
                    else if ((userInput[userInputStringIndex] == '.') && (char.IsDigit(userInput[userInputStringIndex + 1])) && ((userInputStringIndex == 0)/* || (userInput[userInputStringIndex - 1] == ' ')*/))
                    {
                        eachNumber.Append('0').Append(userInput[userInputStringIndex]);
                    }
                }
                else if ((userInputStringIndex == inputLength - 1) && (char.IsDigit(userInput[userInputStringIndex])))
                {
                    eachNumber.Append(userInput[userInputStringIndex]);
                    builder2arraylist = eachNumber.ToString();
                    numbers.Add(builder2arraylist);
                    eachNumber.Clear();
                }
            }
            #endregion
            #region output and display the result
            if (numbers.Count == 0)
            {
                txbxResultArrayMaxMin.Text = "No valid numbers found, please check the input format and try again.";
                //ClearInput();
            }
            else
            {
                outputSBuilder = new StringBuilder("");
                outputSBuilder.AppendLine($"The number of elements in array is: {numbers.Count}");
                decimal[] nums = new decimal[numbers.Count];
                for (int i = 0; i < numbers.Count; i++)
                {
                    outputSBuilder.AppendLine($"element - {i} : " + numbers[i].ToString());
                    nums[i] = Convert.ToDecimal(numbers[i].ToString());
                }
                decimal max = nums.Max();
                decimal min = nums.Min();
                outputSBuilder.AppendLine($"Maximum element is: {max}");
                outputSBuilder.AppendLine($"Minmum element is: {min}");
                txbxResultArrayMaxMin.Text = outputSBuilder.ToString();
            }
            #endregion
        }catch(OverflowException oorex) { MessageBox.Show($"{oorex.Message}","The number is too large!"); }
        }

        private void txbxResultArrayMaxMin_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
