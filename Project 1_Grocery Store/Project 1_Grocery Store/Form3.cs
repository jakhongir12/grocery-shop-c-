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
    public partial class Form3 : Form
    {
        double sum = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Displaydata d = new Displaydata("", "", 0, "");
            FileStream fs = new FileStream("myFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string name = "";
            double price;
            string id = "";
            string unit = "";
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] data = s.Split(':');
                name = data[0];
                price = Convert.ToDouble(data[2]);
                id = data[1];
                unit = data[3];
                listBox1.Items.Add(name);
                Datacenter.Productlist.Add(new Displaydata(name, id, price, unit));
            }
            sr.Close();
            fs.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("myFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string name = "";
            string id = "";
            string price = "";
            string pr_name = listBox1.SelectedItem.ToString();
            int temp = 0;
            if (listBox1.SelectedIndex > -1)
            {
                temp = listBox1.SelectedIndex;
            }
            int i = 0;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] data = s.Split(':');
                name = data[0];
                if (i == temp)
                {
                    id = data[1];
                    price = data[2];
                    break;
                }
                i++;
            }
            sr.Close();
            fs.Close();
            ProductName_OPT.Text = pr_name;
            ID_OPT.Text = id;
            Price_OPT.Text = price;
        }

        private void AddToBasket_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("myFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string name = "";
            string id = "";
            string price = "";
            string pr_name = listBox1.SelectedItem.ToString();
            int temp = 0;
            double qty = 0, temp1 = 0, temp2 = 0;
            qty = Convert.ToDouble(Quantity_OPT.Value);
            if (listBox1.SelectedIndex > -1)
            {
                temp = listBox1.SelectedIndex;
            }
            int i = 0;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] data = s.Split(':');
                name = data[0];
                if (i == temp)
                {
                    id = data[1];
                    price = data[2];
                    temp1 = Convert.ToDouble(price);
                    break;
                }
                i++;
            }
            sr.Close();
            fs.Close();
            temp2 = temp1 * qty;
            sum += temp2;
            string quantity = Convert.ToString(Quantity_OPT.Value);
            string output = quantity + " X " + ProductName_OPT.Text;
            listBox2.Items.Add(output);
            sum_lbl.Text = Convert.ToString(sum);
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            sum_lbl.Text = "";
            MessageBox.Show($"Your Total is : {sum} $ \nTHANK YOU FOR YOUR PURCHASE!\nWish to see you again SOON!");
        }
    }
}
