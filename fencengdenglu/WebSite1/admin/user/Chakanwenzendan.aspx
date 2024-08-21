<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chakanwenzendan.aspx.cs" Inherits="admin_user_Chakanwenzendan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
          <h2>中医问诊窗体</h2>  
    <div class="form-group">          
          <h3>舌苔情况</h3>  
          <asp:RadioButtonList ID="TongueCondition" runat="server" RepeatDirection="Horizontal">  
              <asp:ListItem Text="偏红" Value="偏红" />  
              <asp:ListItem Text="偏白" Value="偏白" />  
              <asp:ListItem Text="偏黄" Value="偏黄" />  
          </asp:RadioButtonList>  
          
                <div class="form-group">    
          <h3>咳嗽情况</h3>  
          <asp:RadioButtonList ID="CoughCondition" runat="server" RepeatDirection="Horizontal">  
              <asp:ListItem Text="无" Value="无" />  
              <asp:ListItem Text="轻微" Value="轻微" />  
              <asp:ListItem Text="严重" Value="严重" /> 
          </asp:RadioButtonList>  
           

  <div class="form-group">  
          <h3>大小便情况</h3>  
          <asp:RadioButtonList ID="BowelCondition" runat="server" RepeatDirection="Horizontal">  
              <asp:ListItem Text="正常" Value="正常" />  
              <asp:ListItem Text="便秘" Value="便秘" />  
              <asp:ListItem Text="腹泻" Value="腹泻" />  
          </asp:RadioButtonList>  
            
         <div class="form-group">  

    <div class="form-group">
        <label for="username">专家诊断:</label>
          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator
         ID="RequiredFieldValidator1" runat="server" ErrorMessage="新闻标题能为空" 
            ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
    
    </div>
          <div class="form-group">
    <label for="username">开药处方:</label>
      <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Height="300" Width="100%"></asp:TextBox><asp:RequiredFieldValidator
     ID="RequiredFieldValidator4" runat="server" ErrorMessage="新闻内容不能为空" 
        ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator>

</div>



  <div class="form-group">
      
   
  </div>
  </div>
    </form>
</body>
</html>
