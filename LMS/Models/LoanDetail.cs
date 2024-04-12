using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class LoanDetail
    {
        public int LoanDetailId { get; set; }
        public int LoanId { get; set; }
        public int PeriodNo { get; set; }
        public double BeginningBalance { get; set; }
        public double Principle { get; set; }
        public double Interest { get; set; }
        public double Payment { get; set; }
        public double EndingBalance { get; set; }
        public int IsPaid { get; set; }
        public DateTime PaidDate { get; set; } = DateTime.Now;
        public string Note { get; set; }
    }
}
