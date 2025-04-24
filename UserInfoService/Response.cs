using System.Text.Json.Serialization;

namespace soap.UserInfoService;

public class Response<T>
{
        [JsonPropertyName("statusCode")]
         public int? StatusCode { get; set; } 
         
        [JsonPropertyName("status")]
         public string? Status { get; set; } 
     
         [JsonPropertyName("error")]
         public string? Error { get; set; } 
     
         [JsonPropertyName("timeStamp")]
         public string? TimeStamp { get; set; } 
     
         [JsonPropertyName("data")]
         public T Data { get; set; } 
}