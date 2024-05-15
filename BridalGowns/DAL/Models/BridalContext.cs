using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class BridalContext : DbContext
{
    public BridalContext()
    {
    }

    public BridalContext(DbContextOptions<BridalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Crown> Crowns { get; set; }

    public virtual DbSet<Gown> Gowns { get; set; }

    public virtual DbSet<Meeting> Meetings { get; set; }

    public virtual DbSet<OrderSchedule> MeetingsSchedules { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrdersSchedule> OrdersSchedules { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\BridalGowns\\BridalGowns\\BridalGowns\\DAL\\BridalGownDB.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clients__3214EC0740636E94");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasKey(e => e.ColorId).HasName("PK__tmp_ms_x__8DA7676D0B56D87F");

            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.Color1)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Color");
        });

        modelBuilder.Entity<Crown>(entity =>
        {
            entity.HasKey(e => e.CrownCode).HasName("PK__tmp_ms_x__39BC608B879BFB4B");

            entity.Property(e => e.CrownCode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Image)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Color).WithMany(p => p.Crowns)
                .HasForeignKey(d => d.ColorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ColorCrowns");
        });

        modelBuilder.Entity<Gown>(entity =>
        {
            entity.HasKey(e => e.GownCode).HasName("PK__Gowns__4CB2791E3C356CB8");

            entity.Property(e => e.GownCode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Image)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Size)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Color).WithMany(p => p.Gowns)
                .HasForeignKey(d => d.ColorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ColorGowns");
        });

        modelBuilder.Entity<Meeting>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Meetings__A25C5AA64D88ABD7");

            entity.Property(e => e.ClientId)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ClientID");
            entity.Property(e => e.MeetingTime).HasColumnType("datetime");

            entity.HasOne(d => d.Client).WithMany(p => p.Meetings)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientMeetings");
        });

        modelBuilder.Entity<OrderSchedule>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Meetings__A25C5AA6F2C349FC");

            entity.ToTable("MeetingsSchedule");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.HasOne(d => d.MeetingCodeNavigation).WithMany(p => p.MeetingsSchedules)
                .HasForeignKey(d => d.MeetingCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MeetingsMeetingsSchedule");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderNumber).HasName("PK__Orders__CAC5E7424C1941A3");

            entity.Property(e => e.OrderNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ClientId)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ClientID");
            entity.Property(e => e.CrownCode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GownCode)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PickedUp).HasColumnName("PickedUP");
            entity.Property(e => e.WeddingDate).HasColumnType("date");

            entity.HasOne(d => d.Client).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientOrders");

            entity.HasOne(d => d.CrownCodeNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CrownCode)
                .HasConstraintName("FK_CrownOrders");

            entity.HasOne(d => d.GownCodeNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.GownCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GownOrders");
        });

        modelBuilder.Entity<OrdersSchedule>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__OrdersSc__A25C5AA6881954FA");

            entity.ToTable("OrdersSchedule");

            entity.Property(e => e.CrownCode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.GownCode)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.CrownCodeNavigation).WithMany(p => p.OrdersSchedules)
                .HasForeignKey(d => d.CrownCode)
                .HasConstraintName("FK_CrownSchedule");

            entity.HasOne(d => d.GownCodeNavigation).WithMany(p => p.OrdersSchedules)
                .HasForeignKey(d => d.GownCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GownSchedule");
        });

        //modelBuilder.Entity<Schedule>(entity =>
        //{
        //    entity.HasKey(e => e.Code).HasName("PK__Schedule__A25C5AA627A92F08");

        //    entity.ToTable("Schedule");

        //    entity.Property(e => e.CrownCode)
        //        .HasMaxLength(30)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Date).HasColumnType("date");
        //    entity.Property(e => e.GownCode)
        //        .IsRequired()
        //        .HasMaxLength(30)
        //        .IsUnicode(false);

        //    entity.HasOne(d => d.CrownCodeNavigation).WithMany(p => p.Schedules)
        //        .HasForeignKey(d => d.CrownCode)
        //        .HasConstraintName("FK_CrownsSchedule");

        //    entity.HasOne(d => d.GownCodeNavigation).WithMany(p => p.Schedules)
        //        .HasForeignKey(d => d.GownCode)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_GownsSchedule");
        //});

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
