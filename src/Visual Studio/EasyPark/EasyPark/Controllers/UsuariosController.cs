using EasyPark.EasyPark.Domain.Interface.Services;
using EasyPark.EasyPark.Domain.Requests;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace EasyPark.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuariosService _usuariosSservice;

        public UsuariosController(IUsuariosService usuariosSservice)
        {
            _usuariosSservice = usuariosSservice;
        }


        public IActionResult NovoUsuario()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastrarNovoUsuario(UsuariosRequest usuariosRequest)
        {

            var cadastraUsuario = _usuariosSservice.CadastrarUsuario(usuariosRequest);

            if(cadastraUsuario.Result.CadastroExiste)
            {
                TempData["ContaExiste"] = cadastraUsuario.Result.CadastroExiste;
                TempData["ContaCriada"] = cadastraUsuario.Result.ContaCriada;
            }
            else
            {
                TempData["ContaCriada"] = cadastraUsuario.Result.ContaCriada;
                TempData["ContaExiste"] = cadastraUsuario.Result.CadastroExiste;
                TempData["Usuario"] = usuariosRequest.NomeUsuario;
            }

            return RedirectToAction("EfetivacaoCadastro");
        }

        public async Task<IActionResult> EfetivacaoCadastro()
        {
            if(TempData["ContaExiste"]!=null)
            {
                ViewBag.ContaExiste = TempData["ContaExiste"];
            }
            
                        if(TempData["ContaCriada"]!=null)
            {
                ViewBag.ContaCriada = TempData["ContaCriada"];
                ViewBag.Usuario = TempData["Usuario"];
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
public async Task<IActionResult> EfetivaLogin(UsuariosRequest usuariosRequest)
        {
            var autenticaUsuario = _usuariosSservice.PersistirLoginAsyinc(usuariosRequest).Result;

            if(autenticaUsuario==null)
                            return RedirectToAction("ErroAutenticacao");
            
            
            Claim nomeUsuario = new Claim(ClaimTypes.Name, autenticaUsuario.NomeUsuario);
            Claim usuarioId = new Claim(ClaimTypes.Hash, autenticaUsuario.UsuarioId.ToString());
            Claim nivelAcesso = new Claim(ClaimTypes.NameIdentifier, autenticaUsuario.NivelAcesso.ToString());

            IList<Claim> claims = new List<Claim>()
            {
                nomeUsuario,
                usuarioId,
                nivelAcesso
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "usuarios");

            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            HttpContext.SignInAsync(claimsPrincipal);
            HttpContext.User = claimsPrincipal;

            
            switch (autenticaUsuario.NivelAcesso)
            {
                case 1:
                    return RedirectToAction("index", "Cliente");
                    break;
                case 2:
                    return RedirectToAction("index", "PrestadorServico");
                    break;
                case 3:
                    return RedirectToAction("index", "Empresa");
            }

            return RedirectToAction("index", "ErroSolicitacao");
        }

        public IActionResult ErroAutenticacao()
        {
            return View();
        }

        public IActionResult Sair()
        {
            return RedirectToAction("index", "home");
        }
    }
}
