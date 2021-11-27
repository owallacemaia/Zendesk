using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Zendesk.Handler
{
    public class HttpClientAuthorizationDelegatingHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Authorization", "Basic d2FsbGFjZW1haWFnQGdtYWlsLmNvbTpNQWlAOTY5OSQj");

            return base.SendAsync(request, cancellationToken);
        }
    }
}
