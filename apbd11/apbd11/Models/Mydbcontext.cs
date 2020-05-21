using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd11.Models
{
    public class Mydbcontext: DbContext
    {


        public DbSet<Patient> Patients { get; set; }

        public DbSet<Perscription> Perscriptions { get; set; }


        public DbSet<PerscriptionMedicament>

        public Mydbcontext(DbContextOptions<Mydbcontext> options):base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        
        
        {

            modelBuilder.Entity<Patient>(entitity =>
            {


                entitity.HasKey(e => e.IdPatient).HasName("Patient_PK");
                entitity.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
                entitity.Property(e => e.LastName).HasMaxLength(100).IsRequired();
                entitity.Property(e => e.Birthdate).IsRequired();







            });


            modelBuilder.Entity<Perscription>(p =>
            {

                p.HasKey(e => e.IdPerscription).HasName("Percription_PK");
                p.Property(e => e.Date).HasDefaultValueSql("GETDATE()").IsRequired();
                p.Property(e => e.DueDate).IsRequired();


                p.HasOne(p => p.Patient).WithMany(d => d.Perscriptions).HasForeignKey(p => p.IdPatient).OnDelete(DeleteBehavior.Cascade).HasConstraintName("Persciption_Patient_FK");


            });
        
        
        
        
        }

    }
}
