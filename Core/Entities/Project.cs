namespace Core.Entities
{
    public class Project : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string GitUrl { get; set; }
        public string Url { get; set; }
    }

}
