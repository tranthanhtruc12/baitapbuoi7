using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Buoi7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog svg = new SaveFileDialog();
            svg.Filter = "Text file | *.txt";
            if(svg.ShowDialog()==DialogResult.OK)
            {
                string filename;
                filename = svg.FileName;
                textBox1.Text = filename;
                StreamWriter sw = File.CreateText(filename);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Text File (*.txt)|*.txt|All Document (*.pdf)|*.pdf";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                StreamReader f = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = f.ReadToEnd();
                f.Close();
            }
        }

    }
}
