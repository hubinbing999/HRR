
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

        public FenyeModel2 Fenye(int currentPage, int rl, string human_major_kind_id, string human_major_id, string gjz, string startDate, string endDate)
        {
            return st1.Fenye(currentPage, rl, human_major_kind_id, human_major_id, gjz, startDate, endDate);
        }

        public FenyeModel2 Fenye2(int currentPage, int rl, string human_major_kind_id, string human_major_id, string gjz, string startDate, string endDate)
        {
            return st1.Fenye2(currentPage, rl, human_major_kind_id, human_major_id, gjz, startDate, endDate);
        }

        public FenyeModel2 Fenye3(int currentPage, int rl)
        {
            return st1.Fenye3(currentPage, rl);
        }

        public FenyeModel2 Fenye4(int currentPage, int rl)
        {
            return st1.Fenye4(currentPage, rl);
        }

        public FenyeModel2 Fenye5(int currentPage, int rl)
        {
            return st1.Fenye5(currentPage, rl);
        }

        public FenyeModel2 Fenye6(int currentPage, int rl)
        {
            return st1.Fenye6(currentPage, rl);
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

        public int update2(engage_resumeModel st)
        {
            return st1.update2(st);
        }

        public int update3(engage_resumeModel st)
        {
            return st1.update3(st);
        }

        public int update4(engage_resumeModel st)
        {
            return st1.update4(st);
        }

        public int update5(engage_resumeModel st)
        {
            return st1.update5(st);
        }
    }
}
                
