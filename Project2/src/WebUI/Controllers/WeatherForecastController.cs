using Microsoft.AspNetCore.Mvc;
using Project2.Application.WeatherForecasts.Queries.GetWeatherForecasts;

namespace Project2.WebUI.Controllers;
public class WeatherForecastController : ApiControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await Mediator.Send(new GetWeatherForecastsQuery());
    }
}
