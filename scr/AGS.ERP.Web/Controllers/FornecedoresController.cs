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
    public class FornecedoresController : Controller
    {
        private readonly IFornecedorAppService _fornecedorAppService;

        public FornecedoresController(IFornecedorAppService fornecedorAppService)
        {
            _fornecedorAppService = fornecedorAppService;
        }

        // GET: Fornecedores
        public IActionResult Index()
        {
            return View(_fornecedorAppService.GetAll());
        }

        // GET: Fornecedores/Details/5
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = _fornecedorAppService.GetById(id);
                
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // GET: Fornecedores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fornecedores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FornecedorViewModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                _fornecedorAppService.Add(fornecedor);
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedor);
        }

        // GET: Fornecedores/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = _fornecedorAppService.GetById(id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return View(fornecedor);
        }

        // POST: Fornecedores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, FornecedorViewModel fornecedor)
        {
            if (id != fornecedor.FornecedorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _fornecedorAppService.Update(fornecedor);                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FornecedorExists(fornecedor.FornecedorId))
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
            return View(fornecedor);
        }

        // GET: Fornecedores/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = _fornecedorAppService.GetById(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // POST: Fornecedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var fornecedor = _fornecedorAppService.GetById(id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            _fornecedorAppService.Remove(id);

            return RedirectToAction(nameof(Index));
        }

        private bool FornecedorExists(int id)
        {
            return !(_fornecedorAppService.GetById(id).FornecedorId.ToString() == string.Empty);

        }
    }
}
