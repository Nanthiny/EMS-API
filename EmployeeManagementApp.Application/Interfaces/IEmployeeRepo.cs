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
	public interface IEmployeeRepo
	{
		Task<Employee> CreateEmployeeAsync(EmployeeCreateRequestDto employeeDto);
		Task<Employee> UpdateEmployeeAsync(int id, EmployeeCreateRequestDto employeeDto);
		Task<Employee> GetEmployeeAsync(int id);
		Task<IEnumerable<EmployeeDto>> GetAllEmployeeAsync();
		Task<bool> DeleteEmployeeAsync(int id);

	}
}
