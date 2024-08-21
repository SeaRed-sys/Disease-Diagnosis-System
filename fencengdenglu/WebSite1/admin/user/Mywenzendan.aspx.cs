using EntityClass;
using System;
using xitongfenxi;

public partial class admin_user_Mywenzendan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        newclass l = new newclass();
        WZD_View[] t = l.getNewsbyuid(int.Parse(Session["id"].ToString()));

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

            Label2.Text += "<tr><td>" + t[i].nid + "</td > " +
                            "<td >" + nflag + "</td >" +
                            "<td class='actions'> " +
                            "<a href='Chakanwenzendan.aspx?nid=" + t[i].nid.ToString() + "'>查看问诊单</a>" +
                            "<a href='DeleteNews.aspx?nid=" + t[i].nid.ToString() + "'>删除</a>  " +
                            "</td> </tr> ";
        }

    }
}