using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Models
{
    public class Genre : BaseModel
    {
        public long GenreId { get; set; }

        public string GenreName { get; set; }

        public ICollection<Movie> Movies { get; set; }

    }
}
