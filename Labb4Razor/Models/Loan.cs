using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb4Razor.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }
        

        [ForeignKey("Customer")]
        public int FkCustomerId { get; set; }
        public Customer? Customer { get; set; }

        [ForeignKey("Book")]
        public int FkBookId { get; set; }
        public Book? Book { get; set; }

        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
