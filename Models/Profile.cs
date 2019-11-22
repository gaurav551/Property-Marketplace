using System;
using System.ComponentModel.DataAnnotations;

namespace Nepalists.Models

{
    public class Profile
    {
        public int Id { get; set; }
        public string UserId { get; set; } 
        public string UserName { get; set; }
        [Required]
        [MinLength(5,ErrorMessage="Please give your Full Name")]
        public string FullName { get; set; }
        public string ImageUrl { get; set; }

        //Extra
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]

        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string  Email { get; set; }
        [Required]
        public string Address { get; set; }

        public string Address2 { get; set; }
        [Required]
       

        public string DateOfBirth { get; set; }
        public int FollowersCount { get; set; } = 0;
        public int Listing { get; set; } = 0 ;

        public DateTime Date { get; set; } = DateTime.Now;
    }
}