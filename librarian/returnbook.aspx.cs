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
    public partial class returnbook : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        int id;
        string books_isbn = "";
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
                id = Convert.ToInt32(Request.QueryString["id"].ToString());

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update issue_books set is_books_return='yes', books_returned_date='" + DateTime.Now.ToString("yyyy/MM/dd") +"' where id="+ id +"";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from issue_books where id="+ id +"";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                foreach(DataRow dr1 in dt1.Rows)
                {
                    books_isbn = dr1["books_isbn"].ToString();
                }

                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "update add_books set available_qty=available_qty+1 where books_isbn='"+ books_isbn.ToString() +"'";
                cmd2.ExecuteNonQuery();

                Response.Redirect("return_books.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}