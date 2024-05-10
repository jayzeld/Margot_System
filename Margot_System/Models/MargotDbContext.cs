using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Margot_System.Models;

public partial class MargotDbContext : DbContext
{
    public MargotDbContext()
    {
    }

    public MargotDbContext(DbContextOptions<MargotDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddPeopleTb> AddPeopleTbs { get; set; }

    public virtual DbSet<DashboardTb> DashboardTbs { get; set; }

    public virtual DbSet<HouseOccupantTb> HouseOccupantTbs { get; set; }

    public virtual DbSet<LoginTb> LoginTbs { get; set; }

    public virtual DbSet<RegisterTb> RegisterTbs { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=ANGELO\\SQLEXPRESS01; Database=MargotDb; User Id=Sample; Password=123; TrustServerCertificate=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddPeopleTb>(entity =>
        {
            entity.ToTable("AddPeopleTb");

            entity.Property(e => e.CivilStatus).HasColumnName("Civil_status");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Company_name");
            entity.Property(e => e.ContactNumber).HasColumnName("Contact_number");
            entity.Property(e => e.DashboardId).HasColumnName("Dashboard_id");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Date_of_birth");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeDuration)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Employee_duration");
            entity.Property(e => e.Employer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("First_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HouseType).HasColumnName("House_type");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Last_name");
            entity.Property(e => e.LengthOfStay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Length_of_stay");
            entity.Property(e => e.Meds)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Middle_name");
            entity.Property(e => e.OccupantId).HasColumnName("Occupant_id");
            entity.Property(e => e.PetOwner).HasColumnName("Pet_owner");
            entity.Property(e => e.Pets)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlaceOfBirth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Place_of_birth");
            entity.Property(e => e.PrecintNumber).HasColumnName("Precint_number");
            entity.Property(e => e.PresentAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Present_address");
            entity.Property(e => e.ProvincialAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Provincial_address");
            entity.Property(e => e.Registered)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SeniorCitizen).HasColumnName("Senior_citizen");
            entity.Property(e => e.StreetSweeper).HasColumnName("Street_sweeper");
            entity.Property(e => e.TakingMeds).HasColumnName("Taking_meds");

            entity.HasOne(d => d.Dashboard).WithMany(p => p.AddPeopleTbs)
                .HasForeignKey(d => d.DashboardId)
                .HasConstraintName("FK_AddPeopleTb_DashboardTb");

            entity.HasOne(d => d.Occupant).WithMany(p => p.AddPeopleTbs)
                .HasForeignKey(d => d.OccupantId)
                .HasConstraintName("FK_AddPeopleTb_HouseOccupantTb");
        });

        modelBuilder.Entity<DashboardTb>(entity =>
        {
            entity.ToTable("DashboardTb");

            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HouseOccupantTb>(entity =>
        {
            entity.ToTable("HouseOccupantTb");

            entity.Property(e => e.BirthDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CivilStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SourceIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LoginTb>(entity =>
        {
            entity.ToTable("LoginTb");

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RegisterTb>(entity =>
        {
            entity.ToTable("RegisterTb");

            entity.Property(e => e.Cpass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CPass");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FName");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LName");
            entity.Property(e => e.Mname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MName");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uid).HasColumnName("UId");
            entity.Property(e => e.Uname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UName");

            entity.HasOne(d => d.UidNavigation).WithMany(p => p.RegisterTbs)
                .HasForeignKey(d => d.Uid)
                .HasConstraintName("FK_RegisterTb_LoginTb");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
