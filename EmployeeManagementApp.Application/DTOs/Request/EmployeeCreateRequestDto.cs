using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Application.DTOs.Request
{
	public class EmployeeCreateRequestDto
	{
		[Required]
		public string EmployeeName { get; set; }
		[Required]
		public string EmployeeNumber { get; set; }
		[Required]
		[EmailAddress(ErrorMessage = "Invalid Email Address.")]
		public string EmailAddress { get; set; }
		[Required]
		[MinLength(6)]
		[MaxLength(20)]
		[Phone(ErrorMessage = "Invalid Phone Number.")]
		public string Phone { get; set; }
		[Required]
		public string JobTitle { get; set; }
		[Required]
		public DateTime JoinedDate { get; set; }
		[Required]
		public int DepartmentId { get; set; }

	}
}
