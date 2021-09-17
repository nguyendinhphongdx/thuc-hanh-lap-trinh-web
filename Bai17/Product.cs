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
        string images;

        public Product(int id, string name, string status, double price, string unit, string images)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.price = price;
            this.unit = unit;
            this.Images = images;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public double Price { get => price; set => price = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Images { get => images; set => images = value; }
    }
}