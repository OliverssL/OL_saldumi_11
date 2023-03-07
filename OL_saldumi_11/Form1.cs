using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OL_saldumi_11
{
    public partial class Form1 : Form
    {
        double cena6 = 0;
        double cena7 = 0;
        double cena8 = 0;
        double cena0 = 0;
        double kg1 = 0;
        double kg2 = 0;
        double kg3 = 0;
        double kg4 = 0;
        double sk1 = 0;
        double cena1 = 0;
        double cena2 = 0;
        double cena3 = 0;
        double cena4 = 0;
        double cena5 = 0;
        double cena = 0;
        double skaits = 0;
        private string filepath;

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

            catch (Exception ex)
            {
                MessageBox.Show("Nebija ievadīti korekti dati");
                MessageBox.Show(ex.Message);
            }
            nauda1.Text = (kg4 * cena5).ToString();
            textBox10.Text = (kg2 * cena3).ToString();
            nauda2.Text = (kg3 * cena4).ToString();
            nauda3.Text = (kg1 * cena2).ToString();
            atlikums.Text = (sk1 - cena).ToString();
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
        { try
            {
                if (Migle.Checked == true)
                {
                    cena2 = 7.49;
                    skaits = skaits + 1;
                    kg1 = Convert.ToDouble(textBox4.Text);
                    cena8 = kg1 * cena2;
                }
            }
            catch
            {
                MessageBox.Show("Nebija ievadīti korekti dati");
            }
        }

        private void Rudzupuķe_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Rudzupuķe.Checked == true)
                    cena3 = 12.19;
                skaits = skaits + 1;
                kg2 = Convert.ToDouble(textBox2.Text);
                cena7 = kg2 * cena3;

            }
            catch
            {
                MessageBox.Show("Nebija ievadīti korekti dati");
            }
        }

        private void Serenāde_CheckedChanged(object sender, EventArgs e)
        { try
            {
                if (Serenāde.Checked == true)

                    cena4 = 16.99;
                skaits = skaits + 1;
                kg3 = Convert.ToDouble(textBox3.Text);
                cena5 = kg3 * cena4;

            }
            catch
            {
                MessageBox.Show("Nebija ievadīti korekti dati");
            }
        }

        private void Gotiņa_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Gotiņa.Checked == true)
                    cena5 = 10.69;
                skaits = skaits + 1;
                kg4 = Convert.ToDouble(textBox5.Text);
                cena6 = kg4 * cena5;
            }
            catch
            {
                MessageBox.Show("Nebija ievadīti korekti dati");
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
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                string vards = this.textBox6.Text;
                string kg = this.textBox1.Text;
                string failanosaukums = vards + "_" + DateTime.Now.ToString("ddMMyyyy") + "_ceks.txt";
                StreamWriter musu_faila_ierakstitajs = new StreamWriter(failanosaukums);
                musu_faila_ierakstitajs.WriteLine(vards);
                musu_faila_ierakstitajs.WriteLine(kg);
                musu_faila_ierakstitajs.Close();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void atlikums_TextChanged(object sender, EventArgs e)
        {
            
        }


private void nauda1_TextChanged(object sender, EventArgs e)
        {
            
            string cena = this.nauda1.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string cena = this.textBox10.Text;
        }

        private void nauda2_TextChanged(object sender, EventArgs e)
        {
            string cena = this.nauda2.Text;
        }

        private void nauda3_TextChanged(object sender, EventArgs e)
        {
            string cena = this.nauda3.Text;
        }
    }
}
