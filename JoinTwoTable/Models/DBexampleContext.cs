using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JoinTwoTable.Models
{
    public partial class DBexampleContext : DbContext
    {
        public DBexampleContext()
        {
        }

        public DBexampleContext(DbContextOptions<DBexampleContext> options)
            : base(options)
        {
        }

       
        public virtual DbSet<City> Cities { get; set; } = null!;
        
        public virtual DbSet<State> States { get; set; } = null!;
      

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId).HasColumnName("City_id");

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.StateId).HasColumnName("State_id");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_City_States");
            });

           
           

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.StateId).HasColumnName("State_id");

                entity.Property(e => e.StateName).HasMaxLength(50);
            });

            

           

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
