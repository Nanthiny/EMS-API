using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Domain.Entities
{
	/// <summary>
	/// Model for employee salary entity table
	/// </summary>
	public class EmployeeSalaryDetail
	{
		[Key]
		public int EmployeeSalaryDetailId { get; set; }
		[Required]
		public int EmployeeId { get; set; }
		[Required]
		public double Salary { get; set; }
		[Required]
		public DateTime EffectiveDate { get; set; }
		public Employee Employee { get; set; } = null!;

	}
}
