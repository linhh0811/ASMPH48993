using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
        public class CustomerDAL
    {
        AsmcContext asmcContext = new AsmcContext();
        public List<Customer> GetAllCustomer()
        {
            var customer = asmcContext.Customers.ToList();
            return customer;

        }
        public bool Create(Customer customer)
        {

            asmcContext.Customers.Add(customer);
            return asmcContext.SaveChanges() > 0;  // >0 thì true thêm thành công, nếu <=0 thì chưa add được dữ liệu
        }
        public bool Update(Customer customer)
        {
            asmcContext.Customers.Update(customer);
            return asmcContext.SaveChanges() > 0;
        }

       public bool Delete(Customer customer)
        {
            asmcContext.Customers.Remove(customer);
            return asmcContext.SaveChanges() > 0;
        }

        public Customer FindCTByid(int id)
        {
           return asmcContext.Customers.Find(id);
        }
       
    }
}
