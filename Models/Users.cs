using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigrationTool.Models
{
	public class Users
	{
		public Guid Id { get; set; }

		public string Username { get; set; }

		public string Email { get; set; }

		public string Firstname { get; set; }

		public string Lastname { get; set; }

		public string ImageUrl { get; set; }

		public string Phone { get; set; }

		public bool? IsWoman { get; set; }

		public string City { get; set; }

		public string Zip { get; set; }

		public string Address { get; set; }

		public DateTime? Birthdate { get; set; }

		public string SecretKey { get; set; }

		public DateTime? TermsConfirmDate { get; set; }

		public bool? SeenNewFunctions { get; set; }

		public string SelectedLanguage { get; set; }

		public string Title { get; set; }

		public int? AccountStatus { get; set; }

		public int? CustomerId { get; set; }

		public int? LanguageId { get; set; }

		public bool? MultipleAccess { get; set; }

		public bool? IsPrimeryAccount { get; set; }

		public bool? PrimeryAccount { get; set; }

		public int UserTypeId { get; set; }
	}
}
