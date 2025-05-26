namespace CVWebApp.Models
{
    public class Picture
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? PictureUrl{ get; set; }
    }
}
