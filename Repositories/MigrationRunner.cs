using Dapper;
using DataMigrationTool.Models;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigrationTool
{
	public class MigrationRunner
	{
		private IDbConnection dbConnectionSource = null;
		private IDbConnection dbConnectionDestination = null;

		private readonly string sqlConnectionStringSource = "Data Source =DESKTOP-14KKTQP\\SQLEXPRESS;initial catalog=Yobber-Live-Local;Trusted_Connection=yes";
		private readonly string sqlConnectionStringDestination = "Data Source =DESKTOP-14KKTQP\\SQLEXPRESS;initial catalog=Yobber;Trusted_Connection=yes";

		public MigrationRunner()
		{
			dbConnectionSource = new SqlConnection(sqlConnectionStringSource);
			dbConnectionDestination = new SqlConnection(sqlConnectionStringDestination);
		}

		public IEnumerable<YobberAdminUser> ImportData(string tableid) 
		{
			try
			{
				using (dbConnectionSource) 
				{
					dbConnectionSource.Open();
					switch (tableid)
					{
						case "yobberAdminUsers":
							string query = "SELECT * FROM yobberAdminUsers";

							Log.Information("Data queried from source successfully");
							dbConnectionSource.Close();
							return dbConnectionSource.Query<YobberAdminUser>(query);

						default:
							break;
					}
				}
				return null;
				
			}
			catch (Exception ex)
			{
				Log.Error($"Error occured at ImportData with Message: {ex.Message}");
				throw;
			}
		}

		public bool MigrateData(IEnumerable<YobberAdminUser> passedList) 
		{
			try
			{
				using (dbConnectionDestination = new SqlConnection(sqlConnectionStringDestination))
				{
					dbConnectionDestination.Open();
					foreach (var item in passedList.ToList())
					{
						string query = "INSERT INTO UserInternals (UserId) VALUES (@UserId)";

						try
						{
							//var onresult = dbConnectionDestination.Execute("SET IDENTITY_INSERT Advertisements ON");
							var affectedrows = dbConnectionDestination.Execute(query, new { UserId = item.UserId });

							if (affectedrows > 0)
							{
								//var offresult = dbConnectionDestination.Execute("SET IDENTITY_INSERT Advertisements OFF");
								Log.Information($"Internal User {item.UserId} with Role ID {item.RoleId} registered to database successfully");   
							}
							else
							{
								return false;
							}
						}
						catch (Exception ex)
						{
							Log.Error($"Error occured at Internal User {item.UserId} with Role ID {item.RoleId} with Message: {ex.Message}");
						}
					}
					dbConnectionDestination.Close();
				}
			}
			catch (Exception)
			{
				throw;
			}
			return true;
		}

		public IEnumerable<UserInternal> GetAllExistingFromDestination() 
		{
			try
			{
				using (dbConnectionDestination)
				{
					dbConnectionDestination.Open();
					return dbConnectionDestination.Query<UserInternal>("SELECT UserInternals.UserId FROM UserInternals");
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public int GetUserTypeByName(string type) 
		{
			switch (type)
			{
				case "Administrator":
					return 1;

				case "Employer":
					return 2;

				case "Candidate":
					return 3;

				default:
					return 0;
			}
		}
	}
}
