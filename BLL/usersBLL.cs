
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

        public List<usersModel> SelectList()
        {
            return st1.SelectList();
        }

        public int SelectCount()
        {
            return st1.SelectCount();
        }

        public DataTable BandList()
        {
            return st1.BandList();
        }

        public DataTable ShowBYQX(object Aid, object id)
        {
            return st1.ShowBYQX(Aid, id);
        }

        public DataTable SelectJS(int Uid)
        {
            return st1.SelectJS(Uid);
        }
    }
}
                
