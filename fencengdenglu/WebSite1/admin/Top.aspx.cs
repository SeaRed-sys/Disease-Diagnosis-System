using System;
using xitongfenxi;
public partial class admin_Top : System.Web.UI.Page
{
    /// <summary>
    /// 页面首次加载
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        //首先，判断用户名是否为空值或空字符串
        //如果是，转入登录界面，重新登录
        if (Session["username"] == null || Session["username"].ToString() == "")
        {
            Response.Write("<script>alert('请先登录系统');window.parent.location.href='../Login.aspx'</script>");
        }
        //接着，根据用户的权限分配
        else
        {
            userclass l = new userclass();
            
            if (l.getuserrole(int.Parse(Session["id"].ToString())) == "0")
            {
                Label1.Text = l.getusermingzhi(int.Parse(Session["id"].ToString()))+"你的权限为超级管理员";
            }
            if (l.getuserrole(int.Parse(Session["id"].ToString())) == "1")
            {
                Label1.Text = l.getusermingzhi(int.Parse(Session["id"].ToString())) + "你的权限为普通用户";
            }
            if (l.getuserrole(int.Parse(Session["id"].ToString())) == "2")
            {
                Label1.Text = l.getusermingzhi(int.Parse(Session["id"].ToString())) + "你的权限为专家";
            }
        }
    }

    /// <summary>
    /// 退出后台按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        //将Session值清空，再返回登录界面
        Session["username"] = "";
        Session["id"] = "";

        Response.Write("<script>alert('成功退出系统');window.parent.location.href='../Login.aspx'</script>");
       
        
       
    }
}