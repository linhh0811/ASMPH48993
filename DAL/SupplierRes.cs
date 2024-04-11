using DTO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupplierRes
    {
        AsmcContext asmcContext = new AsmcContext();
        public List<Supplier> GetAllSup()
        {
            var products = asmcContext.Suppliers.ToList();
            return products;

        }
        public Supplier GetById(int id)
        {
            return asmcContext.Suppliers.Find(id);
        }
    }
}
