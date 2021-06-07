using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessComputer
{
    public partial class Form1 : Form
    {
        private List<Process> processes = null;
        
        public Form1()
        {
            
            InitializeComponent();
        }
        private void GetProc()
        {
            processes.Clear();
            processes = Process.GetProcesses().ToList<Process>();
        }

        private void RefreshList()
        {
            listView1.Items.Clear();
            foreach(Process p in processes)
            {
                PerformanceCounter pc = new PerformanceCounter();
                pc.CategoryName = "Process";
                pc.CounterName = "working set";
                pc.InstanceName = p.ProcessName;
                string[] row = new string[] { p.ProcessName.ToString(),
                    p.Id.ToString(),p.MainWindowTitle.ToString(),p.BasePriority.ToString(),p.StartInfo.ToString()
                   
                };
                listView1.Items.Add(new ListViewItem(row));
                pc.Close();
                pc.Dispose();
            }
            Text = "Process " + processes.Count.ToString();
        }
        private void RefreshList(List<Process> processes, string keyword)
        {
            listView1.Items.Clear();
            foreach (Process p in processes)
            {
                PerformanceCounter pc = new PerformanceCounter();
                pc.CategoryName = "Process";
                pc.CounterName = "working set";
                pc.InstanceName = p.ProcessName;
                string[] row = new string[] { p.ProcessName.ToString(),
                    p.Id.ToString(),p.MainWindowTitle.ToString(),p.BasePriority.ToString(),p.StartInfo.ToString()
                    
                };
                listView1.Items.Add(new ListViewItem(row));
                pc.Close();
                pc.Dispose();
            }
            Text = "Process " + processes.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Interaction.InputBox("Name program", "Start Process");
            try 
            {
                Process.Start(path);
            }
            catch (Exception) { }

        }
        private void KillProsess(Process process)
        {
            process.Kill();
            process.WaitForExit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try 
            { 
               if (listView1.SelectedItems[0]!=null)
                {

                    Process processToKill = processes.Where((x) => x.ProcessName ==
                    listView1.SelectedItems[0].SubItems[0].Text).ToList()[0];
                    KillProsess(processToKill);
                    GetProc();
                    RefreshList();





                }
            }
            catch(Exception)
            {

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processes = new List<Process>();
            GetProc();
            RefreshList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetProc();
            RefreshList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetProc();
            List<Process> filter = processes.Where((x) => x.ProcessName.ToLower().
              Contains(textBox1.Text.ToLower())).ToList<Process>();
            RefreshList (filter, textBox1.Text);
        }
    }
}
