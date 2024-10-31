using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product()
            {
                Name = "IPhone X",
                Description = "Description",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = "Smart Phone"
            },
            new Product()
            {
                Name = "IPhone X",
                Description = "Description",
                ImageFile = "product-2.png",
                Price = 950.00M,
                Category = "Smart Phone"
            },
            new Product()
            {
                Name = "IPhone X",
                Description = "Description",
                ImageFile = "product-3.png",
                Price = 950.00M,
                Category = "Smart Phone"
            },
            new Product()
            {
                Name = "IPhone X",
                Description = "Description",
                ImageFile = "product-4.png",
                Price = 950.00M,
                Category = "Smart Phone"
            },
            new Product()
            {
                Name = "IPhone X",
                Description = "Description",
                ImageFile = "product-5.png",
                Price = 950.00M,
                Category = "Smart Phone"
            },
        };
    }
}
