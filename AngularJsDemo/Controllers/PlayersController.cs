﻿using AngularJsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJsDemo.Controllers
{
    public class PlayersController : Controller
    {
        // GET: Players
        public ActionResult Index()
        {
            return View("Index2");
        }
        public JsonResult GetAllPlayers()
        {
            using (NBAEntities nba = new NBAEntities())
            {
                var players = nba.Players.ToList();
                return Json(players, JsonRequestBehavior.AllowGet);
            }
        }
    }
}