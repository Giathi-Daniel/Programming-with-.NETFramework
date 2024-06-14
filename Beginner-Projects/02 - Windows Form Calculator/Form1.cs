namespace _02___Windows_Form_Calculator
{
    public partial class Form1 : Form
    {
        double firstNumber, secondNumber;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out firstNumber))
            {
                Button button = (Button)sender;
                operation = button.Text;
                txtDisplay.Text += " " + operation + ""; 
            } else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisplay.Clear();
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string[] parts = txtDisplay.Text.Split(' ');
            if (parts.Length == 3 && double.TryParse(parts[2], out secondNumber))
            {
                switch (operation)
                {
                    case "+":
                        txtDisplay.Text = (firstNumber + secondNumber).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (firstNumber - secondNumber).ToString();
                        break;
                    case "*":
                        txtDisplay.Text = (firstNumber * secondNumber).ToString();
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            txtDisplay.Text = (firstNumber / secondNumber).ToString();
                        } else
                        {
                            MessageBox.Show("Cannot divide by zero.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "%":
                        txtDisplay.Text = (firstNumber % secondNumber).ToString();
                        break;
                }
            } else
            {
                MessageBox.Show("Please enter a valid number. ", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            firstNumber = secondNumber = 0;
        }
    }
}
