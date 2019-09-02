
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
    public class config_majorBLL : config_majorIBLL
    {
        config_majorIDAO st1 = iocComm.config_majorDAO();
        public int Add1(config_majorModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<config_majorModel> select1()
        {
            return st1.select();
        }

        public List<config_majorModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public List<config_majorModel> selectxlk1(string id)
        {
            return st1.selectxlk(id);
        }

        public int update1(config_majorModel st)
        {
            return st1.update(st);
        }
    }
}
                
