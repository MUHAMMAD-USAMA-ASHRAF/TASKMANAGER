using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace taskmanagerbyJH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Process[] procs;
        private void getprocesses()  
        {
            procs = Process.GetProcesses();
            if (Convert.ToInt32(label2.Text) != procs.Length)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < procs.Length;i++ )
                {
                    listBox1.Items.Add(procs[i].ProcessName);
                }
                label2.Text = procs.Length.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getprocesses();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getprocesses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procs[listBox1.SelectedIndex].Kill();
        }

        private void kILLPROCESSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procs[listBox1.SelectedIndex].Kill();
        }
    }
}
