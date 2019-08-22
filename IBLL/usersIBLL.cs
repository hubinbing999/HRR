
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface usersIBLL
    {
        int Add1(usersModel st);
        List<usersModel> select1();
        int update1(usersModel st);
        List<usersModel> selectupdate(int id);
        int delete(int id);
        int dl(usersModel us);
    }
}
