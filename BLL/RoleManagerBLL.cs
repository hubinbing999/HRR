
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ioc;
using IBLL;
using DAO;
using IDAO;
using System.Data;

namespace BLL
{
    public class RoleManagerBLL : RoleManagerIBLL
    {
        RoleManagerIDAO st1 = iocComm.RoleManagerDAO();
        public int Add1(RoleManagerModel st)
        {
            return st1.Add(st);
        }

        public int AddPer(string sql)
        {
            return st1.AddPer(sql);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public int DeletePer(string rid)
        {
            return st1.DeletePer(rid);
        }

        public List<RoleManagerModel> fenye(int currentPage)
        {
            return st1.fenye(currentPage);
        }

        public int pages()
        {
            return st1.pages();
        }

        public int Row()
        {
            return st1.Row();
        }

        public List<RoleManagerModel> select1()
        {
            return st1.select();
        }

        public DataTable selectQX(string rid, string pid)
        {
            return st1.selectQX(rid,pid);
        }

        public List<RoleManagerModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(RoleManagerModel st)
        {
            return st1.update(st);
        }


    }
}
                
