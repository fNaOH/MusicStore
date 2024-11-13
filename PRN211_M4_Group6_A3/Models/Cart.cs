using System;
using System.Collections.Generic;

namespace PRN211_M4_Group6_A3.Models
{
    public partial class Cart
    {
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int AlbumId { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Album Album { get; set; }
    }
}
