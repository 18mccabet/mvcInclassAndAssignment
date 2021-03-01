using System;
using System.Collections.Generic;

#nullable disable

namespace BlockBuster.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }

        public int GenreId { get; set; }
        public string GenreDescr { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
