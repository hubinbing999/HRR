
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.bangzhu;

namespace IBLL
{
  public  interface salary_standardIBLL
    {
        int Add1(salary_standardModel st);
        List<salary_standardModel> select1();
        int update1(salary_standardModel st);
        List<salary_standardModel> selectupdate(int id);
        int delete(int id);
        string BianHao();
        salary_standardFenYe fenye(int dqy, int rl);
        XCcan Fenye2(salarystandard_query_locateCan ji);
        int BianGenupdate(salary_standardModel item);
    }
}
