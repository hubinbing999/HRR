
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
    public class usersBLL : usersIBLL
    {
        usersIDAO st1 = iocComm.usersDAO();
        public int Add1(usersModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<usersModel> select1()
        {
            return st1.select();
        }

        public List<usersModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(usersModel st)
        {
            return st1.update(st);
        }
        public int dl(usersModel us) {
            return st1.dl(us);
        }
    }
}
                
