using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
  public  class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int classsid { get; set; }
        public virtual Classs Classs { get; set; }

    }
}
