using EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xitongfenxi;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        newclass l = new newclass();
        T_news[] models = l.getNewsbyShenhe();
       
        for (int i = 0; i < models.Length; i++)
        {
            Label1.Text += " <div class='news-item'> <h2 class='news-title'><a href='NewsView.aspx?nid=" + models[i].nid +"' target='_blank'>" + models[i].newtiltle + "</a></h2><p class='news-time'>2023-04-01 12:00</p></div>";
        }
       
    }
}