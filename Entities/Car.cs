using System;
using System.Collections.Generic;

namespace EntityFrameworkProject.Entities
{
    public partial class Car
    {
        public int Id { get; set; }
        public int? ModelId { get; set; }
        public int? FuelTypeId { get; set; }
        public int? ColorId { get; set; }
        public int? ConditionId { get; set; }
        public int? BanTypeId { get; set; }
        public int? GearboxTypeId { get; set; }
        public int? TransmitterId { get; set; }
        public int? Deleted { get; set; }

        public virtual BanType? BanType { get; set; }
        public virtual Color? Color { get; set; }
        public virtual Condition? Condition { get; set; }
        public virtual FuelType? FuelType { get; set; }
        public virtual GearboxType? GearboxType { get; set; }
        public virtual Model? Model { get; set; }
        public virtual Transmitter? Transmitter { get; set; }
    }
}
