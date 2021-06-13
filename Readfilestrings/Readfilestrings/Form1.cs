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

namespace Readfilestrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sl = Convert.ToString(textBox1.Text);
            string str = File.ReadAllText("New.txt");
            textBox2.Text = str;
            int count = -1;
            Action action = () =>
              {
                  if (str.Contains(sl))
                  {
                      label2.Text = "Текст содержит слово" + sl;
                  }
                  else
                  {
                      label2.Text = "В тексте нет искомого слова" + sl;
                  }
              };
            action.BeginInvoke(null, null);
            int a = -1;
            int i = 0;
            Action act = () =>
              {


                  while (i != -1)
                  {
                      i = str.IndexOf(sl, a + 1);
                      a = i;
                      count++;
                      label3.Text = "Количесво слов " + count;
                      Thread.Sleep(100);
                  }
              };
            act.BeginInvoke(null, null);
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = Convert.ToString(textBox3.Text).ToLower();
            string[] words = text.Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);
            var result = words.GroupBy(x => x)
                              .Where(x => x.Count() > 1)
                              .Select(x => new { Word = x.Key, Frequency = x.Count() });
            Action ac = () =>
              {
                  foreach (var item in result)
                  {
                      textBox4.Text = ("Количество повторов: ", item.Word, item.Frequency).ToString();
                  }
              };
            ac.BeginInvoke(null, null);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Action a = () =>
             {
                 for (int i = 0; true; i++)
                 {
                     listBox1.Items.Add("hello" + i);
                     Thread.Sleep(100);
                 }
             };
            a.BeginInvoke(null, null);
        }
    }
}
