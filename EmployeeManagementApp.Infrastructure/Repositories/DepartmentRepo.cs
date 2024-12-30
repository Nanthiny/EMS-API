using EmployeeManagementApp.Application.DTOs.Request;
using EmployeeManagementApp.Application.DTOs;
using EmployeeManagementApp.Application.Interfaces;
using EmployeeManagementApp.Domain.Entities;
using EmployeeManagementApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Infrastructure.Repositories
{
	public class DepartmentRepo : CrudRepo<Department>, IDepartmentRepo
	{
		public DepartmentRepo(SystemDbContext dbContext) : base(dbContext)
		{

		}
		public async Task<Department> CreateDepartmentAsync(DepartmentCreateRequestDto departmentDto)
		{
			var department = new Department
			{
				DepartmentName = departmentDto.DepartmentName
			};
			return await CreateAsync(department);
		}

		public async Task<bool> DeleteDepartmentAsync(int id)
		{
			return await DeleteAsync(id);
		}

		public async Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync()
		{
			var list = new List<DepartmentDto>();

			var departments = await _dbContext.Departments.AsNoTracking().ToListAsync();
			foreach (var item in departments)
			{
				list.Add(new DepartmentDto
				{
					DepartmentId = item.DepartmentId,
					DepartmentName = item.DepartmentName
				});
			}
			return list;
		}

		public async Task<Department> GetDepartmentAsync(int id)
		{
			return await GetAsync(id);
		}

		public async Task<Department> UpdateDepartmentAsync(int id, DepartmentCreateRequestDto departmentDto)
		{
			var entity = await GetAsync(id);
			if (entity != null)
			{
				entity.DepartmentId = id;
				entity.DepartmentName = departmentDto.DepartmentName;
				entity = await UpdateAsync(entity);
			}
			return entity;
		}
	}
}
