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
    public partial class Create_Promo_Code : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Create_PromoCode(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String Code = code.Text;
            DateTime IssueDate = DateTime.Parse(issueDate.Text);
            DateTime ExpiryDate = DateTime.Parse(expiryDate.Text);
            decimal Discount = decimal.Parse(discount.Text);
            int aid = (int)(Session["user"]);

            SqlCommand CreatePromo = new SqlCommand("AdminCreatePromocode", conn);
            CreatePromo.CommandType = CommandType.StoredProcedure;
            CreatePromo.Parameters.Add(new SqlParameter("@code", Code));
            CreatePromo.Parameters.Add(new SqlParameter("@isuueDate", IssueDate));
            CreatePromo.Parameters.Add(new SqlParameter("@expiryDate", ExpiryDate));
            CreatePromo.Parameters.Add(new SqlParameter("@discount", Discount));
            CreatePromo.Parameters.Add(new SqlParameter("@adminId", aid));

            conn.Open();
            CreatePromo.ExecuteNonQuery();
            conn.Close();
        }
        protected void Home(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}