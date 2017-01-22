using Procore.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Procore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Number model)
        {
            int num = model.number;            
            ArrayList Primes_List = new ArrayList();
            if(num==0 || num==1 || num > int.MaxValue)
            {
                TempData["count"] = "Enter a valid positive integer (greater than 1)";
                return RedirectToAction("Index");
            }
            Primes_List.Add(2);
            for (int i=3;i<=num;i=i+2)
            {
                Primes_List.Add(i);
            }

            for(int i=2;i<=num;i++)
            {
                for (int j = i*i; j <= num; j = j + i)
                {
                        Primes_List.Remove(j);
                }
            }
            //to format the display of the number num
            String s = "";
            foreach(var item in Primes_List)
            {
                s = s +", "+ item;
            }
            TempData["count"] = "Number of primes is " + Primes_List.Count.ToString();
            TempData["primelist"] = "Primes List for "+ num + " is : "+ s.Substring(1);
            return RedirectToAction("Index");
        }
    }
}