
           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
  public  interface engage_interviewIDAO
    {
        int Add(engage_interviewModel st);
        List<engage_interviewModel> select();
        int update(engage_interviewModel st);
        List<engage_interviewModel> selectupdate(int id);
        int delete(int id);


    }
} 
