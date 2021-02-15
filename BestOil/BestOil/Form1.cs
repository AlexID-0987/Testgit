using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        List<Toplivo> top = Toplivo.GetToplivos();
        Burger b = new Burger(0,0,0);
        Poteyto p = new Poteyto(0, 0, 0);
        Cola c = new Cola(0, 0, 0);
        double cena = 10;
        int koli;
        double summa;
        double globalsumm;
        double summa_a;
        double sum;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kol;
            Toplivo selectedToplivo = listBox1.SelectedItem as Toplivo;
            string info = $"{selectedToplivo.Price}";
            textBox1.Text = info;
            
            
                kol = Convert.ToInt32(textBox2.Text);
                textBox3.Text = $"{kol}";
            
            
            if (radioButton1.Checked)
            {
                sum = kol * selectedToplivo.Price;
                textBox3.Text = $"{sum}";
                label7.Text = $"{sum.ToString()}";

            }
            




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            listBox1.DataSource = top;
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            

            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            textBox4.Text = $"{cena}";
            if (checkBox1.Checked)
            {
                
                koli = Convert.ToInt32(textBox5.Text);
                textBox5.Text = $"{koli}";
                summa = koli * cena;
                //label11.Text = $"{summa.ToString()}";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            b.Cena = 24.56;
            b.Summa = 0;
            textBox6.Text = $"{b.Cena.ToString()}";
            if (checkBox3.Checked)
            {
                b.Kol = Convert.ToInt32(textBox7.Text);
                textBox7.Text = $"{b.Kol}";
                b.Summa = b.Kol * b.Cena;
                //textBox8.Text = $"{b.Summa}";
            }
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            p.Cena = 12.56;
            p.Summa = 0;
            textBox8.Text = $"{p.Cena.ToString()}";
            if (checkBox4.Checked)
            {
                p.Kol = Convert.ToInt32(textBox9.Text);
                textBox9.Text = $"{p.Kol}";
                p.Summa = p.Kol * p.Cena;
                //textBox11.Text = $"{p.Summa}";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            c.Cena = 9.23;
            c.Summa = 0;
            textBox10.Text = $"{c.Cena.ToString()}";
            if (checkBox5.Checked)
            {
                c.Kol = Convert.ToInt32(textBox11.Text);
                textBox11.Text = $"{c.Kol}";
                c.Summa = c.Kol * c.Cena;
                //textBox11.Text = $"{p.Summa}";
            }
            globalsumm = c.Summa + p.Summa + b.Summa + summa;
            label11.Text = $"{globalsumm.ToString()}";
        }


        private void groupBox5_Enter(object sender, EventArgs e)
        {
            //globalsumm = c.Summa + p.Summa + b.Summa + summa;
            //label11.Text = $"{globalsumm.ToString()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            summa_a = globalsumm + sum;
            label12.Text = $"{summa_a.ToString()}";
        }
    }
}
