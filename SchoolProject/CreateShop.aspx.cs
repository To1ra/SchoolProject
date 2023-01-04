using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolProject
{
    public partial class CreateShop1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void btnSave_Click1(object sender, EventArgs e)
        {
            try
            {
                string last_fn = "";
                OleDbConnection Con = new OleDbConnection();
                Con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\Project.accdb";
                Con.Open();
                string sqlstring1 = "SELECT * FROM Items; ";
                OleDbCommand cmd = new OleDbCommand(sqlstring1, Con);
                OleDbDataReader Dr = cmd.ExecuteReader();
                Dr.Read();
                Response.Write("<div id='ItemPicker'> ");
                if (Dr.HasRows)
                {

                    do
                    {
                        if (Equals(Dr["MyCategory"], last_fn) == false)
                        {
                            Response.Write("<div class=" + "col-12" + ">");
                            Response.Write("<h3 id=\"" + Dr["MyCategory"].ToString() + "\"  + class=\"machineHeading\" >" + Dr["MyCategory"].ToString() + "</h3>");
                            Response.Write("<ul type=\"" + Dr["MyCategory"].ToString() + "\">");
                            Response.Write("</div>");
                            Response.Write("<div class=\"col-5 heading\">");
                            Response.Write("<h4>Name</h4>");
                            Response.Write("</div>");
                            Response.Write("<div class=\"col-2 heading\">");
                            Response.Write("<h4>Level</h4> ");
                            Response.Write("</div>");
                            Response.Write("<div class=\"col-2 heading\">");
                            Response.Write("<h4>Price</h4>");
                            Response.Write("</div>");
                            Response.Write("<div class=\"col-3 heading\">");
                            Response.Write("<h4>Quantity</h4>");
                            Response.Write("</div>");
                            last_fn = Dr["MyCategory"].ToString();
                        }


                        else
                        {
                            Response.Write("<hr>");
                            Response.Write("<div class=\"col-3 foodName\">");
                            Response.Write(Dr["ItemName"].ToString());
                            Response.Write("</div>");
                            Response.Write("<div class=\"col-2 foodPic\">");
                            // Response.Write("<img class=\"foodPicSize\" src=\"../HD_Foods/" + foods[i].imgid + ".png\">");
                            Response.Write("</div>");
                            Response.Write("<div class=\"col-2 foodLevel\">");
                            Response.Write(Dr["Food_Level"].ToString());
                            Response.Write("</div>");
                            Response.Write("<div class=\"col-2 foodPrice\">");
                            Response.Write(Dr["Price"].ToString());
                            Response.Write("</div>");
                            Response.Write("<div class=\"col-3 quantityInput\">");
                            Response.Write("<input class=" + "numinp" + " type=\"number\" id=\"" + Dr["Food_ID"] + "\" step=\"1\" min=\"0\" value=\"" + '1' /*getDefaultFoodValue(foods[i].tag)*/ + "\" onchange=\"onFoodChange(this.id)\">");
                            Response.Write("</div>");
                        }
                    }
                    while (Dr.Read());
                    Response.Write("</div>");
                    Con.Close();
                }
            }

            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            //    try
            //    {
            //        OleDbConnection Con1 = new OleDbConnection();
            //        Con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\Project.accdb";
            //        Con1.Open();
            //        string sqlstring1 = "SELECT * FROM A WHERE HashID = '#9Z48' ";
            //        OleDbCommand cmd = new OleDbCommand(sqlstring1, Con1);
            //        OleDbDataReader Dr = cmd.ExecuteReader();
            //        Dr.Read();
            //        if (Dr.HasRows)
            //        {
            //            string a = Dr["FarmLevel"].ToString();
            //            string b = Dr["FarmID"].ToString();
            //            string c = Dr["HashID"].ToString();
            //            string id = ShopId();
            //            DateTime currentTime = DateTime.Now;
            //            TimeZoneInfo timeZone = TimeZoneInfo.Local;
            //            string time = "" + currentTime + timeZone.DisplayName+ "";
            //            string sqlstring = " INSERT INTO Shops (ShopID,ShopPassword,TimeCreated,AmountOfItems,HighestFood, Name_IG, FarmID, FarmLevel, TransferOption, Particial) VALUES " + "('" + id + "','" + ShopPassword.Text + "','" + time + "','" + 256 + "','" + 0 + "','" + Name_IG.Text + "','" + b + "','" + a + "','" + TransferOpt.Text  + "','"  + Particial.Checked + "');";
            //            OleDbCommand cmd1 = new OleDbCommand(sqlstring, Con1);
            //            int y = 0;
            //            y = cmd1.ExecuteNonQuery();
            //            Response.Write(y);
            //            Con1.Close();
            //        }
            //        Con1.Close();
            //    }

            //    catch (Exception ex)
            //    {
            //        Response.Write(ex.Message);
            //    }
            //}


            //public string ShopId()
            //{
            //    string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            //    Random rng = new Random();
            //    string code = "";
            //    for (int i = 0; i < 6; i++)
            //    {
            //        char ch = chars[rng.Next(chars.Length)];
            //        code += ch;
            //    }
            //    return code;
            //}

        }
    }
}


