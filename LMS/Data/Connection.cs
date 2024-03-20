using Oracle.ManagedDataAccess.Client;
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
		static OracleConnection conn;
		public static OracleConnection GetConnection()
		{
			conn  = new OracleConnection("Data Source = localhost:1521/XEPDB1; User id = Loan; Password = Loan1234");
			if(conn != null )
			{
				conn.Open();
			}
			return conn;
		}
		
	}
}
