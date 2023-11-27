namespace HomeWork3.Entites
{
    public class Product
    {
        private static int id = 0;

        public Product()
        {
            Id = id;
            id++;
        }

        public int Id { get; set; }
        public string ImgName { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
