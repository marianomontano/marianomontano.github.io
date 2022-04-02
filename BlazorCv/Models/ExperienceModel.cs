namespace BlazorCv.Models;

public class ExperienceModel
{
    public string? Company { get; set; }
    public string? Title { get; set; }
    public string? DateFrom { get; set; }
    public string? DateTo { get; set; }
    public List<string>? Tasks { get; set; }
}