using System;
using System.Collections.Generic;

#nullable disable

namespace BlockBuster.Models
{
    public partial class Movie
    {
        public Movie()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int MovieId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int GenreId { get; set; }
        public int DirectorId { get; set; }

        public virtual Director Director { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
