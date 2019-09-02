
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace IBLL
{
  public  interface RoleManagerIBLL
    {
        int Add1(RoleManagerModel st);
        List<RoleManagerModel> select1();
        int update1(RoleManagerModel st);
        List<RoleManagerModel> selectupdate(int id);
        int delete(int id);
        List<RoleManagerModel> fenye(int currentPage);
        int Row();
        int pages();
        DataTable selectQX(string rid, string pid);
        int DeletePer(string rid);
        int AddPer(string sql);


    }
}
