
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface human_file_digIBLL
    {
        int Add1(human_file_digModel st);
        List<human_file_digModel> select1();
        int update1(human_file_digModel st);
        List<human_file_digModel> selectupdate(int id);
        int delete(int id);
    }
}
