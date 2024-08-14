using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane3172.ENTITIES.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        //Relational Properties
        public virtual List<Book> Books { get; set; }
    }
}
