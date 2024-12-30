using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Application.DTOs.Request
{
	public class SalaryDetailsCreateRequestDto
	{
		[Required]
		public int EmployeeId { get; set; }
		[Required]
		public double Salary { get; set; }
		[Required]
		public DateTime EffectiveDate { get; set; }
	}
}
