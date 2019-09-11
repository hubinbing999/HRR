using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.bangzhu
{
  public  class CXinCan
    {
        public List<salary_grantModel> li { get; set; }
        //总人数
        public int zrs { get; set; }
        //薪酬总数
        public int xczs { get; set; }
        //基本薪酬总数
        public decimal salary_standard_sum { get; set; }
        //实发金额
        public decimal salary_paid_sum { get; set; }
    }
}
