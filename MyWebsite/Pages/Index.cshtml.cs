using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebsite.Models;
namespace MyWebsite.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public required List<ProjectCard> Projects { get; set; }  // Create the Project List on startup

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Projects =
        [
            new ProjectCard {Title = "Project 1", Description = "Description 1", Link = "https://github.com/LandonPyko"},
            new ProjectCard {Title = "Project 2", Description = "Description 2", Link = "https://github.com/LandonPyko"},
            new ProjectCard {Title = "Project 3", Description = "Description 3", Link = "https://github.com/LandonPyko"}
        ];

    }
}
