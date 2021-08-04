using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigrationTool.Models
{
	public class SocialLogin
	{
		public string Id { get; set; }
		public Guid UserId { get; set; }
		public string Email { get; set; }
		public string ProviderName { get; set; }
	}
}
