using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class RoleManagerModel
    {   
        public System.Int32 RoleID { get; set; }


        [Required(ErrorMessage = "角色名称不能为空")]
        public System.String RoleName { get; set; }
        [Required(ErrorMessage = "角色说明不能为空")]
        public System.String RoleState { get; set; }

        [Required(ErrorMessage = "请选择是否")]
        public System.String RoleOk { get; set; }

                     } }
