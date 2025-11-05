using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace 泛用基督教會會員管理系統2版通用API.SQLiteModels.Church;

public partial class ChurchMembersNewContext : DbContext
{
    public ChurchMembersNewContext()
    {
    }

    public ChurchMembersNewContext(DbContextOptions<ChurchMembersNewContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LOGINRECORD> LOGINRECORD { get; set; }

    public virtual DbSet<MEMBERPASSWORDS> MEMBERPASSWORDS { get; set; }

    public virtual DbSet<MEMBERS> MEMBERS { get; set; }

    public virtual DbSet<SERIAL_TABLE> SERIAL_TABLE { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=ChurchMembersNew.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LOGINRECORD>(entity =>
        {
            entity.HasKey(e => new { e.LOGINID, e.LOGINTIME });
        });

        modelBuilder.Entity<MEMBERPASSWORDS>(entity =>
        {
            entity.HasKey(e => e.LOGINID);
        });

        modelBuilder.Entity<MEMBERS>(entity =>
        {
            entity.HasKey(e => e.LOGINID);
        });

        modelBuilder.Entity<SERIAL_TABLE>(entity =>
        {
            entity.HasKey(e => e.TABLENAME);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
