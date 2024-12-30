using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Application.DTOs
{
	public class ResponseMessage
	{
		public bool IsSuccess { get; set; }
		public string Message { get; set; }

		public static ResponseMessage GetResult(bool success, string msg)
		{
			return new ResponseMessage { IsSuccess = success, Message = msg };
		}
	}
}
