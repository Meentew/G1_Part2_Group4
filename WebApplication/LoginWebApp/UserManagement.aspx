<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="LoginWebApp.UserManagement" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Management</title>
    <style>
        body { font-family: Tahoma, Arial, sans-serif; background: #f0f2f5; }
        .page-box {
            width: 650px; margin: 60px auto; padding: 30px;
            background: #fff; border-radius: 8px; box-shadow: 0 2px 8px rgba(0,0,0,0.15);
        }
        .page-box h2 { color: #2b6cb0; }
        table { width: 100%; border-collapse: collapse; margin-top: 15px; }
        th, td { padding: 10px; border: 1px solid #ddd; text-align: left; }
        th { background: #2b6cb0; color: #fff; }
        tr:nth-child(even) { background: #f7f9fc; }
        .btn-back {
            display: inline-block; margin-top: 20px; padding: 8px 15px;
            background: #718096; color: #fff; text-decoration: none; border-radius: 4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="page-box">
            <h2>User Management</h2>
            <p>รายชื่อผู้ใช้งานทั้งหมดในระบบ (ดึงจากฐานข้อมูลจริง)</p>

            <asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="false" CellPadding="0">
                <Columns>
                    <asp:BoundField DataField="UserID" HeaderText="User ID" />
                    <asp:BoundField DataField="FullName" HeaderText="Full Name" />
                    <asp:BoundField DataField="RoleName" HeaderText="Role" />
                </Columns>
            </asp:GridView>

            <a href="MainMenu.aspx" class="btn-back">&laquo; กลับไปหน้า Main Menu</a>
        </div>
    </form>
</body>
</html>
