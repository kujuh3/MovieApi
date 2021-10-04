using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MovieApi.Models
{
    public class ProducingCompany : BaseModel
    {
        [Required]
        public string CompanyName { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
