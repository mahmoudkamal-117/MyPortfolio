namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string Name { get; set; }
        public string Profil { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public long Phone { get; set; }
        public Address Address { get; set; }
    }

}
