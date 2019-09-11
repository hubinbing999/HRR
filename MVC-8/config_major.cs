using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
  public  class config_major
    {
       [Key]
        public System.Int32 mak_id { get; set; }


        public System.String major_kind_id { get; set; }


        public System.String major_kind_name { get; set; }


        public System.String major_id { get; set; }


        public System.String major_name { get; set; }


        public System.Int32 test_amount { get; set; }
       
    }
}
