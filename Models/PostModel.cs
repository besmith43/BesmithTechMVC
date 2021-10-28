namespace BesmithTechMVC.Models;

public class PostModel
{
    public string ID { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Updated { get; set; } = DateTime.Now;
    public bool Deleted { get; set; } = false;
    public string Title { get; set; }
    public int Views { get; set; } = 0;
    public string Content { get; set; }
    public string Excerpt { get; set; }
    public string CoverImagePath { get; set; }
    public bool Public { get; set; } = false;
}