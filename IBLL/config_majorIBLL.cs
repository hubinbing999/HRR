
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface config_majorIBLL
    {
        int Add1(config_majorModel st);
        List<config_majorModel> select1();
        int update1(config_majorModel st);
        List<config_majorModel> selectupdate(int id);
        int delete(int id);
        List<config_majorModel> selectxlk1(string id);
    }
}
