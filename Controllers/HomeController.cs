using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
  public class HomeController : Controller
  {
    public ViewResult Index()
    {
      return View(Repository.Going.Count());
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
      return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
      if (ModelState.IsValid)
      {
        Repository.AddResponse(guestResponse);
        return View("Thanks", guestResponse);
      }

      return View();
    }

    public ViewResult ListResponses()
    {
      return View(Repository.Going);
    }
  }
}
