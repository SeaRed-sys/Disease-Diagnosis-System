using System;
using xitongfenxi;
using System.Web.Security;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
       
    }
    /// <summary>
    /// 登录按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {

        //验证用户信息
        userclass l = new userclass();
        string md5psw = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox2.Text.Trim(), "MD5");
        int uid = l.islogin(TextBox1.Text.Trim(), md5psw);

        
        if (uid > 0)
        {
            //如果正确，传入Session值
            Session["username"] = TextBox1.Text.Trim();
            Session["id"] = uid.ToString();
            Response.Redirect("admin/UserPage.html");
        }
        else
        {
            //如果错误，给出提示
            Response.Write("<script>alert('用户或者密码错误')</script>");
        }
       
    }
    
}