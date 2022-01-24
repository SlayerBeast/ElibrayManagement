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
    
    public partial class edit_books : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        int id;

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
                if (IsPostBack) return;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM add_books where id="+id+"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    bookstitle.Text = dr["book_title"].ToString();
                    authorname.Text = dr["books_author_name"].ToString();
                    isbn.Text = dr["books_isbn"].ToString();
                    qty.Text = dr["available_qty"].ToString();
                    booksimage.Text = dr["books_image"].ToString();
                    bookspdf.Text = dr["books_pdf"].ToString();
                    booksvideo.Text = dr["books_video"].ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void b3_Click(object sender, EventArgs e)
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
                

                if(f1.FileName.ToString() != "")
                {
                    f1.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_images/" + f1.FileName.ToString());
                    path = "books_images/" + f1.FileName.ToString();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE add_books set book_title='" + bookstitle.Text + "',books_image='" + path.ToString() + "',books_author_name='" + authorname.Text + "',books_isbn='" + isbn.Text + "',available_qty='" + qty.Text + "' where id=" + id + "";
                    cmd.ExecuteNonQuery();
                }

                if (f2.FileName.ToString() != "")
                {

                    f2.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_pdf/" + f2.FileName.ToString());
                    path2 = "books_pdf/" + f2.FileName.ToString();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE add_books set book_title='" + bookstitle.Text + "',books_pdf='" + path2.ToString() + "',books_author_name='" + authorname.Text + "',books_isbn='" + isbn.Text + "',available_qty='" + qty.Text + "' where id=" + id + "";
                    cmd.ExecuteNonQuery();
                }
                if (f3.FileName.ToString() != "")
                {

                    f3.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_videos/" + f3.FileName.ToString());
                    path3 = "books_videos/" + f3.FileName.ToString();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE add_books set book_title='" + bookstitle.Text + "',books_video='" + path3.ToString() + "',books_author_name='" + authorname.Text + "',books_isbn='" + isbn.Text + "',available_qty='" + qty.Text + "' where id=" + id + "";
                    cmd.ExecuteNonQuery();
                }
                if(f1.FileName.ToString() == "" && f2.FileName.ToString() == "" && f3.FileName.ToString() == "")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE add_books set book_title='" + bookstitle.Text + "',books_author_name='" + authorname.Text + "',books_isbn='" + isbn.Text + "',available_qty='" + qty.Text + "' where id=" + id + "";
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