using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Issue:BaseEntity
    {

        public Issue()
        {
            
        }
		//Relational Property
		public virtual List<SaloonIssue> SaloonIssues { get; set; }




		public string Description { get; set; }
        public string IssueType { get; set; }

		public DateTime? DelayDate { get; set; }


		public override string ToString()
        {
            if (Description ==null)
            {
                return $"{IssueType}";
            }
            return $"{IssueType},{Description}";
        }
    }
}
