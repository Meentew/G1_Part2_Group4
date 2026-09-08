<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginWebApp.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>เข้าสู่ระบบ - Login</title>
    <style>
        body { font-family: Tahoma, Arial, sans-serif; background: #f0f2f5; }
        .login-box {
            width: 320px; margin: 100px auto; padding: 30px;
            background: #fff; border-radius: 8px; box-shadow: 0 2px 8px rgba(0,0,0,0.15);
        }
        .login-box h2 { text-align: center; color: #333; }
        .form-group { margin-bottom: 15px; }
        .form-group label { display: block; margin-bottom: 5px; color: #555; }
        .form-group input[type=text], .form-group input[type=password] {
            width: 100%; padding: 8px; box-sizing: border-box;
            border: 1px solid #ccc; border-radius: 4px;
        }
        .btn-login {
            width: 100%; padding: 10px; background: #2b6cb0; color: #fff;
            border: none; border-radius: 4px; cursor: pointer; font-size: 15px;
        }
        .btn-login:hover { background: #1e4e8c; }
        .error-msg { color: #c0392b; text-align: center; display: block; margin-top: 10px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-box">
            <h2>เข้าสู่ระบบ</h2>

            <div class="form-group">
                <label for="txtUserID">User ID</label>
                <asp:TextBox ID="txtUserID" runat="server" placeholder="กรอก User ID"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtPassword">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="กรอกรหัสผ่าน"></asp:TextBox>
            </div>

            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn-login" OnClick="btnLogin_Click" />

            <asp:Label ID="lblError" runat="server" CssClass="error-msg" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>