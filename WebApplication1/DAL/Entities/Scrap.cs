namespace WebApplication1.DAL.Entities
{
    public class Scrap
    {
        public int ScrapId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation Property
        public ICollection<ScrapImg> ScrapImgs { get; set; }

    }
}
