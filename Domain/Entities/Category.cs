namespace App.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public List<Blog>? Blogs { get; set; }
    }
}
