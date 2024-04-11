using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
       public  class OrderItem
    {
       OrderItem orderItem = new OrderItem();
        public List<OrderItem> GetAllOrderItem()
        {
            var orderItems = orderItem.GetAllOrderItem();
            return orderItems;
        }
        public bool Delete(int id)
        {
            return orderItem.Delete(id);
        }
    }
}
