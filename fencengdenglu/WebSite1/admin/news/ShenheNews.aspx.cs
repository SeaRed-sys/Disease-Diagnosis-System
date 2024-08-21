using EntityClass;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using xitongfenxi;

public partial class admin_news_ShenheNews : System.Web.UI.Page
{
    /// <summary>
    /// 获取问诊单信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //根据问诊单的主键 获得问诊单
            if (Request.QueryString["nid"] != null && Request.QueryString["nid"] != "")
            {
                int id = int.Parse(Request.QueryString["nid"].ToString());
                ViewState["id"] = Request.QueryString["nid"];
                newclass l = new newclass();
                T_news t = l.getNewById(id);

                TextBox1.Text = t.newtiltle;
                TextBox4.Text = t.newcontent;
                TongueCondition.SelectedValue = t.shetai;
                CoughCondition.SelectedValue = t.keshou;
                BowelCondition.SelectedValue = t.daxiaobian;

                userclass u = new userclass();
                T_user[] zj = u.getallusers(2);
                for (int i = 0; i < zj.Length; i++)
                {
                    ListItem l1 = new ListItem(zj[i].userminzhi, zj[i].id.ToString());
                    DropDownList1.Items.Add(l1);
                }

            }
            
        }

    }

    /// <summary>
    /// 实现问诊单分配
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["nid"].ToString());
        ViewState["id"] = Request.QueryString["nid"];
        newclass l = new newclass();
        T_news t = l.getNewById(id);


        if (l.updateNews(t, int.Parse(DropDownList1.SelectedValue.ToString())))
        {
            Response.Write("<script>alert('分配问诊单成功');window.location.href='NewsDefault.aspx'</script>");

        }
        else
        {
            Response.Write("<script>alert('分配问诊单失败');window.location.href='NewsDefault.aspx'</script>");

        }
    }

 }