using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;

namespace DAL
{
    public class ProductDAL
    {
        AsmcContext asmcContext = new AsmcContext();
        public List<Product> GetAllProduct()
        {
            var products = asmcContext.Products.ToList();
            return products;

        }
        public bool Create(Product product)
        {

            asmcContext.Products.Add(product);
            return asmcContext.SaveChanges() > 0;  // >0 thì true thêm thành công, nếu <=0 thì chưa add được dữ liệu
        }

        public bool Update(Product product)
        {
            asmcContext.Products.Update(product);
            return asmcContext.SaveChanges() > 0;
        }
       public Product FindPRByid(int id)
        {
           return asmcContext.Products.Find(id);
        }
        public bool Delete(Product product)
        {
            asmcContext.Remove(product);
            return asmcContext.SaveChanges() > 0;
        }
        public Product GetByid(int id)
        {
            return asmcContext.Products.Find(id);
        }


        public Product GetbyId(int id)
        {
            return asmcContext.Products.Find(id);
        }









    }
}
