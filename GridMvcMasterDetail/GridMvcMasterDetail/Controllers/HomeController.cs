using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GridMvcMasterDetail.Models;

namespace GridMvcMasterDetail.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var departments = BuildDepartmentsList();
			return View(departments);
		}

		public ActionResult EmployeesGrid(int id)
		{
			var employeesInDepartment = BuildEmployeesList().Where(emp => emp.DepartmentId == id);
			return PartialView(employeesInDepartment);
		}

		private IEnumerable<Department> BuildDepartmentsList()
		{
			var departments = new List<Department>();
			departments.Add(new Department {Id = 1, Name = "IT"});
			departments.Add(new Department {Id = 2, Name = "HR"});
			departments.Add(new Department {Id = 3, Name = "Facilities"});
			departments.Add(new Department {Id = 4, Name = "Accounts"});

			return departments;
		}

		private IEnumerable<Employee> BuildEmployeesList()
		{
			var employees = new List<Employee>();
			employees.Add(new Employee {Id = 1, DepartmentId = 1, Name = "Bruce Wayne", Age = "30"});
			employees.Add(new Employee {Id = 2, DepartmentId = 1, Name = "Peter Parker", Age = "33"});
			employees.Add(new Employee {Id = 3, DepartmentId = 1, Name = "Tony Stark", Age = "32"});
			employees.Add(new Employee {Id = 4, DepartmentId = 1, Name = "Bruce Banner", Age = "40"});

			employees.Add(new Employee {Id = 5, DepartmentId = 2, Name = "Kimi Raikonnen", Age = "33"});
			employees.Add(new Employee {Id = 6, DepartmentId = 2, Name = "Mika Hakkinen", Age = "46"});
			employees.Add(new Employee {Id = 7, DepartmentId = 2, Name = "Valteri Bottas", Age = "28"});
			employees.Add(new Employee {Id = 8, DepartmentId = 2, Name = "Nico Hulkenberg", Age = "29"});

			employees.Add(new Employee {Id = 9, DepartmentId = 3, Name = "Christopher Nolan", Age = "39"});
			employees.Add(new Employee {Id = 10, DepartmentId = 3, Name = "Quetin Tarentino", Age = "46"});
			employees.Add(new Employee {Id = 11, DepartmentId = 3, Name = "David Fincher", Age = "34"});
			employees.Add(new Employee {Id = 12, DepartmentId = 3, Name = "Roland Emmerich", Age = "52"});

			employees.Add(new Employee {Id = 13, DepartmentId = 4, Name = "John Nash", Age = "61"});
			employees.Add(new Employee {Id = 14, DepartmentId = 4, Name = "Alan Turing", Age = "47"});

			return employees;
		}
	}
}