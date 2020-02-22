using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            string Inumb1, Inumb2;
            double numb1, numb2, result;
            Inumb1 = Convert.ToString(textBox1.Text);
            Inumb2 = Convert.ToString(textBox2.Text);

            if (!double.TryParse(Inumb1, out numb1))
            {
                a = 1;
                textBox3.Text = "请在第一个数字框中输入数字";
            }
            if (!double.TryParse(Inumb2, out numb2))
            {
                b = 1;
                textBox3.Text = "请在第二个数字框中输入数字";
            }
            if (a + b == 2)
            {
                textBox3.Text = "请在两个数字框中输入数字";
            }
            switch (comboBox1.Text)
            {
                case "+":
                    result = numb1 + numb2;
                    textBox3.Text = result.ToString();
                    break;
                case "-":
                    result = numb1 - numb2;
                    textBox3.Text = result.ToString();
                    break;
                case "*":
                    result = numb1 * numb2;
                    textBox3.Text = result.ToString();
                    break;
                case "/":
                    if (numb2 != 0)
                    {
                        result = numb1 / numb2;
                        textBox3.Text = result.ToString();
                    }
                    else
                        textBox3.Text = "除数不能为0";
                    break;
            }

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
