using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_teste
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = 1;
            txt_caixa.Text = txt_caixa.Text + a.ToString(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_result_Click(object sender, EventArgs e)
        {
            DataTable a = new DataTable();
            if (txt_caixa.Text != "")
            {
                string expressao = txt_caixa.Text;
                expressao = expressao.Replace(',', '.');
                double resultado = Convert.ToDouble(a.Compute(expressao, null));
                result.Text = resultado.ToString();
            }
            
            

        }

        private void lb_2_Click(object sender, EventArgs e)
        {
            
            int a = 2;
            txt_caixa.Text = txt_caixa.Text + a.ToString();
        }

        private void lb_mais_Click(object sender, EventArgs e)
        {
            string s = "+";
            txt_caixa.Text = txt_caixa.Text + s.ToString();
        }

        private void lb_3_Click(object sender, EventArgs e)
        {
            int a = 3;
            txt_caixa.Text = txt_caixa.Text + a.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_caixa.Clear();
        }

        private void lb_4_Click(object sender, EventArgs e)
        {
            int a = 4;
            txt_caixa.Text = txt_caixa.Text + a.ToString();
        }

        private void lb_5_Click(object sender, EventArgs e)
        {
            int a = 5;
            txt_caixa.Text = txt_caixa.Text + a.ToString();
        }

        private void lb_6_Click(object sender, EventArgs e)
        {
            int a = 6;
            txt_caixa.Text = txt_caixa.Text + a.ToString();
        }

        private void lb_7_Click(object sender, EventArgs e)
        {
            int a = 7;
            txt_caixa.Text = txt_caixa.Text + a.ToString();
        }

        private void lb_8_Click(object sender, EventArgs e)
        {
            int a = 8;
            txt_caixa.Text = txt_caixa.Text + a.ToString();
        }

        private void lb_9_Click(object sender, EventArgs e)
        {
            int a = 9;
            txt_caixa.Text = txt_caixa.Text + a.ToString();
        }

        private void lb_menos_Click(object sender, EventArgs e)
        {
            string s = "-";
            txt_caixa.Text = txt_caixa.Text + s.ToString();
        }

        private void lb_mult_Click(object sender, EventArgs e)
        {
            string s = "*";
            txt_caixa.Text = txt_caixa.Text + s.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "/";
            txt_caixa.Text = txt_caixa.Text + s.ToString();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            txt_caixa.Text = txt_caixa.Text + a.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = ".";
            txt_caixa.Text = txt_caixa.Text + a;
        }
    }
}
