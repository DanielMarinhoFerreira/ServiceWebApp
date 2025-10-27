using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceClient;
using ServiceWebApp.ViewModels;
using System.ServiceModel;

namespace ServiceWebApp.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioClient _client = new();


        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Cadastro(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return View(usuario);
            }
            else
            {
                try
                {
                    var result = await _client.CreateAsync(usuario);

                    return RedirectToAction("Index", "Home");

                }
                catch (FaultException ex)
                {
                    TempData["MensagemErro"] = $"{ex.Message}";
                }

                return View(usuario);
            }
        }


        [HttpGet]
        public async Task<IActionResult> EditableUsuario(string Id)
        {
            try
            {
                var result = await _client.ReadAsync(int.Parse(Id));

                return View(new UsuarioDto()
                {
                    Id = result.Body.ReadResult.Id,
                    Name = result.Body.ReadResult.Name,
                    Surname = result.Body.ReadResult.Surname,
                    Email = result.Body.ReadResult.Email,
                });

            }
            catch (FaultException ex)
            {
                TempData["MensagemErro"] = $"{ex.Message}";
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> EditableUsuario(Usuario usuario)
        {
            try
            {
                var result = await _client.UpdateAsync(usuario);
            }
            catch (FaultException ex)
            {
                TempData["MensagemErro"] = $"{ex.Message}";
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
