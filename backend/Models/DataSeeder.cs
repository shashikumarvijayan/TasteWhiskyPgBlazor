namespace TasteWhiskyApi.Models;

public static class DataSeeder
{
    public static void Seed(TasteWhiskyContext db)
    {
        if (db.Distilleries.Any())
            return;

        var dist = new Distillery { Name = "Glen Codex", Region = "Highlands" };
        db.Distilleries.Add(dist);

        var dram = new Dram
        {
            Name = "Glen Codex 12",
            Age = 12,
            Distillery = dist
        };
        db.Drams.Add(dram);

        var user = new User { UserName = "testuser" };
        db.Users.Add(user);

        var note = new TastingNote
        {
            Dram = dram,
            User = user,
            Nose = "Sweet cereal",
            Palate = "Malty with a hint of vanilla",
            Finish = "Medium, warming",
            Score = 85,
            Overall = "Solid daily dram"
        };
        db.TastingNotes.Add(note);

        db.SaveChanges();
    }
}
