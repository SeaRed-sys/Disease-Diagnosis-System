using System;
using xitongfenxi;

public partial class admin_news_DeleteUser : System.Web.UI.Page
{
    /// <summary>
    /// 删除用户
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["nid"] != null && Request.QueryString["nid"] != "")
        {

            //获取到任意行的主键，并且进行各种操作
            //删除、修改
            int id = int.Parse(Request.QueryString["nid"].ToString());
            userclass l = new userclass();
            string role = l.getuserrole(id );
            if (l.deleteuser(id))
            {
                if (role == "1")
                {
                    Response.Write("<script>alert('删除成功');window.location.href='InforHuangzhe.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除成功');window.location.href='InforZhunjia.aspx'</script>");
                }
                
            }
            else
            {
                if (role == "1")
                {
                    Response.Write("<script>alert('删除失败');window.location.href='InforHuangzhe.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除失败');window.location.href='InforZhunjia.aspx'</script>");
                }
            }
        }
    }
}