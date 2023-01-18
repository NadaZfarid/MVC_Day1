using Day1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class RegisterController : Controller
    {
        public ViewResult Form()
        {
            return View();
        }
        public IActionResult Thanks()
        {
            return View();
        }
        public IActionResult GetAllGuests()
        {
            List<Guest> guests = GuestList.Guests;
            return View("summery", guests);
        }
        public IActionResult addnewguest(Guest guest)
        {
            GuestList.addguest(guest);

            if (guest.willattend)
            {
                return View("Thanks");
            }
            else
            {
                GuestList.removeguest(guest);
                return Content("See You Later");
            }
        }
    }
}
