using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROJECT.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public float Pret { get; set; }
        public int CategoryId { get; set; }
        public int ImageId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public int UserId { get; set; }
        public virtual Category Category { get; set; }
    }

}