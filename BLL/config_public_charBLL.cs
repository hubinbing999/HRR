
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
    public class config_public_charBLL : config_public_charIBLL
    {
        config_public_charIDAO st1 = iocComm.config_public_charDAO();
        public int Add1(config_public_charModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<config_public_charModel> select1()
        {
            return st1.select();
        }

        public List<config_public_charModel> SelectByKind(config_public_charModel cm)
        {
            return st1.SelectByKind(cm);
                }

        public List<config_public_charModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(config_public_charModel st)
        {
            return st1.update(st);
        }
    }
}
                
