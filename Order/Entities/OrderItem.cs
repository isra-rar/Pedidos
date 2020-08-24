using Bogus;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Order.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        public void SubTotal()
        {
            Price += Product.Price * Quantity;
        }

        public override string ToString()
        {
            return Quantity
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Product;
        }
    }
}
