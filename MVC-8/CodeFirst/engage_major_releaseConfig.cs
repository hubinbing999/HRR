
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace MVC_8.CodeFirst
{
   public class engage_major_releaseConfig:EntityTypeConfiguration<engage_major_release>
    {
        public engage_major_releaseConfig()
        {
            this.ToTable(nameof(engage_major_release));
        }
    }
}
