using System;
using System.Collections.Generic;

#nullable disable

namespace VehicleManagement.Data.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Expenses = new HashSet<Expense>();
            Fuels = new HashSet<Fuel>();
            MaintenanceTypes = new HashSet<MaintenanceType>();
            Maintenances = new HashSet<Maintenance>();
            VehicleImages = new HashSet<VehicleImage>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string FriendlyName { get; set; }
        public int VehicleTypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public long Odometer { get; set; }
        public string Vin { get; set; }
        public string LicensePlate { get; set; }
        public string Notes { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Fuel> Fuels { get; set; }
        public virtual ICollection<MaintenanceType> MaintenanceTypes { get; set; }
        public virtual ICollection<Maintenance> Maintenances { get; set; }
        public virtual ICollection<VehicleImage> VehicleImages { get; set; }
    }
}
