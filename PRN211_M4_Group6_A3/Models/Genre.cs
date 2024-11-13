﻿using System;
using System.Collections.Generic;

namespace PRN211_M4_Group6_A3.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Albums = new HashSet<Album>();
        }

        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
