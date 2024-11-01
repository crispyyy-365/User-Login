using Praktika;

Product product = new("Apple", "Iphone16", 1000, 500, 10);

Medicine medicine1 = new("valium");
Medicine medicine2 = new("Xanax");
Medicine medicine3 = new("Weed");

Pharmacy.AddArr(medicine1);
Pharmacy.Addarr(medicine2);
Pharmacy.AddArr(medicine3);

Console.WriteLine("Products:");
product.GetInfo();

product.Sale(7);
Console.WriteLine("1ci Satisdan sonra:");
product.GetInfo();

product.Sale(2);
Console.WriteLine("2ci Satisdan sonra:");
product.GetInfo();

Medicine medicine = new("Grip");
medicine.Name = "Nu";
medicine.Price = -1;
medicine.DiscountPrice = 35;

Console.WriteLine(medicine.Price);