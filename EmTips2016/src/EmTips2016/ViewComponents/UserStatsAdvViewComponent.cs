using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using EmTips2016.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EmTips2016.ViewComponents
{
    public class UserStatsAdvViewComponent : ViewComponent
    {
        DataManager dataManager;

        public UserStatsAdvViewComponent(EmDbContext context)
        {
            this.dataManager = new DataManager(context);
        }

        public IViewComponentResult Invoke(string username)
        {
            var model = dataManager.GetStatsForSpecificUserAdv(username);
            return View(model);
        }
    }
}
