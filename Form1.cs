namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumber.Text,out int number))
            {
                MessageBox.Show("Enter a valid integer.", "Error");
                return;
            }

            if (number < 0)
            {
                MessageBox.Show("The number should be not negative.", "Error");
                return;
            }
            else
            {
                int factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                lblResult.Text = $"The Factorial of {number} Is: {factorial}";
            }
        }
    }
}
