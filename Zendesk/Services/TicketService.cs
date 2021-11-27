
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Zendesk.Models;

namespace Zendesk.Services
{
    public interface ITicketService
    {
        Task<AllTickets> ObterTickets();
        Task<TicketInfo> ObterTicket(int id);
    }

    public class TicketService : BaseService, ITicketService
    {
        private readonly HttpClient _httpClient;

        public TicketService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://kahdabra.zendesk.com");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders
                          .Accept
                          .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<TicketInfo> ObterTicket(int id)
        {
            var response = await _httpClient.GetAsync($"/api/v2/tickets/{id}.json");

            TratarErrosResponse(response);

            return await DeserializarObjetoResponse<TicketInfo>(response);
        }

        public async Task<AllTickets> ObterTickets()
        
        {
            var response = await _httpClient.GetAsync("api/v2/tickets.json?page=2&per_page=25");
            
            TratarErrosResponse(response);

            return await DeserializarObjetoResponse<AllTickets>(response);
        }
    }
}
