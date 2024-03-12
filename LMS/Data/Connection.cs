using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data
{
	public class Connection
	{
		static SqlConnection conn;
		public static SqlConnection GetConnection()
		{
			conn  = new SqlConnection("Data Source=.\\SQLExpress;Database=LMS_Db;Integrated security = true;");
			if(conn != null )
			{
				conn.Open();
			}
			return conn;
		}
		
	}
}
