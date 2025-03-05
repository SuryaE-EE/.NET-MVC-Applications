using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWeb;

public partial class EmployeeWebContext : DbContext
{
    public EmployeeWebContext()
    {
    }

    public EmployeeWebContext(DbContextOptions<EmployeeWebContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-FHBRPJ7;database=EmployeeWeb;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblEmplo__3213E83FFE1B181A");

            entity.ToTable("tblEmployees");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Job)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
