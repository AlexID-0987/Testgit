using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int val = 0;
            int rez;
            string[] second = Directory.GetFiles(name); 

            for (int i = 0; i < second.Length; i++)
            {
                listBox1.Items.Add(second[i]);
            }
            
            while (val<second.Length)
            {
                
                rez = val++;
                label2.Text = rez.ToString();
                
                
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Action act = () =>
             {
                 for (int i = 0; true; i++)
                 {
                     listBox2.Items.Add(i * 2);
                     Thread.Sleep(100);
                 }
             };
            act.BeginInvoke(null, null);
        }
    }
}
