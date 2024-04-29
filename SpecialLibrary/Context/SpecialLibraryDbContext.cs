using Microsoft.EntityFrameworkCore;
using SpecialLibrary.Models;

namespace SpecialLibrary.Context
{
    internal class SpecialLibraryDbContext : DbContext
    {
        public static SpecialLibraryDbContext Shared = SpecialLibraryDbContextFactory.CreateDbContext();

        public SpecialLibraryDbContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OrderInfo> Orders { get; set; }
        public DbSet<OrderInfoUser> OrderInfoUsers { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var result = await base.SaveChangesAsync(cancellationToken);

            ChangeTracker.Clear();

            return result;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasData(Enumerable.Range(1,5).Select(x => new User
                {
                    Id = x,
                    Name = $"User{x}",
                    IsLibraryWorker = x % 2 == 0,
                }));

            modelBuilder
                .Entity<OrderInfo>()
                .HasData(Enumerable.Range(1, 30).Select(x => new OrderInfo
                {
                    Id = x,
                    Title = $"Order{x}",
                    Type = (OrderInfoType)Random.Shared.Next(0,2),
                    SecurityLevel = (OrderInfoSecurityLevel)Random.Shared.Next(0, 2),
                    Location = $"Order Location {x}",
                    IsAwarded = false,
                    CreateDate = DateTime.Now,
                }));

            modelBuilder
                .Entity<OrderInfoUser>()
                .HasKey(x => new { x.OrderInfoId, x.UserId });

            modelBuilder
                .Entity<OrderInfoUser>()
                .HasOne(pc => pc.OrderInfo)
                .WithMany(p => p.OrderInfoUsers)
                .HasForeignKey(pc => pc.OrderInfoId);

            modelBuilder
                .Entity<OrderInfoUser>()
                .HasOne(pc => pc.User)
                .WithMany(c => c.OrderInfoUsers)
                .HasForeignKey(pc => pc.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
