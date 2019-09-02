using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
  public   class Access
    {
        [Key]
        public System.Int32 id { get; set; }


        public System.String text { get; set; }


        public System.Int32 PID { get; set; }


        public System.String Aaddress { get; set; }


        public System.String state { get; set; }

    }
}
