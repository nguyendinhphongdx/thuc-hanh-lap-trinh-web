using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai17
{
    public class Product
    {
        int id;
        string name;
        string status;
        double price;
        string unit;

        public Product(int id, string name, string status, double price, string unit)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.Price = price;
            this.Unit = unit;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public double Price { get => price; set => price = value; }
        public string Unit { get => unit; set => unit = value; }
    }
}