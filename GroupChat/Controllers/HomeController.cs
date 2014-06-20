using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroupChat.Helpers;
using GroupChat.Models;

namespace GroupChat.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new HomeViewModel();
            model.RoomsList = RoomsHelper.GetCurrentRooms();
            return View(model);
        }

    }
}
