using Microsoft.AspNetCore.Mvc;

namespace DotNetRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string GetName()
        {
            return "Parvez";
        }

        [HttpGet]
        public string GetFullName()
        {
            return "A S M Masud Parvez";
        }
    }
}
