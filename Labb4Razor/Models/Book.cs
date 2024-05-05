using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Labb4Razor.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public bool IsReturned { get; set; }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Loan>? Loans { get; set; }
    }
}
