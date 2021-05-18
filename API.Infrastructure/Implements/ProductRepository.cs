using API.Core.DbModels;
using API.Core.Interfaces;
using API.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Infrastructure.Implements
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;


        public ProductRepository(StoreContext context)
        {
            _context = context;
        }


        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        /// <summary>
        /// Tüm Ürünleri Listeler
        /// </summary>
        /// <returns></returns>
        public async Task<IReadOnlyList<Product>> GetProductAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
