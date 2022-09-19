using csharp_oop_shop;

Product product1 = new Product("patate", "ottimi tuberi", 0.90m, 10);

Console.WriteLine("Prodotto:");
Console.WriteLine(product1.FullName());
Console.WriteLine("Descrizzione prodotto: ");
Console.WriteLine(product1.Description);
Console.WriteLine("Prezzo Senza Iva: ");
Console.WriteLine(product1.Price);
Console.WriteLine("Prezzo Con Iva: ");
Console.WriteLine(product1.TaxPrice());