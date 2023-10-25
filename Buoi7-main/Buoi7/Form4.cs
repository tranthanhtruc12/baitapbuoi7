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
    public partial class Form4 : Form
    {
        private List<CheckBox> checkBoxes;
        private List<string> textList;
        public Form4()
        {
            InitializeComponent();
            checkBoxes = new List<CheckBox>
            {
                checkBox1,
                checkBox2,
                checkBox3
            };
        }
        private void Form_load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kinh");
            comboBox1.Items.Add("Chăm");
            comboBox1.Items.Add("Hoa");
            comboBox1.SelectedItem = "Kinh";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = comboBox1.SelectedItem.ToString();
            int selectedIndex = comboBox1.SelectedIndex;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem subitem2= new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem subitem3 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem subitem4 = new ListViewItem.ListViewSubItem();
            item.Text = textBox1.Text;
            subitem.Text = textBox2.Text;
            item.SubItems.Add(subitem);
            listView1.Items.Add(item);
            //-------------subitem2-----------//
            if(radioButton1.Checked)
            {
                subitem2.Text = radioButton1.Text;
            }
            else
            {
                subitem2.Text = radioButton2.Text;
            }
            item.SubItems.Add(subitem2);
            //----------subitem3------------//
            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    subitem3.Text += checkBox.Text + ", " + Environment.NewLine;
                }
            }
            item.SubItems.Add(subitem3);
            //---------subitem4----------//
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in listView1.SelectedItems)
            {
                l.Remove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null && listView1.FocusedItem.Index >= 0)
            {
                ListViewItem item = listView1.FocusedItem;
                item.SubItems[0].Text = textBox1.Text;
                item.SubItems[1].Text = textBox2.Text;
               

            }
        }
    }
}
