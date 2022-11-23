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
    public class EmpresaController : Controller
    {

        private readonly IEstacionamentoService _estacionamentoService;

        public EmpresaController(IEstacionamentoService estacionamentoService)
        {
            _estacionamentoService = estacionamentoService;
        }

        [Authorize]
        public async Task<IActionResult> RemoverEstacionamento(int id)
        {
            _estacionamentoService.RemoverEstacionamento(id);
            return RedirectToAction("StatusRemocao");
        }

        [Authorize]
        public IActionResult StatusRemocao()
        {
            ObterNomeUsuarioLogado();
            return View();
        }

        [Authorize]
        public async Task<IActionResult> AtualizarEstacionamento(int id)
        {
            ObterNomeUsuarioLogado();
            ViewBag.UsuarioIdLogadoEmpresa = ObterIdUsuarioLogado();
            var recuperaEstacionamento = _estacionamentoService.GeraEstacionamentoByIdAsync(id).Result;

            return View(recuperaEstacionamento);
        }

        [Authorize]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> EfetivarAlteracaoEstacionamento(EstacionamentoResponse estacionamentoResponse)
        {
            TempData["NomeEstacionamentoAlterado"] = estacionamentoResponse.NomeEstacionamento;
            _estacionamentoService.AtualizarEstacionamento(estacionamentoResponse);
            return RedirectToAction("StatusAlteracaoEstacionamento");
        }

        public IActionResult StatusAlteracaoEstacionamento()
        {
            ObterNomeUsuarioLogado();
            ViewBag.NomeEstacionamentoAlterado = TempData["NomeEstacionamentoAlterado"];
            return View();
        }


        [Authorize]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> EfetivarCadastroEstacionamento(EstacionamentoRequest estacionamentoRequest)
        {
            TempData["NomeEstacionamentoCriado"] = estacionamentoRequest.NomeEstacionamento;
            _estacionamentoService.CriarEstacionamento(estacionamentoRequest);
            return RedirectToAction("EstacionamentoCriado");
        }

        [Authorize]
        public IActionResult EstacionamentoCriado()
        {
            ViewBag.NomeEstacionamentoCriado = TempData["NomeEstacionamentoCriado"];
            return View();
        }

        [Authorize]
        public async Task<IActionResult> GerenciarEstacionamento()
        {
            var preparaEstacionamentosCadastrados = _estacionamentoService.GeraListaEstacionamento(ObterIdUsuarioLogado()).Result;
            return View(preparaEstacionamentosCadastrados);
        }

        [Authorize]
        public IActionResult CadastrarEstacionamento()
        {
            ObterNomeUsuarioLogado();
            ViewBag.UsuarioIdLogadoEmpresa = ObterIdUsuarioLogado();
                        var preparaListaEstadoParaRequest= new EstacionamentoRequest();
            preparaListaEstadoParaRequest.estados = _estacionamentoService.ObterEstados().Result;
            
            
            return View(preparaListaEstadoParaRequest);
        }

        [Authorize]
        public IActionResult Index()
        {
            ObterNomeUsuarioLogado();
            return View();
        }



        public void ObterNomeUsuarioLogado()
        {
            var obtemNomeUsuarioLogado = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
            ViewData["NomeUsuarioLogadoEmpresa"] = obtemNomeUsuarioLogado;

        }

        public int ObterIdUsuarioLogado()
        {
            var obtemIdUsuario = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Hash).Value;
            return int.Parse(obtemIdUsuario);
        }


    }
}
