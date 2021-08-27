using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace uploadFile
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String strFolder = Server.MapPath("/App_Data/");
            string[] filePaths = Directory.GetFiles(strFolder);
            List<Item> items = CutFiles(filePaths);
            String resString = "";
            
            foreach (Item item in items)
            {
                
                TableRow r = new TableRow();
                TableCell c = new TableCell();
                FileInfo finfo = new FileInfo(item.FilePath);
                c.Controls.Add(new LiteralControl("<p class='cell'>" + item.FileName + "</p>"));
                r.Cells.Add(c);
                TableCell cSize = new TableCell();
                Button button = new Button();
                button.Click += new EventHandler(this.btnDowload_Click);
                button.OnClientClick = item.FilePath;
                button.Attributes.Add("fileName", item.FileName);
                button.Attributes.Add("pathFile", item.FilePath);
                button.Text = finfo.Length+"";
                //cSize.Controls.Add(new LiteralControl("<p class='cell'>" + finfo.Length + "</p>"));
                cSize.Controls.Add(button);
                r.Cells.Add(cSize);
                Table1.Rows.Add(r);
                //resString += item.FileName + "</br>";
            }
            Response.Write(resString);
        }

     

        private List<Item> CutFiles(string[] filePaths)
        {
            List<Item> listItem = new List<Item>();
            foreach (string item in filePaths)
            {

                string[] arraySlash = item.Split('\\');
                listItem.Add(new Item(arraySlash[arraySlash.Length - 1], item));
            }
            return listItem;
        }
        protected void btnDowload_Click(object sender, EventArgs e)
        {
            // Here's where you do stuff.
            Button button = (Button)sender;
            Response.Clear();
            Response.ContentType = "application/octet-stream";
            Response.AppendHeader("Content-Disposition", "filename=" + button.Attributes["fileName"]);
            Response.TransmitFile(button.Attributes["pathFile"]);
        }

    }
    
}
