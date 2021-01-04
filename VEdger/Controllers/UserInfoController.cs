namespace VEdger.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using VEdger.Models;
    using VEdger.Repository;

    public class UserInfoController : Controller
    {

        readonly IRepository<UserData> repository = new EntityRepository<UserData>();

        [HttpGet]
        public ActionResult Index()
        {
            var data = repository.Read<UserData>().FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult Index(
            UserData data)

        {
            var dataFromRepository = repository.Read<UserData>(data);
            if(dataFromRepository == null)
            {
                repository.Create<UserData>(data);
            }
            else if(dataFromRepository?.Count() == 0)
            {
                repository.Create<UserData>(data);
            }
            else
            {
                repository.Update<UserData>(data);
            }

            return View(data);
        }
    }
}