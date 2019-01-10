using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontaktverwaltung.Data
{
    public class SaveThis
    {

        public SaveThis()
        {

        }

        public List<Contact> allContacts { get; set; }
        public List<Group> allGroups { get; set; }
        public List<int> usedIDs { get; set; }
    }
}
