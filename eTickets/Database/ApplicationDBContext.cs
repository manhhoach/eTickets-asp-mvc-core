using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Database
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
    }
}
