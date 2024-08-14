using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane3172.ENTITIES.Models
{
    public class Shelf : BaseEntity
    {
        public string ShelfCode { get; set; }
        public int? RoomID { get; set; }

        //Relational Properties
        public virtual List<Book> Books { get; set; }
        public virtual Room Room { get; set; }
    }
}
