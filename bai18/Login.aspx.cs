using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bai18
{
    public partial class Login : System.Web.UI.Page
    {
        public bool block;
        public bool loginStatus;
        public List<Account> accounts;
        public List<Session> sessions;
        public int timeBlockLogin;
        protected void Page_Load(object sender, EventArgs e)
        {
            int limitLogin = (int)Session["LoginRemain"];
            accounts = (List<Account>)Application["Accounts"];
            sessions = (List<Session>)Session["Sessions"];
            showAccounts();
            block = (limitLogin == 0);
            // block => gettime block in config
            if (block)
            {
                timeBlockLogin = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["timeBlockLogin"]);
            }
            label.Visible = false;
            loginStatus = (bool)Session["logined"];
            // must not firt access website
            if (loginStatus)
            {
                showSession();
            }
            else
            {
                if (limitLogin != Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["limitLogin"]))
                {
                    label.Visible = true;
                }
            }
           
        }

        private void showSession()
        {
            for (int i = 0; i < sessions.Count; i++)
            {
                TableRow row = new TableRow();
                TableCell userCell = new TableCell();
                TableCell timeCell = new TableCell();
                userCell.Text = sessions[i].Account.Username;
                timeCell.Text = sessions[i].Time.ToString();
                row.Controls.Add(userCell);
                row.Controls.Add(timeCell);
                tblSession.Controls.Add(row);
            }
        }

        private void showAccounts()
        {
            for(int i=0;i< accounts.Count; i++)
            {
                TableRow row = new TableRow();
                TableCell userCell = new TableCell();
                TableCell passCell = new TableCell();
                userCell.Text = accounts[i].Username;
                passCell.Text = accounts[i].Password;
                row.Controls.Add(userCell);
                row.Controls.Add(passCell);
                TableAccount.Controls.Add(row);
            }
            
        }
    }
}