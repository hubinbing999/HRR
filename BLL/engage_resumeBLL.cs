
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
    public class engage_resumeBLL : engage_resumeIBLL
    {
        engage_resumeIDAO st1 = iocComm.engage_resumeDAO();
        public int Add1(engage_resumeModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<engage_resumeModel> select1()
        {
            return st1.select();
        }

        public List<engage_resumeModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(engage_resumeModel st)
        {
            return st1.update(st);
        }
    }
}
                
