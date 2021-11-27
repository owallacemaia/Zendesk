using Microsoft.AspNetCore.Mvc;
using Zendesk.Models;
using Zendesk.Services;

namespace Zendesk.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        [Route("tickets")]
        public async Task<IActionResult> Index()
        {
            var teste = await _ticketService.ObterTickets();
            return View(teste);
        }

        [HttpGet]
        [Route("ticket/{id:int}")]
        public async Task<IActionResult> Ticket(int id)
        {
            var teste = await _ticketService.ObterTicket(id);
            return View(teste);
        }
    }
}
