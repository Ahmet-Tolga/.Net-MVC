
using Microsoft.AspNetCore.Mvc;
using ContactFormApp.Models;
using ContactFormApp.Data;

namespace ContactFormApp.Controllers
{
    public class ContactFormController : Controller
    {
        private readonly AppDbContext _context;

        public ContactFormController(AppDbContext context)
        {
            _context = context;
        }

        // Formun gösterildiği sayfa
        public IActionResult Index()
        {
            return View();
        }

        // Form gönderildiğinde çalışacak aksiyon
        [HttpPost]
        public IActionResult Submit(ContactForm model)
        {
            if (ModelState.IsValid)
            {
                _context.ContactForms.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Success");
            }

            return View("Index", model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
