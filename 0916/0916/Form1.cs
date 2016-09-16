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
        System.Collections.ArrayList NotAvailable;
        public Form1()
        {
            BackingStore = new System.Collections.ArrayList();
            NotAvailable = new System.Collections.ArrayList();
            InitializeComponent();
        }
        public void InitializeShowBox()
        {
            BackingStore.Add(new Carlist()
            {
                Available = true,
                Made = "1999",
                Model = "Blerp 2000",
                Color = "Green",
                RegNumber = "AOB932",
                Seats = "5",
                Price = "125000 SEK"
            });
            BackingStore.Add(new Carlist()
            {
                Available = true,
                Made = "1979",
                Model = "HERPtastic B2",
                Color = "Blue",
                RegNumber = "BLU367",
                Seats = "7",
                Price = "145750 SEK"
            });
            BackingStore.Add(new Carlist()
            {
                Available = true,
                Made = "2004",
                Model = "Mehton 70",
                Color = "Yellow",
                RegNumber = "ZID173",
                Seats = "1",
                Price = "100 SEK"
            });
            listBoxShow.Items.Add(BackingStore);
        }
        public void AddNewCar()
        {
            BackingStore.Add(new Carlist()
            {
                Available = true,
                Made = textBoxMade.Text,
                Model = textBoxModel.Text,
                Color = textBoxColor.Text,
                RegNumber = textBoxReg.Text,
                Seats = textBoxSeats.Text,
                Price = textBoxPrice.Text
            });
        }
        private void panelShow_Paint(object sender, PaintEventArgs e) { }
        private void panelAdd_Paint(object sender, PaintEventArgs e) { }
        private void panelReturn_Paint(object sender, PaintEventArgs e) { }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            panelShow.Visible = true;
            panelAdd.Visible = false;
            panelReturn.Visible = false;
        }
        private void buttonShowCar_Click(object sender, EventArgs e)
        {
            panelShow.Visible = false;
            panelAdd.Visible = true;
            panelReturn.Visible = false;
        }
        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            panelShow.Visible = false;
            panelAdd.Visible = false;
            panelReturn.Visible = true;
        }
        private void buttonReturnCar_Click(object sender, EventArgs e)
        {

        }

        private void listBoxShow_SelectedIndexChanged(object sender, EventArgs e){}
        private void buttonBook_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMake_TextChanged(object sender, EventArgs e){}
        private void textBoxModel_TextChanged(object sender, EventArgs e){}
        private void textBoxColor_TextChanged(object sender, EventArgs e){}
        private void textBoxReg_TextChanged(object sender, EventArgs e){}
        private void textBoxSeats_TextChanged(object sender, EventArgs e){}
        private void textBoxPrice_TextChanged(object sender, EventArgs e){}
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddNewCar();
        }

        private void listBoxBooked_SelectedIndexChanged(object sender, EventArgs e){}
        private void buttonReturn_Click(object sender, EventArgs e){}
    }
}
