using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using EmTips2016.ViewModels;
using EmTips2016.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EmTips2016.Controllers
{
    public class HomeController : Controller
    {
        DataManager dataManager;

        public HomeController(EmDbContext context)
        {
            this.dataManager = new DataManager(context);
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: /<controller>/
        public IActionResult Results()
        {
            return View();
        }

        public IActionResult PlaceBets()
        {
            //var model = dataManager.GetAdvanceTeams();
            return View();
        }

        [HttpPost]
        public JsonResult PlaceBets(BetViewModel[] items)
        {

            var status = dataManager.PlaceSomeBets(items);

            if (status == "success")
            {
                return Json("Ditt tips är inskickat!");
            }
            else
            {
                return Json("Användarnamnet var inte korrekt");
            }
        }

        public IActionResult PlaceAdvance()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlaceAdvance(AdvanceTeamVM viewModel)
        {
            var list = new List<string>();

            list.Add(viewModel.Albanien);
            list.Add(viewModel.Schweiz);
            list.Add(viewModel.Belgien);
            list.Add(viewModel.England);
            list.Add(viewModel.Frankrike);
            list.Add(viewModel.Irland);
            list.Add(viewModel.Island);
            list.Add(viewModel.Italien);
            list.Add(viewModel.Kroatien);
            list.Add(viewModel.Nordirland);
            list.Add(viewModel.Polen);
            list.Add(viewModel.Portugal);
            list.Add(viewModel.Rumänien);
            list.Add(viewModel.Ryssland);
            list.Add(viewModel.Slovakien);
            list.Add(viewModel.Spanien);
            list.Add(viewModel.Sverige);
            list.Add(viewModel.Tjeckien);
            list.Add(viewModel.Turkiet);
            list.Add(viewModel.Tyskland);
            list.Add(viewModel.Ukraina);
            list.Add(viewModel.Ungern);
            list.Add(viewModel.Wales);
            list.Add(viewModel.Österrike);

            var eight = list
                .Where(o => o == "Åttondelsfinal")
                .ToList();

            var quarter = list
                .Where(o => o == "Kvartsfinal")
                .ToList();

            var semifinal = list
                .Where(o => o == "Semifinal")
                .ToList();

            var final = list
                .Where(o => o == "Final")
                .ToList();

            var champ = list
                .Where(o => o == "Mästare")
                .ToList();

            var group = list
                .Where(o => o == "Gruppspel")
                .ToList();



            //Kolla så att rätt antal steg fått rätt antal lag
            if (group.Count != 8 || quarter.Count != 4 || eight.Count != 8 || semifinal.Count != 2 || final.Count != 1 || champ.Count != 1)
            {
                return View(viewModel);
            }
            else
            {
                dataManager.placeSomeAdvBets(viewModel);
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }          
        }



        public IActionResult AddUsers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUsers(UserVM user)
        {
            if (user.Password != "valarmorghulis")
            {
                return View(user);
            }
            else
            { 
            dataManager.CreateUser(user);
            return View();
            }
        }

        public IActionResult Leaderboard()
        {
            //var model = dataManager.GetLeaderBoard();
            //return View();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpPost]
        public JsonResult CalcStats(CalcResVM[] items)
        {
            //removing results from games that arent played yes eg. "-"
            items = items.Where(val => val.name.Length > 2).ToArray();

            dataManager.CalcStats(items);

            if (items != null)
            {
                return Json("success");
            }
            else
            {
                return Json("failed");
            }
        }

        [HttpPost]
        public JsonResult CalcAdv(CalcAdvVM[] items)
        {
            //items = items.Where(val => val.adv.Length > 2).ToArray();
            //if (items != null)
            //    dataManager.CalcAdvStats(items);

            
            return Json("sucess");
        }


        public IActionResult UserStats(int id)
        {
            var model = dataManager.GetStatsForSpecificUser(id);
            if (model != null)
            {
                return View(model);

            }
            else
            {
                return View();
            }
        }

        public IActionResult Rules()
        {
            return View();
        }






    }
}
