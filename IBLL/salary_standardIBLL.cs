
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface salary_standardIBLL
    {
        int Add1(salary_standardModel st);
        List<salary_standardModel> select1();
        int update1(salary_standardModel st);
        List<salary_standardModel> selectupdate(int id);
        int delete(int id);
    }
}
