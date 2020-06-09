using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Standby_Chadha_HFAISSI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            try
            {
                if (double.Parse(textBox3.Text) <= 1 && double.Parse(textBox3.Text) >= 0 && double.Parse(textBox2.Text) >= 0 && double.Parse(textBox2.Text) <= 1)
                {
                    int k = 0;
                    double R = Standby.calcule(double.Parse(textBox1.Text), double.Parse(textBox2.Text), k);
                    while (R < double.Parse(textBox3.Text))
                    {
                        k += 1;
                        R += Standby.calcule(double.Parse(textBox1.Text), double.Parse(textBox2.Text), k);
                    }
                    MessageBox.Show("le nombre de composants est:" + k);
                }
                else MessageBox.Show("vérifier que R* et lamda appartient à [0;1]");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
