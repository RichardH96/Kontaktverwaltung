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
            this.Members = new List<Contact>();
        }


        public string Name { get; set; }
        public List<Contact> Members { get; set; }
        public string Info { get; set; }
    }
}
