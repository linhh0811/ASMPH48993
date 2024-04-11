using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupplierService
    {
        SupplierRes spRes = new SupplierRes();
        
        AsmcContext asmcContext = new AsmcContext();
        public List<Supplier> GetAllSup()
        {
            var product = spRes.GetAllSup();
            return product;
        }
        public Supplier GetById(int id)
        {
            return asmcContext.Suppliers.Find(id);
        }
    }
}
