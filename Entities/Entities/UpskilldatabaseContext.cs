using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entities.Entities;

public partial class UpskilldatabaseContext : DbContext
{
    public UpskilldatabaseContext()
    {
    }

    public UpskilldatabaseContext(DbContextOptions<UpskilldatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FlashcardDetail> FlashcardDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FlashcardDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Flashcar__3214EC07F0D0D950");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Answer).IsUnicode(false);
            entity.Property(e => e.Question).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
