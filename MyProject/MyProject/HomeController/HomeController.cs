
namespace LanguageFeatures.Controllers
{
  public class HomeController : Controller
  {
    public ViewResult Index()
    {
      Product[] products = Product.GetProducts();
      return View(new string[] { products[1].Name });
    }
  }
}