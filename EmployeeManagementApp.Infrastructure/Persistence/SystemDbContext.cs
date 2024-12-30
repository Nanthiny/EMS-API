using EmployeeManagementApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Infrastructure.Persistence
{
	public class SystemDbContext : DbContext
	{
		public SystemDbContext(DbContextOptions<SystemDbContext> options) : base(options)
		{
		}
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Department>()
				.HasMany(e => e.Employees)
				.WithOne(e => e.Department)
				.HasForeignKey(e => e.DepartmentId)
				.IsRequired();


			modelBuilder.Entity<Employee>()
				.HasOne(e => e.EmployeeSalaryDetail)
				.WithOne(e => e.Employee)
				.HasForeignKey<EmployeeSalaryDetail>(e => e.EmployeeId)
				.IsRequired();

			modelBuilder.Entity<Department>()
				.HasIndex(e => e.DepartmentName)
				.IsUnique();

			modelBuilder.Entity<Employee>()
				.HasIndex(e => e.EmployeeNumber)
				.IsUnique();
			modelBuilder.Entity<EmployeeSalaryDetail>()
				.HasIndex(e => e.EmployeeId)
				.IsUnique();
		}
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<EmployeeSalaryDetail> EmployeeSalaryDetails { get; set; }
	}
}
