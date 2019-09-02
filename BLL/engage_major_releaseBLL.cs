
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
    public class engage_major_releaseBLL : engage_major_releaseIBLL
    {
        engage_major_releaseIDAO st1 = iocComm.engage_major_releaseDAO();
        public int Add1(engage_major_releaseModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public FenYeModel Fenye(int currentPage, int rl)
        {
            return st1.Fenye(currentPage, rl);
        }

        public List<engage_major_releaseModel> select1()
        {
            return st1.select();
        }

        public List<engage_major_releaseModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(engage_major_releaseModel st)
        {
            return st1.update(st);
        }
    }
}
                
