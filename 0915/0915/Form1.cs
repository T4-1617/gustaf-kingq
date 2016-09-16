using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0915
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList BackingStore;
        public Form1()
        {
            BackingStore = new System.Collections.ArrayList();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void textBox2_TextChanged(object sender, EventArgs e){}
        private void radioButton1_CheckedChanged(object sender, EventArgs e){}
        private void radioButton2_CheckedChanged(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            BackingStore.Add(new Customer() { lname = textBox2.Text, fname = textBox1.Text });


            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
