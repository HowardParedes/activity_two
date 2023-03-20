using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionOutputBox.Text = wishlist.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Filbuttonbox_Click(object sender, EventArgs e)
        {
            wishlist.Items.Add("Jeans");
            wishlist.Items.Add("Jacket");
            wishlist.Items.Add("Shorts");
            wishlist.Items.Add("Shirt");
            wishlist.Items.Add("Shoes");
        }

        private void Setbuttonbox_Click(object sender, EventArgs e)
        {
            wishlist.Sorted = true;
        }

        private void Clearbuttonbox_Click(object sender, EventArgs e)
        {
            wishlist.Items.Clear();
        }

        private void selectionbox_TextChanged(object sender, EventArgs e)
        {
            SelectionOutputBox.Text = wishlist.Text;
        }

        private void Countbuttonbox_Click(object sender, EventArgs e)
        {
            CountOutputBox.Text = Convert.ToString(wishlist.Items.Count);
        }

        private void countOutput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Closebuttonbox_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
