using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project2.Application.Interfaces;
public interface ICarService
{
    Task<List<CarViewDTO>> GetAllCars();
    Task<bool> CarCreate(CarCreateDTO carCreateDTO);
    Task<bool> Delete(int id);
    Task<Car> DeleteGet(int id);
    Task<bool> Edit(int carId, CarEditDTO carEditDTO);
    Task<CarEditDTO> Edit(int id);
    Task<List<CarViewDTO>> SortByBrand(int? id);
    Task<SelectList> BrandList();
}
