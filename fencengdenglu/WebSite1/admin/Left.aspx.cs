using System;
using xitongfenxi;
public partial class admin_Left : System.Web.UI.Page
{
    /// <summary>
    /// 页面首次加载
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
       
       //先判断Session的用户“id”是否为空值或者空字符串
       if (Session["id"] != null && Session["id"].ToString() != "")
       {
           //根据session值和userclass来获取用户的角色值
           userclass l = new userclass();
           string role= l.getuserrole(int.Parse(Session["id"].ToString()));

            //根据用户角色分配不同功能
           if (role == "0")
           {
               Label1.Text = 
                    "<a href='user/Xiugaimima.aspx' target='rightFrame' >修改密码</a><br/>" +
                    "<a href='news/NewsDefault.aspx' target='rightFrame' >问诊单管理</a><br/>" +
                    "<a href='news/NewsDefault.aspx' target='rightFrame' >分配问诊单</a><br/>" +
                    "<a href='news/InforZhunjia.aspx' target='rightFrame' >专家信息管理</a><br/>" +
                    "<a href='news/InforHuangzhe.aspx' target='rightFrame' >患者信息管理</a><br/>";
           }
           if (role == "1")
           {
               Label1.Text = 
                    "<a href='news/InsertNews.aspx' target='rightFrame' >提交问诊单</a><br/>" +
                    "<a href='user/Mywenzendan.aspx' target='rightFrame' >我的问诊单</a><br/>" +
                    "<a href='user/Xiugaimima.aspx' target='rightFrame' >修改密码</a><br/>";
           }
            if (role == "2")
            {
                Label1.Text =
                    "<a href='user/Xiugaimima.aspx' target='rightFrame' >修改密码</a><br/>" +
                    "<a href='news/NewsDefault.aspx' target='rightFrame' >处理问责单</a>";
            }

        }
     
    }
}