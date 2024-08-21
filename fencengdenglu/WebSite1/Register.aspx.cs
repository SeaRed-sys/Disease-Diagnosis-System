﻿using System;
using System.Web.Security;
using xitongfenxi;
public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    /// <summary>
    /// 注册按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        //首先判断两次密码是否一致

        if (TextBox2.Text.Trim() != TextBox3.Text.Trim())
        {
            Response.Write("<script>alert('两次密码不一致')</script>");
        }

        //然后在增加新的普通用户

        else
        {
            userclass u = new userclass();
            string md5psw = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox2.Text.Trim(), "MD5");
            if (u.yonghuzhuce(txtusername.Text.Trim(), md5psw, txtuserminzhi.Text.Trim(), DropDownuserregion.SelectedValue, Radiousergender.SelectedValue,int.Parse(txtuserage.Text.Trim()))) 
            {
                Response.Write("<script>alert('注册成功'); window.parent.location.href='Login.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('注册失败')</script>");
            }

        }
    }
}