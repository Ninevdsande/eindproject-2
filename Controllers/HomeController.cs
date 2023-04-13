﻿using eindproject_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MySql.Data;
using eindproject_2.Database;

namespace eindproject_2.Controllers
{
   public class HomeController : Controller
    {
       private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          var huizen = GetAllHuizen();
            return View(huizen);    

         
        }
      
        
        public IActionResult Zoeken()
        {
            return View();
        }
        public IActionResult Contact()
        {
           return View();
        }
        [HttpPost]
        [Route("contact")]
       public IActionResult Contact(Person person)
        {
            if (ModelState.IsValid)
                DatabaseConnector.SavePerson(person);
            return Redirect("/Succes");
           return View(person);

        }
        public IActionResult Accommodaties()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<Huizen> GetAllHuizen()
        {
            var rows = DatabaseConnector.GetRows("select * from huizen");

            List<Huizen> huizen = new List<Huizen>();

            foreach (var row in rows)
            {
                Huizen h = new Huizen();
                h.naam = row["naam"].ToString();
                h.type = row["type"].ToString();
                h.locatie = row["locatie"].ToString();
                h.beschrijving_kort = row["beschrijving_kort"].ToString();
                h.beschrijving_lang = row["beschrijving_lang"].ToString();
                h.datum_begin = row["datum_begin"].ToString();
                h.datum_eind = row["datum_eind"].ToString();
                h.afbeelding = row["afbeelding"].ToString();
                h.prijs = row["prijs"].ToString();
                h.id = Convert.ToInt32(row["id"]);

                huizen.Add(h);  
            }

            return huizen;
        }
    }
}