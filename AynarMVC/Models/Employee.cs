using AynarMVC.Models.Base;

namespace AynarMVC.Models
{
    public class Employee : BaseItem
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public string ImgPath { get; set; }

        public List<SosialLinks> SosialLinks { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
