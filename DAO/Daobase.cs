using MVC_8;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Log4;

namespace DAO
{
    public class Daobase<T> where T : class
    {
        static MyDbContext db = CreateDbContext();

        private static MyDbContext CreateDbContext()
        {
            //从当前请求的线程取值
            db = CallContext.GetData("s") as MyDbContext;
            if (db == null)
            {
                db = new MyDbContext();
                //把上下文对象存入当前请求的线程中
                CallContext.SetData("s", db);
            }
            return db;
        }

        //新增
        public int Add(T t)
        {
            db.Set<T>().Add(t);
            return db.SaveChanges();
        }

        //删除  根据 条件删除
        public int Del(Expression<Func<T, bool>> where,T ta)
        {
            RemoveHoldingEntityInContext(ta);
            T t = db.Set<T>().Where(where).AsNoTracking().FirstOrDefault();
            db.Set<T>().Attach(t);
            //对数据删除
            db.Set<T>().Remove(t);
            return db.SaveChanges();
        }
        //查询所有
        public List<T> SelectAll()
        {
            List<T> list = db.Set<T>().Select(e => e).AsNoTracking().ToList();
            return list;
        }
        //根据条件查询
        public List<T> SeleteBy(Expression<Func<T, bool>> where)
        {
            List<T> list = db.Set<T>().Select(e => e).Where(where).AsNoTracking().ToList();
            return list;
        }
        //分页查询 k代表数据类型 ，查询条件 ，总记录数 ，当前页，显示数量
        public List<T> FenYe<K>(Expression<Func<T, K>> order, Expression<Func<T, bool>> where, ref int rows, int currentPage, int pageSize)
        {
            var data = db.Set<T>().OrderBy(order).Where(where).AsNoTracking();
            rows = data.Count();//获取总行数
            List<T> list = data.Skip((currentPage - 1) * pageSize)
                   .Take(pageSize)
                   .ToList();
            return list;
        }

        //修改
        public int ModifyWithOutproNames(T model, params string[] proNames)
        {
            RemoveHoldingEntityInContext(model);
            DbEntityEntry entry = db.Entry<T>(model);
            entry.State = EntityState.Unchanged;
            var properties = model.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                if (properties[i].PropertyType.Name.Contains("ICollection")// 排除 外键  
                    || proNames.Contains(properties[i].Name) || properties[i].GetValue(model, null) == null) continue;
                entry.Property(properties[i].Name).IsModified = true;
            }
            db.Configuration.ValidateOnSaveEnabled = false;
            return db.SaveChanges();
           
           
        }
        private Boolean RemoveHoldingEntityInContext(T entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<T>();
            var entityKey = objContext.CreateEntityKey(objSet.EntitySet.Name, entity);

            Object foundEntity;
            var exists = objContext.TryGetObjectByKey(entityKey, out foundEntity);

            if (exists)
            {
                objContext.Detach(foundEntity);
            }
       

            return (exists);
        }

    }
}
