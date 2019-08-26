
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
    public class human_file_digBLL : human_file_digIBLL
    {
        human_file_digIDAO st1 = iocComm.human_file_digDAO();
        public int Add1(human_file_digModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<human_file_digModel> select1()
        {
            return st1.select();
        }

        public List<human_file_digModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(human_file_digModel st)
        {
            return st1.update(st);
        }
    }
}
                
