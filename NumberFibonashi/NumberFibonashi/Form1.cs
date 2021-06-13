using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberFibonashi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);

            int a = 1;
            Action act = () =>
            {
                for (int i = 1; i <= value; i += a)
                {

                    a = i - a;
                    listBox1.Items.Add(i);
                    Thread.Sleep(100);
                }
            };
            act.BeginInvoke(null, null);
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox2.Text);
            int a = 1;
            Action acion = () =>
             {
                 for (int i = 1; i <= value; i += a)
                 {

                     a = i - a;
                     listBox2.Items.Add(i);
                     Thread.Sleep(100);
                 }
             };
            acion.BeginInvoke(null, null);
        }
    }
}
