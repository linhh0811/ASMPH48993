using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class OrderBLL
    {
       
       OrderDAL orderDAL = new OrderDAL();
        public List<Order> GetAllOrder()
        {
            var customer = orderDAL.GetAllOrder();
            return customer;

        }
        public string CreateOrder( DateTime orderDate, string orderNumber, int customerId, decimal totalAmount)
        {
            Order order = new Order();
            {
            order.OrderDate = orderDate;
            order.OrderNumber = orderNumber;
            order.CustomerId = customerId;
            order.TotalAmount = totalAmount;
           };
            if (orderDAL.Create(order))
            {
                return "Thêm thành công";
            }
            else
                return "Thêm thất bại";
        }
        public string UpdateOrder(int id, DateTime orderDate, string orderNumber, int customerId, decimal totalAmount)
        {
            Order odSua = orderDAL.FindByORid(id);
            odSua.Id = id;
            odSua.OrderDate = orderDate;
            odSua.OrderNumber = orderNumber;
            odSua.CustomerId = customerId;
            odSua.TotalAmount = totalAmount;
            if (orderDAL.Update(odSua))
            {
                return "Thêm thành công";
            }
            else
                return "Thêm thất bại";
        }
        public string DeleteOrder(int id)
        {
           Order odXoa = orderDAL.FindByORid(id);
            if (orderDAL.Delete(odXoa))
            {
                return "Xóa thành công";
            }
            else
                return "Xóa thất bại";
        }
        public bool CheckExists(int id)
        {
            return orderDAL.FindByORid(id) != null;
        }

    }
}
