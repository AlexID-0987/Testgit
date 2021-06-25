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

namespace Numberarr
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
            Mutex mu = new Mutex();
            Thread t = new Thread(() =>
            {
                int a = 1000;
                for (int i = 0; i < a; i++)
                {
                    mu.WaitOne();
                    listBox1.Items.Add(i);
                    label1.Text = ($"Thread {Thread.CurrentThread.ManagedThreadId}");
                    mu.ReleaseMutex();

                }
            });
            t.Start();
            
              

                  for (int i = 1000; i > 0; i--)
                  {
                      mu.WaitOne();
                      listBox2.Items.Add(i);
                      label2.Text = ($"Thread {Thread.CurrentThread.ManagedThreadId}");
                      mu.ReleaseMutex();
                  }
              
            


        }
    }
}
