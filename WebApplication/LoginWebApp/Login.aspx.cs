using System;
using System.Configuration;
using System.Data.SqlClient;

namespace LoginWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ไม่ต้องทำอะไรตอนโหลดหน้าแรก
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUserID.Text.Trim();
            string password = txtPassword.Text.Trim();

            // ตรวจสอบว่ากรอกครบไหม
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                ShowError("กรุณากรอก User ID และ Password ให้ครบ");
                return;
            }

            // ดึง connection string จาก Web.config
            string connStr = ConfigurationManager.ConnectionStrings["LoginAppDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // ใช้ Parameterized Query ป้องกัน SQL Injection (ห้าม concat string ตรงๆ)
                string query = "SELECT FullName, RoleName FROM Users WHERE UserID = @UserID AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Login สำเร็จ -> เก็บข้อมูลไว้ใน Session
                                Session["UserID"] = userId;
                                Session["FullName"] = reader["FullName"].ToString();
                                Session["RoleName"] = reader["RoleName"].ToString();

                                Response.Redirect("MainMenu.aspx");
                            }
                            else
                            {
                                // ไม่เจอ record ที่ตรงกัน -> Login ล้มเหลว
                                ShowError("User ID หรือ Password ไม่ถูกต้อง");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        ShowError("เกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล: " + ex.Message);
                    }
                }
            }
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }
    }
}