using AdamFreeman.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdamFreeman.Controllers
{
  public class HomeController : Controller
  {
    public ViewResult Index()
    {
      int hour = DateTime.Now.Hour;
      string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
      return View("MyView", viewModel);
    }
  }
}