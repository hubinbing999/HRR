using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class FenYeModel3
    {
        public int rows { get; set; }//总纪录数
        public List<engage_interviewModel> list;
        public int pageSize { get; set; }//总页数
    }
}
