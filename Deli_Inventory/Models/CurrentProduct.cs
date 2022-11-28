using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deli_Inventory.Models
{
    public class CurrentProduct
    {
        public string ItemName { get; set; }
        public DateTime ExpireDate  { get; set; }
        public string WhoPutOut { get; set; }
    }
}
