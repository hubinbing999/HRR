
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface salary_standard_detailsIBLL
    {
        int Add1(salary_standard_detailsModel st);
        List<salary_standard_detailsModel> select1();
        int update1(salary_standard_detailsModel st);
        List<salary_standard_detailsModel> selectupdate(string id);
        int delete(int id);
    }
}
