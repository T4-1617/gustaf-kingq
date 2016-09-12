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
        int amountOfCustomers = 0;
        string[] combinedCustomers = new string[0];


        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void textBox2_TextChanged(object sender, EventArgs e) {}
        private void textBox3_TextChanged(object sender, EventArgs e) {}
        private void button1_Click(object sender, EventArgs e)
        {
            CustomerList customerInfo = new CustomerList();
            customerInfo.Fname = textBox1.Text;
            customerInfo.Lname = textBox2.Text;
            //string fullname = customerInfo.Fname + " " + customerInfo.Lname;
            Random r = new Random();
            int ID = r.Next(100, 201);
            bool[] listOfIDs = new bool[ID];
            listOfIDs[customerInfo.IDNumber] = true;

            if (listOfIDs[customerInfo.IDNumber] == true)
            {
                customerInfo.Active = true;
                amountOfCustomers += 1;
                //combinedCustomers[fullname] = fullname;
            }
            else
            {
                customerInfo.Active = false;
            }
            customerInfo.IDNumber = ID;

            listBox1.Items.Add("NEW CUSTOMER NUMBER: " + amountOfCustomers);
            listBox1.Items.Add("IDNumber: " + customerInfo.IDNumber);
            listBox1.Items.Add("First name: " + customerInfo.Fname);
            listBox1.Items.Add("Last name: " + customerInfo.Lname);
            listBox1.Items.Add("Active: " + customerInfo.Active);
            listBox1.Items.Add("");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = (amountOfCustomers + "    is the magic number");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
