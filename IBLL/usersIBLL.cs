
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace IBLL
{
  public  interface usersIBLL
    {
        int Add1(usersModel st);
        List<usersModel> select1();
        int update1(usersModel st);
        List<usersModel> selectupdate(int id);
        int delete(int id);
        int dl(usersModel us);
        List<usersModel> SelectList();
        int SelectCount();
        DataTable BandList();
        /// <summary>
        /// 查询某角色下所有的权限
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable ShowBYQX(object Aid, object id);
        DataTable SelectJS(int Uid);

    }
}
