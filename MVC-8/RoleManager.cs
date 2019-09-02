using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
    public class RoleManager
    {
        [Key]
        public System.Int32 RoleID { get; set; }


        public System.String RoleName { get; set; }


        public System.String RoleState { get; set; }


        public System.String RoleOk { get; set; }

    }
}
