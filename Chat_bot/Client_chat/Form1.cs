using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_chat
{
    public partial class Form1 : Form
    {
        Client client = new Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           listBox1.Items.Add(client.Connect_chat());
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            client.Mess(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            Task.Run(() =>
            {
                while (true)
                {
                    string ms = client.Remess();
                    listBox1.BeginInvoke(new Action(() =>
                    {
                        listBox1.Items.Add(ms);
                    }));
                }
            });
        }
    }
}
