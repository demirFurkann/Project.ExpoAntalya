using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {

        public Order()
        {
            OrderExtras = new List<OrderExtra>();
        }

        public DateTime? DeliveryDate { get; set; }

        public int? SaloonID { get; set; }
        public int? EmployeeID { get; set; }

        public int? CustomerID { get; set; }

        public decimal UnitPrice { get; set; }
        public  Activity Active { get; set; }

        //public List<Extra> Extras { get; set; }

       

        public override string ToString()
        {


            if (OrderExtras.Count<1)
            {
                return $"{Saloon.SaloonName} fiyatı => {UnitPrice:C2}";
            }
            string extras = null;

            foreach (OrderExtra item in OrderExtras)
            {
                extras += $"{item.Extra.Name}, ";
            }
            return $"{Saloon.SaloonName} Salonu, İçindeki extralar => {extras} Fiyat: {UnitPrice:C2}";
        }

        public void TutarHesapla()
        {
            UnitPrice = Saloon.UnitPrice;

            switch (Active)
            {
                case Activity.High:
                    UnitPrice += 150;
                    break;
                case Activity.Medium:
                    UnitPrice += 100;
                    break;
                    case Activity.Low:
                    UnitPrice += 50;
                    break;
              
            }

            foreach (OrderExtra item in OrderExtras)
            {
                UnitPrice += item.Extra.UnitPrice;
            }
    
        }

        //Relational Properties

        public virtual Saloon Saloon { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual List<OrderExtra> OrderExtras { get; set; }

    }
}
