
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface human_fileIBLL
    {
        int Add1(human_fileModel st);
        List<human_fileModel> select1();
        int update1(human_fileModel st);
        List<human_fileModel> selectupdate(int id);
        int delete(int id);
    }
}
