using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();

            cmbOperator.Items.Add("+");
            cmbOperator.Items.Add("-");
            cmbOperator.Items.Add("/");
            cmbOperator.Items.Add("x");

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" && txtNum2.Text == "")
            {
                MessageBox.Show("Invalid Input");
            }

            else if (cmbOperator.Text == "")
            {
                MessageBox.Show("Invalid Operator");
            }

            else
            {

                float num1 = (float)Convert.ToDouble(txtNum1.Text);
                float num2 = (float)Convert.ToDouble(txtNum2.Text);

                if (cmbOperator.Text == "+")
                {
                    listView1.Items.Clear();
                    float computed = BasicComputation.Addition(num1, num2);
                    string end = computed.ToString();
                    listView1.Items.Add("Total: " + end);
                }

                else if (cmbOperator.Text == "-")
                {
                    listView1.Items.Clear();
                    float computed = BasicComputation.Subtraction(num1, num2);
                    string end = computed.ToString();
                    listView1.Items.Add("Total: " + end);
                }

                else if (cmbOperator.Text == "x")
                {
                    listView1.Items.Clear();
                    float computed = BasicComputation.Multiplication(num1, num2);
                    string end = computed.ToString();
                    listView1.Items.Add("Total: " + end);
                }

                else if (cmbOperator.Text == "/")
                {
                    listView1.Items.Clear();
                    float computed = BasicComputation.Division(num1, num2);
                    string end = computed.ToString();
                    listView1.Items.Add("Total: " + end);
                }
            }
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            listView1.Items.Add("Total: " + Environment.NewLine + "");
        }
    }
}