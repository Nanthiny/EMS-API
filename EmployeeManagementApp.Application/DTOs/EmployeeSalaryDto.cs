using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Application.DTOs
{
	public class EmployeeSalaryDto
	{
		public int EmployeeSalaryDetailsId { get; set; }
		public int EmployeeId { get; set; }
		public string EmployeeNumber { get; set; }
		public double Salary { get; set; }
		public DateTime EffectiveDate { get; set; }
	}
}
