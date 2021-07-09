using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_frends
{
    public partial class Form1 : Form
    {
        Client cl = new Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(cl.ConnectChat());
            Task.Run(() =>
            {
                while (true)
                {
                    string m = cl.ReciveMes();
                    listBox1.BeginInvoke(new Action(() =>
                    {
                        listBox1.Items.Add(m);

                    }));
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl.Messge(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }
    }
}
