using HomeWork3.Entites;

namespace HomeWork3.Data
{
    public class ProductRepository
    {
        public static List<Product> GetProducts()
        {
            return new()
            {
                new()
                {
                    Name = "Men's Shirt",
                    Price = "75$",
                    ImgName = "p1.png"
                },
                new()
                {
                    Name = "Men's Shirt",
                    Price = "80$",
                    ImgName = "p2.png"
                },
                new()
                {
                    Name = "Women's Dress",
                    Price = "68$",
                    ImgName = "p3.png"
                },
                new()
                {
                    Name = "Women's Dress",
                    Price = "70$",
                    ImgName = "p4.png"
                },
                new()
                {
                    Name = "Women's Dress",
                    Price = "75$",
                    ImgName = "p5.png"
                },
                new()
                {
                    Name = "Women's Dress",
                    Price = "58$",
                    ImgName = "p6.png"
                },
                new()
                {
                    Name = "Women's Dress",
                    Price = "80$",
                    ImgName = "p7.png"
                },
                new()
                {
                    Name = "Men's Shirt",
                    Price = "65$",
                    ImgName = "p8.png"
                },
                new()
                {
                    Name = "Men's Shirt",
                    Price = "65$",
                    ImgName = "p9.png"
                },
                new()
                {
                    Name = "Men's Shirt",
                    Price = "65$",
                    ImgName = "p10.png"
                },
                new()
                {
                    Name = "Men's Shirt",
                    Price = "65$",
                    ImgName = "p11.png"
                },
                new()
                {
                    Name = "Women's Dress",
                    Price = "65$",
                    ImgName = "p12.png"
                }
            };
        }
    }
}
