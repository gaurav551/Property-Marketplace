using System;
using System.ComponentModel.DataAnnotations;
namespace Nepalists.Models
{
    public class Listing
    {
        
        
        public int Id { get; set; }
        [Required(ErrorMessage="Title is required 😥")]
        public string Title { get; set; }
        [Required(ErrorMessage="Description is Required")]
        [MinLength(15,ErrorMessage="Description is not enough ☺"  )]

       
        public string Description { get; set; }
     
        [Required(ErrorMessage="Please Select and Image")]
        public string Images { get; set; }
        public DateTime ListedOn { get; set; } =  DateTime.Now;
        //contact
        [Required]
        [EmailAddress(ErrorMessage="Not Valid Email !!!")]
       
        public string Email { get;set; }
        [Required]
       
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
       
        public string Phone { get; set; }
        public string PostedBy { get; set; }
        public string UserId { get; set; }
        ///opening closing
        public string TimeFrom { get; set; }
         public string TimeTo { get; set; }
        [Required]
        public string Location { get; set; }
        public string Category { get; set; }

        [Required(ErrorMessage="Price is Required")]
        [Range(100, int.MaxValue,ErrorMessage="Price must be in number &&  > 100")]

        public string Price { get; set; }
        // public Saved Saved {get;set;}
        // public int SavedId {get;set;}
    }
}