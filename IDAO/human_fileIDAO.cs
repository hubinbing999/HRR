
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.bangzhu;

namespace IDAO
{
  public  interface human_fileIDAO
    {
        string Add(human_fileModel st);
        List<human_fileModel> select();
        int update(human_fileModel st);
        List<human_fileModel> selectupdate(string id);
        int delete(int id);
        canshulei fenye(int dqy,int rl);
        int update12(human_fileModel item);
        canshulei fenye3(int dqy, int rl, string name); 
        canshulei fenye2(Cansh ji);
        int update13(human_fileModel item);
        int updateztai(human_fileModel item);
        canshulei fenye4(int dqy, int rl);
    }
} 
