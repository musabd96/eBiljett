using eBiljett.Models;
using eBiljett.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace eBiljett.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Discription = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Discription = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Discription = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Discription = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Discription = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();

                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            fullName = "Actor 1",
                            Bio = "This is the description of the first cinema",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg",
                        },
                        new Actor()
                        {
                            fullName = "Actor 2",
                            Bio = "This is the description of the first cinema",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg",
                        },
                        new Actor()
                        {
                            fullName = "Actor 3",
                            Bio = "This is the description of the first cinema",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg",
                        },
                        new Actor()
                        {
                            fullName = "Actor 4",
                            Bio = "This is the description of the first cinema",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg",
                        },
                        new Actor()
                        {
                            fullName = "Actor 5",
                            Bio = "This is the description of the first cinema",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg",
                        },
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            fullName = "Producer 1",
                            Bio = "This is the description of the first cinema",
                            profilePictureURL = "http://dotnethow.net/images/producer/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            fullName = "Producer 2",
                            Bio = "This is the description of the first cinema",
                            profilePictureURL = "http://dotnethow.net/images/producer/producer-2.jpeg",
                        },
                        new Producer()
                        {
                            fullName = "Producer 3",
                            Bio = "This is the description of the first cinema",
                            profilePictureURL = "http://dotnethow.net/images/producer/producer-3.jpeg",
                        },
                        new Producer()
                        {
                            fullName = "Producer 4",
                            Bio = "This is the description of the first cinema",
                            profilePictureURL = "http://dotnethow.net/images/producer/producer-4.jpeg",
                        },
                        new Producer()
                        {
                            fullName = "Producer 5",
                            Bio = "This is the description of the first cinema",
                            profilePictureURL = "http://dotnethow.net/images/producer/producer-5.jpeg",
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life Movie description,",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StarDate= DateTime.Now.AddDays(-10),
                            EndDate= DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = Enums.MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the The Shawshank Redemption Movie description,",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StarDate= DateTime.Now,
                            EndDate= DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = Enums.MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost Movie description,",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StarDate= DateTime.Now,
                            EndDate= DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = Enums.MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race  description,",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StarDate= DateTime.Now.AddDays(-10),
                            EndDate= DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = Enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob Movie description,",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StarDate= DateTime.Now.AddDays(-10),
                            EndDate= DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = Enums.MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles Movie description,",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StarDate= DateTime.Now.AddDays(3),
                            EndDate= DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = Enums.MovieCategory.Drama
                        },

                    });
                    context.SaveChanges();
                }
                //Actors & MOvies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
