
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface salary_standard_detailsIDAO
    {
        int Add(salary_standard_detailsModel st);
        List<salary_standard_detailsModel> select();
        int update(salary_standard_detailsModel st);
        List<salary_standard_detailsModel> selectupdate(string id);
        int delete(int id);


    }
} 
