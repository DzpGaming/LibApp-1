using System;
using System.Linq;
using LibApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LibApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                context.Database.EnsureCreated();
                if (!context.MembershipTypes.Any())
                {

                    context.MembershipTypes.AddRange(
                        new MembershipType
                        {
                            Id = 1,
                            Name = "Name1",
                            SignUpFee = 0,
                            DurationInMonths = 0,
                            DiscountRate = 0
                        },
                        new MembershipType
                        {
                            Id = 2,
                            Name = "Name2",
                            SignUpFee = 30,
                            DurationInMonths = 1,
                            DiscountRate = 10
                        },
                        new MembershipType
                        {
                            Id = 3,
                            Name = "Name3",
                            SignUpFee = 90,
                            DurationInMonths = 3,
                            DiscountRate = 15
                        },
                        new MembershipType
                        {
                            Id = 4,
                            Name = "Name4",
                            SignUpFee = 300,
                            DurationInMonths = 12,
                            DiscountRate = 20
                        });
                    context.SaveChanges();
                }

                if (!context.Books.Any())
                {
                    context.Books.AddRange(
                        new Book
                        {
                            Name = "Szklany Tron",
                            AuthorName = "Sarah J. Maas",
                            Genre = context.Genre.Where(g => g.Id == 1).SingleOrDefault(),
                            GenreId = 1,
                            DateAdded = new DateTime(2017, 2, 11),
                            ReleaseDate = new DateTime(2013, 8, 2),
                            NumberInStock = 7,
                            NumberAvailable = 3
                        },
                        new Book
                        {
                            Name = "Pan Lodowego ogrodu tom I",
                            AuthorName = "Meyer Stephenie",
                            Genre = context.Genre.Where(g => g.Id == 1).SingleOrDefault(),
                            GenreId = 1,
                            DateAdded = new DateTime(2016, 7, 27),
                            ReleaseDate = new DateTime(2005, 3, 11),
                            NumberInStock = 16,
                            NumberAvailable = 9
                        },
                        new Book
                        {
                            Name = "Wiedźmin Sezon Burz",
                            AuthorName = "Sapkowski Andrzej",
                            Genre = context.Genre.Where(g => g.Id == 1).SingleOrDefault(),
                            GenreId = 1,
                            DateAdded = new DateTime(2016, 9, 12),
                            ReleaseDate = new DateTime(2013, 11, 6),
                            NumberInStock = 22,
                            NumberAvailable = 7
                        },
                        new Book
                        {
                            Name = "Profesor",
                            AuthorName = "John Katzenbach",
                            Genre = context.Genre.Where(g => g.Id == 1).SingleOrDefault(),
                            GenreId = 2,
                            DateAdded = new DateTime(2017, 8, 24),
                            ReleaseDate = new DateTime(2011, 9, 15),
                            NumberInStock = 3,
                            NumberAvailable = 2
                        },
                        new Book
                        {
                            Name = "Harry Potter i Przeklęte dziecko",
                            AuthorName = "Jack Thorne",
                            Genre = context.Genre.Where(g => g.Id == 3).SingleOrDefault(),
                            GenreId = 3,
                            DateAdded = new DateTime(2016, 8, 16),
                            ReleaseDate = new DateTime(2016, 7, 30),
                            NumberInStock = 8,
                            NumberAvailable = 5
                        }
                    );

                    //context.SaveChanges();
                }
            }
        }
    }
}