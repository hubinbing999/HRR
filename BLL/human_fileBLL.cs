
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
using System.Data;

namespace BLL
{
    public class human_fileBLL : human_fileIBLL
    {
        human_fileIDAO st1 = iocComm.human_fileDAO();
        public string Add1(human_fileModel st)
        {
            return st1.Add(st);
        }
        public canshulei fenye(int dqy, int rl) {
            return st1.fenye(dqy,rl);
        }
        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<human_fileModel> select1()
        {
            return st1.select();
        }

        public List<human_fileModel> selectupdate(string id)
        {
            return st1.selectupdate(id);
        }

        public int update1(human_fileModel st)
        {
            return st1.update(st);
        }
        public int update12(human_fileModel item) {
            return st1.update12(item);
        }
        public canshulei fenye2(Cansh ji) {
            return st1.fenye2(ji);
        }
       public canshulei fenye3(int dqy, int rl, string name)
        {

            return st1.fenye3(dqy,rl, name);
        }
        public int update13(human_fileModel item) {
            return st1.update13(item);
        }
       public int updateztai(human_fileModel item) {
            return st1.updateztai(item);
        }
        public canshulei fenye4(int dqy, int rl) {
            return st1.fenye4(dqy,rl);
        }
        public DataTable FenYe(int currentPage, out int rows, out int pages, string where, int pageSize)
        {
            return st1.FenYe(currentPage, out rows, out pages, where, pageSize);
        }
    }
}
                
