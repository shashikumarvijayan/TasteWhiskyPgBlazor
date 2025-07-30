namespace TasteWhiskyApi.Models;

public class Dram
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string? SpecialBottling { get; set; }

    public int DistilleryId { get; set; }
    public Distillery Distillery { get; set; } = null!;
    public ICollection<TastingNote> Notes { get; set; } = new List<TastingNote>();
}
