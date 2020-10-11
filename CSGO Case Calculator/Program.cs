using System;
using System.Windows.Forms;
using CSGO_Case_Calculator.Properties;

namespace CSGO_Case_Calculator {

	internal static class Program {

		/// <summary>
		///     Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		private static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Settings.Default.Reload();
			Application.Run(new Form_Main());
			Settings.Default.Save();
		}

	}

}