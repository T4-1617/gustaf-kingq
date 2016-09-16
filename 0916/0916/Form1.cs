using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0916
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList BackingStore;
        public Form1()
        {
            BackingStore = new System.Collections.ArrayList();
            InitializeComponent();
        }

        private void buttonShowCar_Click(object sender, EventArgs e){}
        private void buttonAddCar_Click(object sender, EventArgs e){}
        private void buttonReturnCar_Click(object sender, EventArgs e){}

        private void listBoxShow_SelectedIndexChanged(object sender, EventArgs e){}
        private void buttonBook_Click(object sender, EventArgs e){}

        private void textBoxMake_TextChanged(object sender, EventArgs e){}
        private void textBoxModel_TextChanged(object sender, EventArgs e){}
        private void textBoxColor_TextChanged(object sender, EventArgs e){}
        private void textBoxReg_TextChanged(object sender, EventArgs e){}
        private void textBoxSeats_TextChanged(object sender, EventArgs e){}
        private void textBoxPrice_TextChanged(object sender, EventArgs e){}
        private void buttonAdd_Click(object sender, EventArgs e){}

        private void listBoxBooked_SelectedIndexChanged(object sender, EventArgs e){}
        private void buttonReturn_Click(object sender, EventArgs e){}
    }
}
