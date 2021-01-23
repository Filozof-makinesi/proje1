using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedIndex.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Items[listBox1.SelectedIndex].ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox1.Items)
            {
                MessageBox.Show(item);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                if (listBox2.Items.IndexOf(item) == -1)
                    listBox2.Items.Add(item);
                else
                    MessageBox.Show("ilgili eleman zaten var");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <listBox1.Items.Count; i++)
            {
                listBox1.Items.Remove(listBox1.Items[i]);
            }
        }
    }
}
