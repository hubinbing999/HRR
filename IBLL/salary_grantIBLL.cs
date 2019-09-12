
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.bangzhu;

namespace IBLL
{
  public  interface salary_grantIBLL
    {
        List<string> bianHao();
        int Add1(salary_grantModel st);
        List<salary_grantModel> select1();
        int update1(salary_grantModel st);
        List<salary_grantModel> selectupdate(int id);
        int delete(int id);
        List<salary_grantModel> selectupdateda(string id);
        salary_grantCan fenye(int dqy, int rl);
        int updateChenk(salary_grantModel item);
        salary_grantCan fenye2(query_locateCan va, int dqy, int rl);
        int updateFan(salary_grantModel item);
    }
}
