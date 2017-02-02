using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrainWebAPI.Models
{
    public class TrainWebAPIContextInitializer : DropCreateDatabaseAlways<TrainWebAPIContext>
    {
        protected override void Seed(TrainWebAPIContext context)
        {
            var books = new List<Book>
            {
                new Book() {Name = "Blood in the soil", Author = "MV Makaukau", Price = 50.89m},
                new Book() {Name = "We gazed at Him and cried", Author = "NT Shivambu", Price = 153.89m},
                new Book() {Name = "The world knew him not", Author = "Tivani Tedesca", Price = 125.89m},
                new Book() {Name = "He was their own", Author = "Nyiko McKay", Price = 80.89m},
                new Book() {Name = "They Rejected Him", Author = "TT Tedesca", Price = 17.89m},
                new Book() {Name = "He died in the hands of many", Author = "Mugandzeri McKay", Price = 33.89m}

            };

            books.ForEach(x=> context.Books.Add(x));
            context.SaveChanges();

            var order = new Order()
            {
                Customer = "Gabriel Tedesca", OrderDate = new DateTime(2017,10,07)
            };

            var details = new List<OrderDetail>()
            {
                new OrderDetail() {Book = books[0], Quantity = 1, Order = order},
                new OrderDetail() {Book = books[2], Quantity = 2, Order = order},
                new OrderDetail() {Book = books[4], Quantity = 3, Order = order}
            };

            context.Orders.Add(order);
            details.ForEach(o=> context.OrderDetails.Add(o));
            context.SaveChanges();


            order = new Order()
            {
                Customer = "Tarzesher Tedesca",
                OrderDate = new DateTime(2017, 1, 12)
            };

            details = new List<OrderDetail>()
            {
                new OrderDetail() {Book = books[1], Quantity = 2, Order = order},
                new OrderDetail() {Book = books[1], Quantity = 12, Order = order},
                new OrderDetail() {Book = books[2], Quantity = 2, Order = order},
                new OrderDetail() {Book = books[4], Quantity = 2, Order = order}
            };

            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();


            base.Seed(context);
        }
    }
}