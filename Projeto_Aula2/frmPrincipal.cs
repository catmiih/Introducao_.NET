using System;
using System.Windows.Forms;

namespace Projeto_Aula2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = Soma(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));

            MessageBox.Show($"O resultado da soma foi {result}");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int result = Subtracao(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            MessageBox.Show($"O resultado da subtração foi {result}");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int result = Multiplicacao(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            MessageBox.Show($"O resultado da multiplicação foi {result}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result = Divisao(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            MessageBox.Show($"O resultado da divisão foi {result}");
        }

        public static int Soma(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtracao(int num1, int num2)
        {
            if(num1 > num2)
                return num1 - num2;
            else 
                return num2 - num1;
        }

        public static int Multiplicacao(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divisao(int num1, int num2)
        {
            if(num1 > num2)
                return num1 / num2;
            else 
                return num2 / num1;
        }

    }
}
