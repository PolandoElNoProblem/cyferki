using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cyferki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible= checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int los;
            Random rand = new Random();
            if (radioButton1.Checked)
            
                los = rand.Next(0, 1000);
            
            else if(radioButton2.Checked)
            {
                los = rand.Next(0, 100); 
            }
            else (radioButton3.Checked)
            {
                los = rand.Next(0, 10);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
