
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace MVC_8.CodeFirst
{
   public class human_fileConfig:EntityTypeConfiguration<human_file>
    {
        public human_fileConfig()
        {
            this.ToTable(nameof(human_file));
        }
    }
}
