
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface engage_resumeIBLL
    {
        int Add1(engage_resumeModel st);
        List<engage_resumeModel> select1();
        int update1(engage_resumeModel st);
        int update2(engage_resumeModel st);
        List<engage_resumeModel> selectupdate(int id);
        int delete(int id);
        FenyeModel2 Fenye(int currentPage, int rl, string human_major_kind_id, string human_major_id, string gjz, string startDate, string endDate);
        FenyeModel2 Fenye2(int currentPage, int rl, string human_major_kind_id, string human_major_id, string gjz, string startDate, string endDate);
        FenyeModel2 Fenye3(int currentPage, int rl);
        FenyeModel2 Fenye4(int currentPage, int rl);
        FenyeModel2 Fenye5(int currentPage, int rl);
        FenyeModel2 Fenye6(int currentPage, int rl);
        int update3(engage_resumeModel st);
        int update4(engage_resumeModel st);
        int update5(engage_resumeModel st);
    }
}
