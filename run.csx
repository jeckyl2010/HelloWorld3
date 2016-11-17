using System.Net;
using System.Threading.Tasks;

public static async Task<HttpListenerResponse> Run( HttpListenerRequest res, TraceWriter log)
{
    return res.CreateResponse(HttpStatusCode.OK, "Hello world!");
}