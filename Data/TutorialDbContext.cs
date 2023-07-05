using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using start_csharp.Models;

namespace tutorial_csharp.Data;

public partial class TutorialDbContext : DbContext
{
    public TutorialDbContext()
    {
    }

    public TutorialDbContext(DbContextOptions<TutorialDbContext> options)
        : base(options)
    {
    }

    public DbSet<Company> Companies => Set<Company>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("name=DefaultConnection", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.21-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
