using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace 泛用基督教會會員管理系統2版通用API.SQLiteModels.Exceptions;

public partial class ExceptionLogContext : DbContext
{
    public ExceptionLogContext()
    {
    }

    public ExceptionLogContext(DbContextOptions<ExceptionLogContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EXCEPTIONDATA> EXCEPTIONDATA { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=ExceptionLog.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EXCEPTIONDATA>(entity =>
        {
            entity.HasKey(e => e.EVENTTIME);

            entity.HasIndex(e => e.SERIAL, "IX_EXCEPTIONDATA_SERIAL").IsUnique();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
