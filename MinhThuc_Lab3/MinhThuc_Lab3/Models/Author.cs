﻿using System.ComponentModel.DataAnnotations;

namespace MinhThuc_Lab3.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Biography { get; set; }

        [StringLength(100)]
        public string Nationality { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(100)]
        public string Website { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }

        public string Avatar { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
