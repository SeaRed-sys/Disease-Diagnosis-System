using EntityClass;
using System;
using System.Web.Security;
using xitongfenxi;

public partial class admin_Xiugaimima : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //首先，判断用户名是否为空值或空字符串
        //如果是，转入登录界面，重新登录
        if (Session["username"] == null || Session["username"].ToString() == "")
        {
            Response.Write("<script>alert('请先登录系统');window.parent.location.href='../Login.aspx'</script>");
        }
        //显示用户的姓名
        else
        {
            userclass l = new userclass();

            lblUserName.Text = l.getusermingzhi(int.Parse(Session["id"].ToString()));
        }
    }

    /// <summary>
    /// 确认修改密码按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    [Obsolete]
    protected void Button1_Click(object sender, EventArgs e)
    {

        //获取用户信息
        int id = int.Parse(Session["id"].ToString());
        userclass l = new userclass();
        T_user user = l.getuserById(id);

        //对密码进行hash值
        string md5oldpsw = FormsAuthentication.HashPasswordForStoringInConfigFile(txbOldpassword.Text.Trim(), "MD5");
        string md5newpsw = FormsAuthentication.HashPasswordForStoringInConfigFile(txbNewpassword.Text.Trim(), "MD5");

        //首先判断原密码是否输入正确
        if (user.userpwd == md5oldpsw)
        {
            user.userpwd = md5newpsw;
            msg.Text = "";
            //再进行修改密码
            if (l.updateyonghupwd(user))
            {
                Response.Write("<script>alert('密码修改成功')</script>");

                txbNewpassword.Text = "";
                txbOldpassword.Text = "";
            }
            else
            {
                Response.Write("<script>alert('密码修改失败')</script>");
            }
            
        }
        else
        {
            msg.Text = "密码输入错误！";
            txbNewpassword.Text = "";
            txbOldpassword.Text = "";
        }
    }
}