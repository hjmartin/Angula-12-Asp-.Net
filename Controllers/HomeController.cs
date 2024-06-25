using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_Directiva.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public HomeController()
        {
            
        }

    }
}
