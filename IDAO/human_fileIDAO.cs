
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface human_fileIDAO
    {
        int Add(human_fileModel st);
        List<human_fileModel> select();
        int update(human_fileModel st);
        List<human_fileModel> selectupdate(int id);
        int delete(int id);


    }
} 
