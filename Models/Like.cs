using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalBeltExam.Models
{


    public class Like
    {
        [Key]
        public int LikeId {get; set;}
        public int UserId {get; set;}
        public int IdeaId {get; set;}
        public User User {get; set;}
        public Idea Idea {get; set;}
    }
}