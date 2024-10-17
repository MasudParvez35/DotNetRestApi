using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("Get")]
        [HttpGet]
        public string GetName()
        {
            return "Parvez";
        }

        [Route("GetFullName")]
        [HttpGet]
        public string GetFullName()
        {
            return "Masud Parvez";
        }
    }
}
