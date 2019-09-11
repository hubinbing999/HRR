using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class FenyeModel2
    {
        public int rows { get; set; }//总纪录数
        public List<engage_resumeModel> list;
        public int pageSize { get; set; }//总页数
    }
}
