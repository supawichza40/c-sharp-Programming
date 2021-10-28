using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Visualizer_App
{
    public partial class Form1 : Form
    {
        int[] arrayOfNumber;
        Graphics g;
        float numberOfPixel;
        int graphicDelay;
        
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = Convert.ToString(0);
            textBox1.Text = Convert.ToString(10);
            comboBox1.SelectedItem = "Bubble Sort";


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void button1_Click(object sender, EventArgs e)
        {   
            g = panel1.CreateGraphics();
            int numberEntries = panel1.Width;
            int max_value = panel1.Height;
            int numberOfItem = Convert.ToInt32(textBox1.Text);
            arrayOfNumber = new int[numberOfItem];
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, numberEntries, max_value);
            Random randint = new Random();
            for (int i = 0; i < numberOfItem; i++)
            {
                arrayOfNumber[i] = randint.Next(0, max_value);

            }
            for (int i = 0; i < numberOfItem; i++)
            {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), i * (float)numberOfPixel, max_value - arrayOfNumber[i], (float)numberOfPixel, max_value);
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i*(float)numberOfPixel, max_value - arrayOfNumber[i],(float)numberOfPixel-1, max_value-1);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numberEntries = panel1.Width;
            int max_value = panel1.Height;
            string sortAlgoOption = comboBox1.SelectedItem.ToString();

            if (sortAlgoOption == "Bubble Sort")
            {   
                ISortEngine se = new BubbleSortEngine();
                se.DoWork(arrayOfNumber, g, panel1.Height, numberOfPixel,graphicDelay);
            }
            else if (sortAlgoOption == "Quick Sort")
            {
                ISortEngine se = new QuickSortEngine();

                se.DoWork(arrayOfNumber, g, panel1.Height,numberOfPixel,graphicDelay);
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, numberOfPixel, max_value);
                for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                {
                    g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), i * numberOfPixel, max_value - arrayOfNumber[i], numberOfPixel, max_value);
                    g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i*numberOfPixel, max_value - arrayOfNumber[i], numberOfPixel-1, max_value-1);

                }

            }
            else if (sortAlgoOption == "Insertion Sort")
            {
                ISortEngine se = new InsertionSortEngine();
                se.DoWork(arrayOfNumber, g, panel1.Height, numberOfPixel, graphicDelay);
            }
            else
            {
                MessageBox.Show("Invalid algorithm");
            }


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //height of the panel adjustable 606
            trackBar1.Minimum = 20;
            trackBar1.Maximum = 606;
            panel1.Height = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //width of the panel adjustable 1496 max
            trackBar2.Minimum = 20;
            trackBar2.Maximum = 1496;
            panel1.Width = trackBar2.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Number of input from 5 - 1000+
            if (textBox1.Text=="")
            {
                
            }
            else
            {
                numberOfPixel = (float)(Convert.ToDouble(panel1.Width) / Convert.ToDouble(textBox1.Text));
            }
       
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text=="")
            {
                textBox2.Text = "";
            }
            else
            {
                graphicDelay = Convert.ToInt32(textBox2.Text);
            }
       

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
