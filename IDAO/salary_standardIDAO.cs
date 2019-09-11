
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.bangzhu;

namespace IDAO
{
  public  interface salary_standardIDAO
    {
        int Add(salary_standardModel st);
        List<salary_standardModel> select();
        int update(salary_standardModel st);
        List<salary_standardModel> selectupdate(int id);
        int delete(int id);
        string BianHao();
        salary_standardFenYe fenye(int dqy, int rl);
        XCcan Fenye2(salarystandard_query_locateCan ji);
        int BianGenupdate(salary_standardModel item);
    }
} 
