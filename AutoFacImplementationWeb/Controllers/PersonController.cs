using AutoFacImplementationWeb.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AutoFacImplementationWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonBusiness _personBusiness;

        public PersonController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        [HttpGet]
        [Route("personList")]
        public List<string> GetPersonList()
        {
            return _personBusiness.GetPersonList();
        }
    }
}
