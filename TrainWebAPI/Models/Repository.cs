
using System.Linq;

namespace TrainWebAPI.Models
{
    public class Repository : IRepository
    {
        private TrainWebAPIContext db;

        public Repository(TrainWebAPIContext db)
        {
            this.db = db;
        }

        public IQueryable<Order> GetAllOrders()
        {
            return db.Orders;
        }

        public IQueryable<Order> GetAllOrderswithDetailsOrders()
        {
            return db.Orders.Include("OrderDetails");
        }

        public Order GetOrder(int id)
        {
            return db.Orders.Include("OrderDetails.Book")
                .FirstOrDefault(o => o.Id == id);
        }
    }
}