using FCamara.Shared.Entities;

namespace FCamara.Domain.Entities
{
    public class Product :  Entity
    {
        protected Product() { }

        public Product(string title, string description, string image, decimal price)
        {
            Title = title;
            Description = description;
            Image = image;
            Price = price;
        }
        
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public decimal Price { get; private set; }
    }
}
