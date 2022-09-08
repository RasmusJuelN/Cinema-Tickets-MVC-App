using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDataInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Palads",
                            LogoURL = "https://c8.alamy.com/comp/2E49J4M/copenhagen-denmark-12-dec-2020-the-logo-of-the-palads-in-copenhagen-2E49J4M.jpg",
                            Description = "Oplev Københavns ældste biograf Palads i den ikoniske bygning ved Vesterport St. Palads er vores største biograf med hele 17 sale."
                        },

                        new Cinema()
                        {
                            Name = "CineMaxx",
                            LogoURL = "http://nsmedia.dk/wp-content/uploads/2016/07/cinemaxx.jpg",
                            Description = "CinemaxX er en biografkæde bestående af tre biografer beliggende i henholdsvis Aarhus, København og Odense. Vi er Danmarks næststørste biografkæde!"
                        },

                        new Cinema ()
                        {
                            Name = "Empire Bio",
                            LogoURL = "https://www.kino.dk/sites/default/files/cinema-logo/empire_kinodk_logo.jpg",
                            Description = "Empire er indbegrebet af Nørrebro, og for mange den bedste biograf i København. Programmet er omhyggeligt kurateret, så du altid kan finde en film der er værd at se. Huset bruges også til en række offentlige og private events."
                        },

                        new Cinema ()
                        {
                            Name = "ATLAS",
                            LogoURL = "https://cdn.odendo.com/single_picture/11880/308/mega/logo%20atlas_13.png",
                            Description = "En god film med kaffe og cookie i loungen er en perfekt måde at starte dagen på. Vi glæder os til at hygge om jer"
                        },

                        new Cinema ()
                        {
                            Name = "Gloria Biograf",
                            LogoURL = "https://www.nfbio.dk/sites/nfbio.dk/files/media-images/2020-02/Biograferne_recliner2_1.jpg",
                            Description = "Gloria Biograf er en 'arthouse-biograf', der ligger ved Rådhuspladsen i København. Biografens repertoire er en blanding af premierer på små film, der kun kommer op i et par biografer, og film, der kommer op, efter de er gået ud af andre biografer som Dagmar eller Grand."
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
                            FullName = "Actor 1",
                            Biography = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Biography = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Biography = "This is the Bio of the third actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Biography = "This is the Bio of the fourth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Biography = "This is the Bio of the fifth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 6",
                            Biography = "This is the Bio of the sixth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 7",
                            Biography = "This is the Bio of the seventh actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();

                }
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Biography = "This is the Bio of the first producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Biography = "This is the Bio of the second producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Biography = "This is the Bio of the third producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Biography = "This is the Bio of the fourth producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Biography = "This is the Bio of the fifth producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
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
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();

                }
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {

                        // Movie 1

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
                            ActorId = 7,
                            MovieId = 1
                        },


                        // Movie 2

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
                            ActorId = 7,
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

