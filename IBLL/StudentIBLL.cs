using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
  public  interface StudentIBLL
    {
        int Add1(StudentModel st);
        List<StudentModel> select1();
        int update1(StudentModel st);
        List<StudentModel> selectupdate(int id);
        int delete(int id);
    }
}
