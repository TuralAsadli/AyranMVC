using AynarMVC.Models.Base;

namespace AynarMVC.Models
{
    public class Position : BaseItem
    {
        public string PositionName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
