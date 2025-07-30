namespace TasteWhiskyApi.Models;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = "";
    public ICollection<TastingNote> Notes { get; set; } = new List<TastingNote>();
}
