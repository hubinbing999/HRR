
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface engage_interviewIBLL
    {
        int Add1(engage_interviewModel st);
        List<engage_interviewModel> select1();
        int update1(engage_interviewModel st);
        int update2(engage_interviewModel st);
        List<engage_interviewModel> selectupdate(int id);
        int delete(int id);
        List<engage_interviewModel> selectupdate2(int id);
        FenYeModel3 Fenye4(int currentPage, int rl);
        int update3(engage_interviewModel st);
        int update4(engage_interviewModel st);
    }
}
