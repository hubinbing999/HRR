using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDbContext mc = new MyDbContext()) {
                mc.Database.Log = (sql) =>
                {
                    Console.WriteLine(sql);
                };
                Daobase<Student> dao = new Daobase<Student>();
                #region
                //    Student st = new Student() {
                //        Name = "胡彬冰",
                //        Sex = "男",
                //        classsid = 1
                //    };
                //Daobase<Student> dao = new Daobase<Student>();
                // int pd=   dao.Add(st);
                //    if (pd > 0) {
                //        Console.WriteLine("成功");
                //    }
                #endregion
                #region 修改
                Student st = new Student()
                {
                    Id = 4,
                    Name = "胡彬冰11",
                    Sex = "男",
                    
                };
                string[] sat = { "classsid" };
                int pd = dao.ModifyWithOutproNames(st, "Id");
                if (pd > 0)
                {
                    Console.WriteLine("成功");
                }
                #endregion


                #region 删除
                //Student st = new Student();
                //int pd = dao.Del(e => e.Name.Contains("王"));

                //if (pd > 0)
                //{
                //    Console.WriteLine("成功");
                //}
                #endregion
                #region 查询全部
                //Student st = new Student();
                //List<Student> list=  dao.SelectAll();
                //foreach (Student item in list)
                //{
                //    Console.WriteLine(item.Id+""+item.Name+" "+item.Sex);
                //}
                #endregion

                #region 查询id
                //List<Student> list = dao.SeleteBy(e => e.Name.Contains("胡"));
                //foreach (Student item in list)
                //{
                //    Console.WriteLine(item.Id + "" + item.Name + " " + item.Sex);
                //}

                #endregion
                #region 分页
                //rows z总页数 e => e.Id > 0条件 e=>e.Id
                //int rows = 0;
                //List<Student> list = dao.FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, 1, 2);
                //foreach (Student item in list)
                //{
                //    Console.WriteLine(item.Id + "" + item.Name + " " + item.Sex);
                //}
                #endregion
                Console.ReadKey();

}
}
}
}
