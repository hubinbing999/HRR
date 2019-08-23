
                       using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ioc;
using IBLL;
using DAO;
using IDAO;
namespace BLL
{
    public class config_file_second_kindBLL : config_file_second_kindIBLL
    {
        config_file_second_kindIDAO st1 = iocComm.config_file_second_kindDAO();
        public int Add1(config_file_second_kindModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<config_file_second_kindModel> select1()
        {
            return st1.select();
        }

        public List<config_file_second_kindModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public List<config_file_second_kindModel> selectxlk1(string id)
        {
            return st1.selectxlk(id);
        }

        public int update1(config_file_second_kindModel st)
        {
            return st1.update(st);
        }
    }
}
                
