using System;
using System.Collections.Generic;

#nullable disable

namespace VehicleManagement.Data.Models
{
    public partial class Fuel
    {
        public long Id { get; set; }
        public int VehicleId { get; set; }
        public int FuelTypeId { get; set; }
        public DateTime FuelDate { get; set; }
        public int Gallons { get; set; }
        public decimal CostPerGallon { get; set; }
        public string Notes { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
