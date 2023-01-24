using AynarMVC.Interfaces.Repositories;
using AynarMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AynarMVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class MenuController : Controller
    {
        IBaseRepository<Employee> _em;

        public MenuController(IBaseRepository<Employee> em)
        {
            _em = em;
        }

        
        public IActionResult Index()
        {
            
            return View(_em.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
