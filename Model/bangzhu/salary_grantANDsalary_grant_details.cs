using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.bangzhu
{
   public class salary_grantANDsalary_grant_details
    {
        public int id { get; set; }
        public salary_grantModel salary_grant { get; set; }
        public List<salary_grant_detailsModel> salary_grant_details { get; set; }
    }
}
