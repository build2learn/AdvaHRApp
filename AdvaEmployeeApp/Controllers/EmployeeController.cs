using AdvaEmployeeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdvaEmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        HRDBContext DBContext = new HRDBContext();
        public IActionResult Index()
        {
            //List<Employee> employees= DBContext.employees.ToList();
            return GetEmployees();
        }

        private IActionResult GetEmployees()
        {
            var employees = (from Employee in DBContext.Employees
                             join Department in DBContext.Departments on Employee.DepartmentID equals Department.DepartmentId
                             select new Employee
                             {
                                 EmployeeId = Employee.EmployeeId,
                                 EmployeeName = Employee.EmployeeName,
                                 Salary = Employee.Salary,
                                 DepartmentID = Employee.DepartmentID,
                                 DepartmentName = Department.DepartmentName
                             }).ToList().OrderBy(a=> a.DepartmentID);
            return View(employees);
        }

        public IActionResult Create()
        {
            ViewBag.Departments = this.DBContext.Departments.ToList();
            return View(new Employee());
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
           if (ModelState.IsValid)
            {
                DBContext.Employees.Add(employee);
                DBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Departments = this.DBContext.Departments.ToList();
            return View();
        }


        public IActionResult Edit(int ID)
        {
            Employee employee = DBContext.Employees.Where(e => e.EmployeeId == ID).FirstOrDefault();
            ViewBag.Departments=this.DBContext.Departments.ToList();
            return View("Create",employee);
        }

        public IActionResult Edit(Employee employee) {
            if (ModelState.IsValid)
            {
                DBContext.Employees.Update(employee);
                DBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Departments = this.DBContext.Departments.ToList();
            return View("Create",employee);
        }

        public IActionResult Delete(int ID)
        {
            Employee employee = DBContext.Employees.Where(e => e.EmployeeId == ID).FirstOrDefault();
            if(employee!=null)
            {
                DBContext.Employees.Remove(employee);
                 DBContext.SaveChanges();
               
            }
            return RedirectToAction("Index");
        }
       
    }
}
