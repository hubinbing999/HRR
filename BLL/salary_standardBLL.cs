
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
    public class salary_standardBLL : salary_standardIBLL
    {
        salary_standardIDAO st1 = iocComm.salary_standardDAO();
        public int Add1(salary_standardModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<salary_standardModel> select1()
        {
            return st1.select();
        }

        public List<salary_standardModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(salary_standardModel st)
        {
            return st1.update(st);
        }

        public string BianHao() {
            return st1.BianHao();
        }
        public salary_standardFenYe fenye(int dqy, int rl) {
            return st1.fenye(dqy,rl);
        }
        public XCcan Fenye2(salarystandard_query_locateCan ji) {
         return   st1.Fenye2(ji);
        }
        public int BianGenupdate(salary_standardModel item) {
            return st1.BianGenupdate(item);
        }
    }
}
                
