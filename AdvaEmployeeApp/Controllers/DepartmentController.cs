using Microsoft.AspNetCore.Mvc;

namespace AdvaEmployeeApp.Controllers
{
    public class DepartmentController : Controller
    {
        HRDBContext _HRDBContext=new HRDBContext();
        public IActionResult Index()
        {
            List<Department> departmentList = _HRDBContext.Departments.ToList();
            return View(departmentList);
        }
    }
}
