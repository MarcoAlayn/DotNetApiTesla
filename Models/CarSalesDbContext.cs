using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dotnetapitesla.Models;

public partial class CarSalesDbContext : DbContext
{
    public CarSalesDbContext()
    {
    }

    public CarSalesDbContext(DbContextOptions<CarSalesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<ModelSpecification> ModelSpecifications { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("name=ConnectionStrings:CarSalesDB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PK__Cars__A2B5777C05806D13");

            entity.HasIndex(e => e.Model, "UQ__Cars__FB104C13A87E1243").IsUnique();

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.Absbrakes).HasColumnName("ABSBrakes");
            entity.Property(e => e.Acceleration0100KmHSeconds)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Acceleration_0_100_km_h_seconds");
            entity.Property(e => e.BasePriceUsd)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BasePrice_USD");
            entity.Property(e => e.BatteryCapacityKWh)
                .HasColumnType("decimal(5, 1)")
                .HasColumnName("BatteryCapacity_kWh");
            entity.Property(e => e.CentralTouchscreenInches).HasColumnName("CentralTouchscreen_inches");
            entity.Property(e => e.ChargingTime0100Ac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ChargingTime_0_100_AC");
            entity.Property(e => e.ChargingTime1080Dc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ChargingTime_10_80_DC");
            entity.Property(e => e.CurbWeightKg).HasColumnName("CurbWeight_kg");
            entity.Property(e => e.LoadCapacityKg).HasColumnName("LoadCapacity_kg");
            entity.Property(e => e.MaximumSpeedKmH).HasColumnName("MaximumSpeed_km_h");
            entity.Property(e => e.Model)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PowerKW).HasColumnName("Power_kW");
            entity.Property(e => e.TotalHeightMm).HasColumnName("TotalHeight_mm");
            entity.Property(e => e.TotalLengthMm).HasColumnName("TotalLength_mm");
            entity.Property(e => e.TotalWidthMm).HasColumnName("TotalWidth_mm");
            entity.Property(e => e.TrunkCapacityLiters).HasColumnName("TrunkCapacity_liters");
            entity.Property(e => e.WheelbaseMm).HasColumnName("Wheelbase_mm");
            entity.Property(e => e.WltpRangeKm).HasColumnName("WLTP_Range_km");
        });

        modelBuilder.Entity<ModelSpecification>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PK__ModelSpe__A2B5777C0D1A97E8");

            entity.HasIndex(e => e.Model, "UQ__ModelSpe__FB104C138DCB30A2").IsUnique();

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.Acceleration0100Kmh)
                .HasMaxLength(100)
                .HasColumnName("Acceleration_0_100_kmh");
            entity.Property(e => e.AutonomyKm)
                .HasMaxLength(100)
                .HasColumnName("Autonomy_km");
            entity.Property(e => e.DragCoefficient).HasMaxLength(50);
            entity.Property(e => e.LoadCapacityL)
                .HasMaxLength(50)
                .HasColumnName("LoadCapacity_l");
            entity.Property(e => e.MaxSuperchargerKW).HasColumnName("MaxSupercharger_kW");
            entity.Property(e => e.MaximumPowerHp)
                .HasMaxLength(50)
                .HasColumnName("MaximumPower_hp");
            entity.Property(e => e.MaximumSpeedKmh)
                .HasMaxLength(150)
                .HasColumnName("MaximumSpeed_kmh");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PropulsionSystem).HasMaxLength(50);
            entity.Property(e => e.QuarterMile).HasMaxLength(100);
            entity.Property(e => e.Rims).HasMaxLength(50);
            entity.Property(e => e.Warranty).HasMaxLength(255);
            entity.Property(e => e.WeightKg)
                .HasMaxLength(50)
                .HasColumnName("Weight_kg");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
