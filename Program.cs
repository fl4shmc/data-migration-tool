using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Office.Interop.Excel;
using Serilog;
using System.Linq;

namespace DataMigrationTool
{
	class Program
	{
		private readonly IConfiguration _configuration;

		public Program()
		{
		}


		static void Main(string[] args)
		{
			string logTimeStamp = DateTime.Now.ToString("yyyyMMdd_HHmm");
			Log.Logger = new LoggerConfiguration()
				.MinimumLevel.Debug()
				.WriteTo.Console()
				.WriteTo.File($"Logs/migration-{logTimeStamp}.txt", rollingInterval: RollingInterval.Infinite)
				.CreateLogger();

			//Log.Information("Hello, world!");
			ExecuteMigration();
		}

		private static void ExecuteMigration() 
		{
			MigrationRunner runner = new MigrationRunner();
			var result = runner.ImportData("yobberAdminUsers");
			var existingDataset = runner.GetAllExistingFromDestination();
			var filtered = result.ToList().Where(x => !existingDataset.ToList().Any(e => e.UserId == x.UserId));

			var filteredCount = filtered.ToList().Count();

			int totalPageCount = ( filteredCount/ 100) + 1;

			int pageNumber = 1;
			int pageSize = 100;

			for (int i = totalPageCount; i > 0; i--)
			{
				var pagedResult = filtered.Skip((pageNumber - 1) * pageSize).Take(pageSize);
				runner.MigrateData(pagedResult);
				pageNumber++;
			}

			//insert data batch wise from 'result' collection
		}
	}
}
