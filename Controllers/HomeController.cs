using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using CVWebApp.Data;
using CVWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace CVWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GalleryDbContext _context;

        public HomeController(ILogger<HomeController> logger, GalleryDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var pictures = await _context.Pictures.ToListAsync();
            if (pictures.Count > 0)
            {
                return View(pictures);
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        [Route("api/getpictures")]
        public async Task<IActionResult> GetPicturesAPI()
        {
            var pictures = await _context.Pictures.ToListAsync();
            if (pictures.Count > 0)
            {
                return Ok(pictures);
            }
            else
            {
                return Ok("Gallery is empty");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Index(Picture picture, [FromForm] IFormFile file)
        {
            if (file == null || file.Length <= 0 || string.IsNullOrEmpty(file.FileName))
            {
                return View(picture);
            }

            if (!ModelState.IsValid)
            {
                return View(picture);
            }

            var path = Path.Combine("wwwroot", file.FileName);
            using (var stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                await file.CopyToAsync(stream);
            }
            picture.PictureUrl = path;
            _context.Pictures.Add(picture);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [Route("api/uploadpictures")]
        public async Task<IActionResult> UploadPhoto(Picture picture, [FromForm] IFormFile file)
        {
            if (file == null || file.Length <= 0 || string.IsNullOrEmpty(file.FileName))
            {
                return Ok(picture);
            }

            if (!ModelState.IsValid)
            {
                return Ok(picture);
            }

            var path = Path.Combine("wwwroot",file.FileName);
            using(var stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                await file.CopyToAsync(stream);
            }
            picture.PictureUrl = path;
            _context.Pictures.Add(picture);
            await _context.SaveChangesAsync();

            return Ok("Picture Uploaded");
        }
    }
}
