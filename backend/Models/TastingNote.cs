namespace TasteWhiskyApi.Models;

public class TastingNote
{
    public int Id { get; set; }
    public int DramId { get; set; }
    public Dram Dram { get; set; } = null!;
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public string Nose { get; set; } = "";
    public string Palate { get; set; } = "";
    public string Finish { get; set; } = "";
    public int Score { get; set; }
    public string Overall { get; set; } = "";
    public string? PhotoUrl { get; set; }
}
