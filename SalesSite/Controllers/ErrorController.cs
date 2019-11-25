using Microsoft.AspNetCore.Mvc;
namespace SalesSite.Controllers
{
    public class ErrorController:Controller
    {
        [Route("error/404")]
        public IActionResult error404(){
            return View();
        }
    }
}