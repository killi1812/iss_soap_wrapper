using System.ServiceModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace soap.UserInfoService;

[ServiceContract]
public interface IUserInfo
{
    [OperationContract]
   public UserInfoDto GetUserInfo(string username);
}


public class UserInfo : IUserInfo
{
    private readonly HttpClient _httpClient;

    public UserInfo()
    {
        _httpClient = new HttpClient();
    }

    public UserInfoDto GetUserInfo(string username)
    {
        var apiUrl = $"http://localhost:5555/search/{username}";
        var response = _httpClient.GetAsync(apiUrl).Result;

        if (response.IsSuccessStatusCode)
        {
            var jsonResponse = response.Content.ReadAsStringAsync().Result;
            var dto = JsonSerializer.Deserialize<UserInfoDto>(jsonResponse);
            return dto;
        }
        
        return new UserInfoDto
        {
            Status = false,
            Username = username
        };
        
    }
}
