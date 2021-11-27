using Newtonsoft.Json;

namespace Zendesk.Models
{
    public class AllTickets
    {
        public Ticket[] Tickets { get; set; }
        public string Next_Page { get; set; }
        public string Previous_Page { get; set; }
    }
}
