using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0912
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fname;
        string lname;
        static Random r = new Random();
        int ID = r.Next(100,201);
        int amountOfCustomers = 0;




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerList customerInfo = new CustomerList();
            customerInfo.Fname = textBox1.Text;
            customerInfo.Lname = textBox2.Text;
            customerInfo.IDNumber = ID;
            amountOfCustomers += 1;
            //ID 

            listBox1.Items.Add("NEW CUSTOMER:");
            listBox1.Items.Add("IDNumber: " + customerInfo.IDNumber);
            listBox1.Items.Add("First name: " + customerInfo.Fname);
            listBox1.Items.Add("Last name: " + customerInfo.Lname);
            listBox1.Items.Add("Active: ");
            listBox1.Items.Add("");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = amountOfCustomers;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
