using System;
using System.Collections.Generic;
//using System.Componentbrand="", brand;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0914
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int initializeLock = 0;
        private void panel1_Paint(object sender, PaintEventArgs e){}
        private void button1_Click(object sender, EventArgs e){ panel1.Visible = false; }
        private void button2_Click(object sender, EventArgs e){}
        private void button3_Click(object sender, EventArgs e){}
        private void button4_Click(object sender, EventArgs e)
        {

            if (initializeLock == 0)
            {
                Cars first = new Cars() { brand = "Valksvagen", model = "Korkvagnen 645B", color = "Black", bagageSpace = true, seats = 5, automaticGearbox = false, ac = true, maxSpeed = "125km/h", fuelType = "Biodiesel", gasLperKM = 18, price = "125000 SEK", regNumber = "ANG275" };
                Cars second = new Cars() { brand = "Fix it Again Tony", model = "B13 Breaker 1", color = "Yellow", bagageSpace = false, seats = 7, automaticGearbox = false, ac = false, maxSpeed = "45km/h", fuelType = "Diesel", gasLperKM = 19, price = "22500 SEK", regNumber = "DOT945" };
                Cars third = new Cars() { brand = "Eagle Inc.", model = "77 Highflier", color = "Blue", bagageSpace = true, seats = 4, automaticGearbox = true, ac = true, maxSpeed = "160km/h", fuelType = "LPG", gasLperKM = 14, price = "95750 SEK", regNumber = "TBW265" };
                Cars fourth = new Cars() { brand = "Fix it Again Tony", model = "B17 Breaker Down", color = "Black", bagageSpace = true, seats = 9, automaticGearbox = false, ac = false, maxSpeed = "30km/h", fuelType = "Diesel", gasLperKM = 15, price = "21000 SEK", regNumber = "YVT967" };
                Cars fifth = new Cars() { brand = "Derpord", model = "91N7 RainBMW", color = "Rainbow", bagageSpace = false, seats = 2, automaticGearbox = true, ac = false, maxSpeed = "665km/h", fuelType = "Yoghurt", gasLperKM = 18, price = "13505000 SEK", regNumber = "HIB634" };

                listBox1.Items.Add(first);
                listBox1.Items.Add(second);
                listBox1.Items.Add(third);
                listBox1.Items.Add(fourth);
                listBox1.Items.Add(fifth);
                initializeLock += 1;
            }
            else
            {

            }

        }
    }
}
