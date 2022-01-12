using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        private const string ConnString = @"Data Source=LAPTOP-VHEL4P4U\SQLEXPRESS; Initial Catalog=CS_Noah_Maktabi; Integrated Security=true; TrustServerCertificate=True";

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
        public CamperRegistry CamperRegistry { get; set; }
        public DbSet<CounselorRegistry> CounselorRegistries { get; set; }


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
            modelBuilder.Entity<Counselor>().HasOne(c => c.Cabin).WithOne(c => c.Counselor).HasForeignKey("Cabin");
            modelBuilder.Entity<Cabin>().HasOne(c => c.Counselor).WithOne(c => c.Cabin).HasForeignKey("Counselor");

            modelBuilder.Entity<Cabin>().HasData(seed.Cabins);
            modelBuilder.Entity<Camper>().HasData(seed.Campers);
            modelBuilder.Entity<Counselor>().HasData(seed.Counselors);
            modelBuilder.Entity<NextOfKin>().HasData(seed.NextOfKins);
            modelBuilder.Entity<CamperRegistry>().HasData(seed.CamperRegistries);
            modelBuilder.Entity<CounselorRegistry>().HasData(seed.CounselorRegistries);
        }


    }
}