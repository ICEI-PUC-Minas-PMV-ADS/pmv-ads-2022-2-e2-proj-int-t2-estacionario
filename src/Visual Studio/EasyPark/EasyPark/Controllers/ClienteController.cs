using EasyPark.EasyPark.Domain.Interface.Repositorys;
using EasyPark.EasyPark.Domain.Interface.Services;
using EasyPark.EasyPark.Domain.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EasyPark.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly IUtilidadesRepository _utilidadesRepository;

        public ClienteController(IClienteService clienteService, IUtilidadesRepository utilidadesRepository)
        {
            _clienteService = clienteService;
            _utilidadesRepository = utilidadesRepository;
        }

        [Authorize]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AplicaFiltro(BuscaRequest buscaRequest)
        {
            ObterNomeUsuarioLogado();
            var realizaBusca = _clienteService.FiltroBuscaGeral(buscaRequest).Result;
            return View(realizaBusca);
        }

        public IActionResult FiltroBuscaGeral()
        {
            ObterNomeUsuarioLogado();
            var recuperaEstado = new BuscaRequest();
            recuperaEstado.estados = _utilidadesRepository.GetEstados();
            return View(recuperaEstado);
        }

        [Authorize]
        public async Task<IActionResult> Pesquisa(string Busca)
        {
            ObterNomeUsuarioLogado();
            var realizaBusca = _clienteService.BuscaServicosAsync(Busca).Result;
            ViewBag.Pesquisa = Busca;
            return View(realizaBusca);
        }

        [Authorize]
        public IActionResult VerServico()
        {
            ObterNomeUsuarioLogado();
            //passa como parametro a quantidade de registro a ser retornado. 0 retorna todos os registros.
            var geraVitrine = _clienteService.ExibirServicosVitrinePrincipalAsync(0).Result;
            return View(geraVitrine);
                    }

        [Authorize]
        public IActionResult Index()
        {
            ObterNomeUsuarioLogado();
            //passa como parametro a quantidade de registro a ser retornado. 0 retorna todos os registros.
            var geraVitrine = _clienteService.ExibirServicosVitrinePrincipalAsync(2).Result;
            return View(geraVitrine);
        }



        public void ObterNomeUsuarioLogado()
        {
            var obtemNomeUsuarioLogado = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
            ViewData["NomeUsuarioLogado"] = obtemNomeUsuarioLogado;

        }


    }
}
