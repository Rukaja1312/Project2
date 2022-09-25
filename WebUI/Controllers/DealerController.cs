using Application.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project2.Application.Interfaces;

namespace WebUI.Controllers
{
    public class DealerController : Controller
    {
        private readonly IDealerService dealerService;

        public DealerController(IDealerService dealerService)
        {
            this.dealerService = dealerService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(DealerDTO dealerDTO)
        {
            var dealer = await dealerService.CreateDealer(dealerDTO);
            if (!dealer)
            {
                return View(dealer);
            }
            return RedirectToAction("Index", "Cars");
        }

        [Authorize]
        public async Task<IActionResult> MyCars()
        {
            var myCars = await dealerService.DealerCars();

            return View(myCars);
        }
    }
}
