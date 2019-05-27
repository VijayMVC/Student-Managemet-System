using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SMSDBFramework
{
	public class DBSQLServer
	{
		//ExecuteReader = row or row+
		//ExecuteScalar = only value
		//ExecuteNoQuery = update, delete, select
		private string _connstring;

		public DBSQLServer(string connstring)
		{
			this._connstring = connstring;
		}

		public DataTable GetDataList(string storeProceName)
		{
			DataTable dtData = new DataTable();
			using (SqlConnection conn = new SqlConnection(_connstring))
			{
				using (SqlCommand cmd = new SqlCommand(storeProceName, conn))
				{
					cmd.CommandType = CommandType.StoredProcedure;

					conn.Open();

					SqlDataReader reader = cmd.ExecuteReader();
					dtData.Load(reader);
				}
			}

			return dtData;
		}

		public DataTable GetDataList(string storeProceName, DBParameter parameter)
		{
			DataTable dtData = new DataTable();
			using (SqlConnection conn = new SqlConnection(_connstring))
			{
				using (SqlCommand cmd = new SqlCommand(storeProceName, conn))
				{
					cmd.CommandType = CommandType.StoredProcedure;

					conn.Open();

					cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);

					SqlDataReader reader = cmd.ExecuteReader();
					dtData.Load(reader);
				}
			}

			return dtData;
		}

		public DataTable GetDataList(string storeProceName, DBParameter[] parameter)
		{
			DataTable dtData = new DataTable();
			using (SqlConnection conn = new SqlConnection(_connstring))
			{
				using (SqlCommand cmd = new SqlCommand(storeProceName, conn))
				{
					cmd.CommandType = CommandType.StoredProcedure;

					conn.Open();

					foreach (var para in parameter)
					{
						cmd.Parameters.AddWithValue(para.Parameter, para.Value);

					}


					SqlDataReader reader = cmd.ExecuteReader();
					dtData.Load(reader);
				}
			}

			return dtData;
		}

		//Overloading Function

		public object GetScalarValue(string storedProceName)
		{
			object value = null;
			using (SqlConnection conn = new SqlConnection(_connstring))
			{
				using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
				{
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					conn.Open();
					value = cmd.ExecuteScalar();
				}
			}
			return value;
		}

		public object GetScalarValue(string storedProceName, DBParameter parameter)
		{
			object value = null;
			using (SqlConnection conn = new SqlConnection(_connstring))
			{
				using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
				{
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					conn.Open();

					cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);
					value = cmd.ExecuteScalar();
				}
			}
			return value;
		}

		public object GetScalarValue(string storedProceName, DBParameter[] parameter)
		{
			object value = null;
			using (SqlConnection conn = new SqlConnection(_connstring))
			{
				using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
				{
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					conn.Open();
					foreach(var para in parameter)
					{
						cmd.Parameters.AddWithValue(para.Parameter, para.Value);
					}

					value = cmd.ExecuteScalar();
				}
			}
			return value;
		}

		public void SaveOrUpdateRecord(string storedProceName, object obj)
		{
			using (SqlConnection conn = new SqlConnection(_connstring))
			{
				using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					conn.Open();

					//Parameters
					Type type = obj.GetType();
					BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
					PropertyInfo[] properties = type.GetProperties(flags);

					foreach (var property in properties)
					{
						cmd.Parameters.AddWithValue("@" + property.Name, property.GetValue(obj, null));
					}

					cmd.ExecuteNonQuery();
				}
			}
		}

	}
}
