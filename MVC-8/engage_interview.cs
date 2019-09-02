using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
   public class engage_interview
    {
        public int Id { get; set; }
        public string human_name { get; set; }
        public int interview_amount { get; set; }
        public string human_major_kind_id { get; set; }
        public string human_major_kind_name { get; set; }
        public string human_major_id { get; set; }
        public string human_major_name { get; set; }
        public string image_degree { get; set; }
        public string native_language_degree { get; set; }
        public string foreign_language_degree { get; set; }
        public string response_speed_degree { get; set; }
        public string EQ_degree { get; set; }
        public string IQ_degree { get; set; }
        public string multi_quality_degree { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public DateTime registe_time { get; set; }
        public DateTime check_time { get; set; }
        public int resume_id { get; set; }
        public string result { get; set; }
        public string interview_comment { get; set; }
        public string check_comment { get; set; }
        public int interview_status { get; set; }
        public int check_status { get; set; }
    }
}
