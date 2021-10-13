using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalBeltExam.Models
{
    public class User
    {
        [Key]

        public int UserId {get; set;}
        [Required]
        [MinLength(3, ErrorMessage ="Name must be at least 3 characters long")]
        public string Name {get; set;}
        [Required]
        [MinLength(3, ErrorMessage ="Alias must be at least 3 characters long")]
        public string Alias {get; set;}
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage ="Must have 8 characters for the password")]
        public string Password {get; set;}
        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Passwords must match")]
        public string Confirm {get; set;}
        public List<Like> IdeasLiked {get;set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

    }
}