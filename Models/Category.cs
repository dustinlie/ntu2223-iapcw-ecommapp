using Microsoft.Build.Framework;

namespace iapCoursework2.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}
