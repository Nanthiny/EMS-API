using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Domain.Entities
{
	/// <summary>
	/// Model for department entity table
	/// </summary>
	public class Department
	{
		[Key]
		public int DepartmentId { get; set; }
		[Required]
		public string DepartmentName { get; set; } = default!;
		public IEnumerable<Employee>? Employees { get; set; }
	}
}
