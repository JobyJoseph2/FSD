using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace POWebAPI.DAL
{
	
	public static class DBConnection
	{
		private static SqlConnection _connection;
		public static SqlConnection Connection
		{
			get
			{
				if (_connection == null)
					return MakeConnection();
				else
					return _connection;
			}
		}

		private static SqlConnection MakeConnection()
		{
			string constr = System.Configuration.ConfigurationManager.ConnectionStrings["MyDBConnection"].ToString();
			_connection = new SqlConnection(constr);
			return _connection;

		}
	}
}