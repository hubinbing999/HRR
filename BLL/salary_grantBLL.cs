
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
using Model.bangzhu;

namespace BLL
{
    public class salary_grantBLL : salary_grantIBLL
    {
        salary_grantIDAO st1 = iocComm.salary_grantDAO();
        public int Add1(salary_grantModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<salary_grantModel> select1()
        {
            return st1.select();
        }

        public List<salary_grantModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(salary_grantModel st)
        {
            return st1.update(st);
        }
        public List<salary_grantModel> selectupdateda(string id) {
            return st1.selectupdateda(id);
        }
        public salary_grantCan fenye(int dqy, int rl) {
            return st1.fenye(dqy, rl);
        }
        public int updateChenk(salary_grantModel item) {
            return st1.updateChenk(item);
        }
        public salary_grantCan fenye2(query_locateCan va, int dqy, int rl) {
            return st1.fenye2(va,dqy,rl);
        }
        public int updateFan(salary_grantModel item) {
            return st1.updateFan(item);
        }
    }
}
                
