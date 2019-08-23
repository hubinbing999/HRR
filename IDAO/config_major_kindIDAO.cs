
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface config_major_kindIDAO
    {
        int Add(config_major_kindModel1 st);
        List<config_major_kindModel1> select();
        int update(config_major_kindModel1 st);
        List<config_major_kindModel1> selectupdate(string id);
        int delete(int id);


    }
} 
