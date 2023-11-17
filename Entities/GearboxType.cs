using System;
using System.Collections.Generic;

namespace EntityFrameworkProject.Entities
{
    public partial class GearboxType
    {
        public GearboxType()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Deleted { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
