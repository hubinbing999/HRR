using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8.CodeFirst
{
  public  class ClasssConfig: EntityTypeConfiguration<Classs>
    {
        public ClasssConfig() {
            this.ToTable(nameof(Classs));
        }
    }
}
