using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Web;
using SCGREEN_Web_Union.com.Models;
using System.Web.Routing;



namespace SCGREEN_Web_Union.com.Controllers
{
    public class FamilyController : Controller
    {
        List<Family> families;

        public FamilyController()
        {
            families = new List<Family>
            {
                new Family() { id=0, familyname = "Madeira", address1 = "123 Hastings Dr", city = "Cranberry Township", state = "PA", zip = "16066", homephone = "7247797964" },
                new Family() { id=1, familyname = "Johns", address1 = "3200 College Ave", city = "Beaver Falls", state = "PA", zip = "15010", homephone = "7248461298" },
                new Family() { id=2, familyname = "Ellis", address1 = "1 Sycamore Hollow", city = "Pittsburgh", state = "PA", zip = "15212", homephone = "4122371212" },
                new Family() { id=3, familyname = "Braddock", address1 = "23 Livingstone Dr", city = "Monroeville", state = "PA", zip = "15010", homephone = "4123277486" }
            };


        }

        
        

       // //GET: Family/Details/5
       public ActionResult Details(int id) //(int id)
        {
            var f = families[id];

            return View(f);
        }
        public ActionResult Edit()
        {   
            return View();
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            if (Session["FamilyList"] == null)
            {
                Session["FamilyList"] = families; //families
            }
        }

        // GET: Person
        public ActionResult Index()
        {
            var p = (List<Family>)Session["FamilyList"];
            return View(p);
        }
        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Family newFamily = new Family()
                {
                    
                    familyname = collection["familyname"],
                    address1 = collection["address1"],
                    city = collection["city"],
                    state = collection["state"],
                    zip = collection["zip"],
                    homephone = collection["homephone"]                   
                };

                // Add the person to the list
                families = (List<Family>)Session["FamilyList"];
                families.Add(newFamily);

                // Save the list to the session
                Session["FamilyList"] = families;

                return RedirectToAction("index");
            }

            catch
            {
                return View();
            }

        }
       // // GET: Person/Details/5
       // public ActionResult details(int id) 
        //{
            // Get the list of people from the session
            //var pList = (List<Family>)Session["FamilyList"];

            // Get the person with the passed in ID
           // var p = pList[id]; //

           // var f = families[id];

            //    return View(f);

            // Return the person data to the view
           // return View(p);
            
       // }
    }

}
    