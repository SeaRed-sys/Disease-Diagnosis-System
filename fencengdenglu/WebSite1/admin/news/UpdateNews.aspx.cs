using EntityClass;
using System;
using System.Collections.Generic;
using System.Web.UI;
using xitongfenxi;

public partial class admin_news_UpdateNews : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
       //页面只初始化一次
       //显示患者的问诊情况
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["nid"] != null && Request.QueryString["nid"] != "")
            {
                int id = int.Parse(Request.QueryString["nid"].ToString());
               
                ViewState["id"] = Request.QueryString["nid"];
                newclass l = new newclass();
                userclass u = new userclass();
                lblusername.Text = u.getusermingzhi(id);
                T_news t = l.getNewById(id);

                
                lblshetai.Text = t.shetai;
                lblkesou.Text = t.keshou;
                lbldaxiaobian.Text = t.daxiaobian;
                TextBox1.Text = t.newtiltle;
                TextBox4.Text = t.newcontent;

            }
        }
        
       
    }

    /// <summary>
    /// 提交问诊单
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        newclass l = new newclass();
        T_news t = l.getNewById(int.Parse(ViewState["id"].ToString()));
        t.newtiltle = TextBox1.Text.Trim();
        t.newcontent = TextBox4.Text.Trim();

        if (l.updateNews2(t))
        {
            Response.Write("<script>alert('审批问诊单成功');window.location.href='NewsDefault.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('审批问诊单失败');window.location.href='NewsDefault.aspx'</script>");
        }
       
    }
}