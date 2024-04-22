using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Loan
    {
        public User User { get; set; }
        public Document Document { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Loan(User user, Document document, DateTime loanDate, DateTime returnDate)
        {
            User = user;
            Document = document;
            LoanDate = loanDate;
            ReturnDate = returnDate;
        }
    }
}
