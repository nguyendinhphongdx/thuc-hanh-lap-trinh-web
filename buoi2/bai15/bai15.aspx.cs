using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace bai15
{
    public partial class bai15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Count > 0)
            {
                String name = Request.Form["name"];
                String gender = Request.Form["gender"];
                String birthday = Request.Form["birthday"];
                //Response.Write(Server.MapPath(""));
                showXML(name,gender,birthday);
            }
            else
            {
                Response.Redirect("index.html");
            }
        }
        public void showXML(String name,String gender,String birthday)
        {
            //  XmlDocument xml = new XmlDocument();
            //  string s = vxl.ToString() ;
            //xml.LoadXml(s);
            //Response.ContentType = "text/xml";
            // Response.Write(s);
            // string fileName = @"..\..\phone.xml";
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.LoadXml("<?xml version='1.0'?> <ViXuLy></ViXuLy>");
            //XmlElement xname, xgender, xdate;
            //xname = xmlDoc.CreateElement("Name");
            //xgender = xmlDoc.CreateElement("Name");
            //xdate = xmlDoc.CreateElement("Name");
            //xname.InnerText = name;
            //xgender.InnerText = gender;
            //xdate.InnerText = birthday;
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