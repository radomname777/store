using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Product : UserControl
    {


        public Product()
        {
            InitializeComponent();
        }
        public Image picturebox
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        public string Labeltxt { get => label1.Text; set => label1.Text = value; }
        public string ProductCount { get => Count_txt.Text; set => Count_txt.Text = value; }
        public string Price { get => Price_txt.Text; set => Price_txt.Text = value; }
        public bool Checked { get => guna2ImageCheckBox1.Checked; set => guna2ImageCheckBox1.Checked = value; }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
