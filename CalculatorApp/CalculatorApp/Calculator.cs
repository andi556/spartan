using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        double Number;
        double Result = 0;
        string operation;
        bool isOperator = false;
        string numberValue;
        List<string> operationsList = new List<string>();
        List<string> numbersList = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "." };
        List<string> operatorList = new List<string> { "+", "-", "=", "/", "x" };

        public Calculator()
        {
            operation = "";
            InitializeComponent();
            buttonEqual.Focus();
        }

        private void ButtonOperation_Click(object sender, EventArgs e)
        {
            operationsList.Add(textBoxResult.Text);
            isOperator = true;
            Button b = sender as Button;
            if (String.IsNullOrEmpty(textBoxExecution.Text))
            {
                textBoxExecution.Text = textBoxResult.Text + b.Text;
            }
            else
            {
                textBoxExecution.Text += textBoxResult.Text + b.Text;
            }
            if (String.IsNullOrEmpty(operation))
            {
                operation = b.Text;
                Result = Convert.ToDouble(textBoxResult.Text);
            }
            else
            {
                Number = Convert.ToDouble(textBoxResult.Text);

                Calculate(operation);

                textBoxResult.Text = Convert.ToString(Result);
                operation = b.Text;
            }
            operationsList.Add(b.Text);
            buttonEqual.Focus();
        }

        private void ButtonDecimalDot_Click(object sender, EventArgs e)
        {
            if(!textBoxResult.Text.Contains("."))
                textBoxResult.AppendText(".");
            buttonEqual.Focus();
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            Number = Convert.ToDouble(textBoxResult.Text);

            Calculate(operation);
            
            textBoxResult.Text = Convert.ToString(Result);
            Number = Result;
            textBoxExecution.Text = "";
            isOperator = false;
            operation = "";
            buttonEqual.Focus();
        }

        private void Calculate(string operation)
        {
            if (operation == "+")
            {
                Result = (Result + Number);
            }
            if (operation == "-")
            {
                Result = (Result - Number);
            }
            if (operation == "x")
            {
                Result = (Result * Number);
            }
            if (operation == "/")
            {
                if (Number == 0)
                {
                    textBoxResult.Text = "Cannot divide by zero";
                    return;
                }
                else
                {
                    Result = (Result / Number);
                }
            }
            if (operation == "%")
            {
                Result = (Result * Number) / 100;
            }
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            buttonEqual.Focus();
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            textBoxExecution.Text = "";
            Result = 0;
            isOperator = false;
            buttonEqual.Focus();
            operationsList.RemoveRange(0, operationsList.Count);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length > 1)
            {
                textBoxResult.Text = textBoxResult.Text.Substring(0, textBoxResult.Text.Length - 1);
            }
            else
            {
                textBoxResult.Text = "0";
            }
            buttonEqual.Focus();
        }

        private void ButtonNumbers_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = b.Text;
            }
            else
            { 
                if (isOperator)
                {
                    textBoxResult.Text = b.Text;
                    isOperator = false;
                }
                else
                {
                    textBoxResult.AppendText(b.Text);
                }
            }
            buttonEqual.Focus();
        }

        private void ButtonNumbers_Click(string value)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = value;
            }
            else
            {
                if (isOperator)
                {
                    textBoxResult.Text = value;
                    isOperator = false;
                }
                else
                {
                    textBoxResult.AppendText(value);
                }
            }
            operationsList.Add(value);
            buttonEqual.Focus();
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    button0.PerformClick();
                    break;
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button2.PerformClick();
                    break;
                case Keys.NumPad3:
                    button3.PerformClick();
                    break;
                case Keys.NumPad4:
                    button4.PerformClick();
                    break;
                case Keys.NumPad5:
                    button5.PerformClick();
                    break;
                case Keys.NumPad6:
                    button6.PerformClick();
                    break;
                case Keys.NumPad7:
                    button7.PerformClick();
                    break;
                case Keys.NumPad8:
                    button8.PerformClick();
                    break;
                case Keys.NumPad9:
                    button9.PerformClick();
                    break;
                case Keys.Add:
                    buttonAdd.PerformClick();
                    break;
                case Keys.Subtract:
                    buttonSubstract.PerformClick();
                    break;
                case Keys.Multiply:
                    buttonMultiply.PerformClick();
                    break;
                case Keys.Divide:
                    buttonDivision.PerformClick();
                    break;
                case Keys.Return:
                    buttonEqual.PerformClick();
                    break;
                case Keys.Decimal:
                    buttonDecimalDot.PerformClick();
                    break;
                default:
                    if (e.KeyData == (Keys.Control | Keys.Z))
                    {
                        Undo();
                    }
                    break;
            };
        }

        private void Undo()
        {
            string execution = "";
            Number = 0;
            operation = "";
            Result = 0;
            if (operationsList.Count > 0)
            {
                if (textBoxResult.Text.Length > 1)
                {
                    string croppedValue = textBoxResult.Text.Substring(0, textBoxResult.Text.Length - 1);
                    if (!String.IsNullOrEmpty(croppedValue))
                    {
                        operationsList[operationsList.Count - 1] = croppedValue;
                        textBoxResult.Text = croppedValue;
                    }
                    else
                    {
                        operationsList[operationsList.Count - 1] = "0";
                        textBoxResult.Text = "0";
                    }
                }
                else
                {
                    operationsList.RemoveAt(operationsList.Count - 1);
                    foreach (string str in operationsList)
                    {
                        if (numbersList.Any(s => str.Contains(s)))
                        {
                            if (isOperator)
                            {
                                numberValue = str;
                                Number = Convert.ToDouble(numberValue);
                                isOperator = false;
                            }
                            else
                            {
                                numberValue += str;
                                Result = Convert.ToDouble(numberValue);
                            }
                            
                        }
                        else
                            if (operatorList.Any(s => str.Contains(s)))
                            {
                                isOperator = true;
                                if (String.IsNullOrEmpty(operation))
                                {
                                    operation = str;
                                    Result = Convert.ToDouble(numberValue);
                                }
                                else
                                {
                                    Number = Convert.ToDouble(numberValue);

                                    Calculate(operation);
                                    operation = str;
                                }
                            }
                        execution += str;
                    }
                    Calculate(operation);
                    textBoxResult.Text = Convert.ToString(Result);
                    textBoxExecution.Text = execution;
                }
            }
            buttonEqual.Focus();
        }
    }
}
