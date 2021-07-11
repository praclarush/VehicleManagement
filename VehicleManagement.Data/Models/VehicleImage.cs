using System;
using System.Collections.Generic;

#nullable disable

namespace VehicleManagement.Data.Models
{
    public partial class VehicleImage
    {
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public byte[] ImageData { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
