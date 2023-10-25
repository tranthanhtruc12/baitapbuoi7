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
    public partial class Form2 : Form
    {
        private List<string> textList;
        public Form2()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
            item.Text = textBox1.Text;
            subitem.Text = textBox2.Text;
            item.SubItems.Add(subitem);
            listView1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem l in listView1.SelectedItems)
            {
                l.Remove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.FocusedItem != null && listView1.FocusedItem.Index>=0)
            {
                ListViewItem item = listView1.FocusedItem;
                item.SubItems[0].Text = textBox1.Text;
                item.SubItems[1].Text = textBox2.Text;
            }
        }


    }
}
