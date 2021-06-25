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

namespace Randnumform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[100];
            Random ra = new Random();
            Mutex mut = new Mutex();
            
            
            Thread tr = new Thread(() =>
              {
                  for (int i = 0; i < arr.Length; i++)
                  {
                      mut.WaitOne();
                      arr[i] = ra.Next(-100, 100);
                      listBox1.Items.Add(arr[i]);
                      label1.Text = ($"Thread {Thread.CurrentThread.ManagedThreadId}");
                      int max = arr[arr.Length - 1];
                      label2.Text = ($"Max number {max}");
                      int min = arr.Min();
                      label3.Text = ($"Min number {min}");
                      mut.ReleaseMutex();


                  }
              });
            
            tr.Start();
            
            
        }
    }
}
