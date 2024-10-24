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
            if (!long.TryParse(txtNumber.Text,out long number))
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
                long factorial = 1;
                for (int i = 1; i <= number; i++)
                {

                    if (factorial > long.MaxValue / i)
                    {
                        MessageBox.Show("The number is to much bigger to calculate the factorial", "Error");
                        return;
                    }
                    factorial *= i;
                }

                lblResult.Text = $"The Factorial of {number} Is: {factorial}";
            }
        }
    }
}
