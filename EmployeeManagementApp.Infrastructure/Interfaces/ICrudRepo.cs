using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Infrastructure.Interfaces
{
	public interface ICrudRepo<T> where T : class
	{
		Task<T> CreateAsync(T entity);
		Task<T> UpdateAsync(T entity);
		Task<bool> DeleteAsync(int Id);
		Task<T> GetAsync(int id);
		Task<IEnumerable<T>> GetAllAsync();
	}
}
