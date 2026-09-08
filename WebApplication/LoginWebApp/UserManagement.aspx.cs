using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LoginWebApp
{
    public partial class UserManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ถ้ายังไม่ได้ Login ให้เด้งกลับไปหน้า Login
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            // Access Control: หน้านี้ Admin เท่านั้น
            // แม้ User จะพิมพ์ URL ตรงๆ เข้ามาก็ต้องเด้งออกไป ไม่ใช่แค่ซ่อนเมนู
            string role = Session["RoleName"].ToString().Trim();
            if (!role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                Response.Redirect("MainMenu.aspx");
                return;
            }

            if (!IsPostBack)
            {
                LoadUsers();
            }
        }

        private void LoadUsers()
        {
            string connStr = ConfigurationManager.ConnectionStrings["LoginAppDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT UserID, FullName, RoleName FROM Users";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    gvUsers.DataSource = dt;
                    gvUsers.DataBind();
                }
            }
        }
    }
}