using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HashMapWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HashTab(int size)
        {            
            Hashtable hashtable = new Hashtable();

            hashtable[1] = "Pierwszy";
            hashtable[2] = "Drugi";
            hashtable[size-1] = "Prawie Ostatni";

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("HashTable [" + entry.Key + "] " + entry.Value);
            }
            stopwatch.Stop();
            
            ViewBag.Time = stopwatch.Elapsed;

            return View();
        }

        public ActionResult JustTab(int size)
        {
            String[] table = new String[size];

            table[1] = "Pierwszy";
            table[2] = "Drugi";
            table[size - 1] = "Prawie ostatni";

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < table.Count(); i++)
            {
                Console.WriteLine("Tab [" + i + "] " + table[i]);

            }
            stopwatch.Stop();

            ViewBag.Time = stopwatch.Elapsed;

            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}