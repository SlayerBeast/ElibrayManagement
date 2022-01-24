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
    public partial class display_all_books : System.Web.UI.Page
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
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM add_books";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                r1.DataSource = dt;
                r1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        public string checkvideo(object myvalue,object id)
        {
            if (myvalue == "")
            {
                return myvalue.ToString();
            }
            else
            {
                return "<a href='delete_files.aspx?id=" + id + "' style='color:red'>delete video</a>";
            }
        }

        public string checkpdf(object myvalue1, object id)
        {
            if (myvalue1 == "")
            {
                return myvalue1.ToString();
            }
            else
            {
                return "<a href='delete_files.aspx?id1=" + id + "' style='color:red'>delete pdf</a>";
            }
        }
    }
}