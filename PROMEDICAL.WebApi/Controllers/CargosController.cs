using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROMEDICAL.Business.Extensions;
using System.Threading.Tasks;

namespace PROMEDICAL.WebApi.Controllers
{
    public class CargosController : Controller
    {
        // GET: CargosController
        public ActionResult Index()
        {
            return View();
        }

        public async Task<object> ListAsync()
        {
            var result = new ApiServiceResult();

            return result.Data;
        }
        // GET: CargosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CargosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CargosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CargosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CargosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CargosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CargosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
