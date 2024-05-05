using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Labb4Razor.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 7)]
        public string Name { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 7)]
        public string Email { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 4)]
        public string Phone { get; set; }


        [DataType(DataType.Date)]
        public DateTime MembershipStartDate { get; set; }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Loan>? Loans { get; set; }
    }
}
