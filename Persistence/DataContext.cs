using System.Security.Cryptography.X509Certificates;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        //Noahs connectionString
        private const string ConnString = @"Data Source=LAPTOP-VHEL4P4U\SQLEXPRESS; Initial Catalog=CS_Noah_Maktabi; Integrated Security=true; TrustServerCertificate=True";
        
        //Teacher's connectionsString
        //private const string ConnString = @"Data Source=DESKTOP-T2GL85N\SQLEXPRESS2017; Initial Catalog=CS_Noah_Maktabi; Integrated Security=true; TrustServerCertificate=True";

        public DataContext() : base()
        {
            
        }
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Cabin> Cabins { get; set; }
        public DbSet<Camper> Campers { get; set; }
        public DbSet<Counselor> Counselors { get; set; }
        public DbSet<NextOfKin> NextOfKins { get; set; }
        public DbSet<CamperRegistry> CamperRegistries { get; set; }
        public DbSet<CounselorRegistry> CounselorRegistries { get; set; }
        public DbSet<Visit> Visits { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var seed = new SeedData();
            modelBuilder.Entity<CamperRegistry>().HasOne(c => c.Camper).WithOne().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<CounselorRegistry>().HasOne(c => c.Counselor).WithOne().OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Visit>().HasOne(v => v.Visitor).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Visit>().HasOne(c => c.Camper).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Visit>().Property(x => x.StartTime).IsRequired();
            modelBuilder.Entity<Visit>().Property(x => x.EndTime).IsRequired();

            modelBuilder.Entity<Cabin>().HasData(seed.Cabins);
            modelBuilder.Entity<Camper>().HasData(seed.Campers);
            modelBuilder.Entity<Counselor>().HasData(seed.Counselors);
            modelBuilder.Entity<NextOfKin>().HasData(seed.NextOfKins);
            modelBuilder.Entity<CamperRegistry>().HasData(seed.CamperRegistries);
            modelBuilder.Entity<CounselorRegistry>().HasData(seed.CounselorRegistries);
            modelBuilder.Entity<Visit>().HasData(seed.Visits);

        }


    }
}