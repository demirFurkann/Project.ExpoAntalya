using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Extra:BaseEntity
    {
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }




		//Relational Properties

		public virtual List<OrderExtra> OrderExtras { get; set; }



	}
}
