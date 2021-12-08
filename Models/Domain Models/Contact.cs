using System.ComponentModel.DataAnnotations;
using System;

namespace ContactManager.Models
{
    public class Contact
    {
        //EF Core will configure the database to generate this value
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter an email address.")]
        public string Email { get; set; }

        [Range(0.1, int.MaxValue, ErrorMessage = "Please enter a category.")]
        public int CategoryId { get; set; } //Foreign key from Category class

        public Category Category { get; set; } //EF will use to connect contact with category

        public string Organization { get; set; }

        public DateTime DateAdded { get; set; }

        public string Slug => 
            FirstName?.Replace(' ', '-').ToLower() + "_" + LastName?.Replace(' ', '-');
    }
}
