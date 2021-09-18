using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai17
{
    public partial class ViewCart : System.Web.UI.Page
    {
        public List<Cart> carts;
        public double totalPrice = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
             carts = (List<Cart>)Session["Cart"];
            totalPrice = getTotalCart();
        }
        public double getTotalCart()
        {
            double totalPrice = 0;
            carts.ForEach(item =>
            {
                totalPrice += item.Product.Price * item.Soluong;
            });
            return totalPrice;
        }
    }
}