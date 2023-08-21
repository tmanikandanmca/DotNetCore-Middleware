using Newtonsoft.Json;

namespace Middlewares.Models;

public class ErrorResponseData
{
    public int ErrorCode { get; set; }
    public string ErrorMessage { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;

    public override string ToString() => JsonConvert.SerializeObject(this);
}
