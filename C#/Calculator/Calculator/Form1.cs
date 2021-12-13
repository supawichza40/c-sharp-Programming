using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string value ;
        private bool isAdd = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void SevenButtonClick(object sender, EventArgs e)
        {
            string value_in = "7";
            value = value + value_in;
            textBox1.Text = value.ToString();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EqualClick(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(value," ");
            textBox1.Text = v.ToString();
            value = v.ToString();
        }

        private void AddOperationButtonClick(object sender, EventArgs e)
        {

            if (isAdd == true)
            {
                value = value.Trim('+');
                AddButton.BackColor = default;
                isAdd = false;
                //MessageBox.Show(value);
            }
            else
            {
                value = value + "+";
                AddButton.BackColor = Color.Green;
                isAdd = true;
                //MessageBox.Show(value);
            }
            //dynamic val = isAdd == true ? isAdd = false : isAdd = true;




        }

        private void Button_One(object sender, EventArgs e)
        {

        }
    }
}
