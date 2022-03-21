using System;
using System.Windows.Forms;

namespace CalculatorTest
{
    public partial class Calculator : Form
    {
        string currentOperation;
        bool IsOperationMode = false;
        int result;

        public Calculator()
        {
            InitializeComponent();
        }

        private void NumberButtonInput(string buttonNumber)
        {
            if (InputBox.Text == "0" || IsOperationMode)
            {
                InputBox.Clear();
            }

            InputBox.Text = InputBox.Text + buttonNumber;
            IsOperationMode = false;
        }
        private void OperationButtonInput(string operationInput)
        {
            if (result != 0)
            {
                ResultButton.PerformClick();
                currentOperation = operationInput;
                IsOperationMode = true;
            }
            else
            {
                currentOperation = operationInput;
                bool success = int.TryParse(InputBox.Text, out result);

                if(!success)
                {
                    InputBox.Text = "Input to large";
                }

                IsOperationMode = true;
            }
        }

        #region button 0-9 click
        private void button1_Click(object sender, EventArgs e)
        {
            NumberButtonInput("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            NumberButtonInput("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            NumberButtonInput("3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            NumberButtonInput("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            NumberButtonInput("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            NumberButtonInput("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            NumberButtonInput("7");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            NumberButtonInput("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            NumberButtonInput("9");
        }
        private void button0_Click(object sender, EventArgs e)
        {
            NumberButtonInput("0");
        }
        #endregion

        #region operationalButtons
        private void AdditionButton_Click(object sender, EventArgs e)
        {
            OperationButtonInput("+");
        }
        private void SubractionButton_Click(object sender, EventArgs e)
        {
            OperationButtonInput("-");
        }
        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            OperationButtonInput("x");
        }
        private void DivisionButton_Click(object sender, EventArgs e)
        {
            OperationButtonInput("/");
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            InputBox.Text = "0";
            result = 0;
        }
        private void ResultButton_Click(object sender, EventArgs e)
        {
            int currentInput;
            string errorMsg = "";
            bool success = int.TryParse(InputBox.Text, out currentInput);

            if (success)
            {
                try
                {
                    if (currentOperation == "+")
                    {
                        result = checked(result + currentInput);
                    }
                    if (currentOperation == "-")
                    {
                        result = checked(result - currentInput);
                    }
                    if (currentOperation == "x")
                    {
                        result = checked(result * currentInput);
                    }
                    if (currentOperation == "/")
                    {
                        if (currentInput == 0)
                        {
                            errorMsg = "Cannot devide";
                        }
                        else
                        {
                            result = checked(result / currentInput);
                        }
                    }
                }
                catch
                {
                    errorMsg = "Result to large";
                }
            }
            else
            {
                errorMsg = "Input to large";
            }

            if (!string.IsNullOrWhiteSpace(errorMsg))
            {
                InputBox.Text = errorMsg;
            }
            else
            {
                InputBox.Text = result.ToString(); 
            }
        }
        #endregion
    }
}
