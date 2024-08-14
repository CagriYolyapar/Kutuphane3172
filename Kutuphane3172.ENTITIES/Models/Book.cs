using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane3172.ENTITIES.Models
{
    public class Book : BaseEntity
    {
        public string BookName { get; set; }
        public int? AuthorID { get; set; }
        public int? CategoryID { get; set; }
        public int? ShelfID { get; set; }

        //Relational Properties
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<BookTag> BookTags { get; set; }
        public virtual Shelf Shelf { get; set; }
    }
}
