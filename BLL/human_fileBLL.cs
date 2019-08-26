
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
    public class human_fileBLL : human_fileIBLL
    {
        human_fileIDAO st1 = iocComm.human_fileDAO();
        public int Add1(human_fileModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<human_fileModel> select1()
        {
            return st1.select();
        }

        public List<human_fileModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(human_fileModel st)
        {
            return st1.update(st);
        }
    }
}
                
