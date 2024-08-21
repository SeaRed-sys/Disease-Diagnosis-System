<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InforZhunjia.aspx.cs" Inherits="admin_news_InforManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
  
        /* 查询输入框和按钮样式 */  
        .search-container {  
            margin-bottom: 20px;  
            text-align: center;  
        }  
  
        .search-container input[type=text] {  
            padding: 6px;  
            width: 300px;  
            border: 1px solid #ccc;  
            border-radius: 4px;  
            box-sizing: border-box;  
        }  
  
        .search-container button {  
            padding: 6px 10px;  
            margin-left: 5px;  
            background-color: #4CAF50;  
            color: white;  
            border: none;  
            cursor: pointer;  
            border-radius: 4px;  
        }  
  
        .search-container button:hover {  
            background-color: #45a049;  
        }  
  
        /* 表格样式 */  
        table {  
            width: 100%;  
            border-collapse: collapse;  
            margin-top: 20px;  
            background-color: #fff;  
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);  
        }  
  
        th, td {  
            padding: 12px;  
            text-align: left;  
            border-bottom: 1px solid #ddd;  
        }  
  
        th {  
            background-color: #f5f5f5;  
            font-weight: bold;  
        }  
  
        th:last-child {  
            text-align: center;  
        }  
  
        .actions {  
            text-align: right;  
        }  
  
        .actions button {  
            margin-left: 5px;  
            padding: 5px 10px;  
            background-color: #4CAF50;  
            color: white;  
            border: none;  
            cursor: pointer;  
            border-radius: 4px;  
        }  
  
        .actions button:hover {  
            background-color: #45a049;  
        }  
  
        /* 去除最后一个单元格的下边框，使表格看起来更整洁 */  
        tr td:last-child {  
            border-bottom: none;  
        }  
  
        /* 去除表格的最后一行的下边框，如果是表格的最后一行 */  
        tr:last-child td {  
            border-bottom: none;  
        }  
    </style> 
</head>
<body>
    <form id="form1" runat="server">
       <div>
 
        <h1>专家信息管理</h1>  
        <a href="InsertZhuanjia.aspx">添加专家</a>  

      </div>

    <div class="search-container">  
        <asp:TextBox ID="txttitle" runat="server"></asp:TextBox> 
        <asp:Button ID="Button2"  runat="server" Text="查询"  OnClick="Button2_Click"/>
    </div>  
  
<table>  
    <thead>  
        <tr>  
            <th>专家编号</th>  
            <th>专家姓名</th>  
            <th>专家信息</th>  
            <th>专家单位</th>  
            <th>专家年龄</th>  
            <th>操作</th>  
        </tr>  
    </thead>  
    <tbody>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    </tbody>
       
</table>  

    </form>
</body>
</html>
