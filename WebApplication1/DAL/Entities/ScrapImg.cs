namespace WebApplication1.DAL.Entities
{
    public class ScrapImg
    {
        public int ScrapImgId { get; set; }

        // Foreign Key
        public int ScrapId { get; set; }

        public string ImgUrl { get; set; }

        // Navigation Property
        public Scrap Scrap { get; set; }
    }
}
