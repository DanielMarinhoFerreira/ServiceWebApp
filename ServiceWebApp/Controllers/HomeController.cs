using Microsoft.AspNetCore.Mvc;
using ServiceClient;
using ServiceWebApp.ViewModels;
using System.ServiceModel;

namespace ServiceWebApp.Controllers
{
    public class HomeController(ILogger<HomeController> logger) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly UsuarioClient _client = new();

        public async Task<IActionResult> Index()
        {
            var service = await _client.ReadAllAsync();

            return View(new ViewUsuarioDto()
            {
                Usuarios = service.ToList(),
            });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteUsuario(string Id)
        {
            try
            {
                var result = await _client.DeleteAsync(int.Parse(Id));
            }
            catch (FaultException ex)
            {
                TempData["MensagemErro"] = $"{ex.Message}";
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
