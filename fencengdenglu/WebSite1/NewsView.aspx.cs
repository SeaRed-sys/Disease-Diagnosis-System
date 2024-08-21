using EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xitongfenxi;
public partial class NewsView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["nid"] != null && Request.QueryString["nid"] != "")
        {
            newclass l = new newclass();
            T_news t= l.getNewById(int.Parse(Request.QueryString["nid"].ToString()));
            titlelab.Text = t.newtiltle;
            contentlab.Text = t.newcontent;


        }
        
    }
}