using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VehicleManagement.Data.Models;

#nullable disable

namespace VehicleManagement.Data
{
    public partial class VehicleManagementDbContext : DbContext
    {
        public VehicleManagementDbContext()
        {
        }

        public VehicleManagementDbContext(DbContextOptions<VehicleManagementDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Fuel> Fuels { get; set; }
        public virtual DbSet<Maintenance> Maintenances { get; set; }
        public virtual DbSet<MaintenanceType> MaintenanceTypes { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehicleImage> VehicleImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasIndex(e => new { e.VehicleId, e.ExpenseDate }, "IX_Expenses_VehicleId_ExpenseDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.Expense1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Expense");

                entity.Property(e => e.ExpenseDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).IsRequired();

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Expenses_Vehicle");
            });

            modelBuilder.Entity<Fuel>(entity =>
            {
                entity.ToTable("Fuel");

                entity.HasIndex(e => new { e.VehicleId, e.FuelDate }, "IX_Fuel_VehicleID_FuelDate");

                entity.Property(e => e.CostPerGallon).HasColumnType("money");

                entity.Property(e => e.FuelDate).HasColumnType("datetime");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Fuels)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fuel_Vehicle");
            });

            modelBuilder.Entity<Maintenance>(entity =>
            {
                entity.ToTable("Maintenance");

                entity.HasIndex(e => new { e.VehicleId, e.CreatedDate }, "IX_Maintenance_VehicleId_CreatedDate");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaintenanceType)
                    .WithMany(p => p.Maintenances)
                    .HasForeignKey(d => d.MaintenanceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Maintenance_MaintenanceType");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Maintenances)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Maintenance_Vehicle");
            });

            modelBuilder.Entity<MaintenanceType>(entity =>
            {
                entity.ToTable("MaintenanceType");

                entity.HasIndex(e => e.VehicleId, "IX_MaintenanceType_VehicleId");

                entity.Property(e => e.FriendlyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeletable).HasColumnName("IsDeletable ");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.MaintenanceTypes)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceType_Vehicle");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("Vehicle");

                entity.HasIndex(e => e.UserId, "IX_Vehicle_UserId");

                entity.Property(e => e.FriendlyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicensePlate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Make)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId).IsRequired();

                entity.Property(e => e.Vin)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("VIN");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicle_AspNetUsers");
            });

            modelBuilder.Entity<VehicleImage>(entity =>
            {
                entity.ToTable("VehicleImage");

                entity.Property(e => e.ImageData).IsRequired();

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleImages)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_VehicleImage_Vehicle");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
