<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Xiugaimima.aspx.cs" Inherits="admin_Xiugaimima" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <style>  
      /* 基础样式 */  
      body {  
          font-family: Arial, sans-serif;  
          margin: 0;  
          padding: 20px;  
          background-color: #f0f0f0;  
      }  

      h1 {  
          text-align: center;  
          color: #333;  
      }  

   .login-container {
        width: 300px;
        padding: 40px;
        background: #fff;
        border-radius: 5px;
        box-shadow: 0 2px 5px rgba(0, 0, 0, 0.2);
      }
      .login-container h2 {
        text-align: center;
        margin-bottom: 20px;
      }
      .form-group {
        margin-bottom: 15px;
      }
      .form-group label {
        display: block;
        margin-bottom: 5px;
      }
      .form-group input[type="text"],
      .form-group input[type="password"] {
        width: 100%;
        padding: 10px;
        margin-top: 2px;
        border: 1px solid #ddd;
        border-radius: 4px;
        box-sizing: border-box; 
      }
      .form-group input[type="submit"] {
        width: 100%;
        padding: 10px;
        border: none;
        border-radius: 4px;
        background: #5cb85c;
        font-size: 16px;
        color: white;
        cursor: pointer;
      }
      .form-group input[type="submit"]:hover {
        background: #4cae4c;
      }


  </style>  
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>修改密码</h1>

        <div class="form-group">
            <label for="username">用户名:</label>
            <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label>
        </div>

        <div class="form-group">
          <label for="Oldpassword">旧密码:</label>
          <asp:TextBox ID="txbOldpassword" runat="server" ></asp:TextBox><asp:Label ID="msg" runat="server" Text="" ForeColor="Red"></asp:Label>
          <label for="Oldpassword">新密码:</label>
            <asp:TextBox ID="txbNewpassword" runat="server" ></asp:TextBox>
          <asp:RequiredFieldValidator
             ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空" 
                ControlToValidate="txbNewpassword" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
         <asp:Button ID="Button1" runat="server" Text="确认修改" onclick="Button1_Click"  />  
       </div>
    </div>
    </form>
</body>
</html>
