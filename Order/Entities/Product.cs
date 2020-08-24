using Bogus;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Order
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product GetDataProduct()
        {
            return new Faker<Product>("pt_BR").StrictMode(true)
                .RuleFor(p => p.Name, f => f.Commerce.ProductMaterial())
                .RuleFor(p => p.Price, f => f.Random.Double(2.0, 10.0));
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
