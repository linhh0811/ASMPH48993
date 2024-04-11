using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DTO.Models;
using DTO;


namespace BLL
{
    public class ProductBLL
    {
        ProductDAL productDAL = new ProductDAL();
        public List<Product> GetAllProduct()
        {
            var product = productDAL.GetAllProduct();
            return product;
        }

        public string CreateProduct(string ProductName, int SupplierId, decimal UnitPrice, string pack, bool IsDiscontinued)

        {
            Product pr = new Product()
            {

                ProductName = ProductName,
                SupplierId = SupplierId,
                UnitPrice = UnitPrice,
                Package = pack,
                IsDiscontinued = IsDiscontinued,

            };
            if (productDAL.Create(pr))
            {
                return "Thêm thành công";
            }
            else
                return "Thêm thất bại";

        }
        
        // Xu ly cap nhat
        public string UpdateProduct(int id, string productName, int supplierId, decimal unitPrice, string Pack, bool isDiscontinued)
        {
            Product prSua = productDAL.FindPRByid(id);
            prSua.ProductName = productName;
            prSua.SupplierId = supplierId;
            prSua.UnitPrice = unitPrice;
            prSua.Package = Pack;
            prSua.IsDiscontinued = isDiscontinued;
            if (productDAL.Update(prSua))
            {
                return "Thêm thành công";
            }
            else
                return "Thêm thất bại";
        }
        public bool CheckExists(int id)
        {
            return productDAL.FindPRByid(id) != null;
        }
        //  Xoa
        public string DeleteProduct(int id)
        {
            Product prXoa = productDAL.FindPRByid(id);
            if (productDAL.Delete(prXoa))
            {
                return "Xóa thành công";
            }
            else
                return "Xóa thất bại";
        }
        public Product GetById(int id)
        {
            return productDAL.GetbyId(id);
        }


















        //public List<Order> GetAllOrders()
        //{
        //    var order = productDAL.GetAllOrder();
        //    return order;
        //}
        //public string CreateOrder(DateTime orderDate, string orderNumber, int customerId, decimal totalAmount)

        //{
        //    Order order = new Order()
        //    {
        //        OrderDate = orderDate,
        //        OrderNumber = orderNumber,
        //        CustomerId = customerId,
        //        TotalAmount = totalAmount



        //    };
        //    if (productDAL.Create(order))
        //    {
        //        return "Thêm thành công";
        //    }
        //    else
        //        return "Thêm thất bại";
        //}
        //public string UpdateOrder(int id, DateTime orderDate, string orderNumber, int customerId, decimal totalAmount)
        //{
        //    Order orSua = productDAL.FindByORid(id);
        //    {
        //        orSua.OrderDate = orderDate;
        //        orSua.OrderNumber = orderNumber;
        //        orSua.CustomerId = customerId;
        //        orSua.TotalAmount = totalAmount;

        //    }
        //    if (productDAL.Update(orSua))
        //    {
        //        return "Them thanh cong";
        //    }
        //    else
        //        return "Them that bai";
        //}
    }
}
