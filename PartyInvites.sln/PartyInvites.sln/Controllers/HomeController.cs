using Microsoft.AspNetCore.Mvc;
using PartyInvites.sln.Models;

namespace PartyInvites.sln.Controllers
{
  public class HomeController : Controller
  {
    public ViewResult Index()
    {
      return View();
    }
    public ViewResult Privacy()
    {
      return View();
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
      return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
      Repository.AddResponse(guestResponse);
      return View("Thanks", guestResponse);
    }
  }
}