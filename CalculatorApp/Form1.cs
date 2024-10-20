namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        String equation = ""; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
            {
                textBox_Result.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button10.PerformClick(); 
                operationPerformed = button.Text;

                equation = resultValue + " " + operationPerformed;
                labelOperation.Text = equation;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text); 

                equation = resultValue + " " + operationPerformed;
                labelOperation.Text = equation;
            }

            isOperationPerformed = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            equation = ""; 
            labelOperation.Text = ""; 
        }

        private void button10_Click(object sender, EventArgs e) 
        {
            Double secondValue;
            try
            {
                secondValue = Double.Parse(textBox_Result.Text); 
            }
            catch
            {
                MessageBox.Show("Invalid input");
                return;
            }

            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + secondValue).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - secondValue).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * secondValue).ToString();
                    break;
                case "/":
                    if (secondValue != 0)
                    {
                        textBox_Result.Text = (resultValue / secondValue).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Undefined");
                        textBox_Result.Text = "0";
                    }
                    break;
                default:
                    break;
            }

            equation += " " + secondValue + " = " + textBox_Result.Text;
            labelOperation.Text = equation;

            resultValue = Double.Parse(textBox_Result.Text); 
            operationPerformed = "";
            isOperationPerformed = true;
        }
    }
}
