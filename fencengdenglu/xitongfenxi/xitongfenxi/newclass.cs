using System.Data.SqlClient;
using System.Configuration;
using EntityClass;
using System.Data;

namespace xitongfenxi
{
   public class newclass
    {       
        public SqlDataReader sqlDataReader;

        /// <summary>
        ///根据主键获得问诊单实例
        /// </summary>
        public T_news getNewById(int id)
        {
            T_news t = new T_news();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM news WHERE nid="+id;
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                t.newtiltle = sqlDataReader["newtiltle"].ToString();
                t.newcontent = sqlDataReader["newcontent"].ToString();
                t.uid =  int.Parse(sqlDataReader["uid"].ToString());
                t.newflag = int.Parse(sqlDataReader["newflag"].ToString());
                t.nid = int.Parse(sqlDataReader["nid"].ToString());
                t.zid = int.Parse(sqlDataReader["zid"].ToString());
                t.aid = int.Parse(sqlDataReader["aid"].ToString());
                t.shetai = sqlDataReader["shetai"].ToString();
                t.daxiaobian = sqlDataReader["daxiaobian"].ToString();
                t.keshou = sqlDataReader["keshou"].ToString();
            }
            else
            {
                return null;
            }
            return t;

        }

        /// <summary>
        /// 新增问诊单
        /// </summary>
        /// <param name="t">为问诊单实例</param>
        /// <returns></returns>
        public bool addnews(T_news t)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();


            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string s = "INSERT INTO news VALUES ('" + t.newtiltle + "','" + t.newcontent + "',"+t.uid+",1,0,0,'" + t.shetai + "','" + t.daxiaobian + "','" + t.keshou + "')";

            sqlCommand.CommandText = s;
            int f = 0;
            f = sqlCommand.ExecuteNonQuery();

            if (f > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }

        /// <summary>
        /// 获得全部问诊单数组
        /// </summary>
        public T_news[] getallnews()
         {
            
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM news ";

            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(dataSet);

            T_news[] t = new T_news[dataSet.Tables[0].Rows.Count];
            for (int i = 0; i < t.Length; i++)
            {
                T_news temp = new T_news();

                temp.nid = int.Parse(dataSet.Tables[0].Rows[i]["nid"].ToString());
                temp.uid =int.Parse(dataSet.Tables[0].Rows[i]["uid"].ToString());
                temp.newflag = int.Parse(dataSet.Tables[0].Rows[i]["newflag"].ToString());
                temp.newtiltle = dataSet.Tables[0].Rows[i]["newtiltle"].ToString();
                temp.newcontent = dataSet.Tables[0].Rows[i]["newcontent"].ToString();
                temp.zid = int.Parse(dataSet.Tables[0].Rows[i]["zid"].ToString());
                temp.aid = int.Parse(dataSet.Tables[0].Rows[i]["aid"].ToString());
                temp.shetai = dataSet.Tables[0].Rows[i]["shetai"].ToString();
                temp.daxiaobian = dataSet.Tables[0].Rows[i]["daxiaobian"].ToString();
                temp.keshou = dataSet.Tables[0].Rows[i]["keshou"].ToString();

                t[i] = temp;

            }

            return t;
           
        }

        /// <summary>
        ///  获得全部分配给某位专家问诊单数组
        /// </summary>
        /// <param name="zid">专家主键</param>
        /// <returns></returns>
        public T_news[] getallnewszj(int zid)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM news where zid=" + zid;

            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(dataSet);

            T_news[] t = new T_news[dataSet.Tables[0].Rows.Count];
            for (int i = 0; i < t.Length; i++)
            {
                T_news temp = new T_news();

                temp.nid = int.Parse(dataSet.Tables[0].Rows[i]["nid"].ToString());
                temp.uid = int.Parse(dataSet.Tables[0].Rows[i]["uid"].ToString());
                temp.newflag = int.Parse(dataSet.Tables[0].Rows[i]["newflag"].ToString());
                temp.newtiltle = dataSet.Tables[0].Rows[i]["newtiltle"].ToString();
                temp.newcontent = dataSet.Tables[0].Rows[i]["newcontent"].ToString();
                temp.zid = int.Parse(dataSet.Tables[0].Rows[i]["zid"].ToString());
                temp.aid = int.Parse(dataSet.Tables[0].Rows[i]["aid"].ToString());
                temp.shetai = dataSet.Tables[0].Rows[i]["shetai"].ToString();
                temp.daxiaobian = dataSet.Tables[0].Rows[i]["daxiaobian"].ToString();
                temp.keshou = dataSet.Tables[0].Rows[i]["keshou"].ToString();

                t[i] = temp;

            }

            return t;

        }
        /// <summary>
        /// 更新问诊单，分配给专家
        /// </summary>
        /// <param name="t">问诊单实例</param>
        /// <param name="zid">专家的主键</param>
        /// <returns></returns>
        public bool updateNews(T_news t,int zid)
          {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();


            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string s = "update news set zid = " + zid + " ,newflag=3 where nid = " + t.nid ;
           
            
            sqlCommand.CommandText = s;
            int f = 0;
            f = sqlCommand.ExecuteNonQuery();

            if (f > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 专家诊断开药问诊单
        /// </summary>
        /// <param name="t">问诊单实例 </param>
        /// <returns></returns>
        public bool updateNews2(T_news t)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();


            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string s = "update news set newtiltle = '" + t.newtiltle + "', newcontent = '" + t.newcontent + "' where nid = " + t.nid;


            // string s = "update INTO news VALUES ('" + t.newtiltle + "','" + t.newcontent + "',1,1)";
            //update news set newtiltle = '1111', newcontent = '2222' where nid = 8;
            sqlCommand.CommandText = s;
            int f = 0;
            f = sqlCommand.ExecuteNonQuery();

            if (f > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        ///删除问诊单，参数为问诊单主键
        /// </summary>
        public bool deletenews(int newsid)
          {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();


            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string s = "delete news where nid="+ newsid;

            sqlCommand.CommandText = s;
            int f = 0;
            f = sqlCommand.ExecuteNonQuery();

            if (f > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        ///查询问诊单，参数为问诊单标题
        /// </summary>
        public WZD_View[] getNewsbyTitle(string username)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from WZD_View where username like '%" + username + "%'";

            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(dataSet);

            WZD_View[] t = new WZD_View[dataSet.Tables[0].Rows.Count];
            for (int i = 0; i < t.Length; i++)
            {
                WZD_View temp = new WZD_View();

                temp.nid = int.Parse(dataSet.Tables[0].Rows[i]["nid"].ToString());
                temp.uid = int.Parse(dataSet.Tables[0].Rows[i]["uid"].ToString());
                temp.newflag = int.Parse(dataSet.Tables[0].Rows[i]["newflag"].ToString());
                temp.newtiltle = dataSet.Tables[0].Rows[i]["newtiltle"].ToString();
                temp.newcontent = dataSet.Tables[0].Rows[i]["newcontent"].ToString();  
                temp.userage = int.Parse(dataSet.Tables[0].Rows[i]["userage"].ToString());
                temp.usergender = dataSet.Tables[0].Rows[i]["usergender"].ToString();
                temp.userregion = dataSet.Tables[0].Rows[i]["userregion"].ToString(); 
                temp.userunit = dataSet.Tables[0].Rows[i]["userunit"].ToString();
                temp.userinfor = dataSet.Tables[0].Rows[i]["userinfor"].ToString();
                temp.userminzhi = dataSet.Tables[0].Rows[i]["userminzhi"].ToString(); 
                temp.username = dataSet.Tables[0].Rows[i]["username"].ToString();

                t[i] = temp;

            }

            return t;
        }


        /// <summary>
        /// 获取用户的全部问诊单
        /// </summary>
        /// <param name="uid">用户主键</param>
        /// <returns></returns>
        public WZD_View[] getNewsbyuid(int uid)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from WZD_View where uid ="+ uid;

            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(dataSet);

            WZD_View[] t = new WZD_View[dataSet.Tables[0].Rows.Count];
            for (int i = 0; i < t.Length; i++)
            {
                WZD_View temp = new WZD_View();

                temp.nid = int.Parse(dataSet.Tables[0].Rows[i]["nid"].ToString());
                temp.uid = int.Parse(dataSet.Tables[0].Rows[i]["uid"].ToString());
                temp.newflag = int.Parse(dataSet.Tables[0].Rows[i]["newflag"].ToString());
                temp.newtiltle = dataSet.Tables[0].Rows[i]["newtiltle"].ToString();
                temp.newcontent = dataSet.Tables[0].Rows[i]["newcontent"].ToString();
                temp.userage = int.Parse(dataSet.Tables[0].Rows[i]["userage"].ToString());
                temp.usergender = dataSet.Tables[0].Rows[i]["usergender"].ToString();
                temp.userregion = dataSet.Tables[0].Rows[i]["userregion"].ToString();
                temp.userunit = dataSet.Tables[0].Rows[i]["userunit"].ToString();
                temp.userinfor = dataSet.Tables[0].Rows[i]["userinfor"].ToString();
                temp.userminzhi = dataSet.Tables[0].Rows[i]["userminzhi"].ToString();
                temp.username = dataSet.Tables[0].Rows[i]["username"].ToString();

                t[i] = temp;

            }

            return t;
        }

        /// <summary>
        ///获取全部问诊单
        /// </summary>
        public WZD_View[] getallWZD_View()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from WZD_View";

            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(dataSet);

            WZD_View[] t = new WZD_View[dataSet.Tables[0].Rows.Count];
            for (int i = 0; i < t.Length; i++)
            {
                WZD_View temp = new WZD_View();

                temp.nid = int.Parse(dataSet.Tables[0].Rows[i]["nid"].ToString());
                temp.uid = int.Parse(dataSet.Tables[0].Rows[i]["uid"].ToString());
                temp.newflag = int.Parse(dataSet.Tables[0].Rows[i]["newflag"].ToString());
                temp.newtiltle = dataSet.Tables[0].Rows[i]["newtiltle"].ToString();
                temp.newcontent = dataSet.Tables[0].Rows[i]["newcontent"].ToString();
                temp.userage = int.Parse(dataSet.Tables[0].Rows[i]["userage"].ToString());
                temp.usergender = dataSet.Tables[0].Rows[i]["usergender"].ToString();
                temp.userregion = dataSet.Tables[0].Rows[i]["userregion"].ToString();
                temp.userunit = dataSet.Tables[0].Rows[i]["userunit"].ToString();
                temp.userinfor = dataSet.Tables[0].Rows[i]["userinfor"].ToString();
                temp.userminzhi = dataSet.Tables[0].Rows[i]["userminzhi"].ToString();
                temp.username = dataSet.Tables[0].Rows[i]["username"].ToString();

                t[i] = temp;

            }

            return t;
        }

        /// <summary>
        /// 获取专家的全部问诊单
        /// </summary>
        /// <param name="uid">用户主键</param>
        /// <returns></returns>
        public WZD_View[] getNewsbyzid(int zid)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from WZD_View where zid =" + zid;

            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(dataSet);

            WZD_View[] t = new WZD_View[dataSet.Tables[0].Rows.Count];
            for (int i = 0; i < t.Length; i++)
            {
                WZD_View temp = new WZD_View();

                temp.nid = int.Parse(dataSet.Tables[0].Rows[i]["nid"].ToString());
                temp.uid = int.Parse(dataSet.Tables[0].Rows[i]["uid"].ToString());
                temp.newflag = int.Parse(dataSet.Tables[0].Rows[i]["newflag"].ToString());
                temp.newtiltle = dataSet.Tables[0].Rows[i]["newtiltle"].ToString();
                temp.newcontent = dataSet.Tables[0].Rows[i]["newcontent"].ToString();
                temp.userage = int.Parse(dataSet.Tables[0].Rows[i]["userage"].ToString());
                temp.usergender = dataSet.Tables[0].Rows[i]["usergender"].ToString();
                temp.userregion = dataSet.Tables[0].Rows[i]["userregion"].ToString();
                temp.userunit = dataSet.Tables[0].Rows[i]["userunit"].ToString();
                temp.userinfor = dataSet.Tables[0].Rows[i]["userinfor"].ToString();
                temp.userminzhi = dataSet.Tables[0].Rows[i]["userminzhi"].ToString();
                temp.username = dataSet.Tables[0].Rows[i]["username"].ToString();

                t[i] = temp;

            }

            return t;
        }

        /// <summary>
        /// 审核通过问诊单
        /// </summary>
        /// <param name="newsid">问诊单实例</param>
        /// <returns></returns>
        public bool ShenheNews(int newsid)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();


            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string s = "update news set newflag = 2 where nid = " + newsid;

            
            sqlCommand.CommandText = s;
            int f = 0;
            f = sqlCommand.ExecuteNonQuery();

            if (f > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        /// <summary>
        /// 获得全部已审核的问诊单
        /// </summary>
        /// <returns></returns>
        public T_news[] getNewsbyShenhe()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from news where newflag =2";

            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(dataSet);

            T_news[] t = new T_news[dataSet.Tables[0].Rows.Count];
            for (int i = 0; i < t.Length; i++)
            {
                T_news temp = new T_news();

                temp.nid = int.Parse(dataSet.Tables[0].Rows[i]["nid"].ToString());
                temp.uid = int.Parse(dataSet.Tables[0].Rows[i]["uid"].ToString());
                temp.newflag = int.Parse(dataSet.Tables[0].Rows[i]["newflag"].ToString());
                temp.newtiltle = dataSet.Tables[0].Rows[i]["newtiltle"].ToString();
                temp.newcontent = dataSet.Tables[0].Rows[i]["newcontent"].ToString();
                t[i] = temp;

            }

            return t;
        }
    }
}
