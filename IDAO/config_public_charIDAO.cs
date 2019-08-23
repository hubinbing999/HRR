
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface config_public_charIDAO
    {
        int Add(config_public_charModel st);
        List<config_public_charModel> select();
        int update(config_public_charModel st);
        List<config_public_charModel> selectupdate(int id);
        int delete(int id);
        List<config_public_charModel> SelectByKind(config_public_charModel cm);
    }
} 
