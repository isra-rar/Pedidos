using Order.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public override string ToString()
        {
            return Moment
                + ", "
                + OrderStatus
                + ", "
                + Client.ToString();
        }
    }
}
