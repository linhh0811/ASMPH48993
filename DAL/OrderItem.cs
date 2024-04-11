using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class OrderitemDAL
    {
        AsmcContext asmcContext = new AsmcContext();
        public List <OrderItem> GetAllOrderItem()
        {
            var orderItems = asmcContext.OrderItems.ToList();
            return orderItems;
        }
        public bool Delete(int id)
        {
            try
            {
                var find = asmcContext.OrderItems.Where(x => x.ProductId == id).ToList();
                if (find != null)
                {
                    for (int i = 0; i < find.Count; i++)
                    {
                        asmcContext.OrderItems.Remove(find[i]);
                      asmcContext.SaveChanges();
                    }

                }

                return true;
            }
            catch { return false; }
        }

    }
}
