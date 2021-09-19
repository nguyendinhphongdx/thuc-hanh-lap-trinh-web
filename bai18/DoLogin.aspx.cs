using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bai18
{
    public partial class DoLogin : System.Web.UI.Page
    {
        public List<Account> Accounts;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Count >0 )
            {
                Accounts = (List<Account>)Application["Accounts"];
                string username = Request.Form["username"];
                string password = Request.Form["password"];
                Account currentLogin = Accounts.Find(item => item.Username == username && item.Password == password);
                int limitLogin = (int)Session["LoginRemain"];
                if (limitLogin != 0)
                {
                    if (currentLogin == null)
                    {
                        Session["LoginRemain"] = limitLogin - 1;
                        Session["logined"] = false;
                        Response.Redirect("/Login.aspx?login=false");
                    }
                    else
                    {
                        List<Session> listSession = (List<Session>)Session["Sessions"];
                        listSession.Add(new Session(currentLogin, DateTime.Now));
                        Session["Sessions"] = listSession;
                        Session["logined"] = true;
                        Session["LoginRemain"] = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["limitLogin"]);
                        Response.Redirect("/Login.aspx?login=success");
                    }
                }
                else
                {
                    Response.Redirect("/Login.aspx?status=block");
                }
            }
            else
            {
                Response.Redirect("/Login.aspx");
            }
        }
    }
}