using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement.student
{
    public partial class issued_books : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string penalty = "0";
        double noofdays = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (Session["student"] == null)
                {
                    Response.Redirect("student_login.apsx");
                }

                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from penalty";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    penalty = dr2["penalty"].ToString();
                }

                    DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("member_id");
                dt.Columns.Add("books_isbn");
                dt.Columns.Add("books_issue_date");
                dt.Columns.Add("books_approx_return_date");
                dt.Columns.Add("full_name");
                dt.Columns.Add("is_books_return");
                dt.Columns.Add("books_returned_date");
                dt.Columns.Add("latedays");
                dt.Columns.Add("penalty");
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from issue_books where member_id='"+ Session["student"].ToString()+"'";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                foreach(DataRow dr1 in dt1.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["member_id"] = dr1["member_id"].ToString();
                    dr["books_isbn"] = dr1["books_isbn"].ToString();
                    dr["books_issue_date"] = dr1["books_issue_date"].ToString();
                    dr["books_approx_return_date"] = dr1["books_approx_return_date"].ToString();
                    dr["full_name"] = dr1["full_name"].ToString();
                    dr["is_books_return"] = dr1["is_books_return"].ToString();
                    dr["books_returned_date"] = dr1["books_returned_date"].ToString();


                    DateTime d1 = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"));
                    DateTime d2 = Convert.ToDateTime(dr1["books_approx_return_date"].ToString());

                    if (d1 > d2)
                    {
                        TimeSpan t = d1 - d2;
                        noofdays = t.TotalDays;
                        dr["latedays"] = noofdays.ToString();
                    }
                    else
                    {
                        dr["latedays"] = "0";
                    }
                    dr["penalty"] = Convert.ToString(Convert.ToDouble(noofdays) * Convert.ToDouble(penalty)); 
                    dt.Rows.Add(dr);
                }
                d1.DataSource = dt;
                d1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}