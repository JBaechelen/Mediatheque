using Mediatheque.Dal;
using Mediatheque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Mediatheque.Controllers
{
    public class HomeController : Controller
    {
        GameContext gc = new GameContext();

        // GET: Home
        public ViewResult Index(string id) //les parametre doit s'appeller id par defaut, voir dans route config pour changement
        {
            if (id == null)
            {
                return View(gc.Games.ToList());
            }
            return View(gc.Games.ToList().Where(x => x.Categorie == id));
        }

        public ActionResult Info(int id)
        {
            Games g = GameContext.Context.Games.Find(id);
            return View(g);
        }
    }
}