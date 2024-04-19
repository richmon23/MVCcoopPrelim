﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RetizaCoopPrelim.Entities;

public partial class PrelimmvcnewContext : DbContext
{
    public PrelimmvcnewContext()
    {
    }

    public PrelimmvcnewContext(DbContextOptions<PrelimmvcnewContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ClientInfo> ClientInfos { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MORT-DESIREE\\SQLEXPRESS;Database=PRELIMMVCNEW;TrustServerCertificate=true;Trusted_Connection=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClientInfo>(entity =>
        {
            entity.ToTable("ClientInfo");

            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Birthdate).HasColumnType("date");
            entity.Property(e => e.Civilstatus)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NameofFather)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NameofMother)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Occupation)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Religion)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity.ToTable("UserType");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
