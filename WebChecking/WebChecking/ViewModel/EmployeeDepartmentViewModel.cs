using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebChecking.Models;

namespace WebChecking.ViewModel
{
	public class EmployeeDepartmentViewModel
	{
		public IEnumerable<Department> Departments { get; set; }
		public Employee Employee { get; set; }
        public Department Department { get; set; }
    }
}