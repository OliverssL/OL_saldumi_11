using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OL_saldumi_11
{
    public partial class Form1 : Form
    {
        double sk1 = 0;
        double cena1 = 0;
        double cena2 = 0;
        double cena3 = 0;
        double cena4 = 0;
        double cena5 = 0;
        double cena = 0;
        double skaits = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Eiro_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        { try
            {
                sk1 = Convert.ToDouble(Eiro.Text);
                cena = (cena1 + cena2 + cena3 + cena4 + cena5) / skaits;
                textBox1.Text = (sk1 / cena).ToString();//izvada rezultatu textBox1 
            }
    
        catch(Exception ex)
        {
                MessageBox.Show("Nebija ievadīti korekti dati");
                MessageBox.Show(ex.Message);
        }
        }

private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void Migle_CheckedChanged(object sender, EventArgs e)
        {
            if (Migle.Checked == true)
            {
                cena2 = 7.49;
                skaits = skaits + 1;
            }
            else 
            {
                cena1 = 9.88;
            }
        }

        private void Rudzupuķe_CheckedChanged(object sender, EventArgs e)
        {
            if (Rudzupuķe.Checked == true)
            {
                cena3 = 12.19;
                skaits = skaits + 1;
            }
            else
            {
                cena1 = 9.88;
            }

        }

        private void Serenāde_CheckedChanged(object sender, EventArgs e)
        {
            if (Serenāde.Checked == true)
            {
                cena4 = 16.99;
                skaits = skaits + 1;
            }
            else
            {
                cena1 = 9.88;
            }
        }

        private void Gotiņa_CheckedChanged(object sender, EventArgs e)
        {
            if (Gotiņa.Checked == true)
            {
                cena5 = 10.69;
                skaits = skaits + 1;
            }
            else
            {
                cena1 = 9.88;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = (sk1 / cena2).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = (cena4 / skaits).ToString();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.Text = (cena3 / skaits).ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = (cena5 / skaits).ToString();
        }
    }
}
