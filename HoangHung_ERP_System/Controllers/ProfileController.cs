using System;
using System.Collections.Generic;
using System.Web.Mvc;
using HoangHung_ERP_System.Data;
using HoangHung_ERP_System.ViewModels;

namespace HoangHung_ERP_System.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {

            var repo = new HRWorldsRepository();
            var hrworldList = repo.GetHRWorlds();
            return View(hrworldList);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            var repo = new HRWorldsRepository();
            var hrworld = repo.CreateHRWorld();
            return View(hrworld);
        }


        [HttpGet]
        public ActionResult GetCities()
        {
         
                var repo = new CitiesRepository();

                IEnumerable<SelectListItem> cities = repo.GetCities();

                return Json(cities, JsonRequestBehavior.AllowGet);
            
            return null;
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "NameUngVien,NgaySinh")] HRWorldEditViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var repo = new HRWorldsRepository();
                    bool saved = repo.SaveHRWorld(model);
                    if (saved)
                    {
                        return RedirectToAction("Index");
                    }
                }

                throw new ApplicationException("Invalid model");

            }
            catch (ApplicationException ex)
            {
                throw ex;
            }
        }
    }
}