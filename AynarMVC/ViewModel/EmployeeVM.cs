using System.ComponentModel.DataAnnotations.Schema;

namespace AynarMVC.ViewModel
{
    public class EmployeeVM : BaseVM
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public int PositionId { get; set; }

        public ICollection<int> SosialLinks { get; set; }

        [NotMapped]
        public IFormFile Img { get; set; }
    }
}
