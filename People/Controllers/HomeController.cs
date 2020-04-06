using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using People.Data;
using People.Models;

namespace People.Controllers
{
    public class HomeController : Controller
    {
        private string _connection=@"Data Source=.\sqlexpress;Initial Catalog=People;Integrated Security=True";
        public IActionResult Index()
        {   
            Peopledb db = new Peopledb(_connection);
            return View(db.ShowAllPeople());
            
        }
        public IActionResult AddPeople()
        {
            return View();
        }
        public IActionResult AddMorePeople(List<Person> people)
        {
            Peopledb db = new Peopledb(_connection);
            db.AddPeople(people);
            return Redirect("/");

        }

    }
}
