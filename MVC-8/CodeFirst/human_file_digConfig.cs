
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace MVC_8.CodeFirst
{
   public class human_file_digConfig:EntityTypeConfiguration<human_file_dig>
    {
        public human_file_digConfig()
        {
            this.ToTable(nameof(human_file_dig));
        }
    }
}
