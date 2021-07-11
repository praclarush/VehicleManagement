using System;
using System.Collections.Generic;

#nullable disable

namespace VehicleManagement.Data.Models
{
    public partial class MaintenanceType
    {
        public MaintenanceType()
        {
            Maintenances = new HashSet<Maintenance>();
        }

        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string TypeName { get; set; }
        public string FriendlyName { get; set; }
        public bool IsDeletable { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Vehicle Vehicle { get; set; }
        public virtual ICollection<Maintenance> Maintenances { get; set; }
    }
}
