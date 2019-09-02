
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
        List<engage_resumeModel> selectupdate(int id);
        int delete(int id);
    }
}
