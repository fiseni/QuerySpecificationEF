﻿using PozitronDev.QuerySpecification.EF.IntegrationTests.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PozitronDev.QuerySpecification.EF.IntegrationTests.Specs
{
    public class CompanyWithStoresThenIncludeProductsSpec : Specification<Company>
    {
        public CompanyWithStoresThenIncludeProductsSpec(int id)
        {
            Query.Where(x => x.Id == id)
                .Include(x => x.Stores)
                .ThenInclude(x => x.Products);
        }
    }
}
