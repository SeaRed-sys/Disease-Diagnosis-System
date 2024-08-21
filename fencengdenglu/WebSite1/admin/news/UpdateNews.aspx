<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateNews.aspx.cs" Inherits="admin_news_UpdateNews" %>

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
         <div><h1>患者问诊单处理</h1> </div>

<div class="search-container">  
    <asp:Label ID="lblusername" runat="server"></asp:Label>  患者情况：<br />
   
    舌苔情况：<asp:Label ID="lblshetai" runat="server"></asp:Label> <br />
    咳嗽情况：<asp:Label ID="lblkesou" runat="server"></asp:Label> <br />
    大小便情况：<asp:Label ID="lbldaxiaobian" runat="server"></asp:Label> <br />
</div>  
      <div class="form-group">
        <label for="username">专家诊断:</label>
          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator
         ID="RequiredFieldValidator1" runat="server" ErrorMessage="专家诊断不能为空" 
            ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
    
    </div>
          <div class="form-group">
    <label for="username">专家处方:</label>
      <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Height="300" Width="100%"></asp:TextBox><asp:RequiredFieldValidator
     ID="RequiredFieldValidator4" runat="server" ErrorMessage="专家处方不能为空" 
        ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator>

</div>

    <div class="form-group">
        
        <asp:Button ID="Button1" runat="server" Text="修改新闻" OnClick="Button1_Click"  />
    </div>
    </div>
    </form>
</body>
</html>
