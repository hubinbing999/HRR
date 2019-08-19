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
    public class StudentBLL : StudentIBLL
    {
        StudentIDAO st1 = iocComm.StudetDAO();
        public int Add1(StudentModel st)
        {
            return st1.Add(st);
        }

        public int delete(int id)
        {
            return st1.delete(id);
        }

        public List<StudentModel> select1()
        {
            return st1.select();
        }

        public List<StudentModel> selectupdate(int id)
        {
            return st1.selectupdate(id);
        }

        public int update1(StudentModel st)
        {
            return st1.update(st);
        }
    }
}
