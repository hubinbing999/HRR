using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class human_fileModel
    {
        [Required(ErrorMessage = "id不能为空")]
        public System.Int32 id { get; set; }

        [Required(ErrorMessage = "编号不能为空")]
        public System.String human_id { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String first_kind_id { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String first_kind_name { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String second_kind_id { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String second_kind_name { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String third_kind_id { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String third_kind_name { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_name { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_address { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_postcode { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String human_pro_designation { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String human_major_kind_id { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String human_major_kind_name { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_major_id { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String hunma_major_name { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [RegularExpression(@"^1(3|4|5|7|8)\d{9}$", ErrorMessage = "请输入正确的电话")]
        public System.String human_telephone { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String human_mobilephone { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String human_bank { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String human_account { get; set; }

        [Required(ErrorMessage = "名称不能为空")]
        public System.String human_qq { get; set; }

        [Required(ErrorMessage = "不能为空")]
        [RegularExpression(@"^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$", ErrorMessage = "请输入正确的邮箱")]
        
        public System.String human_email { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String human_hobby { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String human_speciality { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_sex { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_religion { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_party { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String human_nationality { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_race { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.DateTime human_birthday { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_birthplace { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.Int32 human_age { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_educated_degree { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.Int32 human_educated_years { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_educated_major { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_society_security_id { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_id_card { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String remark { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String salary_standard_id { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String salary_standard_name { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.Decimal salary_sum { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.Decimal demand_salaray_sum { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.Decimal paid_salary_sum { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.Int32 major_change_amount { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.Int32 bonus_amount { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.Int32 training_amount { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.Int32 file_chang_amount { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_histroy_records { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_family_membership { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String human_picture { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String attachment_name { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.Int32 check_status { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String register { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.String checker { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.String changer { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.DateTime regist_time { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.DateTime check_time { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public System.DateTime change_time { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.DateTime lastly_change_time { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.DateTime delete_time { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.DateTime recovery_time { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public System.Boolean human_file_status { get; set; }

       

    } }
