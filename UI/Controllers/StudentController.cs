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
    public class StudentController : Controller
    {
        StudentIBLL st = iocComm.StudetIBLL();
        // GET: Student
        public ActionResult Index()
        {
            List<StudentModel> li = st.select1();
            return View(li);
          
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            string name = Request["Name"].ToString();
            string Sex = Request["Sex"].ToString();
            int classsid = int.Parse(Request["classsid"].ToString());
            StudentModel ste = new StudentModel();
            ste.Sex = Sex;
            ste.Name = name;
            ste.classsid = classsid;
            try
            {
                int pd=  st.Add1(ste);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            List<StudentModel> ji = st.selectupdate(id);
            StudentModel su = new StudentModel();
             su.Id= ji[0].Id;
             su.Name= ji[0].Name;
            su.Sex= ji[0].Sex;
              su.classsid=ji[0].classsid;

            return View(su);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            string name = Request["Name"].ToString();
            string Sex = Request["Sex"].ToString();
            int classsid = int.Parse(Request["classsid"].ToString());
            StudentModel ste = new StudentModel();
            ste.Sex = Sex;
            ste.Name = name;
            ste.classsid = classsid;
            ste.Id = id;
            int pd=  st.update1(ste);

            try
            {
                if (pd > 0) {

                return RedirectToAction("Index");
                }
                else { return View(); }
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
          int pd=  st.delete(id);

            return RedirectToAction("Index");
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
