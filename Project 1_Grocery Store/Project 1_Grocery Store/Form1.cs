using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_Grocery_Store
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

        private void ShoppingMenu_Click(object sender, EventArgs e)
        {
            
            Form3 ShoppingPage = new Form3();
            ShoppingPage.ShowDialog();
        }

        private void AddProducts_Click(object sender, EventArgs e)
        {
            
            Form2 AddProducts = new Form2();
            AddProducts.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
