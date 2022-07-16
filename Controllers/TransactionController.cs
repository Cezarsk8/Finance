using Microsoft.AspNetCore.Mvc;

namespace Finance.Controllers
{
    public class TransactionController : Controller
    {
        /// <summary>Creates a transaction</summary>
        public IActionResult Index()
        {
            return View();
        }
    }
}
