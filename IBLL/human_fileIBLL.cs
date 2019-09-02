
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.bangzhu;

namespace IBLL
{
  public  interface human_fileIBLL
    {
        string Add1(human_fileModel st);
        List<human_fileModel> select1();
        int update1(human_fileModel st);
        List<human_fileModel> selectupdate(string id);
        int delete(int id);
        canshulei fenye(int dqy, int rl);
        int update12(human_fileModel item);
        canshulei fenye2(Cansh ji);
        canshulei fenye3(int dqy, int rl, string name);
        int update13(human_fileModel item);
        int updateztai(human_fileModel item);
        canshulei fenye4(int dqy, int rl);
    }
}
