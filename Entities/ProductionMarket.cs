using System;
using System.Collections.Generic;

namespace EntityFrameworkProject.Entities
{
    public partial class ProductionMarket
    {
        public int Id { get; set; }
        public int? CountryId { get; set; }
        public int? Deleted { get; set; }

        public virtual Country? Country { get; set; }
    }
}
