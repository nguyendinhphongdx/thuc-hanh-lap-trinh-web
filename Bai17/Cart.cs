using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai17
{
    public class Cart
    {
        Product product;
        int soluong;

        public Product Product { get => product; set => product = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public Cart(Product product, int soluong)
        {
            this.Product = product;
            this.Soluong = soluong;
        }

        public Cart()
        {
        }

    }
}