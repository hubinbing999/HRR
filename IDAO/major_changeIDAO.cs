
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace IDAO
{
  public  interface major_changeIDAO
    {
        int Add(major_changeModel st);
        List<major_changeModel> select();
        int update(major_changeModel st);
        List<major_changeModel> selectupdate(int id);
        int delete(int id);
        DataTable FenYe(int currentPage, out int rows, out int pages, int pageSize);
        List<major_changeModel> atjcx(string yi, string er, string san, string si, string wu, string time1, string time2);

    }
} 
