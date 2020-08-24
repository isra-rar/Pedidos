using Bogus;
using Order.Entities;
using System;

namespace Order
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Faker faker = new Faker("pt_BR");

            Product product = new Product();
            Client client = new Client();

            OrderItem orderItem = new OrderItem(faker.Random.Int(1,10), product.GetDataProduct());
            orderItem.SubTotal();

            Order.Entities.Order order = new Entities.Order(DateTime.Now, Entities.Enums.OrderStatus.PENDING_PAYMENTE,client.GetDataClient()) ;

            order.OrderItems.Add(orderItem);

            Console.WriteLine(order);
        }
    }
}
