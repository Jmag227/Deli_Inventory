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
            return _conn.Query<CurrentProduct>("SELECT * FROM CURRENT_PRODUCT;");

        }

        public CurrentProduct GetProduct(int id)
        {
            return _conn.QuerySingle<CurrentProduct>("SELECT * FROM CURRENT_PRODUCT WHERE ID = @id",
               new { id = id });

        }

        public void UpdateCurrentProduct(CurrentProduct currentProject)
        {
            _conn.Execute("UPDATE CURRENT_PRODUCT SET ItemName = @itemName, ExpireDate = @expireDate, WhoPutOut = @whoPutOut WHERE Id = @id",
                new { itemName = currentProject, expireDate = currentProject.ExpireDate, whoPutOut = currentProject.WhoPutOut });
        }
    }
}
