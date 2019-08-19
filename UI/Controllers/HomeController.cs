using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ioc;
using Model;
using IBLL;
namespace UI.Controllers
{
    public class HomeController : Controller
    {
        StudentIBLL st = iocComm.StudetIBLL();
        public ActionResult Index()
        {
            List<StudentModel> li = st.select1();
            return View(li);
        }
       

    }
    
}