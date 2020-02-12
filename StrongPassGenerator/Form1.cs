using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongPassGenerator
{
    public partial class Form1 : Form
    {
        Password password = new Password();
        public Form1()
        {
            InitializeComponent();
        }

        private void readHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string targetURL = @"c:\users\administrator\documents\visual studio 2015\Projects\StrongPassGenerator\StrongPassGenerator\HTMLPage1.html";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Text = password.Generate(int.Parse(textBox1.Text),checkBox1.Checked,checkBox2.Checked,checkBox3.Checked,checkBox4.Checked,checkBox5.Checked,checkBox6.Checked);
            
        }
    }
}
