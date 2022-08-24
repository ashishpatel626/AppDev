using Microsoft.AspNetCore.Mvc;
using PartyInvites.sln.Models;
using System.Diagnostics;

namespace PartyInvites.sln.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}