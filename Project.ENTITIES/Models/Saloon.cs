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


        //Relational Properties

        public virtual List<SaloonIssue> SaloonIssues { get; set; }

        public virtual List<Stand> Stands { get; set; }
        public virtual List<Order> Orders { get; set; }



    }
}
