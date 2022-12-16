using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Grocery_Store
{
    internal class Displaydata
    {
        public string Product_name;
        public string Id;
        public double Price;
        public double Quantity;
        public string Unit;

        public Displaydata(string product_name, string id, double price, string unit)
        {
            this.Product_name = product_name;
            this.Id = id;
            this.Price = price;
            this.Unit = unit;
        }
    }
}
