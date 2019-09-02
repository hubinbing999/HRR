
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace IDAO
{
  public  interface usersIDAO
    {
        int Add(usersModel st);
        List<usersModel> select();
        int update(usersModel st);
        List<usersModel> selectupdate(int id);
        int delete(int id);
        int dl(usersModel us);
        List<usersModel> SelectList();
        int SelectCount();
       DataTable BandList();

        DataTable ShowBYQX(object Aid, object id);

        DataTable SelectJS(int Uid);

    }
} 
