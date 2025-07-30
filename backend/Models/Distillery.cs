namespace TasteWhiskyApi.Models;

public class Distillery
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Region { get; set; } = "";
    public ICollection<Dram> Drams { get; set; } = new List<Dram>();
}
