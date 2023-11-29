using eTickets.Model;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

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
                            Name="CGV Nguyễn Chí Thanh",
                            Description="none",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/CGV_logo.svg/2560px-CGV_logo.svg.png"
                        },
                        new Cinema()
                        {
                            Name="CGV Nguyễn Chí Thanh",
                            Description="none",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/CGV_logo.svg/2560px-CGV_logo.svg.png"
                        },
                        new Cinema()
                        {
                            Name="CGV Mipec Tower",
                            Description="none",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/CGV_logo.svg/2560px-CGV_logo.svg.png"
                        },
                        new Cinema()
                        {
                            Name="CGV Hồ Gươm Plaza",
                            Description="none",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/CGV_logo.svg/2560px-CGV_logo.svg.png"
                        }
                    });
                        context.SaveChanges();
                    }
                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            Avatar="https://nghenhinvietnam.vn/uploads/20221025/johnnydeppblir_3773633b_emgr.jpg",
                            FullName="Johnny Depp",
                            Bio="John Christopher \"Johnny\" Depp II was born on June 9, 1963 in Owensboro, Kentucky," +
                            " to Betty Sue Palmer (née Wells), a waitress, and John Christopher Depp, a civil engineer." +
                            " He was raised in Florida. He dropped out of school when he was 15, and fronted a series of" +
                            " music-garage bands, including one named 'The Kids'. When he married Lori A. Depp, he took a" +
                            " job as a ballpoint-pen salesman to support himself and his wife. A visit to Los Angeles, California," +
                            " with his wife, however, happened to be a blessing in disguise, when he met up with actor Nicolas Cage," +
                            " who advised him to turn to acting, which culminated in Depp's film debut in the low-budget horror film," +
                            " A Nightmare on Elm Street (1984), where he played a teenager who falls prey to dream-stalking demon Freddy Krueger."
                        },
                        new Actor()
                        {
                            Avatar="https://nghenhinvietnam.vn/uploads/20221025/johnnydeppblir_3773633b_emgr.jpg",
                            FullName="Johnny Depp 4",
                            Bio="John Christopher \"Johnny\" Depp II was born on June 9, 1963 in Owensboro, Kentucky," +
                            " to Betty Sue Palmer (née Wells), a waitress, and John Christopher Depp, a civil engineer." +
                            " He was raised in Florida. He dropped out of school when he was 15, and fronted a series of" +
                            " music-garage bands, including one named 'The Kids'. When he married Lori A. Depp, he took a" +
                            " job as a ballpoint-pen salesman to support himself and his wife. A visit to Los Angeles, California," +
                            " with his wife, however, happened to be a blessing in disguise, when he met up with actor Nicolas Cage," +
                            " who advised him to turn to acting, which culminated in Depp's film debut in the low-budget horror film," +
                            " A Nightmare on Elm Street (1984), where he played a teenager who falls prey to dream-stalking demon Freddy Krueger."
                        },

                        new Actor()
                        {
                            Avatar="https://nghenhinvietnam.vn/uploads/20221025/johnnydeppblir_3773633b_emgr.jpg",
                            FullName="Johnny Depp 2",
                            Bio="John Christopher \"Johnny\" Depp II was born on June 9, 1963 in Owensboro, Kentucky," +
                            " to Betty Sue Palmer (née Wells), a waitress, and John Christopher Depp, a civil engineer." +
                            " He was raised in Florida. He dropped out of school when he was 15, and fronted a series of" +
                            " music-garage bands, including one named 'The Kids'. When he married Lori A. Depp, he took a" +
                            " job as a ballpoint-pen salesman to support himself and his wife. A visit to Los Angeles, California," +
                            " with his wife, however, happened to be a blessing in disguise, when he met up with actor Nicolas Cage," +
                            " who advised him to turn to acting, which culminated in Depp's film debut in the low-budget horror film," +
                            " A Nightmare on Elm Street (1984), where he played a teenager who falls prey to dream-stalking demon Freddy Krueger."
                        },
                        new Actor()
                        {
                            Avatar="https://nghenhinvietnam.vn/uploads/20221025/johnnydeppblir_3773633b_emgr.jpg",
                            FullName="Johnny Depp 3",
                            Bio="John Christopher \"Johnny\" Depp II was born on June 9, 1963 in Owensboro, Kentucky," +
                            " to Betty Sue Palmer (née Wells), a waitress, and John Christopher Depp, a civil engineer." +
                            " He was raised in Florida. He dropped out of school when he was 15, and fronted a series of" +
                            " music-garage bands, including one named 'The Kids'. When he married Lori A. Depp, he took a" +
                            " job as a ballpoint-pen salesman to support himself and his wife. A visit to Los Angeles, California," +
                            " with his wife, however, happened to be a blessing in disguise, when he met up with actor Nicolas Cage," +
                            " who advised him to turn to acting, which culminated in Depp's film debut in the low-budget horror film," +
                            " A Nightmare on Elm Street (1984), where he played a teenager who falls prey to dream-stalking demon Freddy Krueger."
                        },
                    });
                        context.SaveChanges();
                    }
                    if (!context.Producers.Any())
                    {
                        context.Producers.AddRange(new List<Producer>()
                        {
                            new Producer()
                            {
                                FullName="Christopher Nolan",
                                Avatar="https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcT1oZ8A5ckGQ7Zi1P9AqbK_zO9W5UzJh7_MenkYreON56vAqLZM",
                                Bio="Best known for his cerebral, often nonlinear, storytelling, acclaimed writer-director Christopher Nolan was born on July 30, 1970, in London, England. Over the course of 15 years of filmmaking, Nolan has gone from low-budget independent films to working on some of the biggest blockbusters ever made.At 7 years old, Nolan began making short movies with his father's Super-8 camera"
                            },
                            new Producer()
                            {
                                FullName="Christopher Nolan 2",
                                Avatar="https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcT1oZ8A5ckGQ7Zi1P9AqbK_zO9W5UzJh7_MenkYreON56vAqLZM",
                                Bio="Best known for his cerebral, often nonlinear, storytelling, acclaimed writer-director Christopher Nolan was born on July 30, 1970, in London, England. Over the course of 15 years of filmmaking, Nolan has gone from low-budget independent films to working on some of the biggest blockbusters ever made.At 7 years old, Nolan began making short movies with his father's Super-8 camera"
                            },
                            new Producer()
                            {
                                FullName="Christopher Nolan 3",
                                Avatar="https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcT1oZ8A5ckGQ7Zi1P9AqbK_zO9W5UzJh7_MenkYreON56vAqLZM",
                                Bio="Best known for his cerebral, often nonlinear, storytelling, acclaimed writer-director Christopher Nolan was born on July 30, 1970, in London, England. Over the course of 15 years of filmmaking, Nolan has gone from low-budget independent films to working on some of the biggest blockbusters ever made.At 7 years old, Nolan began making short movies with his father's Super-8 camera"
                            },
                            new Producer()
                            {
                                FullName="Christopher Nolan 4",
                                Avatar="https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcT1oZ8A5ckGQ7Zi1P9AqbK_zO9W5UzJh7_MenkYreON56vAqLZM",
                                Bio="Best known for his cerebral, often nonlinear, storytelling, acclaimed writer-director Christopher Nolan was born on July 30, 1970, in London, England. Over the course of 15 years of filmmaking, Nolan has gone from low-budget independent films to working on some of the biggest blockbusters ever made.At 7 years old, Nolan began making short movies with his father's Super-8 camera"
                            }
                        });
                        context.SaveChanges();
                    }
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                        {
                            new Movie()
                            {
                                Name="The Curse of the Black Pearl",
                                CinemaId=1,
                                Description="The film series started in 2003 with Pirates of the Caribbean: The Curse of the Black Pearl, which had a positive reception from audiences and film critics. It grossed $654 million worldwide",
                                EndDate=DateTime.Now,
                                ImageUrl="https://lumiere-a.akamaihd.net/v1/images/p_piratesofthecaribbean_thecurseoftheblackpearl_19642_d1ba8e66.jpeg",
                                MovieCategory=Data.MovieCategory.Action,
                                Price=100,
                                ProducerId=1,
                                StartDate=DateTime.Now,
                                Sumary="The film series started in 2003 with Pirates of the Caribbean: The Curse of the Black Pearl, which had a positive reception from audiences and film critics. It grossed $654 million worldwide",
                            },
                            new Movie()
                            {
                                Name="Dead Man's Chest",
                                CinemaId=1,
                                Description="The film series started in 2006 with Pirates of the Caribbean: The Curse of the Black Pearl, which had a positive reception from audiences and film critics. It grossed $654 million worldwide",
                                EndDate=DateTime.Now,
                                ImageUrl="https://m.media-amazon.com/images/M/MV5BMTcwODc1MTMxM15BMl5BanBnXkFtZTYwMDg1NzY3._V1_FMjpg_UX1000_.jpg",
                                MovieCategory=Data.MovieCategory.Action,
                                Price=100,
                                ProducerId=1,
                                StartDate=DateTime.Now,
                                Sumary="The film series started in 2003 with Pirates of the Caribbean: The Curse of the Black Pearl, which had a positive reception from audiences and film critics. It grossed $654 million worldwide",
                            },
                             new Movie()
                            {
                                Name="At World's End",
                                CinemaId=1,
                                Description="The film series started in 2006 with Pirates of the Caribbean: The Curse of the Black Pearl, which had a positive reception from audiences and film critics. It grossed $654 million worldwide",
                                EndDate=DateTime.Now,
                                ImageUrl="https://upload.wikimedia.org/wikipedia/en/5/5a/Pirates_AWE_Poster.jpg",
                                MovieCategory=Data.MovieCategory.Action,
                                Price=100,
                                ProducerId=1,
                                StartDate=DateTime.Now,
                                Sumary="The film series started in 2003 with Pirates of the Caribbean: The Curse of the Black Pearl, which had a positive reception from audiences and film critics. It grossed $654 million worldwide",
                            },
                             new Movie()
                            {
                                Name="On Stranger Tides",
                                CinemaId=1,
                                Description="The film series started in 2006 with Pirates of the Caribbean: The Curse of the Black Pearl, which had a positive reception from audiences and film critics. It grossed $654 million worldwide",
                                EndDate=DateTime.Now,
                                ImageUrl="https://m.media-amazon.com/images/M/MV5BMjE5MjkwODI3Nl5BMl5BanBnXkFtZTcwNjcwMDk4NA@@._V1_.jpg",
                                MovieCategory=Data.MovieCategory.Action,
                                Price=100,
                                ProducerId=1,
                                StartDate=DateTime.Now,
                                Sumary="The film series started in 2003 with Pirates of the Caribbean: The Curse of the Black Pearl, which had a positive reception from audiences and film critics. It grossed $654 million worldwide",
                            },
                              new Movie()
                            {
                                Name="Dead Men Tell No Tales",
                                CinemaId=1,
                                Description="The film series started in 2006 with Pirates of the Caribbean: The Curse of the Black Pearl, which had a positive reception from audiences and film critics. It grossed $654 million worldwide",
                                EndDate=DateTime.Now,
                                ImageUrl="https://m.media-amazon.com/images/M/MV5BMTYyMTcxNzc5M15BMl5BanBnXkFtZTgwOTg2ODE2MTI@._V1_.jpg",
                                MovieCategory=Data.MovieCategory.Action,
                                Price=100,
                                ProducerId=1,
                                StartDate=DateTime.Now,
                                Sumary="The film series started in 2003 with Pirates of the Caribbean: The Curse of the Black Pearl, which had a positive reception from audiences and film critics. It grossed $654 million worldwide",
                            }
                        });
                        context.SaveChanges();
                    }
                    if (!context.Actors_Movies.Any())
                    {
                        context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=1
                        },
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=2
                        },
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=3
                        },
                        new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=3
                        },
                          new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=1
                        },
                         new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=2
                        }
                    });
                        context.SaveChanges();
                    }
                }



            }
        }
    }
}
