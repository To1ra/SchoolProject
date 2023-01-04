using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;



namespace SchoolProject
{
    public class Food
    {
        private string name;
        private int lvl;
        private int price;
        private string category;
        private string FoodID;

        public Food(string name, int lvl, int price, string category, string FoodID)
        {
            this.name = name;
            this.lvl = lvl;
            this.price = price;
            this.category = category;
            this.FoodID = FoodID;
        }

        public string getName() { return this.name; }
        public int getLvl() { return this.lvl; }
        public int getPrice() { return this.price; }
        public string getCategory() { return this.category; }

    }

    public partial class CreateShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddItem(object sender, EventArgs e)
        {
            



        }


        protected void Insertbutton(object sender, EventArgs e)
        {
            try
            {
                if (CheckInputs())
                {
                    OleDbConnection Con1 = new OleDbConnection();
                    Con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\Project.accdb";
                    Con1.Open();
                    string sqlstring1 = "SELECT * FROM Items ORDER BY Food_ID DESC ";
                    OleDbCommand cmd = new OleDbCommand(sqlstring1, Con1);
                    OleDbDataReader Dr = cmd.ExecuteReader();
                    Dr.Read();
                    int ID = Int32.Parse(Dr["Food_ID"].ToString()) + 1;// gets the current Item ID


                    string sqlstring = " INSERT INTO Items (MyCategory,ItemName,Food_ID,Price,Food_Level) VALUES " + "('" + InsertCategory.Text + "','" + InsertName.Text + "','" + ID + "','" + InsertPrice.Text + "','" + InsertFood_Level.Text + "');";
                    Response.Write(sqlstring);
                    OleDbCommand cmd1 = new OleDbCommand(sqlstring, Con1);
                    int y = 0;
                    y = cmd1.ExecuteNonQuery();
                    Response.Write(y);
                    Con1.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        public bool CheckInputs()
        {
            string[] RecivedData = { InsertCategory.Text, InsertName.Text, InsertPrice.Text, InsertFood_Level.Text };
            for (int i = 0; i < RecivedData.Length; i++)
            {
                foreach (char char1 in RecivedData[i])
                {
                    if (i <= 1)
                    {
                        if ((char.IsDigit(char1)))
                        {
                            Response.Write("'" + RecivedData[i] + "'" + "  is not a valid input, it has to be a word!");

                            return false;
                        }
                    }

                    else
                    {
                        if (char.IsLetter(char1))
                        {
                            Response.Write("'" + RecivedData[i] + "'" + " is not a valid input, it has to be a number!");
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }


}
