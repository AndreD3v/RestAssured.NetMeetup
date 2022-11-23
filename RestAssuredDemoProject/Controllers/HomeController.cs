using RestAssuredDemoProject.Controllers;

namespace RestAssuredDemoProject.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        MyModel model = new MyModel()
        {
            Message = "Hello World!"
        };
        return View(model);
    }
}
