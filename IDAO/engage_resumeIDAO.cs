
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface engage_resumeIDAO
    {
        int Add(engage_resumeModel st);
        List<engage_resumeModel> select();
        int update(engage_resumeModel st);
        List<engage_resumeModel> selectupdate(int id);
        int delete(int id);


    }
} 
