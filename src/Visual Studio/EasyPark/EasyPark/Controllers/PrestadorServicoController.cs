using EasyPark.EasyPark.Domain.Interface.Services;
using EasyPark.EasyPark.Domain.Requests;
using EasyPark.EasyPark.Domain.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EasyPark.Controllers
{

    public class PrestadorServicoController : Controller
    {
        private readonly IPrestadorServicosServices _prestadorServicosServices;

        public PrestadorServicoController(IPrestadorServicosServices prestadorServicosServices)
        {
            _prestadorServicosServices = prestadorServicosServices;
        }

        [Authorize]
        public IActionResult Index()
        {
            ObterNomeUsuarioLogado();
            
            return View();
        }

        [Authorize]
        public IActionResult PrestadorServico()
        {
            ObterNomeUsuarioLogado();
            var carregaListaEstados = new PrestadorServicosRequest();
            var obtemListaEstadosAtuacao = _prestadorServicosServices.ObterEstados().Result;

            carregaListaEstados.estados = obtemListaEstadosAtuacao;
                ViewBag.UsuarioIdLogado = ObterIdUsuarioLogado();
            return View(carregaListaEstados);
        }

        [Authorize]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> CriarServicos(PrestadorServicosRequest prestadorServicosRequest)
        {
            _prestadorServicosServices.CriarServicos(prestadorServicosRequest);
            
            TempData["NomeServicoCriado"]= prestadorServicosRequest.NomeServico;
            return RedirectToAction("ServicoCriado");
        }

        [Authorize]
        public async Task<IActionResult> ServicoCriado()
        {
            ViewBag.NomeServicoCriado = TempData["NomeServicoCriado"];
            return View();
        }

[Authorize]
        public async Task<IActionResult> GerenciarServico()
        {
            var servicos = _prestadorServicosServices.GeraServicos(ObterIdUsuarioLogado()).Result;
            return View(servicos);
        }

        [Authorize]
        public IActionResult DeletarServico(int id)
        {
            _prestadorServicosServices.RemoverServico(id);
            return RedirectToAction("RemoverServico");
                    }

    [Authorize]
    public IActionResult RemoverServico()
                {
            return View();
        }

        public async Task<IActionResult> AtualizarServico(int id)
        {
            ViewBag.UsuarioIdLogado = ObterIdUsuarioLogado();
            var viewModelServicos = _prestadorServicosServices.GeraServicoViaId(id).Result;
                return View(viewModelServicos);
        }

        [Authorize]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> SalvarServico(PrestadorServicoResponse prestadorServicoResponse)
        {
            _prestadorServicosServices.AtualizarServico(prestadorServicoResponse);
            return RedirectToAction("GerenciarServico");
        }


        public void ObterNomeUsuarioLogado()
        {
            var obtemNomeUsuarioLogado=HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
            ViewData["NomeUsuarioLogado"] = obtemNomeUsuarioLogado;

        }

        public int ObterIdUsuarioLogado()
        {
            var obtemIdUsuario= HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Hash).Value;
            return int.Parse(obtemIdUsuario);
        }


    }
}
