using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7
{
    public partial class Form1 : Form
    {
        private List<string> textList;
        public Form1()
        {
            InitializeComponent();
            textList = new List<string>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            if (!string.IsNullOrEmpty(text))
            {
                textList.Add(text);
                listBox1.Items.Add(text);
                textBox1.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedText = listBox1.SelectedItem.ToString();
                textList.Remove(selectedText);
                listBox1.Items.Remove(selectedText);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedText = listBox1.SelectedItem.ToString();
                string newText = textBox1.Text;

                if (!string.IsNullOrEmpty(newText))
                {
                    int selectedIndex = listBox1.SelectedIndex;
                    textList[selectedIndex] = newText;
                    listBox1.Items[selectedIndex] = newText;
                    textBox1.Text = string.Empty;
                }
            }
        }
    }
}
