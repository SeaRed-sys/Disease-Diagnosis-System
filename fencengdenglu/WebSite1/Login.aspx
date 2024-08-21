<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
  body {
    font-family: Arial, sans-serif;
    background: #f7f7f7;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
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
    box-sizing: border-box; /* Makes sure the padding does not affect the total width of the input */
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
    
    <div class="login-container">
  <h2>登录框</h2>
  <form action="">
    <div class="form-group">
      <label for="username">用户名:</label>
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator
         ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名不能为空" 
            ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
      <label for="password">密码:</label>
      <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator
         ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空" 
            ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
     <asp:Button ID="Button1" runat="server" Text="登录" onclick="Button1_Click"  />  
    
    </div>
      <a href="Register.aspx">注册</a>
     <br/>管理员：林尔正  密码123456<br/>
     用户：test   密码123456 <br/>
     专家：test1   密码123456
  </form>
</div>
   
  </form>
 
           
       
 
</body>
</html>
