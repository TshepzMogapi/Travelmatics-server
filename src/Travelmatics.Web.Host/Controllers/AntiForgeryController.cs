using Microsoft.AspNetCore.Antiforgery;
using Travelmatics.Controllers;

namespace Travelmatics.Web.Host.Controllers
{
    public class AntiForgeryController : TravelmaticsControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
