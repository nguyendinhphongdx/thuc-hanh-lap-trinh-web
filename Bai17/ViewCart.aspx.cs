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

            if (Request.Form.Count > 0)
            {
                string action = Request.Form["action"];
                string id = Request.Form["Id"];
                actionType(action, id);
            }

            totalPrice = getTotalCart();
        }

        private void actionType(string action, string Id)
        {
            if (action == "delete")
            {
                List<Cart> newCarts = carts.FindAll(item => item.Product.Id.ToString() != Id.Trim());
                Session["Cart"] = newCarts;
            }
            if (action == "update")
            {
                string[] soluong = Request.Form["soluong"].Split(',');
                for(int i = 0; i < carts.Count; i++)
                {
                    carts[i].Soluong = Convert.ToInt32(soluong[i]);
                }
                Session["Cart"] = carts;
            }

            carts = (List<Cart>)Session["Cart"];
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