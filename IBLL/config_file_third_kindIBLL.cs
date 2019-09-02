
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface config_file_third_kindIBLL
    {
        int Add1(config_file_third_kindModel st);
        List<config_file_third_kindModel> select1();
        int update1(config_file_third_kindModel st);
        List<config_file_third_kindModel> selectupdate(int id);
        int delete(int id);
        List<config_file_third_kindModel> selectxlk1(string id);
    }
}
