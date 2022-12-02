using AdvaEmployeeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdvaEmployeetApp.Controllers
{
    public class DepartmentController : Controller
    {
        HRDBContext _HRDBContext =new HRDBContext();
        public IActionResult Index()
        {
            List<Department> departmentList = _HRDBContext.Departments.ToList();
            return View(departmentList);
        }

        public IActionResult Create()
        {
            //ViewBag.Departments = this._HRDBContext.Departments.ToList();
            ViewBag.Employee = this._HRDBContext.Employees.ToList();
            return View();
        }


        [HttpPost]
        public IActionResult Create(Department Department)
        {
            if (ModelState.IsValid)
            {
                _HRDBContext.Departments.Add(Department);
                _HRDBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Employee = this._HRDBContext.Employees.ToList();
            return View();
        }


        public IActionResult Edit(int ID)
        {
            Department Department = this._HRDBContext.Departments.Where(e => e.DepartmentId == ID).FirstOrDefault();
            ViewBag.Employee = this._HRDBContext.Employees.ToList();
            return View("Create", Department);
        }

        [HttpPost]
        public IActionResult Edit(Department Department)
        {
            if (ModelState.IsValid)
            {
                _HRDBContext.Departments.Update(Department);
                _HRDBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Employee = this._HRDBContext.Employees.ToList();
            return View("Create", Department);
        }

        public IActionResult Delete(int ID)
        {
            Department Department = _HRDBContext.Departments.Where(e => e.DepartmentId == ID).FirstOrDefault();
            if (Department != null)
            {
                _HRDBContext.Departments.Remove(Department);
                _HRDBContext.SaveChanges();

            }
            return RedirectToAction("Index");
        }

    }
}
