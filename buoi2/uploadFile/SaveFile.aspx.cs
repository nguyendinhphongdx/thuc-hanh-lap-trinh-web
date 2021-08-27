using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace uploadFile
{
    public partial class SaveFile : System.Web.UI.Page
    {
        public String strFolder = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            strFolder = Server.MapPath("/App_Data/");
            HttpPostedFile fileUpload = Request.Files[0];
            if (!Directory.Exists(strFolder))
            {
                Directory.CreateDirectory(strFolder);
            }
            // Save the uploaded file to the server.
            String strFilePath = strFolder + fileUpload.FileName;
            if (File.Exists(strFilePath))
            {
               Console.Write(fileUpload.FileName + " already exists on the server!");
            }
            else
            {
                fileUpload.SaveAs(strFilePath);
                Console.Write( "Save success! " + fileUpload.FileName);
            }
            Response.Redirect("/FileExplorer.aspx");
        }
    }
}