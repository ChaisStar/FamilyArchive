namespace FamilyArchive.Model
{
    public class Phrase : DbEntity
    {
        public string From { get; set; }

        public string To { get; set; }

        public string Text { get; set; }
    }
}