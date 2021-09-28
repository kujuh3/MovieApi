using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Models
{
    public class ProducingCompany : BaseModel
    {
        public long ProducingCompanyId { get; set; }

        public string CompanyName { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
