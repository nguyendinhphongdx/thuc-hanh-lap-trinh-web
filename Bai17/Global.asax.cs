using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Bai17
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product(1, "Product 1", "in stock", 225, "bottle", "./assets/product1.png"));
            list.Add(new Product(2, "Product 2", "in stock", 225, "bottle", "./assets/product2.png"));
            list.Add(new Product(3, "Product 3", "in stock", 225, "bottle", "./assets/product3.png"));
            list.Add(new Product(4, "Product 4", "in stock", 225, "bottle", "./assets/product4.png"));
            list.Add(new Product(5, "Product 5", "in stock", 225, "bottle", "./assets/product5.png"));
            list.Add(new Product(6, "Product 6", "in stock", 225, "bottle", "./assets/product6.png"));
            Application["Products"] = list;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["Cart"] = new List<Cart>();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}