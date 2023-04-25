using SimpleCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleCalculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }
        [HttpPost]

        public ActionResult Index(calc c, string claculate)
        {
            if(claculate == "add") 
            {
                c.Totalnumber = c.number1 + c.number2;
            }

            else if (claculate =="min")
            {
                c.Totalnumber = c.number1 - c.number2;

            }
            else if (claculate == "mul")
            {
                c.Totalnumber = c.number1 * c.number2;

            }
            else if (claculate == "cle")
            {
                c.number1 = 0;
                c.number2=0;
                c.Totalnumber = 0;

            }
            else 
            {
                try
                {
                    c.Totalnumber = c.number1 / c.number2;
                }
                catch (Exception e) 
                {
                    Response.Write("<script>alert('OOPS !!!')</script>");
                }
                
                

            }

            return View(c);
        }

    }
}