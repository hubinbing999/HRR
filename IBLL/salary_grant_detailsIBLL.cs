
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface salary_grant_detailsIBLL
    {
        int Add1(salary_grant_detailsModel st);
        List<salary_grant_detailsModel> select1();
        int update1(salary_grant_detailsModel st);
        List<salary_grant_detailsModel> selectupdate(int id);
        int delete(int id);
        List<salary_grant_detailsModel> selectsalary_grant_id(string id);
    }
}
