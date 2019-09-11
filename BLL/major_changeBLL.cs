
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
using System.Data;

namespace BLL
{
    public class major_changeBLL : major_changeIBLL
    {
        major_changeIDAO st1 = iocComm.major_changeDAO();
        public int Add1(major_changeModel st)
        {
            return st1.Add(st);
        }

        public List<major_changeModel> atjcx(string yi, string er, string san, string si, string wu, string time1, string time2)
        {
            return st1.atjcx(yi, er, san, si, wu, time1, time2);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public DataTable FenYe(int currentPage, out int rows, out int pages, int pageSize)
        {
            return st1.FenYe(currentPage, out rows, out pages, pageSize);
        }

        public List<major_changeModel> select1()
        {
            return st1.select();
        }

        public List<major_changeModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(major_changeModel st)
        {
            return st1.update(st);
        }
    }
}
                
