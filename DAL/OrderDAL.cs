using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
 public class OrderDAL
    {
         AsmcContext asmcContext = new AsmcContext();
        public List<Order> GetAllOrder()
        {
            var order = asmcContext.Orders.ToList();
            return order;
        }
        public bool Create (Order order)
        {
            asmcContext.Orders.Add(order);
            return asmcContext.SaveChanges() > 0;
        }

        public bool Update(Order order)
        {
            asmcContext.Orders.Update(order);
            return asmcContext.SaveChanges() > 0;
        }
        public bool Delete(Order order)
        {
            asmcContext.Orders.Remove(order);
            return asmcContext.SaveChanges() > 0;
        }
       
        public Order FindByORid(int Id)
        {
            return asmcContext.Orders.Find(Id);
        }
    }
}
