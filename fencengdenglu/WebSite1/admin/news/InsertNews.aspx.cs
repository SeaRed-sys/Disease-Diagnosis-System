using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using EntityClass;
using xitongfenxi;
public partial class admin_news_InsertNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 添加问诊单
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        T_news t = new T_news();
        t.shetai = TongueCondition.SelectedValue;
        t.keshou = CoughCondition.SelectedValue;
        t.daxiaobian = BowelCondition.SelectedValue;
        t.uid = int.Parse(Session["id"].ToString());
        newclass newbll = new newclass();


        if (newbll.addnews(t))
        {
            Response.Write("<script>alert('添加问诊单成功');window.location.href='NewsDefault.aspx'</script>");

        }
        else
        {
            Response.Write("<script>alert('添加问诊单失败');window.location.href='NewsDefault.aspx'</script>");

        }
    }
}