using eTickets.Model.Common;
using eTickets.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eTickets.Model
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // khai báo 2 foreignkey
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.MovieId,
                am.ActorId
            });
            modelBuilder.Entity<Actor_Movie>()
                .HasOne(m => m.Movie) // 1 actor_movie thuộc 1 movie
                .WithMany(am => am.Actors_Movies) // 1 movie có nhiều actor_movie
                .HasForeignKey(m => m.MovieId); // MovieId là khoá ngoại

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(a => a.Actor)
                .WithMany(am => am.Actors_Movies)
                .HasForeignKey(a => a.ActorId);

        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

        public override int SaveChanges()
        {
            var modelEntries = ChangeTracker.Entries().Where(
                model => model.Entity is IEntityBase &&
                (model.State == EntityState.Added || model.State == EntityState.Modified)
            );
            foreach (var entry in modelEntries)
            {
                if (entry.Entity is IEntityBase entity)
                {
                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedDate = DateTime.Now;
                    }
                    else
                    {
                        // nếu không phải là tạo mới thì ngăn chặn việc thay đổi CreatedDate và CreatedBy
                        base.Entry(entry).Property("CreatedDate").IsModified = false;
                        base.Entry(entry).Property("CreatedBy").IsModified = false;

                        entity.UpdatedDate = DateTime.Now;
                    }
                }

            }
            return base.SaveChanges();
        }
    }
}
