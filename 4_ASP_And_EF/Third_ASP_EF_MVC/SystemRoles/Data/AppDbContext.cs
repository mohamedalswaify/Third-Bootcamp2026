using Microsoft.EntityFrameworkCore;
using SystemRoles.Models;

namespace SystemRoles.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        public DbSet<PermissionRoles> PermissionRoles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<RoleUser> RoleUsers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<PermissionRoles>()
                .HasKey(pr => new { pr.PermissionsId, pr.RolesId });


            modelBuilder.Entity<RoleUser>()
               .HasKey(ru => new { ru.RoleId, ru.UserId });


        }
    }
}
