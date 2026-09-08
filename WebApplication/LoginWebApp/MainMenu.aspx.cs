using System;

namespace LoginWebApp
{
    public partial class MainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                lblFullName.Text = Session["FullName"].ToString();
                lblRole.Text = Session["RoleName"].ToString();

                string role = Session["RoleName"].ToString();
                phAdminMenu.Visible = (role == "Admin");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}