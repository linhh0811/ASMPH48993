
using DAL;
using DTO.Models;

namespace BLL
{
      public  class CustomerBLL
    {
       CustomerDAL customerDAL = new CustomerDAL();
        public List<Customer> GetAllCustomer()
        {
            var customer = customerDAL.GetAllCustomer();
            return customer;

        }

        public string CreateCustomer(string firtsName, string lastName, string city, string country, string phone)

        {
            Customer ct = new Customer()
            {

                FirstName = firtsName,
                LastName = lastName,
                City = city,
                Country = country,
                Phone = phone

            };
            if (customerDAL.Create(ct))
            {
                return "Thêm thành công";
            }
            else
                return "Thêm thất bại";

        }
        public string UpdateCustomer(int id, string firtsName, string lastName, string city, string country, string phone)
        {
           Customer ctSua = customerDAL.FindCTByid(id);
            ctSua.FirstName = firtsName;
            ctSua.LastName = lastName;
            ctSua.City = city;
            ctSua.Country = country;
            ctSua.Phone = phone;
            
            if (customerDAL.Update(ctSua))
            {
                return "Thêm thành công";
            }
            else
                return "Thêm thất bại";
        }

          public string DeleteCustomer(int id)
        {
            Customer ctXoa = customerDAL.FindCTByid(id);
            if (customerDAL.Delete(ctXoa))
            {
                return "Xóa thành công";
            }
            else
                return "Xóa thất bại";
        }

        public bool CheckExists(int id)
        {
            return customerDAL.FindCTByid(id) != null;
        }
       
    }
}
