using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Calculator.Models;

public partial class CalculatorDbContext : DbContext
{
    public CalculatorDbContext()
    {
    }

    public CalculatorDbContext(DbContextOptions<CalculatorDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CalculatorTable> CalculatorTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Calculator_DB;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CalculatorTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("calculator_Table");

            entity.Property(e => e.FirstNumber).HasColumnName("First_number");
            entity.Property(e => e.Operator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SecondNumber).HasColumnName("Second_number");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
