using System.ComponentModel.DataAnnotations;

namespace MinhThuc_Lab3.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(200)]
        public string Fullname { get; set; }

        public string Description { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public string Address { get; set; }

        public int Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UserCode { get; set; }

        public bool IsLocked { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public string ActiveCode { get; set; }

        public string Avatar { get; set; }

        public virtual ICollection<Loan> Loans { get; set; }
    }
}
