using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using ioc;
using IBLL;
using Newtonsoft.Json;
using System.Data;

namespace UI.Controllers
{
    public class usserController : Controller
    {
        usersIBLL us = iocComm.usersBLL();
        // GET: usser
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult top()
        {
            return View();
        }
        public ActionResult mian()
        {
            return View();
        }
        public ActionResult Index3()
        {
        string q=  HttpContext.Session["user"].ToString();
            return Content(q);
        }
        /// <summary>
        /// 用户管理查询全部
        /// </summary>
        /// <returns></returns>
        public ActionResult User_List()
        {
            ViewData["zs"] = us.SelectCount();
            return View();
        }
        public  ActionResult selectUser()
        {
            List<usersModel> li = us.SelectList();
            string aa = JsonConvert.SerializeObject(li);
            return Content(aa);
        }
        /// <summary>
        /// 用户新增
        /// </summary>
        /// <returns></returns>
        public ActionResult UserAdd()
        {
            //绑定下拉框
            BindSF();
            return View();

        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UserAdd(usersModel u)
        {

            if (ModelState.IsValid)//后台验证
            {
                usersModel um = new usersModel()
                {
                    u_name=u.u_name,
                    u_true_name=u.u_true_name,
                    u_password=u.u_password,
                    roleID=u.roleID
                };
                if (us.Add1(um) > 0)
                {
                    return Content("<script>alert('新增成功！');</script>");
                }
                else
                {
                    return Content("<script>alert('新增失败！'); window.location.href='/usser/User_List';</script>");

                }

            }
            else
            {
                return View();
            }
        }
        private List<SelectListItem> BindSF()
        {
            DataTable dt = us.BandList();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (DataRow item in dt.Rows)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item["RoleName"].ToString(),
                    Value = item["RoleID"].ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt = list;
            return list;
        }
        /// <summary>
        /// 用户修改
        /// </summary>
        /// <returns></returns>
        // GET: config_public_char/Edit/5
        public ActionResult UserUpdate(int id)
        {
            List<SelectListItem> list = BindSF();
            ViewData["s"] = list;

            List<usersModel> listu = us.selectupdate(id);
            usersModel u = new usersModel
            {
                id  = listu[0].id ,
                roleID = listu[0].roleID,
                u_name = listu[0].u_name,
                u_password = listu[0].u_password,
                u_true_name = listu[0].u_true_name
            };
            ViewData.Model = u;
            return View();
        }

        // POST: config_public_char/Edit/5
        [HttpPost]
        public ActionResult UserUpdate(usersModel u)
        {
            try
            {
                if (us.update1(u) > 0)
                {
                    return Content("<script>alert('修改成功！'); window.location.href='/usser/User_List';</script>");
                }
                else
                {
                    return Content("<script>alert('修改失败！'); window.location.href='/usser/UserUpdate';</script>");
                }
            }
            catch
            {
                return View();
            }
        }
        /// <summary>
        /// 用户删除
        /// </summary>
        /// <returns></returns>
        public ActionResult UserDelete(int id)
        {

            if (us.delete(id) > 0)
            {
                return Content("<script>alert('删除成功！'); window.location.href='/usser/User_List';</script>");

            }
            else
            {
                return Content("<script>alert('删除失败！'); window.location.href='/usser/User_List';</script>");

            }

        }

        [HttpPost]
        public ActionResult UserDelete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("User_List");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult dl(FormCollection collection)
        {

            string u_name1 = Request["u_name"];
            string u_password1 = Request["u_password"];
            usersModel us1 = new usersModel()
            {
                u_name = u_name1,
                u_password = u_password1
            };
            int pd = us.dl(us1);//登入的用户id
            //根据用户id查出角色id和角色名字
            DataTable js = us.SelectJS(pd);
            int jsID;
            string jsName;
            string trueName;
            if (pd > 0)
            {
                foreach (DataRow item in js.Rows)
                {
                    trueName = item["u_true_name"].ToString();//真实姓名
                    jsID = int.Parse(item["roleID"].ToString());//角色id
                    jsName = item["RoleName"].ToString();//角色名字
                        Session["user"] = pd;
                        Session["us"] = trueName;
                        return JavaScript("alert('登录成功'); localStorage.setItem('a', '" + trueName + "'); localStorage.setItem('jsid', '" + jsID + "');localStorage.setItem('jsName', '" + jsName + "');  window.location.href='/usser/index'");//page/index.html

                }

            }
            else
            {
                return JavaScript("alert('登录失败'); window.location.href='/usser/Login'");
            }
            return null;
        }

        //根据权限登入
        public ActionResult ShowBYQX()
        { 
            string id = Request["id"];
            string Aid = Request["RoleId"];
            DataTable dt = us.ShowBYQX(Aid, id);
            return Content(JsonConvert.SerializeObject(dt));

        }



        // GET: usser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: usser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: usser/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: usser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: usser/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: usser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: usser/Delete/5
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
