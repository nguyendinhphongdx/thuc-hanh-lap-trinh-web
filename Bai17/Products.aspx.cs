using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai17
{
    public partial class Products : System.Web.UI.Page
    {
        public List<Product> products;
        protected void Page_Load(object sender, EventArgs e)
        {
            //products = MockProducts();
            products = (List<Product>)Application["Products"];
            PanelList.CssClass = "listPannel";
        }

        private List<Product> MockProducts()
        {
            List<Product> list = new List<Product>();
            //for (int i=1;i<6;i++)
            //{
            //    Product product = new Product(i,"Product "+i,"in stock",i*100,"bottle","./assets/login_background_dark.png");
            //    list.Add(product);
            //}
            list.Add(new Product(1, "Product 1", "in stock", 225, "bottle", "./assets/product1.png"));
            list.Add(new Product(2, "Product 2", "in stock", 225, "bottle", "./assets/product2.png"));
            list.Add(new Product(3, "Product 3", "in stock", 225, "bottle", "./assets/product3.png"));
            list.Add(new Product(4, "Product 4", "in stock", 225, "bottle", "./assets/product4.png"));
            list.Add(new Product(5, "Product 5", "in stock", 225, "bottle", "./assets/product5.png"));
            list.Add(new Product(6, "Product 6", "in stock", 225, "bottle", "./assets/product6.png"));
            return list;
        }

    }
}