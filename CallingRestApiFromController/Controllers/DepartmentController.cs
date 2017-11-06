using CallingRestApiFromController.Models;
using CallingRestApiFromController.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallingRestApiFromController.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            DepartmentClient departmentClient = new DepartmentClient();
            List<Department> departments = departmentClient.findAll().ToList();
            return View(departments);
        }

        public ActionResult Create()
        {
            Department department = new Department();
            return View(department);
        }
        [HttpPost]
        public ActionResult Create(Department department)
        {
            DepartmentClient departmentClient = new DepartmentClient();
            departmentClient.Create(department);
            return RedirectToAction("Index");

        }
        public ActionResult Edit(int id)
        {
            DepartmentClient departmentClient = new DepartmentClient();
            Department department = departmentClient.find(id);
            return View("Edit", department);
        }
        [HttpPost]
        public ActionResult Edit(Department department)
        {
            DepartmentClient departmentClient = new DepartmentClient();
            bool result = departmentClient.Edit(department);
            if (result)
            {
                ViewBag.msg = "Department Edit Successfully!";
                return RedirectToAction("Index");
            }else
            {
                ViewBag.msg = "Error To Save Department!";
                return RedirectToAction("Edit", department);
            }
           
        }
        public ActionResult Delete(int id)
        {
            DepartmentClient departmentClient = new DepartmentClient();
            Department department = departmentClient.find(id);
            return View("Edit", department);
        }
        [HttpPost]
        public ActionResult Delete(Department department)
        {
            DepartmentClient departmentClient = new DepartmentClient();
            bool result = departmentClient.Delete(department.id);
            if (result)
            {
                ViewBag.msg = "Department Delete Successfully!";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.msg = "Error To Delete Department!";
                return RedirectToAction("Delete", department.id);
            }
        }
    }
}