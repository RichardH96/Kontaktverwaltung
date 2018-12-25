using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontaktverwaltung.Data
{
	public class Contact
	{
		public Contact()
		{

		}


		public string Name { get; set; }
		public string Surname { get; set; }
		public string street { get; set; }
		public int PLZ { get; set; }
		public string Ort { get; set; }
		public int HouseNr { get; set; }
		public DateTime Birthdate { get; set; }


		public string Email { get; set; }
		public string Telnr { get; set; }

        public bool favorite { get; set; }
        public List<string> groups { get; set; }



    }
}
