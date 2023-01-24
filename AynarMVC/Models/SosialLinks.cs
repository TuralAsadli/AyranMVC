using AynarMVC.Models.Base;

namespace AynarMVC.Models
{
    public class SosialLinks :BaseItem
    {
        public string Link { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
