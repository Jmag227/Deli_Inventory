using Deli_Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deli_Inventory
{
    public interface ICurrentProduct
    {
        public IEnumerable<CurrentProduct> GetAllProducts();
    }
}
