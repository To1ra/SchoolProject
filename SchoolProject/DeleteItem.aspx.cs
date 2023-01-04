using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;


namespace SchoolProject
{
    public partial class DeleteItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Delbutton(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection Con1 = new OleDbConnection();
                Con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\Project.accdb";
                Con1.Open();
                string sqlstring = "DELETE * FROM Items WHERE Food_ID=" + Delbox.Text + ";";
                OleDbCommand cmd = new OleDbCommand(sqlstring, Con1);
                Response.Write(sqlstring);
                int y = 0;
                y = cmd.ExecuteNonQuery();
                Response.Write(y);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}