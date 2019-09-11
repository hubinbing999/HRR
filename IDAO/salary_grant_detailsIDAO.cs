
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface salary_grant_detailsIDAO
    {
        int Add(salary_grant_detailsModel st);
        List<salary_grant_detailsModel> select();
        int update(salary_grant_detailsModel st);
        List<salary_grant_detailsModel> selectupdate(int id);
        int delete(int id);
        List<salary_grant_detailsModel> selectsalary_grant_id(string id);

    }
} 
