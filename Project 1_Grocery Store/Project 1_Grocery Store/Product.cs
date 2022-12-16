using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Grocery_Store
{
    internal class Product
    {
        public string Product_name;
        public string Id;
        public double Price;
        public double Quantity;
        public string Unit;

        public Product(string product_name, string id, double price, string unit)
        {
            this.Product_name = product_name;
            this.Id = id;
            this.Price = price;
            this.Unit = unit;
        }

        public string Exportproduct_Data()
        {
            return $"{this.Product_name}:{this.Id}:{this.Price}:{this.Unit}";
        }
        public void Generate_id()
        {

            Random random_ID = new Random();
            int dg = random_ID.Next(1000, 10000);
            string fl = this.Product_name.Substring(0);
            string ll = this.Product_name.Substring(-1);
            this.Id = $"{fl}_{dg}_{ll}";

        }
    }
}
