using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalBeltExam.Models
{
    public class Idea
    {
        [Key]

        public int IdeaId {get; set;}

        [Required]
        [MinLength(5, ErrorMessage ="Idea must be at least 5 characters long")]
        public string Content {get; set;}
        public int UserId {get;set;}
        public User Creator {get;set;}
        public List<Like> Likes {get;set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        
    }
}