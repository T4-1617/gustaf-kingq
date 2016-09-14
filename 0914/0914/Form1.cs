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

        public void textBox1_TextChanged(object sender, EventArgs e) { }
        public void textBox2_TextChanged(object sender, EventArgs e) { }
        public void textBox3_TextChanged(object sender, EventArgs e) { }
        public void textBox4_TextChanged(object sender, EventArgs e) { }
        public void textBox5_TextChanged(object sender, EventArgs e) { }
        public void textBox6_TextChanged(object sender, EventArgs e) { }
        public void textBox7_TextChanged(object sender, EventArgs e) { }
        public void textBox8_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        Cars first = new Cars() { brand = "Valksvagen", model = "Korkvagnen 645B", color = "Black", bagageSpace = true, seats = 5, gasLperKM = 18, price = "125000 SEK", regNumber = "ANG275" };
        Cars second = new Cars() { brand = "Fix it Again Tony", model = "B13 Breaker 1", color = "Yellow", bagageSpace = false, seats = 7, gasLperKM = 19, price = "22500 SEK", regNumber = "DOT945" };
        Cars third = new Cars() { brand = "Eagle Inc.", model = "77 Highflier", color = "Blue", bagageSpace = true, seats = 4, gasLperKM = 14, price = "95750 SEK", regNumber = "TBW265" };
        Cars fourth = new Cars() { brand = "Fix it Again Tony", model = "B17 Breaker Down", color = "Black", bagageSpace = true, seats = 9, gasLperKM = 15, price = "21000 SEK", regNumber = "YVT967" };
        Cars fifth = new Cars() { brand = "Derpord", model = "91N7 RainBMW", color = "Rainbow", bagageSpace = false, seats = 2, gasLperKM = 18, price = "13505000 SEK", regNumber = "HIB634" };

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            listBox1.SelectedItem = textBox1.Text;
            //Cars. = textBox2.Text;
            //Cars. = textBox3.Text;
            //Cars. = textBox4.Text;
            //Cars. = textBox5.Text;
            //Cars. = textBox6.Text;
            //Cars. = textBox7.Text;
            //Cars. = textBox8.Text;

            //first.brand = (Cars)listBox1.SelectedItem;
        }

        private void button4_Click(object sender, EventArgs e)

        {
            if (initializeLock == 0)
            {
                listBox1.Items.Add(first.model);
                listBox1.Items.Add(second.model);
                listBox1.Items.Add(third.model);
                listBox1.Items.Add(fourth.model);
                listBox1.Items.Add(fifth.model);
                panel1.Visible = false;
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
                initializeLock += 1;
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox8.ReadOnly = false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = listBox1.SelectedItem.brand;
            //textBox2.Text = Cars.;
            //textBox3.Text = Cars.;
            //textBox4.Text = Cars.;
            //textBox5.Text = Cars.;
            //textBox6.Text = Cars.;
            //textBox7.Text = Cars.;
            //textBox8.Text = Cars.;

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
        }
    }
}


