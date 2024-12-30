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
	public interface IDepartmentRepo
	{
		Task<Department> CreateDepartmentAsync(DepartmentCreateRequestDto departmentDto);
		Task<Department> UpdateDepartmentAsync(int id, DepartmentCreateRequestDto departmentDto);
		Task<Department> GetDepartmentAsync(int id);
		Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync();
		Task<bool> DeleteDepartmentAsync(int id);
	}
}
