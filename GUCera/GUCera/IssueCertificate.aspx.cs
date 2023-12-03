using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
	public partial class IssueCertificate : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            error.ForeColor = System.Drawing.Color.Red;
        }

		protected void issueCer(object sender, EventArgs e)
		{
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);


                int idIns = Int16.Parse(Session["user"].ToString());
                int idcourse = Int16.Parse(CourseIDtoIssue.Text);
                int studentID = Int16.Parse(StudentIDtoIssue.Text);
                DateTime issueDateCer ;
                if(!DateTime.TryParse(IssueDate.Text,out issueDateCer) || issueDateCer.AddDays(1) < DateTime.Now)
				{
                    error.Text=" Issue Date has to be  not befor today";
                    return;
				}
              



                SqlCommand cmd = new SqlCommand("InstructorIssueCertificateToStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@insId", idIns));
                cmd.Parameters.Add(new SqlParameter("@cid", idcourse));
                cmd.Parameters.Add(new SqlParameter("@sid", studentID));
                cmd.Parameters.Add(new SqlParameter("@issueDate", issueDateCer));

                SqlCommand cmdTemp = new SqlCommand("calculateFinalGrade", conn);
                cmdTemp.CommandType = CommandType.StoredProcedure;

                cmdTemp.Parameters.Add(new SqlParameter("@insId", idIns));
                cmdTemp.Parameters.Add(new SqlParameter("@cid", idcourse));
                cmdTemp.Parameters.Add(new SqlParameter("@sid", studentID));
                SqlParameter success = cmd.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;


                conn.Open();
                cmdTemp.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                
                conn.Close();
                if (success.Value.ToString() == "0")
                {
                    error.ForeColor = System.Drawing.Color.Green;
                    error.Text="Certificate Issued Successfully to The student";
                }
                else if (success.Value.ToString() == "1")
                {
                    error.Text="Course Is Not In GUCera";
                }
                else if (success.Value.ToString() == "2")
                {
                    error.Text="You do not teach this course";
                }
                else if (success.Value.ToString() == "3")
                {
                    error.Text="course have not accepted yet";
                }
                else if (success.Value.ToString() == "4")
                {
                    error.Text="Student do not take this course";
                }
                else if(success.Value.ToString() == "5")
                {
                    error.Text="Student do not pass this course";
                }
				else
				{
                    error.Text = "Student already has this Certificate";
                }
            }
            catch (Exception ex)
            {
               error.Text="Invalid Data";
            }
        }

		protected void HomePage(object sender, EventArgs e)
		{
            Response.Redirect("Instructor.aspx");
		}
	}
}