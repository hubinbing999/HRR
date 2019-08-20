using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
   public class config_file_first_kind
    {
        public int Id { get; set; }
        public string first_kind_id { get; set; }
        [Required(ErrorMessage = "一级机构名称不能为空")]
        [StringLength(maximumLength: 60, ErrorMessage = "长度不能超过六十位")]
        public string first_kind_name { get; set; }
        [Required(ErrorMessage = "一级机构薪酬发放责任人编号不能为空")]
        public string first_kind_salary_id { get; set; }
        [Required(ErrorMessage = "一级机构销售责任人编号不能为空")]
        public string first_kind_sale_id { get; set; }
       
    }
}
