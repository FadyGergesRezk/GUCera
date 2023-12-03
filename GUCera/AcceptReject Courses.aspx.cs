using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class AcceptReject_Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Accept_Reject(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int aid = (int)(Session["user"]);
            int cid = Int16.Parse(Cid.Text);

            SqlCommand AccRej = new SqlCommand("AdminAcceptRejectCourse", conn);
            AccRej.CommandType = CommandType.StoredProcedure;
            AccRej.Parameters.Add(new SqlParameter("@adminid", aid));
            AccRej.Parameters.Add(new SqlParameter("@courseId", cid));

            conn.Open();
            AccRej.ExecuteNonQuery();
            conn.Close();
            Response.Write(Session["user"]);
        }

		protected void Home(object sender, EventArgs e)
		{
                Response.Redirect("HomePage.aspx");
		}
	}
}