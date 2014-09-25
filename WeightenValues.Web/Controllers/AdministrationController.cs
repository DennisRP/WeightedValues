using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeightenValues.Web.Models;
using WeightenValues.Repository;
using WeightenValues.Repository.Interfaces;

namespace WeightenValues.Web.Controllers
{
    public class AdministrationController : Controller
    {
        // GET: Administration
        public ActionResult Index()
        {
            // #todo This is not good. We need to add a BLL inbetween our repository and web,
            // but this will be postponed to a refactoring process (yeah, right ..)
            IRepository repository = new SQLRepository();            

            var model = new WeightedValuesViewModel()
            {
                Educations = repository.GetEducations,
                Keywords = repository.GetKeywords,
                EducationKeyword = new Dictionary<int,int>(0)
            };

            return View(model);
        }
    }
}