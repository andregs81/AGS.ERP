using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AGS.ERP.Domain.Entities;
using AGS.ERP.Infra.Data.Context;
using AGS.ERP.Application.Interfaces;
using AGS.ERP.Application.ViewModel;

namespace AGS.ERP.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteAppService _clienteAppService;
        private readonly IEstadoAppService _estadoAppService;
        private readonly ICidadeAppService _cidadeAppService;

        public ClienteController(IClienteAppService clienteAppService,
                                 IEstadoAppService estadoAppService,
                                 ICidadeAppService cidadeAppService)
        {
            _clienteAppService = clienteAppService;
            _estadoAppService = estadoAppService;
            _cidadeAppService = cidadeAppService;
        }

        // GET: Cliente
        public IActionResult Index()
        {
            return View(_clienteAppService.GetAll());
        }

        // GET: Cliente/Details/5
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = _clienteAppService.GetById(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Cliente/Create
        public IActionResult Create()
        {
            ViewBag.UF = new SelectList(_estadoAppService.GetAll().OrderBy(e => e.UF), "UF", "Nome");
            ViewBag.CidadeId = new SelectList(_cidadeAppService.GetAll().OrderBy(e => e.UF), "CidadeId", "Nome");
            ViewBag.TipoEndereco = new SelectList(Enum.GetValues(typeof(TipoEnderecoViewModel)));
            return View();
        }

        // POST: Cliente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClienteEnderecoViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                
                _clienteAppService.Add(cliente);
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Cliente/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = _clienteAppService.GetById(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Cliente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ClienteViewModel cliente)
        {
            if (id != cliente.ClienteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _clienteAppService.Update(cliente);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.ClienteId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Cliente/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = _clienteAppService.GetById(id);
                
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var cliente = _clienteAppService.GetById(id);
            _clienteAppService.Remove(cliente);
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            //TODO: Melhorar metodo
            return !string.IsNullOrEmpty(_clienteAppService.GetById(id).ClienteId.ToString());
        }

        public JsonResult GetStateByCity(int idCidade)
        {
            var estado = _estadoAppService.GetByUF(_cidadeAppService.GetById(idCidade).UF);
            return Json(estado);
        }
    }
}
