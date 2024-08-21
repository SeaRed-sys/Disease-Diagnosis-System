using EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xitongfenxi;
public partial class admin_user_Chakanwenzendan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //根据新闻类的主键 获得新闻对象
            if (Request.QueryString["nid"] != null && Request.QueryString["nid"] != "")
            {
                int id = int.Parse(Request.QueryString["nid"].ToString()); 
           
                newclass l = new newclass();
                T_news t = l.getNewById(id);

                TextBox1.Text = t.newtiltle;
                TextBox4.Text = t.newcontent;
                TongueCondition.SelectedValue = t.shetai;
                CoughCondition.SelectedValue = t.keshou;
                BowelCondition.SelectedValue = t.daxiaobian;

            }
        }
    }
}