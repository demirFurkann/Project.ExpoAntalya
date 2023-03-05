using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class SaloonIssue:BaseEntity
	{
        public SaloonIssue()
        {
            Issue = new Issue();
        }
        public int SaloonID { get; set; }

        public int IssueID { get; set; }

        //Relational Properties

        public virtual Saloon Saloon { get; set; }

        public virtual Issue Issue { get; set; }

    }
}
