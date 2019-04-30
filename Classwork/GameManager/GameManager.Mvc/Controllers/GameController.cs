using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameManager.Sql;

namespace GameManager.Mvc.Controllers
{
    public class GameController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var db = GetDatabase();

            var games = db.GetAll();

            return View(games);
            // return Json(games, JsonRequestBehavior.AllowGet);
        }

        private static SqlGameDatabase GetDatabase()
        {
            var connString = ConfigurationManager.ConnectionStrings["database"];
            var db = new SqlGameDatabase(connString.ConnectionString);
            return db;
        }

        public ActionResult Create()
        {
            return View(new Game());
        }

        public ActionResult Edit(int id)
        {
            var db = GetDatabase();
            var game = db.Get(id);
            if (game == null)
                return HttpNotFound();

            return View(game);
        }


        [HttpPost]
        public ActionResult Create(Game model)
        {
            var db = GetDatabase();

            var game = db.Add(model);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Game model)
        {
            var db = GetDatabase();
            var game = db.Get(model.Id);

            //game.Name = model.Name;
            //game.Description = model.Description;
            //game.Completed = model.Completed;
            //game.Owned = model.Owned;
            //game.Price = model.Price;

            db.Update(model.Id, model);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(Game model)
        {
            var db = GetDatabase();
            var game = db.Get(model.Id);

            db.Delete(model.Id);

            return RedirectToAction("Index");
        }

        public ActionResult Delete (int id)
        {
            var db = GetDatabase();
            var game = db.Get(id);
            if (game == null)
                return HttpNotFound();

            return View(game);
        }
    }
}