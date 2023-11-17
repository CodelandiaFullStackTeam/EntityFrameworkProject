using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EntityFrameworkProject.Entities;
using Color = EntityFrameworkProject.Entities.Color;

namespace EntityFrameworkProject.Contexts
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BanType> BanTypes { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Color> Colors { get; set; } = null!;
        public virtual DbSet<Condition> Conditions { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<FuelType> FuelTypes { get; set; } = null!;
        public virtual DbSet<GearboxType> GearboxTypes { get; set; } = null!;
        public virtual DbSet<Model> Models { get; set; } = null!;
        public virtual DbSet<ProductionMarket> ProductionMarkets { get; set; } = null!;
        public virtual DbSet<Transmitter> Transmitters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CarSellDb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BanType>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.Deleted }, "idx_BanTypes_Name_Deleted")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.Deleted }, "idx_Brands_Name_Deleted")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasIndex(e => new { e.ModelId, e.FuelTypeId, e.ColorId, e.ConditionId, e.BanTypeId, e.GearboxTypeId, e.TransmitterId, e.Deleted }, "idx_Cars_Unique_Condition")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BanType)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.BanTypeId)
                    .HasConstraintName("FK__Cars__BanTypeId__4AB81AF0");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK__Cars__ColorId__48CFD27E");

                entity.HasOne(d => d.Condition)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ConditionId)
                    .HasConstraintName("FK__Cars__ConditionI__49C3F6B7");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.FuelTypeId)
                    .HasConstraintName("FK__Cars__FuelTypeId__47DBAE45");

                entity.HasOne(d => d.GearboxType)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.GearboxTypeId)
                    .HasConstraintName("FK__Cars__GearboxTyp__4BAC3F29");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK__Cars__ModelId__46E78A0C");

                entity.HasOne(d => d.Transmitter)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.TransmitterId)
                    .HasConstraintName("FK__Cars__Transmitte__4CA06362");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.CountryId, e.Deleted }, "idx_Cities_Name_CountryId_Deleted")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__Cities__CountryI__3F466844");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.Deleted }, "idx_Colors_Name_Deleted")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.Deleted }, "idx_Conditions_Name_Deleted")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.Deleted }, "idx_Countries_Name_Deleted")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FuelType>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.Deleted }, "idx_FuelTypes_Name_Deleted")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<GearboxType>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.Deleted }, "idx_GearBoxTypes_Name_Deleted")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.BrandId, e.Deleted }, "idx_Models_Name_BrandId_Deleted")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Models__BrandId__2D27B809");
            });

            modelBuilder.Entity<ProductionMarket>(entity =>
            {
                entity.ToTable("ProductionMarket");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ProductionMarkets)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__Productio__Count__4316F928");
            });

            modelBuilder.Entity<Transmitter>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.Deleted }, "idx_Transmitters_Name_Deleted")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
