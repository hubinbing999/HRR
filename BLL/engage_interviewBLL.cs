
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

        public FenYeModel3 Fenye4(int currentPage, int rl)
        {
            return st1.Fenye4(currentPage, rl);
        }

        public List<engage_interviewModel> select1()
        {
            return st1.select();
        }

        public List<engage_interviewModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public List<engage_interviewModel> selectupdate2(int id)
        {
            return st1.selectupdate2(id);
        }

        public int update1(engage_interviewModel st)
        {
            return st1.update(st);
        }

        public int update2(engage_interviewModel st)
        {
            return st1.update2(st);
        }

        public int update3(engage_interviewModel st)
        {
            return st1.update3(st);
        }

        public int update4(engage_interviewModel st)
        {
            return st1.update4(st);
        }
    }
}
                
