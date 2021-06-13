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

namespace Progressbarsport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500; 
            timer1.Enabled = false;
            timer1.Tick += button1_Click;
            timer2.Interval = 900;
            timer2.Enabled = false;
            timer2.Tick += button1_Click;
            timer3.Interval = 1200;
            timer3.Enabled = false;
            timer3.Tick += button1_Click;
            timer4.Interval = 1500;
            timer4.Enabled = false;
            timer4.Tick += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);
            int value1 = Convert.ToInt32(textBox2.Text);
            int value2 = Convert.ToInt32(textBox3.Text);
            int value3 = Convert.ToInt32(textBox4.Text);
            Action action1 = () =>
            {
                for (int i = 0; true; i++)
                {
                    progressBar1.PerformStep();
                    
                    Thread.Sleep(value);
                }

            };
            action1.BeginInvoke(null, null);
            Action action = () =>
            {
                for (int i = 0; true; i++)
                {
                    progressBar2.PerformStep();

                    Thread.Sleep(value1);
                }

            };
            action.BeginInvoke(null, null);
            Action action2 = () =>
            {
                for (int i = 0; true; i++)
                {
                    progressBar3.PerformStep();

                    Thread.Sleep(value2);
                }

            };
            action2.BeginInvoke(null, null);
            Action action3 = () =>
            {
                for (int i = 0; true; i++)
                {
                    progressBar4.PerformStep();

                    Thread.Sleep(value3);
                }

            };
            action3.BeginInvoke(null, null);
        }
    }
}
