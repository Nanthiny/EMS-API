﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Application.DTOs.Request
{
	public class DepartmentCreateRequestDto
	{
		[Required]
		public string DepartmentName { get; set; }
	}
}