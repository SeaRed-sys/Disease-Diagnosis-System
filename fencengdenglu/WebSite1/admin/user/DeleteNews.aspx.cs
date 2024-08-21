using System;
using xitongfenxi;

public partial class admin_user_DeleteNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["nid"] != null && Request.QueryString["nid"] != "")
        {
            //获取到任意行的主键，并且进行各种操作
            //删除、修改
            newclass l = new newclass();
            if (l.deletenews(int.Parse(Request.QueryString["nid"].ToString())))
            {
                Response.Write("<script>alert('删除成功');window.location.href='Mywenzendan.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('删除失败');window.location.href='Mywenzendan.aspx'</script>");
            }
        }
    }
}