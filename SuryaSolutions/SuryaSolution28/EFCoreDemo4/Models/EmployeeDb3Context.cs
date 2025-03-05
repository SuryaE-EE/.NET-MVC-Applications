using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo4.Models;

public partial class EmployeeDb3Context : DbContext
{
    public EmployeeDb3Context()
    {
    }

    public EmployeeDb3Context(DbContextOptions<EmployeeDb3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("server=DESKTOP-FHBRPJ7;database=EmployeeDB3;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC0761E9CFDB");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
