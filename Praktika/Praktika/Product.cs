namespace Praktika
{
    internal class Product
    {
        public string Id;
        public string BrandName;
        public string ModelName;
        public decimal Price;
        public decimal Cost;
        public decimal Income = 0;
        public int Count;

        public Product(string brandName, string modelName, decimal price, decimal cost, int count)
        {
            Id = GenerateId(brandName, modelName);
            BrandName = brandName;
            ModelName = modelName;
            Price = price;
            Cost = cost;
            Count = count < 0 ? 0 : count;
        }

        public string GenerateId(string brandName, string modelName)
        {
            brandName = brandName.Length >= 2 ? brandName.Substring(0, 2) : brandName;
            modelName = modelName.Length >= 2 ? modelName.Substring(0, 2) : modelName;

            return brandName + modelName;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Id: {Id}, Brand name: {BrandName}, Model name: {ModelName}, Price: {Price}, Income: {Income}, Cost: {Cost}, Count: {Count}");
        }

        public bool Sale(int quantity)
        {
            if (Count >= quantity)
            {
                decimal earning = (Price - Cost) * quantity;
                Income += earning;
                Count -= quantity;

                Console.WriteLine("\nSatis ugurlu oldu!");
                return true;
            }
            else
            {
                Console.WriteLine("\nKifayet qeder mehsul yoxdur!");
                return false;
            }
        }
    }
}
