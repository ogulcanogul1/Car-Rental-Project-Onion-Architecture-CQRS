using App.Application.Mediator.Queries.CarPriceQueries;
using App.Application.Mediator.Queries.CarQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCarPriceByHour")]
        public async Task<IActionResult> GetCarPriceByHour() => Ok(await _mediator.Send(new GetCarPriceByHourQueryRequest(true)));
        [HttpGet("GetCarPriceByDay")]
        public async Task<IActionResult> GetCarPriceByDay() => Ok(await _mediator.Send(new GetCarPriceByDayQueryRequest(true)));
        [HttpGet("GetCarPriceByWeek")]
        public async Task<IActionResult> GetCarPriceByWeek() => Ok(await _mediator.Send(new GetCarPriceByWeekQueryRequest(true)));
    }
}
