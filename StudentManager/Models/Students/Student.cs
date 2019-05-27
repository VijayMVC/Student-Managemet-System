using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Models.Students
{
	public class Student
	{
		public int StudentId { get; set; }
		public string StudentName { get; set; }
		public string FatherName { get; set; }
		public string PhoneNumber { get; set; }
		public int CityId { get; set; }
		public string EmailAddress { get; set; }
		public int DepartmentId { get; set; }
		public string AddressLine { get; set; }
	}
}
