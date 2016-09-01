using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0831
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tal1; //Tar in det första talet
            tal1 = textBox1.Text;
            string tal2; //Tar in det andra talet
            tal2 = textBox2.Text;

            int i1; //Omvandlar båda talen från formatet string till integers
            i1 = Int32.Parse(tal1);
            int i2;
            i2 = Int32.Parse(tal2);

            int result1; //Lägger ihop talen och skapar en resultatsvariabel
            result1 = i1 + i2;

            string result2; //Skapar en sammanfattningsvariabel
            result2 = string.Format("{0} " + "+ " + "{1} = {2}", //Sammanställer sammanfattningsvariabeln genom att lägga ihop talen, resultat och det passande räknesättstecknet
                i1,
                i2,
                result1);

            listBox1.Items.Add("ADDED:"); //Ett stilval som annonsierar vilket räknesätt som används
            listBox1.Items.Add(result2);

            textBox1.Text = ""; //Tömmer textboxarna för vidareanvändning
            textBox2.Text = "";

            //Upprepar sedan detta tre gånger i formen av de andra räknesätten


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tal1;
            tal1 = textBox1.Text;
            string tal2;
            tal2 = textBox2.Text;

            int i1;
            i1 = Int32.Parse(tal1);
            int i2;
            i2 = Int32.Parse(tal2);

            int result1;
            result1 = i1 - i2;

            string result2;
            result2 = string.Format("{0} " + "- " + "{1} = {2}",
                i1,
                i2,
                result1);

            listBox1.Items.Add("SUBTRACTED:");
            listBox1.Items.Add(result2);

            textBox1.Text = ""; 
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tal1;
            tal1 = textBox1.Text;
            string tal2;
            tal2 = textBox2.Text;

            int i1;
            i1 = Int32.Parse(tal1);
            int i2;
            i2 = Int32.Parse(tal2);

            int result1;
            result1 = i1 * i2;

            string result2;
            result2 = string.Format("{0} " + "* " + "{1} = {2}",
                i1,
                i2,
                result1);

            listBox1.Items.Add("MULTIPLIED:");
            listBox1.Items.Add(result2);

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tal1;
            tal1 = textBox1.Text;
            string tal2;
            tal2 = textBox2.Text;

            int i1;
            i1 = Int32.Parse(tal1);
            int i2;
            i2 = Int32.Parse(tal2);

            int result1;
            result1 = i1 / i2;

            string result2;
            result2 = string.Format("{0} " + "/ " + "{1} = {2}",
                i1,
                i2,
                result1);

            listBox1.Items.Add("DIVIDED:");
            listBox1.Items.Add(result2);

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
