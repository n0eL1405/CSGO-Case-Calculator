using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CSGO_Case_Calculator
{

    public class UserSettings {
		
		public string currency;
		public int currencyCode;

		public class Settings {

			public string Warning = "WARNING! Do not change anything here! If you do, the program could stop working!";
			public int Currency { get; set; }
		}

		public void saveSettings()
		{

			var propertyFolder = Application.StartupPath;
			var path = @propertyFolder + "\\files\\settings.xml";

			Form_Options Form_Options = new Form_Options();

			if (currency.Equals("$"))
			{
				currencyCode = 1;
			}
			else if (currency.Equals("£"))
			{
				currencyCode = 2;
			}
			else if (currency.Equals("€"))
			{
				currencyCode = 3;
			}

			var settings = new Settings
			{
				Warning = "WARNING! Do not change anything here! If you do, the program could stop working!",
				Currency = currencyCode
			};

			var sr = new XmlSerializer(settings.GetType());
			TextWriter writer = new StreamWriter(path);
			sr.Serialize(writer, settings);
			writer.Close();
		}

		public void loadSettings() {

			var propertyFolder = Application.StartupPath;
			var path = @propertyFolder + "\\files\\settings.xml";

			if (File.Exists(path)) {
				var xs = new XmlSerializer(typeof(Settings));
                var read = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                Settings settings = (Settings)xs.Deserialize(read);

                currencyCode = settings.Currency;

                if (currencyCode == 1)
                {
	                currency = "$";
                }
                else if (currencyCode == 2)
                {
	                currency = "£";
                }
                else if (currencyCode == 3)
                {
	                currency = "€";
                }

				read.Close();

			} else {

				currency = "$";
	            currencyCode = 1;
            }
		}
    }
}
