using System;
using System.Collections.Generic;

#nullable disable

namespace VehicleManagement.Data.Models
{
    public partial class Maintenance
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int MaintenanceTypeId { get; set; }
        public string Name { get; set; }
        public int FrequencyTypeId { get; set; }
        public int Frequency { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsRecurring { get; set; }

        public virtual MaintenanceType MaintenanceType { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
