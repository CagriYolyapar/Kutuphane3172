using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane3172.ENTITIES.Models
{
    public class Author : BaseEntity
    {
        public string UserName { get; set; }
        public string  Password { get; set; }

        //Deneme

        //Relational Properties
        public virtual AuthorProfile Profile { get; set; }
        public virtual List<Book> Books { get; set; }

    }
}
