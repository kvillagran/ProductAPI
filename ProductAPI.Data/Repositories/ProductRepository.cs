using ProductAPI.Core.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProductRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var query = "SELECT * FROM Products WHERE Id = @Id";
            return await _dbConnection.QuerySingleOrDefaultAsync<Product>(query, new { Id = id });
        }

        public async Task<bool> UpdateProductStockAsync(int id, int stock)
        {
            var query = "UPDATE Products SET Stock = @Stock WHERE Id = @Id";
            var result = await _dbConnection.ExecuteAsync(query, new { Stock = stock, Id = id });
            return result > 0;
        }
    }
}

