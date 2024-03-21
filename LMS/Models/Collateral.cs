using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class Collateral
    {
        public int CollateralId { get; set; }
        public string CollateralCode { get; set; }
        public string OwnerName { get; set; }
        public string OwnerNationalCardNumber { get; set; }
        public int CollateralTypeId { get; set; }
        public string CollateralDescription { get; set; }
    }
}
