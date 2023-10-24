using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using ToDoRest.DTO;

namespace ToDoRest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public GetResponse Get()
        {
            return new GetResponse() { Message = "gRPC, which stands for Google Remote Procedure Call, is a cutting-edge open-source framework for building efficient and high-performance distributed systems. It is designed to facilitate communication between applications, allowing them to seamlessly exchange data and invoke functions across different programming languages and platforms. gRPC leverages Protocol Buffers (protobufs) as its interface definition language, enabling developers to define the structure of their data and services in a language-agnostic way. One of the standout features of gRPC is its support for HTTP/2, which offers advantages such as multiplexing, flow control, and header compression, making it incredibly efficient for data transmission. This technology is particularly popular in microservices architectures and cloud-native applications, where low latency and high throughput communication between services is paramount. With its rich ecosystem and language support, gRPC is a powerful tool for building robust and scalable distributed systems." };
        }

        [HttpGet]
        public List<ComplexResponse> GetComplex()
        {
            string z = System.IO.File.ReadAllText(@"Data/Data.json");
            return JsonSerializer.Deserialize<List<ComplexResponse>>(z);
        }
    }
}
