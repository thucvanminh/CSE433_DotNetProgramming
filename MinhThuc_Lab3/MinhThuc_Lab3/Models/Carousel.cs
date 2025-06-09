﻿using System.ComponentModel.DataAnnotations;

namespace MinhThuc_Lab3.Models
{
    public class Carousel
    {
        [Key]
        public int CarouselId { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string LinkUrl { get; set; }

        [Required]
        public int Order { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
