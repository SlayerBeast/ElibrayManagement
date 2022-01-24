using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement.librarian
{
    public partial class adminBookinventory : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["librarian"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string path = "";
                string path2 = "";
                string path3 = "";
                f1.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_images/" + f1.FileName.ToString());
                path = "books_images/" + f1.FileName.ToString();

                if (f2.FileName.ToString() != "")
                {
                    
                    f2.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_pdf/" + f2.FileName.ToString());
                    path2 = "books_pdf/" + f2.FileName.ToString();
                }
                if (f3.FileName.ToString() != "")
                {
                    
                    f3.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_videos/" + f3.FileName.ToString());
                    path3 = "books_videos/" + f3.FileName.ToString();
                }

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO add_books values('"+ bookstitle.Text +"','"+ path.ToString() +"','"+ path2.ToString() +"','"+ path3.ToString() +"','"+ authorname.Text +"','"+ isbn.Text +"','"+ qty.Text +"')";
                cmd.ExecuteNonQuery();
                msg.Style.Add("display", "block");
                con.Close();
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}
