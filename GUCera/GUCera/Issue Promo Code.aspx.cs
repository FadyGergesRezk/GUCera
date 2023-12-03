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
    public partial class Issue_Promo_Code : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Issue_PromoCode(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int sid = Int16.Parse(Sid.Text);
            String pid = Pid.Text;

            SqlCommand IssuePromo = new SqlCommand("AdminIssuePromocodeToStudent", conn);
            IssuePromo.CommandType = CommandType.StoredProcedure;
            IssuePromo.Parameters.Add(new SqlParameter("@sid", sid));
            IssuePromo.Parameters.Add(new SqlParameter("@pid", pid));

            conn.Open();
            IssuePromo.ExecuteNonQuery();
            conn.Close();
            Response.Write(Session["user"]);
        }
        protected void Home(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}