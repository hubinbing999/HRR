
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface human_file_digIDAO
    {
        int Add(human_file_digModel st);
        List<human_file_digModel> select();
        int update(human_file_digModel st);
        List<human_file_digModel> selectupdate(int id);
        int delete(int id);


    }
} 
