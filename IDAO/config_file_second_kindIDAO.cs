
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface config_file_second_kindIDAO
    {
        int Add(config_file_second_kindModel st);
        List<config_file_second_kindModel> select();
        int update(config_file_second_kindModel st);
        List<config_file_second_kindModel> selectupdate(int id);
        int delete(int id);
        List<config_file_second_kindModel> selectxlk(string id);

    }
} 
