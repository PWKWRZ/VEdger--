namespace VEdger.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using VEdger.Models;
    using VEdger.Repository;
    using VEdger.Responses;

    public class UserMenagementController : Controller
    {

        readonly IRepository<UserData> userDataRepository = new EntityRepository<UserData>();

        [HttpGet]
        public ActionResult UserDataSettings()
        {
            var data = userDataRepository.Read<UserData>().FirstOrDefault();
            if (data!= null)
            {
                return View(data);
            }
            var data2 = new UserData
            {
                first_name = "joe"
            };
            return View (data2);
        }

        [HttpPost]
        public ActionResult UserDataSettings(UserData data)

        {
            var dataFromRepository = userDataRepository.Read<UserData>(data);
            if (dataFromRepository == null)
            {
                userDataRepository.Create<UserData>(data);
            }
            else if (dataFromRepository?.Count() == 0)
            {
                userDataRepository.Create<UserData>(data);
            }
            else
            {
                userDataRepository.Update<UserData>(data);
            }

            return View(data);
        }

        [HttpGet]
        public ActionResult SearchMatchSettings()
        {
            var data = new MatchingSettingsResponse {
                maximumDistance = 0,
                ageRange = 0,
                fpe = getCheckboxesForFoodPreferences()
            };

            return View(data);
        }

        private IList<SelectListItem> getCheckboxesForFoodPreferences()
        {
            return new List<SelectListItem>
            {
                new SelectListItem {Text = "test1", Value = "0"},
                new SelectListItem {Text = "Pear", Value = "1"},
                new SelectListItem {Text = "Banana", Value = "Banana"},
                new SelectListItem {Text = "Orange", Value = "Orange"},
            };
        }
    }
}