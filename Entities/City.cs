using System;
using System.Collections.Generic;

namespace EntityFrameworkProject.Entities
{
    public partial class City
    {
        public int Id { get; set; }
        public int? CountryId { get; set; }
        public string Name { get; set; } = null!;
        public int? Deleted { get; set; }

        public virtual Country? Country { get; set; }
    }
}
