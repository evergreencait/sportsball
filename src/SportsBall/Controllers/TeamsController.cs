using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SportsBall.Models;
using Microsoft.EntityFrameworkCore;


namespace SportsBall.Controllers
{
    public class TeamsController : Controller
    {
        private SportsBallContext db = new SportsBallContext();
        public IActionResult Index()
        {
            return View(db.Teams.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisTeam = db.Teams.FirstOrDefault(Teams => Teams.TeamId == id);
            return View(thisTeam);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Team team)
        {
            db.Teams.Add(team);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisTeam = db.Teams.FirstOrDefault(teams => teams.TeamId == id);
            return View(thisTeam);
        }

        [HttpPost]
        public IActionResult Edit(Team team)
        {
            db.Entry(team).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
