using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller

  {
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }
    [Route("/greeting_card")]
    public ActionResult GreetingCard()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient(Request.Query["recipient"]);
      myLetterVariable.SetSender(Request.Query["sender"]);
      myLetterVariable.SetVacationSpot(Request.Query["vacationspot"]);
      myLetterVariable.SetSouvenir(Request.Query["souvenir"]);
      return View("Hello", myLetterVariable);
    }
  }
}
