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

            base.Seed(context);
        }
    }
}