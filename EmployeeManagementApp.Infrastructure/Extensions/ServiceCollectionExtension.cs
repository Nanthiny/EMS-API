using EmployeeManagementApp.Application.Interfaces;
using EmployeeManagementApp.Infrastructure.Persistence;
using EmployeeManagementApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Infrastructure.Extensions
{
	public static class ServiceCollectionExtension
	{
		public static void AddInfraStructure(this IServiceCollection services, IConfiguration configuration)
		{
			var connectionString = configuration.GetConnectionString("SystemDbConnection");
			services.AddDbContext<SystemDbContext>(options => options.UseSqlServer(connectionString));
			services.AddScoped<IEmployeeRepo, EmployeeRepo>();
			services.AddScoped<IDepartmentRepo, DepartmentRepo>();
			services.AddScoped<ISalaryDetailsRepo, EmployeeSalaryRepo>();
		}
	}
}
