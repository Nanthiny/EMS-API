using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Domain.Entities
{
	/// <summary>
	/// Model for employee entity table
	/// </summary>
	public class Employee
	{
		[Key]
		public int EmployeeId { get; set; }
		[Required]
		public string EmployeeName { get; set; } = default!;
		[Required]
		public string EmployeeNumber { get; set; } = null!;
		[Required]
		public string EmailAddress { get; set; } = default!;
		[Required]
		[MinLength(6)]
		[MaxLength(20)]
		public string Phone { get; set; } = default!;

		[Required]
		public string JobTitle { get; set; } = default!;
		[Required]
		public DateTime JoinedDate { get; set; }
		public int DepartmentId { get; set; }
		public int? EmployeeSalaryDetailId { get; set; }
		public Department Department { get; set; } = null!;
		public bool IsActive { get; set; }
		public EmployeeSalaryDetail? EmployeeSalaryDetail { get; set; }
	}
}
