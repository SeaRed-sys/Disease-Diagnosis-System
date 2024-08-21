<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    body {
        font-family: Arial, sans-serif;
        padding: 20px;
    }
    .form-group {
        margin-bottom: 10px;
    }
    .form-group label {
        display: block;
        margin-bottom: 5px;
    }
    .form-group input[type="text"],
    .form-group input[type="password"],
    .form-group input[type="email"] {
        width: 100%;
        padding: 10px;
        border: 1px solid #ddd;
        border-radius: 4px;
        box-sizing: border-box;
    }
    .form-group input[type="submit"] {
        width: 100%;
        padding: 10px;
        border: none;
        border-radius: 4px;
        background-color: #5cb85c;
        color: white;
        cursor: pointer;
    }
    .form-group input[type="submit"]:hover {
        background-color: #4cae4c;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <div class="form-group">
        <label for="username">用户名:</label>
          <asp:TextBox ID="txtusername" runat="server"></asp:TextBox><asp:RequiredFieldValidator
         ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名不能为空" 
            ControlToValidate="txtusername" ForeColor="Red"></asp:RequiredFieldValidator>
    
    </div>
          <div class="form-group">
    <label for="username">用户姓名:</label>
      <asp:TextBox ID="txtuserminzhi" runat="server"></asp:TextBox><asp:RequiredFieldValidator
     ID="RequiredFieldValidator4" runat="server" ErrorMessage="用户姓名不能为空" 
        ControlToValidate="txtuserminzhi" ForeColor="Red"></asp:RequiredFieldValidator>

</div>
                  <div class="form-group">
    <label for="username">用户年龄:</label>
      <asp:TextBox ID="txtuserage" runat="server"></asp:TextBox><asp:RequiredFieldValidator
     ID="RequiredFieldValidator5" runat="server" ErrorMessage="用户年龄不能为空" 
        ControlToValidate="txtuserage" ForeColor="Red"></asp:RequiredFieldValidator>

</div>
                  <div class="form-group">
    <label for="username">用户性别:</label>
                      <asp:RadioButtonList ID="Radiousergender" runat="server" RepeatDirection="Horizontal">
                          <asp:ListItem>男</asp:ListItem>
                          <asp:ListItem>女</asp:ListItem>
                      </asp:RadioButtonList>
                      <asp:RequiredFieldValidator
     ID="RequiredFieldValidator7" runat="server" ErrorMessage="用户性别不能为空" 
        ControlToValidate="Radiousergender" ForeColor="Red"></asp:RequiredFieldValidator>

</div>

                  <div class="form-group">
    <label for="username">用户区域:</label>
                      <asp:DropDownList ID="DropDownuserregion" runat="server">
                          <asp:ListItem Selected="True">请选择你的区域</asp:ListItem>
                          <asp:ListItem>荆溪镇</asp:ListItem> 
                          <asp:ListItem>祥谦镇</asp:ListItem>
                          <asp:ListItem>青口镇</asp:ListItem>
                          <asp:ListItem>尚干镇</asp:ListItem>
                          <asp:ListItem>南通镇</asp:ListItem>
                          <asp:ListItem>南屿镇</asp:ListItem>
                          <asp:ListItem>上街镇</asp:ListItem>
                           
                      </asp:DropDownList>
                      
                      <asp:RequiredFieldValidator
     ID="RequiredFieldValidator6" runat="server" ErrorMessage="用户区域不能为空" 
        ControlToValidate="DropDownuserregion" ForeColor="Red"></asp:RequiredFieldValidator>

</div>

    <div class="form-group">
        <label for="email">密码:</label>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator
         ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空" 
            ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>

    </div>
    <div class="form-group">
        <label for="password">再次输入密码:</label>
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator
         ID="RequiredFieldValidator3" runat="server" ErrorMessage="密码不能为空" 
            ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        
        <asp:Button ID="Button1" runat="server" Text="注册" onclick="Button1_Click" />
    </div>
    </div>
    </form>
</body>
</html>
