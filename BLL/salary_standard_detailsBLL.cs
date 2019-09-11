
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
    public class salary_standard_detailsBLL : salary_standard_detailsIBLL
    {
        salary_standard_detailsIDAO st1 = iocComm.salary_standard_detailsDAO();
        public int Add1(salary_standard_detailsModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<salary_standard_detailsModel> select1()
        {
            return st1.select();
        }

        public List<salary_standard_detailsModel> selectupdate(string id)
        {
            return st1.selectupdate(id);
        }

        public int update1(salary_standard_detailsModel st)
        {
            return st1.update(st);
        }
    }
}
                
