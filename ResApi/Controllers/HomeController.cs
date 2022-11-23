using Microsoft.AspNetCore.Mvc;
using ResApi.Models;
using System.Diagnostics;

namespace ResApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> SaveFiletoProject(IFormFile file)
        {
            var fileName = "imm5669e.pdf";
            string path = Path.Combine(_hostEnvironment.WebRootPath, "/Images/") + fileName;
           // string wwwRootPath = _hostEnvironment.WebRootPath;
           // string path = Path.Combine(wwwRootPath + "/Images/", file.FileName);
           // if (!Directory.Exists(path))
           // {
           //     Directory.CreateDirectory(Path.GetDirectoryName(path));
           // }

            //// var res= Directory.CreateDirectory(Path.GetDirectoryName(path));
            // using (var fileStream = new FileStream(path, FileMode.Create))
            // {
            //     await file.CopyToAsync(fileStream);
            // }

            return View();
        }

    }
}