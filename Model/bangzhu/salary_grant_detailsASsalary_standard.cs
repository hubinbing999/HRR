using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.bangzhu
{
  public  class salary_grant_detailsASsalary_standard
    {
        //一个类--》薪酬发放详细信息--》salary_grant_details+salary_grant_details-》salary_standard_detailsModel

        //薪酬发放详细信息
        public salary_grant_detailsModel salary_grant_details { get; set; }
        //薪酬salary_grant_details对应1个人详细信息
        public List<salary_standard_detailsModel> salary_standard_detailsModel { get; set; }
       
    }
}
