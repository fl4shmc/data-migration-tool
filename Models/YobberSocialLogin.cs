using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigrationTool.Models
{
	public class YobberSocialLogin
	{
		public string ProviderName { get; set; }
		public string Email { get; set; }
		public string Id { get; set; }
		public Guid yobberUser_Id { get; set; }
	}
}
