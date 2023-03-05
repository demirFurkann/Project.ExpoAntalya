using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class OrderExtra:BaseEntity


	{
        public OrderExtra()
        {
            Extra = new Extra();
        }

        public int OrderID { get; set; }

        public int ExtraID { get; set; }

        //Relational Properties

        public virtual Order Order { get; set; }

        public virtual Extra Extra { get; set; }
    }
}
