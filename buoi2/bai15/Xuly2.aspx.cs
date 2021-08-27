using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bai15
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count >0)
            {
                String name = Request.QueryString["name"];
                String gender = Request.QueryString["gender"];
                String birthday = Request.QueryString["birthday"];
                showXML(name,gender,birthday);
            }
            else
            {
                Response.Redirect("index.html");
            }
        }
        public void showXML(String name, String gender, String birthday)
        {
            string str = "<root>" + "<name>" + name + "</name>";
            str += "<gender>" + gender + "</gender>";
            str += "<birthday>" + birthday + "</birthday>";
            str += "</root>";
            Response.ClearHeaders();
            Response.AddHeader("content-type", "text/xml");
            Response.Write(str);
            Response.End();
        }
    }
}