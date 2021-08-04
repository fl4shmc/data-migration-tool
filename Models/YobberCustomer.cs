using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigrationTool.Models
{
	public class YobberCustomer
	{
        public int Id { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string CustomerName { get; set; }
        public string OrganizationNumber { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public System.Guid ContactId { get; set; }
        public string LegalName { get; set; }
        public string AgreementId { get; set; }
        public bool IsVIdeoEnabled { get; set; }
    }
}
