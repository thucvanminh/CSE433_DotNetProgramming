using System.ComponentModel.DataAnnotations;

namespace MinhThuc_Lab3.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool IsActive { get; set; }

        public string Avatar { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
