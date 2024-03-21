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
        public float BeginningBalance { get; set; }
        public float Principle { get; set; }
        public float Interest { get; set; }
        public float Payment { get; set; }
        public float EndingBalance { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PaidDate { get; set; } = DateTime.Now;
        public string Note { get; set; }
    }
}
