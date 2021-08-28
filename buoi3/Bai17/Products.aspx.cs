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
        List<Product> products;
        protected void Page_Load(object sender, EventArgs e)
        {
             products = MockProducts();
            PanelList.CssClass = "listPannel";
            foreach (Product item in products)
            {
                Panel panel = new Panel();
                Button button = new Button();
                button.Text = "Buy Now";
                button.CssClass = "button";
                string content = "<div class='pannel'><h3 style='line-height:50px;margin:0px'>" + item.Name + "</h3>" + "<image class='image' src='./assets/login_background_dark.png'/><h2>"+item.Price+ "</h2></div>";
                panel.Controls.Add(new LiteralControl(content));
                
                panel.Controls.Add(button);
                PanelList.Controls.Add(panel);
            }
             
        }

        private List<Product> MockProducts()
        {
            List<Product> list = new List<Product>();
            for (int i=1;i<6;i++)
            {
                Product product = new Product(i,"Product "+i,"in stock",i*100,"bottle");
                list.Add(product);
            }
            return list;
        }
    }
}