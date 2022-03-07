using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraAssignment
{
    public class SelectAFunction
    {
        public string[] selectfunctionArray = new string[] 
        {
            "Select the function by using the drop down arrow...",
        "1. Write a function that takes an integer minutes and converts it to seconds.",
        "2. Write a function that takes the base and height of a triangle and return its area.",
        "3. Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.",
        "4. Create a function that returns true if a number is a palindrome.",
        "5. Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.",
        "6. Write a C# Sharp program to check whether a given number is even or odd. ",
        "7. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.",
        "8. Write a program in C# Sharp to find maximum and minimum element in an array."
        };
        public void SelectFunction(int cmbxselectedIndex)
        {
            IntMin2Sec intMin2Sec = new IntMin2Sec();
            TriangleArea triangleArea = new TriangleArea();
            SumLess100 sumLess100 = new SumLess100();
            NumifPalindrome numifPalindrome = new NumifPalindrome();
            RvrStringCase rvrStringCase = new RvrStringCase();
            EvenorOdd evenorOdd = new EvenorOdd();
            StuInfoIO stuInfoIO = new StuInfoIO();
            ArrayMaxMin arrayMaxMin = new ArrayMaxMin();
            if (cmbxselectedIndex != 0)
            {
                //this.Visible = false;//Need to add besides SelectFunction(int cmbxSelectedIndex); + a messagebox.error to notify user to make a selection to procede to different functions
                //"this" referring to current form, which is Main Menu form when program first loaded, then each individual forms after
                switch (cmbxselectedIndex)
                {
                    case 1:
                        intMin2Sec.Show();
                        break;
                    case 2:
                        triangleArea.Show();
                        break;
                    case 3:
                        sumLess100.Show();
                        break;
                    case 4:
                        numifPalindrome.Show();
                        break;
                    case 5:
                        rvrStringCase.Show();
                        break;
                    case 6:
                        evenorOdd.Show();
                        break;
                    case 7:
                        stuInfoIO.Show();
                        break;
                    case 8:
                        arrayMaxMin.Show();
                        break;
                }
            }
        }
        public void onClosingMsg()
        {
            MessageBox.Show("Thank you for using my program. Have a nice day, and take care!", "See you next time!");
        }
    }
}
