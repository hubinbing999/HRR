using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface StudentIDAO
    {
        int Add(StudentModel st);
        List<StudentModel> select();
        int update(StudentModel st);
        List<StudentModel> selectupdate(int id);
        int delete(int id);


    }
}
