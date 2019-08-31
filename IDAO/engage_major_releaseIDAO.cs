
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface engage_major_releaseIDAO
    {
        int Add(engage_major_releaseModel st);
        List<engage_major_releaseModel> select();
        int update(engage_major_releaseModel st);
        List<engage_major_releaseModel> selectupdate(int id);
        int delete(int id);
        FenYeModel Fenye(int currentPage,int rl);

    }
} 
