using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Stand:BaseEntity
    {
        public string Area { get; set; }
        public int? SaloonID { get; set; }

        //Relational properties


        public virtual Saloon Saloon { get; set; }
    }
}
