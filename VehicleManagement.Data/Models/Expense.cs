using System;
using System.Collections.Generic;

#nullable disable

namespace VehicleManagement.Data.Models
{
    public partial class Expense
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string Expense1 { get; set; }
        public DateTime ExpenseDate { get; set; }
        public decimal Cost { get; set; }
        public string Notes { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
