using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MVC_8
{
   public class config_file_third_kind
    {
        public int Id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public string third_kind_id { get; set; }
        
        public string third_kind_name { get; set; }
        
        public string third_kind_sale_id { get; set; }
        public string third_kind_is_retail { get; set; }
    }
}
