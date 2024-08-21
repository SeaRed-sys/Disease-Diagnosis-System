using System.Data.SqlClient;
using System.Configuration;
using EntityClass;
using System.Data;

namespace xitongfenxi
{
    //去做数据库相关的内容
    public class userclass
    {
        public SqlDataReader sqlDataReader;
        public SqlConnection sqlConnection;
        public void closeConnection()
        {
            sqlDataReader.Close();  
            sqlConnection.Close();

        }

        /// <summary>
        /// 是否登录成功
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public int islogin(string name, string pwd)
        {
         
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM yonghu WHERE username='" + name + "'and " + "userpwd='" + pwd+"'";
            sqlDataReader = sqlCommand.ExecuteReader();
            
            if (sqlDataReader.Read())
            {
                return int.Parse(sqlDataReader["id"].ToString());
            }
            else
            {
                return 0;
            }
          
        }
        
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">用户密码</param>
        /// <param name="userminzhi">姓名</param>
        /// <param name="userregion">地址</param>
        /// <param name="usergender">性别</param>
        /// <param name="userage">年龄</param>
        /// <returns></returns>
        public bool yonghuzhuce(string name, string pwd,string userminzhi, string userregion,string usergender,int userage)
        {


            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();


            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string s = "INSERT INTO yonghu VALUES ('" + name + "','" + pwd + "','"+userminzhi+ "','','','" + userregion + "','" + usergender + "'," + userage + ",1)";

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
        /// 增加专家信息
        /// </summary>
        /// <param name="name">专家用户名</param>
        /// <param name="pwd">专家密码</param>
        /// <param name="userminzhi">专家姓名</param>
        /// <param name="userregion">专家地址</param>
        /// <param name="usergender">专家性别</param>
        /// <param name="userage">专家年龄</param>
        /// <param name="userinfor">专家描述</param>
        /// <param name="userunit">专家单位</param>
        /// <returns></returns>
        public bool zhuanjiainsert(string name, string pwd, string userminzhi, string userregion, string usergender, int userage,string userinfor,string userunit)
        {


            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();


            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string s = "INSERT INTO yonghu VALUES ('" + name + "','" + pwd + "','" + userminzhi + "','"+ userinfor + "','"+ userunit + "','" + userregion + "','" + usergender + "'," + userage + ",2)";

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
        /// 根据用户id获取用户真实姓名
        /// </summary>
        /// <param name="uid">用户id</param>
        /// <returns></returns>
        public string getusermingzhi(int uid)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM yonghu WHERE id=" + uid;
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                return sqlDataReader["userminzhi"].ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 根据用户id获取用户权限
        /// </summary>
        /// <param name="uid">用户id</param>
        /// <returns></returns>
        public string getuserrole(int uid)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM yonghu WHERE id=" + uid;
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                return sqlDataReader["userrole"].ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 根据主键获得用户实例
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        public T_user getuserById(int id)
        {
            T_user t = new T_user();

            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
            //打开连接
            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM yonghu WHERE id=" + id;
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            { 

                t.id= int.Parse(sqlDataReader["id"].ToString());
                t.userrole = int.Parse(sqlDataReader["userrole"].ToString());
                t.userage= int.Parse(sqlDataReader["userage"].ToString());
                t.usergender = sqlDataReader["usergender"].ToString();
                t.userregion = sqlDataReader["userregion"].ToString();
                t.userunit = sqlDataReader["userunit"].ToString();
                t.userinfor = sqlDataReader["userinfor"].ToString();
                t.userminzhi = sqlDataReader["userminzhi"].ToString();
                t.userpwd = sqlDataReader["userpwd"].ToString();
                t.username = sqlDataReader["username"].ToString();
            }
            else
            {
                return null;
            }
            return t;

        }


        /// <summary>
        /// 获得全部用户数组 参数为权限，为1是所有患者，为2是所有专家
        /// </summary>
        public T_user[] getallusers(int roleid)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM yonghu where userrole="+roleid;

            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(dataSet);

            T_user[] t = new T_user[dataSet.Tables[0].Rows.Count];
            for (int i = 0; i < t.Length; i++)
            {
                T_user temp = new T_user();



                temp.id = int.Parse(dataSet.Tables[0].Rows[i]["id"].ToString());
                temp.userrole = int.Parse(dataSet.Tables[0].Rows[i]["userrole"].ToString());
                temp.userage = int.Parse(dataSet.Tables[0].Rows[i]["userage"].ToString());
                temp.usergender = dataSet.Tables[0].Rows[i]["usergender"].ToString();
                temp.userregion = dataSet.Tables[0].Rows[i]["userregion"].ToString();

                temp.userunit = dataSet.Tables[0].Rows[i]["userunit"].ToString();
                temp.userinfor = dataSet.Tables[0].Rows[i]["userinfor"].ToString();
                temp.userminzhi = dataSet.Tables[0].Rows[i]["userminzhi"].ToString();
                temp.userpwd = dataSet.Tables[0].Rows[i]["userpwd"].ToString();
                temp.username = dataSet.Tables[0].Rows[i]["username"].ToString();
       
                t[i] = temp;

            }

            return t;

        }

        /// <summary>
        /// 更新用户密码
        /// </summary>
        /// <param name="t">用户</param>
        /// <returns></returns>
        public bool updateyonghupwd(T_user t)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string s = $"update yonghu set userpwd = '{t.userpwd}' where id ={t.id}";

         
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
        ///删除用户，参数为用户主键
        /// </summary>
        public bool deleteuser(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //打开连接

            sqlConnection.Open();


            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string s = "delete yonghu where id=" + id;

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


    }
}
