namespace Praktika
{
    internal class Medicine
    {
        public string Category;
        private string _name;
        private decimal _price;
        private decimal _discountPrice;

        public string Name
        {

            get { return _name; }

            set
            {
                if (value.Trim().Length >= 3 && char.IsUpper(value[0]))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Minimum 3 herf olmalidir!");
                }

            }
        }

        public decimal Price
        {
            get { return _price; }

            set
            {
                if (value < 0)
                {
                    _price = 0;
                }
                else
                {
                    _price = value;
                }
            }
        }

        public decimal DiscountPrice
        {
            get { return _discountPrice; }

            set
            {
                _discountPrice = Price * (value / 100);
            }
        }


        public Medicine(string category)
        {
            Category = category;
        }
    }
}
