using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsHidden { get; set; }
    }
}
