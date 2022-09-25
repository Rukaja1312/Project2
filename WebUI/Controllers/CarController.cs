using Application.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project2.Application.Interfaces;

namespace WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService carService;
        private readonly IMapper mapper;

        public CarController(ICarService carService, IMapper mapper)
        {
            this.carService = carService;
            this.mapper = mapper;
        }

        public IActionResult SearchForm()
        {
            ViewData["BrandId"] = carService.BrandList();
            return View();
        }

        public async Task<IActionResult> SearchByBrand(int id)
        {
            var cars = await carService.SortByBrand(id);
            return View("Index", cars);
        }

        public async Task<IActionResult> Index()
        {
            var cars = await carService.GetAllCars();
            return View(cars);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["BrandId"] = carService.BrandList();
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(CarCreateDTO carCreateDTO)
        {
            try
            {
                var car = await carService.CarCreate(carCreateDTO);
                if (!car)
                {
                    return RedirectToAction("Create", "Dealers");
                }
                return RedirectToAction("MyCars", "Dealers");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var car = await carService.Edit(id);

            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, CarEditDTO carEditDTO)
        {

            var carEdit = await this.carService.Edit(id, carEditDTO);

            if (ModelState.IsValid)
            {
                if (!carEdit)
                {
                    return BadRequest();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(carEdit);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var car = await carService.DeleteGet(id);
            return View(car);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            var car = await carService.Delete(id);

            if (!car)
            {
                return NotFound();
            }

            return RedirectToAction("Index", "Cars");
        }
    }
}
