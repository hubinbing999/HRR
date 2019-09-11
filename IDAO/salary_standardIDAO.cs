
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface salary_standardIDAO
    {
        int Add(salary_standardModel st);
        List<salary_standardModel> select();
        int update(salary_standardModel st);
        List<salary_standardModel> selectupdate(int id);
        int delete(int id);


    }
} 
