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
    public partial class View_Certificates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewCertifcate = new SqlCommand("viewCertificate", conn);
            viewCertifcate.CommandType = System.Data.CommandType.StoredProcedure;
            viewCertifcate.Parameters.Add(new SqlParameter("@cid", courseID.Text));
            viewCertifcate.Parameters.Add(new SqlParameter("@sid", Session["user"]));

            DataTable certify = new DataTable();
            certify.Columns.Add("Course ID");
            certify.Columns.Add("Issue Date");
            try
            {
                conn.Open();
                SqlDataReader rdr = viewCertifcate.ExecuteReader(CommandBehavior.CloseConnection);
                String txt = "";
                while (rdr.Read())
                {
                    DataRow dR = certify.NewRow();
                    txt += "Course id :&nbsp" + rdr["cid"].ToString();
                    dR["Course ID"] = rdr["cid"];
                    txt += "<br/>";
                    txt += "Issue date:&nbsp" + rdr["issueDate"];
                    dR["Issue Date"] = rdr["issueDate"];

                    certify.Rows.Add(dR);
                    Response.Write(rdr["cid"]);
                }

                if (certify.Rows.Count == 0)
                {
                    msg.Text = "You are not enrolled in the course or  no certificates has been issued yet";
                    msg.ForeColor = System.Drawing.Color.Red;

                }
                else
                {
                    msg.Text = txt;
                    msg.ForeColor = System.Drawing.Color.Green;

                }

            }
            catch
            {
                msg.Text = "Invalid data";
                msg.ForeColor = System.Drawing.Color.Red;
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student.aspx");
        }


    }
}