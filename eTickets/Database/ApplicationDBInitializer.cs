using eTickets.Models;

namespace eTickets.Database
{
    public class ApplicationDBInitializer
    {
        public static void Seed(IApplicationBuilder appBuilder)
        {
            using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDBContext>();
                if (context != null)
                {
                    context.Database.EnsureCreated();
                    if (!context.Cinemas.Any())
                    {
                        context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="1",
                            Description="1",
                            Logo = "1"
                        }
                    });
                    }
                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {

                        }
                    });
                    }

                    if (!context.Producers.Any())
                    {
                        context.Producers.AddRange(new List<Producer>()
                        {

                        });

                    }
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                        {

                        });
                    }
                    if (!context.Actors_Movies.Any())
                    {
                        context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {

                        }
                    });
                    }
                }



            }
        }
    }
}
