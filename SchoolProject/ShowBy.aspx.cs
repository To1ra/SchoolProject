using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace SchoolProject
{
    public partial class ShowBy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ori1 = "ori";
            outputLabel.Text = ori1;

        }

        protected void Show_By(object sender, EventArgs e)
        {
            OleDbConnection Con1 = new OleDbConnection();
            Con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\Project.accdb";
           
            Con1.Open();
            string sqlstring1 = "SELECT * FROM Items";
            OleDbCommand cmd = new OleDbCommand(sqlstring1, Con1);
            OleDbDataReader Dr = cmd.ExecuteReader();
            Dr.Read();

            Response.Write("MyCategory".ToString());
            Response.Write("                |");
            Response.Write("ItemName".ToString());
            Response.Write("                            |");
            Response.Write("Food_ID".ToString());
            Response.Write("                           |");
            Response.Write("Price".ToString());
            Response.Write("                         |");
            Response.Write("Food_Level".ToString());
            Response.Write("                     ");
            Response.Write("<br/>");

            if (Dr.HasRows)
            {
                do
                {
                    Response.Write(Dr["MyCategory"].ToString());
                    Response.Write("        ");
                    Response.Write(Dr["ItemName"].ToString());
                    Response.Write("         ");
                    Response.Write(Dr["Food_ID"].ToString());
                    Response.Write("         ");
                    Response.Write(Dr["Price"].ToString());
                    Response.Write("          ");
                    Response.Write(Dr["Food_Level"].ToString());
                    Response.Write("         ");
                    Response.Write("<br/>");


                }
                while (Dr.Read());

                Con1.Close();
                Response.Write("found");
            }
            else
            {
                Response.Write("NOT found");
                Con1.Close();

            }

        }
    }
}