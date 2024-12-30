using EmployeeManagementApp.Application.DTOs.Request;
using EmployeeManagementApp.Application.DTOs;
using EmployeeManagementApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Application.Interfaces
{
	public interface ISalaryDetailsRepo
	{
		Task<EmployeeSalaryDetail> CreateEmployeeSalaryAsync(SalaryDetailsCreateRequestDto departmentDto);
		Task<EmployeeSalaryDetail> UpdateEmployeeSalaryAsync(int id, SalaryDetailsCreateRequestDto employeeDto);
		Task<EmployeeSalaryDetail> GetEmployeeSalaryAsync(int id);
		Task<IEnumerable<EmployeeSalaryDto>> GetAllSalaryDetailsAsync();
		Task<bool> DeleteEmployeeSalaryAsync(int id);

	}
}
