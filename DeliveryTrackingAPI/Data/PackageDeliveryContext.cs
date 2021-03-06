using DeliveryTracker.Data.Models;
using DeliveryTrackingAPI;
using Microsoft.EntityFrameworkCore;

namespace DeliveryTracker.Data.Data
{
    public class PackageDeliveryContext : DbContext
    {
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageStatus> PackageStatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CustomConfigManager.AppSetting["ConnectionStrings:DeliveryTrackerDB"]); //"Server=LAPTOP-C319KMRH;database=DeliveryTrackerDB;User ID=sa;password=P@ssword;"
        }
    }
}
