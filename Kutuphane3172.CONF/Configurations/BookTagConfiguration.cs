using Kutuphane3172.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane3172.CONF.Configurations
{
    public class BookTagConfiguration:BaseConfiguration<BookTag>
    {
        public BookTagConfiguration()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.TagID,
                x.BookID
            });
        }
    }
}
