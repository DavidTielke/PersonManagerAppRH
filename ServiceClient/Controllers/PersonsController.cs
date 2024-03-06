using DavidTielke.PersonManagerApp.Backend.PersonManagement;
using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;
using Microsoft.AspNetCore.Mvc;

namespace ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {

        private readonly IPersonManager _manager;

        public PersonsController(IPersonManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        [Route("/Adults")]
        public IEnumerable<Person> GetAllAdults()
        {
            return _manager.GetAllAdults();
        }

        [HttpGet]
        [Route("/Children")]
        public IEnumerable<Person> GetAllChildren()
        {
            return _manager.GetAllChildren();
        }
    }
}
