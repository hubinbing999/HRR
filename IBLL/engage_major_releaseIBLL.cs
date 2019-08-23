
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface engage_major_releaseIBLL
    {
        int Add1(engage_major_releaseModel st);
        List<engage_major_releaseModel> select1();
        int update1(engage_major_releaseModel st);
        List<engage_major_releaseModel> selectupdate(int id);
        int delete(int id);
    }
}
