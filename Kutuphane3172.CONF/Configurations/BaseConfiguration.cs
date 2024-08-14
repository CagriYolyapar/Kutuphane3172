using Kutuphane3172.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane3172.CONF.Configurations
{
    public abstract class BaseConfiguration<T> :EntityTypeConfiguration <T> where T : BaseEntity
    {
        public BaseConfiguration()
        {
            Property(x => x.CreatedDate).HasColumnName("YaratilmaZamani");
        }

        
    }
}
