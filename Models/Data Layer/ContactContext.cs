using Microsoft.EntityFrameworkCore;
using System;

namespace ContactManager.Models
{
    public class ContactContext: DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Coworker" },
                new Category { CategoryId = 4, Name = "Business" }
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                { 
                    ContactId = 1,
                    FirstName = "Jesse",
                    LastName = "Chrisp",
                    PhoneNumber = "216-123-4567",
                    Email = "email@email.com",
                    CategoryId = 1,
                    DateAdded = DateTime.Now
                },
                
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Bret",
                    LastName = "Jones",
                    PhoneNumber = "555-123-4567",
                    Email = "email@work.com",
                    CategoryId = 3,
                    DateAdded = DateTime.Now
                },

                new Contact
                {
                    ContactId = 3,
                    FirstName = "Henry",
                    LastName = "Thomas",
                    PhoneNumber = "123-456-7890",
                    Email = "email@biz.com",
                    CategoryId = 4,
                    DateAdded = DateTime.Now
                }
             );
        }
    }
}
