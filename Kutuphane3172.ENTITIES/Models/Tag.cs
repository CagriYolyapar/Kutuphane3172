using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane3172.ENTITIES.Models
{
    public class Tag : BaseEntity
    {
        public string TagName { get; set; }

        //Relational Properties
        public virtual List<BookTag> BookTags { get; set; }


    }
}
