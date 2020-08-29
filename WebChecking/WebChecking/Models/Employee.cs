using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChecking.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string EName { get; set; }
		public Department Department { get; set; }
		public int DepartmentId { get; set; }
	}
}