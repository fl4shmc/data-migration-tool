using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigrationTool.Models
{
	public class Advertisement
	{
		public int Id { get; set; }
		public DateTime CreateDate { get; set; }
		public string Title { get; set; }
		public int EmploymentTypeId { get; set; }
		public string Description { get; set; }
		public string Header { get; set; }
		public string CompanyLogoUrl { get; set; }
		public string CompanyStreamUrl { get; set; }
		public string PlaceOfEmployment { get; set; }
		public string County { get; set; }
		public bool Active { get; set; }
		public DateTime? AdmissionDate { get; set; }
		public string CompanyName { get; set; }
		public DateTime? PrescribedDay { get; set; }
		public string Salary { get; set; }
		public DateTime? PublishDate { get; set; }
		public string CompanyWebsite { get; set; }
		public string ContactName { get; set; }
		public string ContactPhone { get; set; }
		public string ContactEmail { get; set; }
		public Guid ClientId { get; set; }
		public bool DocumentsRequired { get; set; }
		public bool CoWorkersRequired { get; set; }
		public string CompanyAddress { get; set; }
		public string CompanyZip { get; set; }
		public string CompanyCity { get; set; }
		public string CompanyImageUrl { get; set; }
		public string AdUrl { get; set; }
		public bool Deleted { get; set; }
		public bool Published { get; set; }
		public string PlaceOfEmploymentAdress { get; set; }
		public string PlaceOfEmploymentZip { get; set; }
		public int GroupId { get; set; }
		public int OccupationId { get; set; }
		public bool ExpiredNotificationSent { get; set; }
		public string YesAnswerEmail { get; set; }
		public string NoAnswerEmail { get; set; }
		public bool FilterQuestionIsNotRequired { get; set; }
		public int BranchId { get; set; }
		public bool ExpiredNotificationSentSecond { get; set; }
		public string Culture { get; set; }
		public bool PrescribedNotificationSent { get; set; }
		public bool PrescribedNotificationSentSecond { get; set; }
		public bool VideoQuestionsRequired { get; set; }
		public int CustomerId { get; set; }
		public bool AddToCandidateRegister { get; set; }
		public bool FirstReminderSent { get; set; }
		public bool SecondReminderSent { get; set; }
		public bool ThirdReminderSent { get; set; }
		public DateTime? FirstReminderSentDate { get; set; }
		public DateTime? SecondReminderSentDate { get; set; }
		public DateTime? ThirdReminderSentDate { get; set; }
	}
}
