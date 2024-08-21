using EntityClass;
using System;
using xitongfenxi;

public partial class admin_news_InforHuangzhe : System.Web.UI.Page
{
    /// <summary>
    /// 页面加载显示所有患者
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        userclass l = new userclass();
        T_user[] t = l.getallusers(1);

        //显示所有用户
        for (int i = 0; i < t.Length; i++)
        {

            Label2.Text += "<tr><td>" + t[i].id + "</td >  " +
                "<td >" + t[i].userminzhi + "</td >" +
                "<td >" + t[i].userage + "</td > " +
                "<td >" + t[i].userregion + "</td > " +
                "<td class='actions'> " +
                "<a href='LookNew.aspx?nid=" + t[i].id.ToString() + "'>查看</a> " +
                "<a href='DeleteUser.aspx?nid=" + t[i].id.ToString() + "'>删除</a> " +
                "</td> </tr> ";
        }

    }
    /// <summary>
    /// 根据搜索框中的用户id精确搜索
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button2_Click(object sender, EventArgs e)
    {
        userclass l = new userclass();
        T_user t = l.getuserById(int.Parse(txttitle.Text.Trim()));
        Label2.Text = "<tr><td>" + t.id + "</td >  " +
               "<td >" + t.userminzhi + "</td >" +
               "<td >" + t.userinfor + "</td > " +
               "<td >" + t.userunit + "</td > " +
               "<td >" + t.userage + "</td > " +
               "<td class='actions'> " +
               "<a href='ShenheNews.aspx?nid=" + t.id.ToString() + "'>查看</a> " +
               "<a href='DeleteUser.aspx?nid=" + t.id.ToString() + "'>删除</a> " +
               "<a href='UpdateNews.aspx?nid=" + t.id.ToString() + "'>修改</a> " +
               "</td> </tr> ";
    }
}