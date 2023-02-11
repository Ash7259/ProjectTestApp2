using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Project202322.Shared.Domain;
using Project20232.Server.Configurations.Entities;
using ProjectTestApp2.Server.Models;

namespace ProjectTestApp2.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProductSeedConfiguration());
            builder.ApplyConfiguration(new CategorySeedConfiguration());
        }
    }
}