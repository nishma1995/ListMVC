using ListMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Person> personList = new List<Person>();

            Person person1 = new Person();
            person1.Id = 1;
            person1.Name = "nishma";

            Person person2 = new Person();
            person2.Id = 2;
            person2.Name = "Manu";

            Person person3 = new Person();
            person3.Id = 3;
            person3.Name = "jithu";
            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);


            //ViewBag.personList = personList;
            return View(personList);
        }
    }
}