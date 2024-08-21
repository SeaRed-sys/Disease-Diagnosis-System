using EntityClass;
using System;
using xitongfenxi;

public partial class admin_news_LookNew : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int uid = int.Parse(Request.QueryString["nid"].ToString());
        userclass u = new userclass();
        newclass l = new newclass();
        WZD_View[] t = l.getNewsbyuid(uid);
        lblusername.Text = u.getusermingzhi(uid);



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
                    "<td >" + t[i].shetai + "</td > " +
                    "<td >" + t[i].keshou + "</td > " +
                    "<td >" + t[i].daxiaobian + "</td > " +
                    "<td >" + nflag + "</td > " +
                    "<td >" + t[i].newtiltle + "</td > " +
                    "<td >" + t[i].newcontent + "</td > " +
                    "</td> </tr> ";
        }
    }
        

}