
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
    public class config_file_first_kindBLL : config_file_first_kindIBLL
    {
        config_file_first_kindIDAO st1 = iocComm.config_file_first_kindDAO();
        public int Add1(config_file_first_kindModel st)
        {
            



            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<config_file_first_kindModel> select1()
        {
            return st1.select();
        }

        public List<config_file_first_kindModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(config_file_first_kindModel st)
        {
            return st1.update(st);
        }
    }
}
                
