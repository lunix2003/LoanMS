

namespace LMS.Models
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsHidden { get; set; }
        public int IsLog { get; set; } = 0;
        public string UserType { get; set; }
    }
}
