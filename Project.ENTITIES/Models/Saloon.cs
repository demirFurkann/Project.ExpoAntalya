using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Saloon:BaseEntity
    {

        public string SaloonName { get; set; }
        public string Description { get; set; }

        public decimal UnitPrice { get; set; }


        public override string ToString()
        {
            return $"{SaloonName}";
        }

        public string BilgiGoster()
        {
            return $"Açıklaması => {Description} => Fiyatı : {UnitPrice:C2}";
        }
    }
}
