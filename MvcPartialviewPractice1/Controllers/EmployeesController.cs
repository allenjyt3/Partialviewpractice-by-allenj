using MvcPartialviewPractice1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace MvcPartialviewPractice1.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()//index is a view
        {
            SchoolEntities db = new SchoolEntities();
            return View(db.tbl_Employees);
        }

        public ActionResult IndexPart()//IndexPart is PartialView
        {
            SchoolEntities db = new SchoolEntities();
            //return PartialView();//for partial and render partial.
            return PartialView(db.tbl_Employees);//for render action.
        }
        
    }
}