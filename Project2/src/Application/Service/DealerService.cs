using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Project2.Application.Interfaces;

namespace Project2.Application.Service;
public class DealerService : IDealerService
{
    private readonly ApplicationDbContext context;
    private readonly IMapper mapper;
    private readonly IHttpContextAccessor httpContextAccessor;

    public DealerService(
        ApplicationDbContext context,
        IMapper mapper,
        IHttpContextAccessor httpContextAccessor)
    {
        this.context = context;
        this.mapper = mapper;
        this.httpContextAccessor = httpContextAccessor;
    }

    public async Task<List<CarViewDTO>> DealerCars()
    {
        var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        var dealerId = context.Dealers.Where(x => x.UserId == userId).Select(x => x.Id).FirstOrDefault();

        var allCar = await context.Cars.Include(x => x.Brand).Where(x => x.DealerId == dealerId).ToListAsync();
        var carDealer = mapper.Map<List<CarViewDTO>>(allCar);

        return carDealer;
    }

    public async Task<bool> CreateDealer(DealerDTO dealerDTO)
    {
        var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

        if (userId == null)
        {
            return false;
        }
        var dealer = mapper.Map<Dealer>(dealerDTO);

        dealer.Name = dealerDTO.Name;
        dealer.UserId = userId;

        await context.Dealers.AddAsync(dealer);
        await context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> IsDealer(string userId)
    {
        var dealer = await context.Dealers.AnyAsync(x => x.UserId == userId && x.Name != null);

        if (dealer)
        {
            return true;
        }

        return false;
    }
}
