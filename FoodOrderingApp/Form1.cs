using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel5.Height = button1.Height;
            panel5.Top = button1.Top;
            userControl11.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Height = button1.Height;
            panel5.Top = button1.Top;
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Height = button2.Height;
            panel5.Top = button2.Top;
            userControl21.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
