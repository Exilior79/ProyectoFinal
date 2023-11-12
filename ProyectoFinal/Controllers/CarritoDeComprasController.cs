using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Context;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class CarritoDeComprasController : Controller
    {
        private readonly AutoServicioDatabaseContext _context;

        public CarritoDeComprasController(AutoServicioDatabaseContext context)
        {
            _context = context;
        }

        // GET: CarritoDeCompras
        public async Task<IActionResult> Index()
        {
              return _context.CarritoDeCompra_1 != null ? 
                          View(await _context.CarritoDeCompra_1.ToListAsync()) :
                          Problem("Entity set 'AutoServicioDatabaseContext.CarritoDeCompra_1'  is null.");
        }

        // GET: CarritoDeCompras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CarritoDeCompra_1 == null)
            {
                return NotFound();
            }

            var carritoDeCompra = await _context.CarritoDeCompra_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carritoDeCompra == null)
            {
                return NotFound();
            }

            return View(carritoDeCompra);
        }

        // GET: CarritoDeCompras/Create
        public IActionResult Create()
        {
            // Obtener la lista de clientes y productos desde la base de datos
            var clientes = _context.Clientes.ToList();
            var productos = _context.Productos.ToList();

            // Agregar mensajes de registro
            Console.WriteLine($"Número de clientes: {clientes.Count}");
            Console.WriteLine($"Número de productos: {productos.Count}");

            // Pasa los datos a la vista
            ViewBag.Clientes = new SelectList(clientes, "Id", "dni");
            ViewBag.Productos = new SelectList(productos, "Id", "nombreProducto");

            return View();
        }

        // POST: CarritoDeCompras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClienteId,ProductosIds")] CarritoDeCompra carritoDeCompra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carritoDeCompra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carritoDeCompra);
        }

        // GET: CarritoDeCompras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CarritoDeCompra_1 == null)
            {
                return NotFound();
            }

            var carritoDeCompra = await _context.CarritoDeCompra_1.FindAsync(id);
            if (carritoDeCompra == null)
            {
                return NotFound();
            }
            return View(carritoDeCompra);
        }

        // POST: CarritoDeCompras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClienteId,ProductosIds")] CarritoDeCompra carritoDeCompra)
        {
            if (id != carritoDeCompra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carritoDeCompra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarritoDeCompraExists(carritoDeCompra.Id))
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
            return View(carritoDeCompra);
        }

        // GET: CarritoDeCompras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CarritoDeCompra_1 == null)
            {
                return NotFound();
            }

            var carritoDeCompra = await _context.CarritoDeCompra_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carritoDeCompra == null)
            {
                return NotFound();
            }

            return View(carritoDeCompra);
        }

        // POST: CarritoDeCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CarritoDeCompra_1 == null)
            {
                return Problem("Entity set 'AutoServicioDatabaseContext.CarritoDeCompra_1'  is null.");
            }
            var carritoDeCompra = await _context.CarritoDeCompra_1.FindAsync(id);
            if (carritoDeCompra != null)
            {
                _context.CarritoDeCompra_1.Remove(carritoDeCompra);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarritoDeCompraExists(int id)
        {
          return (_context.CarritoDeCompra_1?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        /*private Cliente ObtenerClientePorId(int clienteId)
        {
            return _context.Clientes.FirstOrDefault(c => c.Id == clienteId);
        }*/
    }
}
