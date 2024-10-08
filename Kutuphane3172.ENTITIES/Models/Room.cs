﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane3172.ENTITIES.Models
{
    public class Room : BaseEntity
    {
        public string RoomName { get; set; }

        //Relational Properties
        public virtual List<Shelf> Shelves { get; set; }
    }
}
