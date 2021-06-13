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

namespace ProgressbarThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            timer2.Interval = 100; 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            timer3.Interval = 1000;
            timer3.Enabled = true;
            timer3.Tick += timer3_Tick;
            timer4.Interval = 700;
            timer4.Enabled = true;
            timer4.Tick += timer4_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Action action = () =>
             {
                 progressBar2.PerformStep();
                 Thread.Sleep(1000);

             };
            action.BeginInvoke(null, null);
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Action actions = () =>
            {
                progressBar3.PerformStep();
                Thread.Sleep(5000);

            };
            actions.BeginInvoke(null, null);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Action actions = () =>
            {
                progressBar4.PerformStep();
                Thread.Sleep(500);

            };
            actions.BeginInvoke(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Action action1 = () =>
             {
                 for (int i = 0; true; i++)
                 {
                     listBox1.Items.Add(i);
                     Thread.Sleep(50);
                 }
                 
             };
            action1.BeginInvoke(null, null);
        }
    }
}
