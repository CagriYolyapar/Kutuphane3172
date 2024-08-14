using Kutuphane3172.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane3172.CONF.Configurations
{
    public class AuthorConfiguration:BaseConfiguration <Author>
    {
        public AuthorConfiguration()
        {
            HasOptional(x => x.Profile).WithRequired(x => x.Author);

        }
    }
}
