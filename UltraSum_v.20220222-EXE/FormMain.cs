using System.Windows.Forms;

namespace Ultra_Sum
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            string a = calculator.getNumberOnly(maskedTextBoxNum1.Text);
            string b = calculator.getNumberOnly(maskedTextBoxNum2.Text);

            if (!calculator.AreInputsVerified(a, b))
            {
                MessageBox.Show("Please check inputs...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (calculator.FindBigOne(a, b) == "b")
            {
                string temp = a;
                a = b;
                b = temp;

                maskedTextBoxNum1.Text = a;
                maskedTextBoxNum2.Text = b;
            }

            string result = "";
            string selectedFunc = "";
            if (radioButtonAdd.Checked)
            {
                selectedFunc = " + ";
                result = calculator.AddNumStrings(a, b);
            }
            else if (radioButtonSubtract.Checked)
            {
                selectedFunc = " - ";
                result = calculator.SubtractNumStrings(a, b);
            }
            else if (radioButtonMultiply.Checked)
            {
                selectedFunc = " x ";
                result = calculator.MultiplyNumStrings(a, b);
            }
            else if (radioButtonDivide.Checked)
            {
                selectedFunc = " ÷ ";
                // Check if the user wants a floating-point result
                if (numericUpDownDecimalPlaces.Value > 0)
                    result = calculator.DivideNumStrings(a, b, (double)numericUpDownDecimalPlaces.Value);
                else
                    result = calculator.DivideNumStrings(a, b);
            }

            textBoxResult.Text = $"Equation : {a}\n{selectedFunc}\n{b}\n=\n{result}\n";
        }


        private void maskedTextBoxNum1_Enter(object sender, EventArgs e)
        {
            maskedTextBoxNum1.SelectAll();
        }

        private void maskedTextBoxNum2_Enter(object sender, EventArgs e)
        {
            maskedTextBoxNum2.SelectAll();
        }

        private void radioButtonDivide_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDecimalPlaces.Enabled = radioButtonDivide.Checked;
        }
    }
}