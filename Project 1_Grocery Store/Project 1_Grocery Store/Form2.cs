using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_1_Grocery_Store
{
    public partial class Form2 : Form
    {
        double cnt = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Product p = new Product("", "", 0, "");
            if (ProductNametxt.Text != "")
            {
                string product_name = ProductNametxt.Text;
                p.Product_name = ProductNametxt.Text;
                if (Pricetxt.Text != "")
                {
                    p.Price = Convert.ToDouble(Pricetxt.Text);
                    if (Unittxt.Text != "")
                    {
                        string unit = Unittxt.Text;
                        p.Unit = Unittxt.Text;
                        if (AutoID.Checked)
                        {
                            Random random_ID = new Random();
                            int num = random_ID.Next(1000, 10000);
                            string fl = product_name.Substring(0, 1);
                            string ll = product_name.Substring(product_name.Length - 1);
                            string id = $"{fl}_{num}_{ll}";
                            p.Id = id;
                            FileStream fs = new FileStream("myFile.txt", FileMode.Append, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine(p.Exportproduct_Data());
                            sw.Close();
                            fs.Close();
                            cnt++;
                            MessageBox.Show($"New Product Added.\nProduct Count: {cnt}");


                        }
                        else if (IDtxt.Text == "")
                        {
                            MessageBox.Show("Please write the ID of the Product or press auto ID");
                        }
                        else
                        {
                            p.Id = IDtxt.Text;
                            FileStream fs = new FileStream("myFile.txt", FileMode.Append, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine(p.Exportproduct_Data());
                            sw.Close();
                            fs.Close();
                            cnt++;
                            MessageBox.Show($"New Product Added.\nProduct Count: {cnt}");

                        }
                    }
                    else { MessageBox.Show("Please Choose a Unit"); }
                }
                else { MessageBox.Show("Please Enter Product Price"); }
            }
            else { MessageBox.Show("Please Enter Product Name"); }
            ProductNametxt.Text = Pricetxt.Text = IDtxt.Text = "";
            Unittxt.SelectedIndex = -1;
        }

        private void Exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
    
}
