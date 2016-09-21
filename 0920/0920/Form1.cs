﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0920
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList BackingStore;
        public Form1()
        {

            BackingStore = new System.Collections.ArrayList();
            InitializeComponent();
        }
        int amountOfCus = 0;
        int amountOfEmp = 0;
        int amountOfSup = 0;
        Random r = new Random();


        public void RegisterAmount()
        {
            AmountRegistered.Text = String.Format("You have registered {0} Customers, {1} Employees and {2} Suppliers.",
                amountOfCus,
                amountOfEmp,
                amountOfSup);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CusAdd.Visible = true;
                EmpAdd.Visible = false;
                EmpAdd.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                CusAdd.Visible = false;
                EmpAdd.Visible = true;
                EmpAdd.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                CusAdd.Visible = false;
                EmpAdd.Visible = false;
                SupAdd.Visible = true;
            }
        }
        private void CusAdd_Paint(object sender, PaintEventArgs e) { }
        private void CusAddSave_Click(object sender, EventArgs e)
        {
            BackingStore.Add(new Customer()
            {
                FirstName = CusAddFname.Text,
                LastName = CusAddLname.Text,
                ID = r.Next(100, 300),
                Phone = CusAddPhone.Text,
            });
            amountOfCus += 1;
            RegisterAmount();
            CusAddFname.Text = String.Empty;
            CusAddLname.Text = String.Empty;
            CusAddPhone.Text = String.Empty;
        }
        private void CusAddCancel_Click(object sender, EventArgs e) { }
        private void CusAddFname_TextChanged(object sender, EventArgs e) { }
        private void CusAddLname_TextChanged(object sender, EventArgs e) { }
        private void CusAddPhone_TextChanged(object sender, EventArgs e) { }
        private void CusAddID_TextChanged(object sender, EventArgs e) { }

        private void CusEdit_Paint(object sender, PaintEventArgs e) { }
        private void CusEditSave_Click(object sender, EventArgs e) { }
        private void CusEditCancel_Click(object sender, EventArgs e) { }
        private void CusEditFname_TextChanged(object sender, EventArgs e) { }
        private void CusEditLname_TextChanged(object sender, EventArgs e) { }
        private void CusEditID_TextChanged(object sender, EventArgs e) { }
        private void CusEditPhone_TextChanged(object sender, EventArgs e) { }


        private void EmpAdd_Paint(object sender, PaintEventArgs e) { }
        private void EmpAddSave_Click(object sender, EventArgs e)
        {
            BackingStore.Add(new Employee()
            {
                FirstName = EmpAddFname.Text,
                LastName = EmpAddLname.Text,
                ID = r.Next(1, 50),
                Phone = EmpAddPhone.Text,
                Title = EmpAddTitle.Text,
                Salary = r.Next(100, 300),
            });
            amountOfEmp += 1;
            RegisterAmount();
            EmpAddFname.Text = String.Empty;
            EmpAddLname.Text = String.Empty;
            EmpAddPhone.Text = String.Empty;
            EmpAddTitle.Text = String.Empty;
        }
        private void EmpAddCancel_Click(object sender, EventArgs e) { }
        private void EmpAddFname_TextChanged(object sender, EventArgs e) { }
        private void EmpAddLname_TextChanged(object sender, EventArgs e) { }
        private void EmpAddPhone_TextChanged(object sender, EventArgs e) { }
        private void EmpAddTitle_TextChanged(object sender, EventArgs e) { }

        private void EmpEdit_Paint(object sender, PaintEventArgs e) { }
        private void EmpEditSave_Click(object sender, EventArgs e) { }
        private void EmpEditCancel_Click(object sender, EventArgs e) { }
        private void EmpEditFname_TextChanged(object sender, EventArgs e) { }
        private void EmpEditLname_TextChanged(object sender, EventArgs e) { }
        private void EmpEditPhone_TextChanged(object sender, EventArgs e) { }
        private void EmpEditID_TextChanged(object sender, EventArgs e) { }
        private void EmpEditTitle_TextChanged(object sender, EventArgs e) { }
        private void EmpEditSalary_TextChanged(object sender, EventArgs e) { }


        private void SupAdd_Paint(object sender, PaintEventArgs e) { }
        private void SupAddSave_Click(object sender, EventArgs e)
        {
            BackingStore.Add(new Supplier()
            {
                Contact = SupAddContact.Text,
                Company = SupAddCompany.Text,
                Phone = SupAddPhone.Text,
            });
            amountOfSup += 1;
            RegisterAmount();
            SupAddContact.Text = String.Empty;
            SupAddCompany.Text = String.Empty;
            SupAddPhone.Text = String.Empty;
        }
        private void SupAddCancel_Click(object sender, EventArgs e) { }
        private void SupAddContact_TextChanged(object sender, EventArgs e) { }
        private void SupAddCompany_TextChanged(object sender, EventArgs e) { }
        private void SupAddPhone_TextChanged(object sender, EventArgs e) { }

        private void SupEdit_Paint(object sender, PaintEventArgs e) { }
        private void SupEditSave_Click(object sender, EventArgs e) { }
        private void SupEditCancel_Click(object sender, EventArgs e) { }
        private void SupEditContact_TextChanged(object sender, EventArgs e) { }
        private void SupEditCompany_TextChanged(object sender, EventArgs e) { }
        private void SupEditPhone_TextChanged(object sender, EventArgs e) { }

        //foreach (Customer xxx in Customers)
        //{
        //    listBox1.Items.Add(xxx);
        //    //listBox1.DisplayMember = "FirstName";
        //    listBox1.DisplayMember = "FullName"; //Detta MÅSTE vara en PROPERTY
        //}
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Customer xxx in BackingStore)
            {
                listBox1.Items.Add(xxx);
                listBox1.DisplayMember = "Fullname";
            }
            foreach (Employee xxx in BackingStore)
            {
                listBox1.Items.Add(xxx);
                listBox1.DisplayMember = "Fullname";
            }
            foreach (Supplier xxx in BackingStore)
            {
                listBox1.Items.Add(xxx);
                listBox1.DisplayMember = "Fullname";
            }
        }




        private void basicLower_Paint(object sender, PaintEventArgs e) { }
        private void basicLowerSave_Click(object sender, EventArgs e) { }
        private void basicLowerCancel_Click(object sender, EventArgs e) { }
         

        private void basicUpper_Paint(object sender, PaintEventArgs e) { }
        private void basicUpperSave_Click(object sender, EventArgs e) { }
        private void basicUpperCancel_Click(object sender, EventArgs e) { }

        private void AmountRegistered_Click(object sender, EventArgs e) { }
    }
}
