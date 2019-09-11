using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
    public class salary_standard
    {
        [Key]
        public System.Int32 ssd_id { get; set; }


        public System.String standard_id { get; set; }


        public System.String standard_name { get; set; }


        public System.String designer { get; set; }


        public System.String register { get; set; }


        public System.String checker { get; set; }


        public System.String changer { get; set; }


        public System.DateTime? regist_time { get; set; }


        public System.DateTime? check_time { get; set; }


        public System.DateTime? change_time { get; set; }


        public System.Decimal salary_sum { get; set; }


        public System.Int32 check_status { get; set; }


        public System.Int32 change_status { get; set; }


        public System.String check_comment { get; set; }


        public System.String remark { get; set; }

    }
}
