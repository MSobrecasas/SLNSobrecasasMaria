using Microsoft.AspNetCore.Mvc;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using System.Linq;

namespace SistemaWebMisRecetas.Controllers
{
	public class RecetaController : Controller
	{
		private readonly DBRecetasContext context;

		public RecetaController(DBRecetasContext context)
		{
			this.context = context;
		}

		//GET /Receta/Index
		[HttpGet]
		public IActionResult Index()
		{
			var operas = context.Recetas.ToList();
			return View(operas);
		}


		//GET /Receta/Create
		[HttpGet]
		public ActionResult Create()
		{
			Receta receta = new Receta();
			return View("Create", receta);
		}

		//POST /Receta/Create
		[HttpPost]
		public ActionResult Create(Receta receta)
		{
			if (ModelState.IsValid)
			{
				context.Recetas.Add(receta);
				context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(receta);
		}

		//GET Receta/Details/{id}
		[HttpGet]
		public ActionResult Details(int id)
		{
			var receta = TraerUna(id);

			if (receta == null)
			{
				return NotFound();
			}

			return View("Details", receta);
		}

		//GET Receta/GetByName/{name}
		[HttpGet]
		public ActionResult GetByName(string name, string lastname)
		{
			var recetas = (from r in context.Recetas
							 where r.Nombre == name &&
							 r.Apellido == lastname
							 select r).ToList();

			if (recetas == null)return NotFound();


			return View("GetByName", recetas);
		}


		//GET Receta/Edit/{id}
		[HttpGet]
		public ActionResult Edit(int id)
		{
			Receta receta = TraerUna(id);

			if (receta == null) return NotFound();

			return View("Edit", receta);

		}

		//POST Receta/Edit
		[HttpPost]
		public ActionResult Edit(Receta receta)
		{
			if (receta == null) return NotFound();

			context.Recetas.Update(receta);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		//GET Receta/Delete/{id}
		[HttpGet]
		public ActionResult Delete(int id)
		{
			var receta = TraerUna(id);

			if (receta == null) return NotFound();

			return View("Delete", receta);
		}

		//POST Receta/delete/{id}
		[ActionName("Delete")]
		[HttpPost]
		public ActionResult DeleteConfirmed(int id)
		{
			Receta receta = TraerUna(id);

			if (receta == null) return NotFound();

			context.Recetas.Remove(receta);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		private Receta TraerUna(int id)
		{
			return context.Recetas.Find(id);
		}
	}
}
