
using System;
using System.Windows.Forms;

namespace FinalWinFormsCalcApp
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool operationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationPerformed))
                textBox1.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(textBox1.Text);
            operationPerformed = true;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (textBox1.Text != "0")
                        textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    else
                        MessageBox.Show("Ошибка: Деление на ноль");
                    break;
            }
        }
    }
}
