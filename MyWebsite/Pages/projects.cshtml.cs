using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebsite.Models;

namespace MyWebsite.Pages;

public class ProjectsModel : PageModel
{
    public required List<ProjectCard> Projects { get; set; }

    public void OnGet()  // When we first load the page, it creates a list of my current projects
    // Then, in the html I will iterate over the projects and display them
    {
        Projects =
        [
            new ProjectCard {Title = "Project 1", Description = "Description 1", Link = "https://github.com/LandonPyko"},
            new ProjectCard {Title = "Project 2", Description = "Description 2", Link = "https://github.com/LandonPyko"},
            new ProjectCard {Title = "Project 3", Description = "Description 3", Link = "https://github.com/LandonPyko"}
        ];
    }

}