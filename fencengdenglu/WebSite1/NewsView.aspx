<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewsView.aspx.cs" Inherits="NewsView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta charset="UTF-8" name="viewport" content="width=device-width, initial-scale=1.0"/>  
<title>新闻列表</title>  
<link rel="stylesheet" href="newstyles.css"/>  
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="news-article">  
  <h1 class="news-title">
                <asp:Label ID="titlelab" runat="server" Text="Label"></asp:Label></h1>  
  <div class="news-content">  
    <asp:Label ID="contentlab" runat="server" Text="Label"></asp:Label>
    <!-- 更多新闻内容段落... -->  
  </div>  
</div>  
        </div>
    </form>
</body>
</html>
