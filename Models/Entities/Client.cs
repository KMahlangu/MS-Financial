using System.ComponentModel.DataAnnotations;

namespace MS.Financial.Web.Models.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^\d{13}$", ErrorMessage = = "SA ID must be 13 digits.")]
        public string IdentityNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public decimal MonthlyIncome { get; set; }
        public string EmploymentStatus { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastAssesmentDate { get; set; }
        
        // NAvigation properties
        public ICollection<DebtCase> DebtCases { get; set; }
        public ICollection<CreditReport> CreditReports { get; set; }

    }
}