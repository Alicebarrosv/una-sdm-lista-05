using System.Text.Json.Serialization;

namespace ConsumerGitHubuser.Models;

public class Perfil
{
    [JsonPropertyName("login")]
    public string Login{get; set;}
    [JsonPropertyName("name")]
    public string Name{get; set;}
    [JsonPropertyName("location")]
    public string Location{get; set;}
    [JsonPropertyName("company")]
    public string Company{get; set;}
}