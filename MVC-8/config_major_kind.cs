using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
  public  class config_major_kind
    {
        [Key]
        public System.Int32 id { get; set; }


        public System.String major_kind_id { get; set; }


        public System.String major_kind_name { get; set; }
        
    }
}
