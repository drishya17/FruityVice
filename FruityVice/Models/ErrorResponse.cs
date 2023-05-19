using Newtonsoft.Json;

namespace FruityVice.Models
{
    public class ErrorResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; } = null!;
    }
}
