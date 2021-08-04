using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigrationTool.Models
{
	public class CustomerUser
	{
		public Guid UserId { get; set; }
		public int CustomerId { get; set; }
		public int RoleId { get; set; }
	}
}
