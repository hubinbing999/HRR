
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface config_public_charIBLL
    {
        int Add1(config_public_charModel st);
        List<config_public_charModel> select1();
        int update1(config_public_charModel st);
        List<config_public_charModel> selectupdate(int id);
        int delete(int id);
    }
}
