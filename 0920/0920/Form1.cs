using System;
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

        private void EmpAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpAddSave_Click(object sender, EventArgs e)
        {
            label1.Text = "Time " + DateTime.Now.ToLongTimeString();
        }

        private void EmpAddCancel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void basicUpper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void CusAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CusAddSave_Click(object sender, EventArgs e)
        {

        }

        private void CusAddCancel_Click(object sender, EventArgs e)
        {

        }

        private void SupAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SupAddSave_Click(object sender, EventArgs e)
        {

        }

        private void SupAddCancel_Click(object sender, EventArgs e)
        {

        }

        private void CusEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CusEditSave_Click(object sender, EventArgs e)
        {

        }

        private void CusEditCancel_Click(object sender, EventArgs e)
        {

        }

        private void EmpEditSave_Click(object sender, EventArgs e)
        {

        }

        private void SupEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SupEditSave_Click(object sender, EventArgs e)
        {

        }

        private void SupEditCancel_Click(object sender, EventArgs e)
        {

        }

        private void EmpEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpEditCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
