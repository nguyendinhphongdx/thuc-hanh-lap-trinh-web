using System;
using System.Collections.Generic;

namespace bai18
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Accounts"] = new List<Account>()
            {
                new Account(1,"root123","123456"),
                new Account(2,"administrator","123456"),
            };
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["LoginRemain"] = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["limitLogin"]);
            Session["Sessions"] = new List<Session>() { };
            Session["logined"] = false;
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