using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
	public class SaloonIssueMap:BaseMap<SaloonIssue>
	{
        public SaloonIssueMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.SaloonID,
                x.IssueID
            });
            
        }
    }
}
