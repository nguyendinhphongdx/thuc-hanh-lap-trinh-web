using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai17
{
    public partial class AddToCart : System.Web.UI.Page
    {
        public List<Cart> cart;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Count>0)
            {
                Product product = new Product();
                int soluong = Convert.ToInt32(Request.Form["soluong"]);
                int masp = Convert.ToInt32(Request.Form["masp"]);
                cart = (List<Cart>)Session["Cart"];
                
                AddNumberOrAddNew(masp,soluong);

                Response.Redirect("/ViewCart.aspx");
            }
            else
            {
                Response.Redirect("/Products.aspx?");
            }
        }

        private void AddNumberOrAddNew(int masp, int soluong)
        {
            int index=-1;
            for (int i=0;i< cart.Count; i++)
            {
                if (cart[i].Product.Id == masp)
                {
                    cart[i].Soluong += soluong;
                    index = i; break;
                }
            }
            // san pham chua co trong gio hang
            if (index==-1)
            {
                List<Product> products = (List<Product>)Application["Products"];
                Product newProduct = products.Find(item => item.Id == masp);
                Cart newCart = new Cart();
                newCart.Product = newProduct;
                newCart.Soluong = soluong;
                cart.Add(newCart);
            }
            Session["Cart"] = cart;
        }
    }
}