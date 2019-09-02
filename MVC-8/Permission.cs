using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
 public    class Permission
    {
        [Key]
        public System.Int32 Pid { get; set; }


        public System.Int32 roleID { get; set; }


        public System.Int32 Aid { get; set; }
    }
}
