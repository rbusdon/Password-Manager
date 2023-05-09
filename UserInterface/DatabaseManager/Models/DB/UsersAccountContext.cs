using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UserInterface.Models.DB;

public partial class UsersAccountContext : DbContext
{
    public UsersAccountContext()
    {
    }

    public UsersAccountContext(DbContextOptions<UsersAccountContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer
    //      ("Data Source=localhost;Initial Catalog=UsersAccount; User Id=sa; Password=Eur66Bag; Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.ApplyConfiguration(new UserConfiguration());
    //}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PK__USERS__737584F798FC33A3");

            entity.ToTable("USERS");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.DateOfSignUp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
