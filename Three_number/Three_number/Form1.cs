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

namespace Three_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label4.Text = Thread.CurrentThread.ManagedThreadId.ToString();
            await Task.Factory.StartNew(() => Num(label1));
            label5.Text = Thread.CurrentThread.ManagedThreadId.ToString();
            await Task.Factory.StartNew(() => Num(label2));
            label6.Text = Thread.CurrentThread.ManagedThreadId.ToString();
            await Task.Factory.StartNew(() => Num(label3));
            


        }
        private void Num(Label label)
        {

            for (int i = 0; i < 100; i++)
            {
                int value = Convert.ToInt32(label.Text);
                value++;
                this.BeginInvoke(new Action(() =>
                {
                    label.Text = value.ToString();
                }));
                Thread.Sleep(100);
            }
            
        }
    }
}
