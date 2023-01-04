using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

namespace SchoolProject
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string code = GenerateCode();
                OleDbConnection Con1 = new OleDbConnection();
                Con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\Project.accdb";
                Con1.Open();

                string sqlstring = "INSERT INTO A (NickName, myPassword, FarmName, FarmLevel, Email, FarmID, HashID, Role) VALUES " + "('" + NickName.Text + "','" + Password.Text + "','" + FarmName.Text + "','" + FarmLevel.Text + "','" + Email.Text + "','" + FarmID.Text + "','" + '#'+code + "','" + "User" + "');";
                Response.Write(sqlstring);
                OleDbCommand cmd1 = new OleDbCommand(sqlstring, Con1);
                int y = 0;
                y = cmd1.ExecuteNonQuery();
                Response.Write(y);
                Con1.Close();
            }

            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        public string GenerateCode()
        {
            string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rng = new Random();
            string code = "";
            for (int i = 0; i < 4; i++)
            {
                char ch = chars[rng.Next(chars.Length)];
                code += ch;
            }
            return code;
        }

    }
}