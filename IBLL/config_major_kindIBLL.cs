
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface config_major_kindIBLL
    {
        int Add1(config_major_kindModel1 st);
        List<config_major_kindModel1> select1();
        int update1(config_major_kindModel1 st);
        List<config_major_kindModel1> selectupdate(string id);
        int delete(int id);
        
    }
}
