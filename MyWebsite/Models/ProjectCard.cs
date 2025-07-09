using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// Data that each project will hold

namespace Portfolio.Pages
{
    public class ProjectCard
    {
        public string? Title { get; set; }
        public string? Description { get; set; }

    }
}