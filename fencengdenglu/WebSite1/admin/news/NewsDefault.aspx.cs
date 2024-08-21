using EntityClass;
using System;
using xitongfenxi;
public partial class admin_news_NewsDefault : System.Web.UI.Page
{
    /// <summary>
    /// 页面加载问诊单
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
              
        newclass l = new newclass();
        userclass u = new userclass();
        WZD_View[] t ;

        //根据专家和管理员身份显示所有问诊单

        //这个为管理员
        if (u.getuserrole(int.Parse(Session["id"].ToString())) == "0")
        {
            t = l.getallWZD_View();
            for (int i = 0; i < t.Length; i++)
            {
                string nflag = "";
                if (t[i].newflag == 1)
                {
                    nflag = "已提交";
                }
                if (t[i].newflag == 2)
                {
                    nflag = "已完成";
                }
                if (t[i].newflag == 3)
                {
                    nflag = "已分配";
                }

                Label2.Text += "<tr><td>" + t[i].nid + "</td >  " +
                    "<td >" + t[i].userminzhi + "</td >" +
                    "<td >" + nflag + "</td > " +
                    "<td class='actions'> " +
                    "<a href='ShenheNews.aspx?nid=" + t[i].nid.ToString() + "'>分配问诊单</a> " +
                    "<a href='DeleteNews.aspx?nid=" + t[i].nid.ToString() + "'>删除</a> "+
                    "</td> </tr> ";
            }
        }
        //这个为专家
        else
        {
            t = l.getNewsbyzid(int.Parse(Session["id"].ToString()));
            for (int i = 0; i < t.Length; i++)
            {
                string nflag = "";
                if (t[i].newflag == 1|| t[i].newflag == 3)
                {
                    nflag = "未完成";
                }
                if (t[i].newflag == 2)
                {
                    nflag = "已完成";
                }

                Label2.Text += "<tr><td>" + t[i].nid + "</td >  " +
                    "<td >" + t[i].userminzhi+ "</td >" +
                    "<td >" + nflag + "</td > " +
                    "<td class='actions'> " +
                    "<a href='DeleteNews.aspx?nid=" + t[i].nid.ToString() + "'>删除</a> " +
                    "<a href='UpdateNews.aspx?nid=" + t[i].nid.ToString() + "'>处理问诊单</a> " +
                    "</td> </tr> ";
            }
        }

        

    }

    /// <summary>
    /// 增加问诊单
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.location.href='InsertNews.aspx'</script>");

    }
    /// <summary>
    /// 根据问诊单标题查询具体问诊单
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button2_Click(object sender, EventArgs e)
    {
        newclass l = new newclass();
        WZD_View[] t = l.getNewsbyTitle(txttitle.Text.Trim());
        for (int i = 0; i < t.Length; i++)
        {
            string nflag = "";
            if (t[i].newflag == 1)
            {
                nflag = "已提交";
            }
            if (t[i].newflag == 2)
            {
                nflag = "已完成";
            }
            if (t[i].newflag == 3)
            {
                nflag = "已分配";
            }

            Label2.Text = "<tr><td>" + t[i].nid + "</td >  " +
                "<td >" + t[i].userminzhi + "</td >" +
                "<td >" + nflag + "</td > " +
                "<td class='actions'> " +
                "<a href='ShenheNews.aspx?nid=" + t[i].nid.ToString() + "'>分配问诊单</a> " +
                "<a href='DeleteNews.aspx?nid=" + t[i].nid.ToString() + "'>删除</a> " +
                "</td> </tr> ";
        }
    }
}