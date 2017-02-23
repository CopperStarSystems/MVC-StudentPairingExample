//  --------------------------------------------------------------------------------------
// DataPassingDemo.HomeController.cs
// 2017/02/22
//  --------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Web.Mvc;
using DataPassingDemo.Helpers;
using DataPassingDemo.Models;

namespace DataPassingDemo.Controllers
{
    public class HomeController : Controller
    {
        readonly List<string> students;

        public HomeController()
        {
            students = new List<string>
                                         {
                                             "Student 1",
                                             "Student 2",
                                             "Student 3",
                                             "Student 4",
                                             "Student 5",
                                             "Student 6",
                                             "Student 7",
                                             "Student 8",
                                             "Student 9"
                                         };
        }

        public ActionResult Index()
        {
            var model = new StudentPairingData {Students = students};
            if (Request["PairStudents"] == "true")
            {
                var helper = new StudentPairingHelper();
                model = helper.PairStudents(model);
            }
            return View(model);
        }
    }
}