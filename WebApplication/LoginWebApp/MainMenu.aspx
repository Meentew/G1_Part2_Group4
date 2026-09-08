<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="LoginWebApp.MainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
    <style>
        body { font-family: Tahoma, Arial, sans-serif; background: #f0f2f5; }
        .menu-box {
            width: 400px; margin: 80px auto; padding: 30px;
            background: #fff; border-radius: 8px; box-shadow: 0 2px 8px rgba(0,0,0,0.15);
        }
        .menu-box h2 { color: #2b6cb0; }
        .menu-box ul { list-style: none; padding: 0; }
        .menu-box ul li { margin-bottom: 10px; }
        .menu-box a {
            display: block; padding: 10px 15px; background: #eef2f7;
            border-radius: 4px; text-decoration: none; color: #2b2b2b;
        }
        .menu-box a:hover { background: #dbe6f3; }
        .role-badge {
            display: inline-block; padding: 3px 10px; border-radius: 12px;
            font-size: 12px; color: #fff; background: #718096; margin-left: 8px;
        }
        .btn-logout {
            margin-top: 20px; padding: 8px 15px; background: #c0392b; color: #fff;
            border: none; border-radius: 4px; cursor: pointer;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="menu-box">
            <h2>
                Welcome <asp:Label ID="lblFullName" runat="server"></asp:Label>
                <span class="role-badge"><asp:Label ID="lblRole" runat="server"></asp:Label></span>
            </h2>

            <ul>
                <li><a href="Content/index.html" target="_blank">1. Home</a></li>
                <li><a href="Content/about.html" target="_blank">2. About</a></li>
                <li><a href="Content/cv.html" target="_blank">3. CV</a></li>
                <li><a href="Content/portfolio.html" target="_blank">4. Portfolio</a></li>
                <li><a href="Content/contact.html" target="_blank">5. Contact</a></li>

                <asp:PlaceHolder ID="phAdminMenu" runat="server" Visible="false">
                    <li><a href="UserManagement.aspx" style="background:#fef3cd;">6. User Management (Admin Only)</a></li>
                </asp:PlaceHolder>
            </ul>

            <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn-logout" OnClick="btnLogout_Click" />
        </div>
    </form>
</body>
</html>