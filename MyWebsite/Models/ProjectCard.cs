using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// Data that each project will hold

namespace MyWebsite.Models
{
    public class ProjectCard
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }

    }
}