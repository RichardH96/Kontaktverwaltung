using Kontaktverwaltung.Login;
using Kontaktverwaltung.Login.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontaktverwaltung
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			FormLogin formLogin = new FormLogin();
			formLogin.ShowDialog();
			if(formLogin.DialogResult==DialogResult.OK)
			{
				Application.Run(new FormMain(formLogin.UserName));
			}
			//Application.Run(new FormMain());
		}
	}
}
