using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using ioc;
using Model;
using Newtonsoft.Json;
using System.Data;

namespace UI.Controllers
{
    public class RoleManagerController : Controller
    {
        RoleManagerIBLL ibl = iocComm.RoleManagerIBLL();
        // GET: RoleManager
        /// <summary>
        /// 显示全部页面
        /// </summary>
        /// <returns></returns>
        public ActionResult right_list()
        {
            ViewData["zs"] = ibl.Row();
            ViewData["page"] = ibl.pages();
            return View();
        }

        /// <summary>
        /// 查询全部角色
        /// </summary>
        /// <returns></returns>
        public ActionResult SelectRole()
        {
            List<RoleManagerModel> list = ibl.fenye(int.Parse(Request["ye"]));
            return Content(JsonConvert.SerializeObject(list));


        }


        // GET: RoleManager/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        /// <summary>
        /// 新增页面
        /// </summary>
        /// <returns></returns>
        // GET: RoleManager/Create
        public ActionResult RoleAdd()
        {
            return View();
        }

        // POST: RoleManager/Create
        /// <summary>
        /// 新增方法
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(RoleManagerModel r)
        {
            
                if (ModelState.IsValid)
                {
                    RoleManagerModel rr = new RoleManagerModel()
                    {
                        RoleID = r.RoleID,
                        RoleName = r.RoleName,
                        RoleState = r.RoleState,
                        RoleOk = r.RoleOk

                    };
                    if (ibl.Add1(rr) > 0)
                    {
                    return Content("<script>alert('新增成功！');window.location.href='/RoleManager/right_list';</script>");
                   // return Content("<script>alert(111)</script>");
                }
                    else
                    {
                        return Content("<script>alert('新增失败！'); window.location.href='/RoleManager/RoleAdd';</script>");
                    }
                }
            return null;
                
            }
        // GET: RoleManager/Edit/5
        /// <summary>
        /// 修改显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult RoleUpdate(int id)
        {
           List<RoleManagerModel> list= ibl.selectupdate(id);
            RoleManagerModel r = new RoleManagerModel()
            {
                //RoleID = list[0].RoleID,
                RoleName = list[0].RoleName,
                RoleState = list[0].RoleState,
                RoleOk = list[0].RoleOk
            };
            int RoleID = list[0].RoleID;
            ViewData["id"] = RoleID;
            ViewData.Model = r;
            return View();
        }
        public ActionResult RoleXG(int id)
        {
            List<RoleManagerModel> list = ibl.selectupdate(id);
            RoleManagerModel r = new RoleManagerModel()
            {
                //RoleID = list[0].RoleID,
                RoleName = list[0].RoleName,
                RoleState = list[0].RoleState,
                RoleOk = list[0].RoleOk
            };
            int RoleID = list[0].RoleID;
            ViewData["id"] = RoleID;
            ViewData.Model = r;
            return View();

        }


        public ActionResult ShowQX()
        {
            string id = Request["id"];
            string RoleID =Request["RoleID"];
            string f = "0";
            DataTable dt;
            if (id != null)
            {
                dt = ibl.selectQX(RoleID, id);
            }
            else
            {
                dt = ibl.selectQX(RoleID, f);
            }
         //   Response.Write(JsonConvert.SerializeObject(dt));
            return Content(JsonConvert.SerializeObject(dt));


        }

        // POST: RoleManager/Edit/5
        /// <summary>
        /// 修改提交（提交成功返回给js页面，进行角色权限表操作）
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        
        public ActionResult RoleUpdate2( )
        {
            string Rolemanager = Request["RoleManager"];
            Dictionary<string ,object> di=JsonConvert.DeserializeObject<Dictionary<string,object>> (Rolemanager);
            RoleManagerModel mm = new RoleManagerModel
            {
                RoleID=int.Parse(di["RoleID"].ToString()),
                RoleName = di["RoleName"].ToString(),
                RoleState=di["RoleState"].ToString(),
                RoleOk=di["RoleOK"].ToString()
            };
            int i = ibl.update1(mm);
            return Content(JsonConvert.SerializeObject(i));
           
        }
        public ActionResult PerDelete()
        {
            string rid = Request["rid"];
            int b = ibl.DeletePer(rid);
            return Content(JsonConvert.SerializeObject(b));

        }
        public ActionResult PerADD1()
        {
            string rid = Request["rid"];
            string Aid = Request["dsd"];
            string sql = string.Format(@"insert into [dbo].[Permission]  values('{0}','{1}')", rid,Aid);
            int c = ibl.AddPer(sql);
            return Content(JsonConvert.SerializeObject(c));

        }

        //public ActionResult PerADD2()
        //{

        //    string rid = Request["rid"];
        //    string Bid = Request["ssd"];
        //    string sql = string.Format(@"insert into [dbo].[Permission]  values('{0}','{1}')", rid, Bid);
        //    int c = ibl.AddPer(sql);
        //    return Content(JsonConvert.SerializeObject(c));
        //}
        // GET: RoleManager/Delete/5
        public ActionResult Delete(int id)
        {
            //删除前查询此角色下有无用户，有用户则不可以删除
            try
            {
                if (ibl.delete(id) > 0)
                {
                    return Content("<script>alert('删除成功！'); window.location.href='/RoleManager/right_list';</script>");

                }
                else
                {
                    return Content("<script>alert('删除失败！'); window.location.href='/RoleManager/right_list';</script>");

                }
            }
            catch (Exception)
            {

                return Content("<script>alert('删除失败！此角色下有用户'); window.location.href='/RoleManager/right_list';</script>");
            }

           

        }

    }
}
