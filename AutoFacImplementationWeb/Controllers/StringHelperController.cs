using Microsoft.AspNetCore.Mvc;

namespace AutoFacImplementationWeb.Controllers
{
    public class StringHelperController : Controller
    {
        public IStringBusiness StringBusiness { get; set; }
        [HttpGet]
        [Route("getUpperCase/{fullName}")]
        public string GetUpperCase(string fullName)
        {
            var upper = StringBusiness.StringToUpper(fullName);
            return upper;
        }
    }
}
