
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
    public class engage_interviewBLL : engage_interviewIBLL
    {
        engage_interviewIDAO st1 = iocComm.engage_interviewDAO();
        public int Add1(engage_interviewModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<engage_interviewModel> select1()
        {
            return st1.select();
        }

        public List<engage_interviewModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(engage_interviewModel st)
        {
            return st1.update(st);
        }
    }
}
                
