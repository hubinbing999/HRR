
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
    public class salary_grant_detailsBLL : salary_grant_detailsIBLL
    {
        salary_grant_detailsIDAO st1 = iocComm.salary_grant_detailsDAO();
        public int Add1(salary_grant_detailsModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<salary_grant_detailsModel> select1()
        {
            return st1.select();
        }

        public List<salary_grant_detailsModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(salary_grant_detailsModel st)
        {
            return st1.update(st);
        }
        public List<salary_grant_detailsModel> selectsalary_grant_id(string id) {
            return st1.selectsalary_grant_id(id);
        }
    }
}
                
