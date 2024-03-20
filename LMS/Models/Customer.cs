using System;

namespace LMS.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public char Sex { get; set; }
        public DateTime DoB { get; set; }
        public string PoB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsHidden { get; set; }
    }
}
