using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AGS.ERP.Application.Interfaces;
using AGS.ERP.Application.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AGS.ERP.Web.Controllers
{
    public class EnderecoController : Controller
    {
        private readonly IEnderecoAppService _enderecoAppService;
        private readonly IEstadoAppService _estadoAppService;
        private readonly ICidadeAppService _cidadeAppService;

        public EnderecoController(
            IEnderecoAppService enderecoAppService,
            IEstadoAppService estadoAppService,
            ICidadeAppService cidadeAppService
            )
        {
            _enderecoAppService = enderecoAppService;
            _cidadeAppService = cidadeAppService;
            _estadoAppService = estadoAppService;

        }


        public ActionResult CreateEnderecoCliente()
        {
            ViewBag.UF = new SelectList(_estadoAppService.GetAll().OrderBy(e => e.UF), "UF", "Nome");
            ViewBag.CidadeId = new SelectList(_cidadeAppService.GetAll().OrderBy(e => e.UF), "CidadeId", "Nome");
            ViewBag.TipoEndereco = new SelectList(Enum.GetValues(typeof(TipoEnderecoViewModel)));

            return PartialView();
        }

        [HttpPost]
        public ActionResult CreateEnderecoCliente(ClienteEnderecoViewModel clienteEndereco)
        {
            if (ModelState.IsValid)
            {
                if (clienteEndereco.EnderecoId == 0)
                    _enderecoAppService.Add(clienteEndereco);
                else
                    _enderecoAppService.Update(clienteEndereco);

            }

            return Json(new { EnderecoId = clienteEndereco.EnderecoId, ClienteId = clienteEndereco.ClienteId });
        }

        public ActionResult EditEnderecoCliente(int id)
        {
            var endereco = _enderecoAppService.GetById((int)id);

            if (endereco == null)
            {
                return NotFound();
            }


            ViewBag.UF = new SelectList(_estadoAppService.GetAll().OrderBy(e => e.UF), "UF", "Nome");
            ViewBag.CidadeId = new SelectList(_cidadeAppService.GetAll().OrderBy(e => e.UF), "CidadeId", "Nome");
            ViewBag.TipoEndereco = new SelectList(Enum.GetValues(typeof(TipoEnderecoViewModel)));

            return PartialView(endereco);
        }


        // GET: Endereco
        public ActionResult ListaEnderecoCliente(int? idCliente)
        {
            if (idCliente == null)
            {
                return NotFound();
            }


            var enderecoCliente = _enderecoAppService.ObterEnderecoPorCliente((int)idCliente);
            return PartialView(enderecoCliente);
        }

        // GET: Endereco
        public IActionResult ObterEndereco(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            ViewBag.UF = new SelectList(_estadoAppService.GetAll().OrderBy(e => e.UF), "UF", "Nome");
            ViewBag.CidadeId = new SelectList(_cidadeAppService.GetAll().OrderBy(e => e.UF), "CidadeId", "Nome");
            ViewBag.TipoEndereco = new SelectList(Enum.GetValues(typeof(TipoEnderecoViewModel)));

            var enderecoCliente = _enderecoAppService.GetById((int)id);

            return Json(enderecoCliente);
            //return PartialView("_EnderecoCliente", enderecoCliente);
        }


        // GET: Endereco
        public ActionResult Index()
        {
            return View();
        }

        // GET: Endereco/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Endereco/NovoEnderecoCliente
        public ActionResult EnderecoCliente()
        {
            ViewBag.UF = new SelectList(_estadoAppService.GetAll().OrderBy(e => e.UF), "UF", "Nome");
            ViewBag.CidadeId = new SelectList(_cidadeAppService.GetAll().OrderBy(e => e.UF), "CidadeId", "Nome");
            ViewBag.TipoEndereco = new SelectList(Enum.GetValues(typeof(TipoEnderecoViewModel)));

            return PartialView();
        }

        // POST: Endereco/Create
        [HttpPost]
        public ActionResult AddOrUpdateEnderecoCliente(ClienteEnderecoViewModel enderecoCliente)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    if (enderecoCliente.EnderecoId > 0)
                        return Json(new { update = "Update" }); // TODO: Implementar o Update
                    else
                        _enderecoAppService.Add(enderecoCliente);

                }
                return Json(new { EnderecoId = enderecoCliente.EnderecoId });
            }
            catch
            {
                return Json(new { EnderecoId = 0 });
            }
        }

        // GET: Endereco/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Endereco/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClienteEnderecoViewModel clienteEndereco)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Endereco/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Endereco/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}