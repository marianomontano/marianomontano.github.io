using System.Text.Json.Serialization;

namespace BlazorCv.Models;

public class ProfileModel
{
    public string? Name { get; set; }
    public string? Title { get; set; }
    public List<string>? Profile { get; set; }
    public string? Phone { get; set; }
    public string? EmailAddress { get; set; }
    public string? GithubLink { get; set; }
}