using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ThirdEye.DAL;

public partial class ThirdEyeContext : DbContext
{
    public ThirdEyeContext()
    {
    }

    public ThirdEyeContext(DbContextOptions<ThirdEyeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ObjectMaster> ObjectMasters { get; set; }

    public virtual DbSet<PositionMaster> PositionMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=ThirdEye;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ObjectMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ObjectMa__3214EC27A8477FB4");
        });

        modelBuilder.Entity<PositionMaster>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
