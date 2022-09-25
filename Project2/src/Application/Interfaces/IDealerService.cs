using Application.DTOs;

namespace Project2.Application.Interfaces;
public interface IDealerService
{
    Task<List<CarViewDTO>> DealerCars();
    Task<bool> CreateDealer(DealerDTO dealerDTO);
    Task<bool> IsDealer(string id);
}
