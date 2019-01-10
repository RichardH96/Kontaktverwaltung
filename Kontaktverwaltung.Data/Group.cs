using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontaktverwaltung.Data
{
    public class Group
    {

        public Group()
        {
            this.members = new List<int>();
        }


        public string Name { get; set; }
        public List<int> members { get; set; }
        public string Info { get; set; }
    }
}
