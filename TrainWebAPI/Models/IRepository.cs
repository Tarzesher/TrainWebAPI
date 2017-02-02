using System.Linq;

namespace TrainWebAPI.Models
{
    public interface IRepository
    {
        IQueryable<Order> GetAllOrders();
        IQueryable<Order> GetAllOrderswithDetailsOrders();
        Order GetOrder(int id);
    }
}