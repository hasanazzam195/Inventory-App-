using InventoryDataAccess.Entity;
using InventoryDataAccess.generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public class CompanyService : ICompanyService
    {
        public void Insert(Company company)
        {
            IGeneric<Company> generic = new Generic<Company>();
            generic.Insert(company);
        }
    }
}
