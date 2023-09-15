using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;

namespace CourseWorkAt4.Database;

public partial class HospitalAt2Context : DbContext
{
    public HospitalAt2Context() 
    {
		//Database.EnsureDeleted();
		Database.EnsureCreated();
	}

	public HospitalAt2Context(DbContextOptions<HospitalAt2Context> options)
        : base(options)
    {
		//Database.EnsureCreated();
		Database.EnsureDeleted();
	}


	public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Attandance> Attandances { get; set; }

    public virtual DbSet<AttandanceService> AttandanceServices { get; set; }
   
    public virtual DbSet<CheckInDoctor> CheckInDoctors { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<DoctorService> DoctorServices { get; set; }

    public virtual DbSet<MedicalSecretary> MedicalSecretaries { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ServiceH> ServiceHs { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
		=> optionsBuilder.UseSqlServer("Server=DESKTOP-NL3TB6V;Database=HospitalAt3;Trusted_Connection=True;TrustServerCertificate=True");
    //login=ala;password=IWantNewYear;initial catalog=HospitalAt2;Trusted_Connection=False
	protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
		modelBuilder.Entity<Account>(entity =>
        {
                    entity.HasKey(e => e.PkIdAcc).HasName("PK__Account__9DD49AFCFE99F4D6");

            entity.ToTable("Account");

                    entity.Property(e => e.PkIdAcc)
                        .ValueGeneratedNever()
                        .HasColumnName("PK_IdAcc");
            entity.Property(e => e.LoginAcc).HasMaxLength(50);
            entity.Property(e => e.PasswordAcc).HasMaxLength(50);
            entity.Property(e => e.TypeAcc).HasMaxLength(20);
			entity.Property(e => e.FKIdDoctor).HasColumnName("FK_IdDoctor");
			entity.Property(e => e.FKIdPatient).HasColumnName("FK_IdPatient");
            entity.Property(e => e.FKIdMedS).HasColumnName("FK_IdMedS");
       });

        modelBuilder.Entity<Appointment>(entity =>
        {
			entity.HasKey(e => e.PkIdAppointment);

			entity.ToTable("Appointment");
			
            entity.Property(e => e.PkIdAppointment)
				.ValueGeneratedNever()
				.HasColumnName("PK_IdAppointment");
			entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FkIdDoctor).HasColumnName("FK_IdDoctor");
            entity.Property(e => e.FkIdPatient).HasColumnName("FK_IdPatient");
        });

        modelBuilder.Entity<Attandance>(entity =>
        {
            entity.HasKey(e => e.PkIdAttandance);

            entity.ToTable("Attandance");

            entity.Property(e => e.PkIdAttandance)
                .ValueGeneratedNever()
                .HasColumnName("PK_IdAttandance");
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FkIdDoctor).HasColumnName("FK_IdDoctor");
            entity.Property(e => e.FkIdPatient).HasColumnName("FK_IdPatient");
            entity.Property(e => e.MedicalFindings).HasMaxLength(100);
        });

        modelBuilder.Entity<AttandanceService>(entity =>
        {
			entity.HasKey(e => e.PkIdAttandanceService);

			entity.ToTable("AttandanceService");

			entity.Property(e => e.PkIdAttandanceService)
				.ValueGeneratedNever()
				.HasColumnName("PK_IdAttandanceService");

			entity.Property(e => e.FkIdAttandance).HasColumnName("FK_IdAttandance");
            entity.Property(e => e.FkIdService).HasColumnName("FK_IdService");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.PkIdDoctor).HasName("PK__Doctor__CBDCA36FB9552F3D");

            entity.ToTable("Doctor");

            entity.Property(e => e.PkIdDoctor)
                .ValueGeneratedNever()
                .HasColumnName("PK_IdDoctor");
            entity.Property(e => e.NameD).HasMaxLength(25);
            entity.Property(e => e.Speciality).HasMaxLength(35);
        });

        modelBuilder.Entity<DoctorService>(entity =>
        {

			entity.HasKey(e => e.PkIdDoctorService);

			entity.ToTable("DoctorService");

			entity.Property(e => e.PkIdDoctorService)
				.ValueGeneratedNever()
				.HasColumnName("PK_IdDoctorService");
			entity.Property(e => e.FkIdDoctor).HasColumnName("FK_IdDoctor");
            entity.Property(e => e.FkIdService).HasColumnName("Fk_IdService");
        });

        modelBuilder.Entity<MedicalSecretary>(entity =>
        {
            entity.HasKey(e => e.PkIdMedS).HasName("PK__MedicalS__D31337052BE35F11");

            entity.ToTable("MedicalSecretary");

            entity.Property(e => e.PkIdMedS)
                .ValueGeneratedNever()
                .HasColumnName("PK_IdMedS");
            entity.Property(e => e.NameMedS).HasMaxLength(25);
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.PkIdPatient).HasName("PK__Patient__D16397F123E9BC79");

            entity.ToTable("Patient");

            entity.Property(e => e.PkIdPatient)
                .ValueGeneratedNever()
                .HasColumnName("PK_IdPatient");
            entity.Property(e => e.NamePatient).HasMaxLength(100);
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity
                .HasKey(e => e.PkIdSchedule);
                entity.ToTable("Schedule");

			entity.Property(e => e.FkIdDoctor).HasColumnName("FK_IdDoctor");
		});

        modelBuilder.Entity<ServiceH>(entity =>
        {
            entity.HasKey(e => e.PkIdService).HasName("PK__ServiceH__211C1C609FD7A63C");

            entity.ToTable("ServiceH");

            entity.Property(e => e.PkIdService)
                .ValueGeneratedNever()
                .HasColumnName("PK_IdService");
            entity.Property(e => e.NameService).HasMaxLength(100);
        });

		modelBuilder.Entity<CheckInDoctor>(entity =>
		{
			entity
				.HasKey(e => e.PkIdCheckInDoctor);
			entity.ToTable("CheckInDoctor");

			entity.Property(e => e.FkIdSchedule).HasColumnName("FK_IdSchedule");
			entity.Property(e => e.CheckIn).HasColumnType("bit");
			entity.Property(e => e.DateCheckIn).HasColumnType("datetime");
		});

		OnModelCreatingPartial(modelBuilder);

	}

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
