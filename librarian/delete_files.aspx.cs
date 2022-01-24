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
    public partial class delete_files : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (Session["librarian"] == null)
                {
                    Response.Redirect("login.aspx");
                }
                if (Request.QueryString["id"] != null)
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE add_books set books_video='' where id='"+ Request.QueryString["id"].ToString() +"'";
                    cmd.ExecuteNonQuery();

                }
                else if (Request.QueryString["id1"] != null)
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE add_books set books_pdf='' where id='" + Request.QueryString["id1"].ToString() + "'";
                    cmd.ExecuteNonQuery();

                }
                else
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE add_books where id='" + Request.QueryString["id2"].ToString() + "'";
                    cmd.ExecuteNonQuery();
                }
                Response.Redirect("display_all_books.aspx");
               
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}