using System;
using System.Collections.Generic;

namespace EntityFrameworkProject.Entities
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
            ProductionMarkets = new HashSet<ProductionMarket>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Deleted { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<ProductionMarket> ProductionMarkets { get; set; }
    }
}
