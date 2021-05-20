using API.Core.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Specifications
{
    public class ProductsWitchProductTypeAndBrandSpecification:BaseSpecification<Product>
    {
        public ProductsWitchProductTypeAndBrandSpecification()
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }

        public ProductsWitchProductTypeAndBrandSpecification(int id)
            :base(x=>x.Id==id)
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }

    }
}
