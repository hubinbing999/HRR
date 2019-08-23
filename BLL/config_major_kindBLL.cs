
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
    public class config_major_kindBLL : config_major_kindIBLL
    {
        config_major_kindIDAO st1 = iocComm.config_major_kindDAO();
        public int Add1(config_major_kindModel1 st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<config_major_kindModel1> select1()
        {
            return st1.select();
        }

        public List<config_major_kindModel1> selectupdate(string id)
        {
            return st1.selectupdate(id);
        }

        public int update1(config_major_kindModel1 st)
        {
            return st1.update(st);
        }
    }
}
                
