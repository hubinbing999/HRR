
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface config_majorIDAO
    {
        int Add(config_majorModel st);
        List<config_majorModel> select();
        int update(config_majorModel st);
        List<config_majorModel> selectupdate(int id);
        int delete(int id);


    }
} 
