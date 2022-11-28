using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using MySql.Data;
using Deli_Inventory.Models;

namespace Deli_Inventory
{
    public class CurrentProductRepository : ICurrentProduct
    {
        public CurrentProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        private readonly IDbConnection _conn;

        IEnumerable<CurrentProduct> ICurrentProduct.GetAllProducts()
        {
            return _conn.Query<CurrentProduct>("SELECT * FROM CURRENTPRODUCTS;");

        }
    }
}
