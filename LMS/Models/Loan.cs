using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public int CustomerId { get; set; }
        public int CollateralId { get; set; }
        public int CreditOfficerId { get; set; }
        public DateTime LoanDate { get; set; } = DateTime.Now;
        public string LoanCode { get; set; }
        public double LoanAmount { get; set; }
        public char Currency { get; set; }
        public double InterestRate { get; set; }
        public double PaymentFrequencyCode { get; set; }
        public string Memo { get; set; }
    }
}
