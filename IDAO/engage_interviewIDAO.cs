
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface engage_interviewIDAO
    {
        int Add(engage_interviewModel st);
        List<engage_interviewModel> select();
        int update(engage_interviewModel st);
        int update2(engage_interviewModel st);
        List<engage_interviewModel> selectupdate(int id);
        int delete(int id);
        FenYeModel3 Fenye4(int currentPage, int rl);
        List<engage_interviewModel> selectupdate2(int id);
        int update3(engage_interviewModel st);
        int update4(engage_interviewModel st);
    }
} 
