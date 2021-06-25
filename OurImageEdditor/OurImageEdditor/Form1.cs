using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PlaginFramework;
using System.Reflection;
using System.IO;

namespace OurImageEdditor
{
    public partial class Form1 : Form
    {
        Dictionary<string, Filter> _filters = new Dictionary<string, Filter>();
        public Form1()
        {
            InitializeComponent();
            var assembly = Assembly.GetExecutingAssembly();
            var folder = Path.GetDirectoryName(assembly.Location);
            LoadFilter(folder);
            CreateFilterMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void LoadFilter(string folder)
        {
            _filters.Clear();
            foreach(var dll in Directory.GetFiles(folder, "*.dll"))
            {
                try
                {
                    var asm = Assembly.LoadFrom(dll);
                    foreach (var type in asm.GetTypes())
                    {
                        if(type.GetInterface("Filter")==typeof(Filter))
                        {
                            var filter = Activator.CreateInstance(type) as Filter;
                            _filters[filter.Name] = filter;
                        }
                    }
                }
                catch (BadImageFormatException) { }
            }
        }
        void CreateFilterMenu()
        {
            plaginToolStripMenuItem.DropDownItems.Clear();
            foreach (KeyValuePair<string, Filter> pair in _filters)
            {
                var item = new ToolStripMenuItem(pair.Key);
                item.Click += new EventHandler(plaginToolStripMenuItem_Click);
                plaginToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        public void plaginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var filter = _filters[menuItem.Text];
            try
            {
                this.Cursor = Cursors.WaitCursor;
                pictureBox1.Image = filter.MyPlugin(pictureBox1.Image);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        void menuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
