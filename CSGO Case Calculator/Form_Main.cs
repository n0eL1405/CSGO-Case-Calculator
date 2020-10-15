using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CSGO_Case_Calculator {

	public partial class Form_Main : Form {

		//create httpclients
		private static readonly HttpClient client = new HttpClient();

		private readonly string steammarktcsgo = "https://steamcommunity.com/market/listings/730/";

		private readonly int wait = 3000;

		//strings for the website infos and amount of cases
		public int aBravo;
		public int aBreakout;
		public int aChroma;
		public int aChroma2;
		public int aChroma3;
		public int aClutch;
		public int aCS20;
		public int aCSGOWC;
		public int aCSGOWC2;
		public int aCSGOWC3;
		public int aDangerZone;
		public int aeSports2013;
		public int aeSports2013Winter;
		public int aeSports2014Summer;
		public int aFalchion;
		public int aGamma;
		public int aGamma2;
		public int aGlove;
		public int aHorizon;
		public int aHuntsman;
		public int aHydra;
		public int aPhoenix;
		public int aPrisma;
		public int aPrisma2;
		public int aRevolver;
		public int aShadow;
		public int aShatteredWeb;
		public int aSpectrum;
		public int aSpectrum2;
		public int aVanguard;
		public int aWildfire;
		public int aWinterOffensive;
		public int aFracture;

        public Form_Main() {
			InitializeComponent();
		}

		public String cut(String price) {

			//cute out the min price
			price = price.Remove(0, 32);
			price = price.Remove(price.IndexOf('€'));

			//replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
			price = price.Replace("--", "00");

			return price;
		}

		//save website in string and extract the price
		public async Task Main() {

			var urlsteammarkt =
				"https://steamcommunity.com/market/priceoverview/?appid=730&currency=3&market_hash_name=";

			if (cBxChroma.Checked) {
				try {
					var response = await client.GetAsync(urlsteammarkt + "Chroma%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxChroma.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxChroma.Text = "0";
			}

			if (cBxChroma2.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Chroma%202%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxChroma2.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxChroma2.Text = "0";
			}

			if (cBxChroma3.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Chroma%203%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxChroma3.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxChroma3.Text = "0";
			}

			if (cBxClutch.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Clutch%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxClutch.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxClutch.Text = "0";
			}

			if (cBxCS20.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "CS20%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxCS20.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxCS20.Text = "0";
			}

			if (cBxCSGOWC.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "CS%3AGO%20Weapon%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxCSGOWC.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxCSGOWC.Text = "0";
			}

			if (cBxCSGOWC2.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "CS%3AGO%20Weapon%20Case%202");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxCSGOWC2.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxCSGOWC2.Text = "0";
			}

			if (cBxCSGOWC3.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "CS%3AGO%20Weapon%20Case%203");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxCSGOWC3.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxCSGOWC3.Text = "0";
			}

			if (cBxDangerZone.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Danger%20Zone%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxDangerZone.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxDangerZone.Text = "0";
			}

			if (cBxeSports2013.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "eSports%202013%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxeSports2013.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxeSports2013.Text = "0";
			}

			if (cBxeSports2013W.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "eSports%202013%20Winter%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxeSports2013W.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxeSports2013W.Text = "0";
			}

			if (cBxeSports2014S.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "eSports%202014%20Summer%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxeSports2014S.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxeSports2014S.Text = "0";
			}

			if (cBxFalchion.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Falchion%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxFalchion.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxFalchion.Text = "0";
			}

			if (cBxFracture.Checked)
			{
				await Task.Delay(wait);

				try
				{
					var response = await client.GetAsync(urlsteammarkt + "Fracture%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxFracture.Text = Convert.ToString(price) + "€";
				}
				catch { }
			}
			else
			{
				rTxtBxFracture.Text = "0";
			}

			if (cBxGamma.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Gamma%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxGamma.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxGamma.Text = "0";
			}

			if (cBxGamma2.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Gamma%202%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxGamma2.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxGamma2.Text = "0";
			}

			if (cBxGlove.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Glove%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxGlove.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxGlove.Text = "0";
			}

			if (cBxHorizon.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Horizon%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxHorizon.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxHorizon.Text = "0";
			}

			if (cBxHuntsman.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Huntsman%20Weapon%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxHuntsman.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxHuntsman.Text = "0";
			}

			if (cBxBravo.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Operation%20Bravo%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxBravo.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxBravo.Text = "0";
			}

			if (cBxBreakout.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Operation%20Breakout%20Weapon%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxBreakout.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxBreakout.Text = "0";
			}

			if (cBxHydra.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Operation%20Hydra%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxHydra.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxHydra.Text = "0";
			}

			if (cBxPhoenix.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Operation%20Phoenix%20Weapon%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxPhoenix.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxPhoenix.Text = "0";
			}

			if (cBxVanguard.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Operation%20Vanguard%20Weapon%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxVanguard.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxVanguard.Text = "0";
			}

			if (cBxWildfire.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Operation%20Wildfire%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxWildfire.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxWildfire.Text = "0";
			}

			if (cBxPrisma.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Prisma%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxPrisma.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxPrisma.Text = "0";
			}

			if (cBxPrisma2.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Prisma%202%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxPrisma2.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxPrisma2.Text = "0";
			}

			if (cBxRevolver.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Revolver%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxRevolver.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxRevolver.Text = "0";
			}

			if (cBxShadow.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Shadow%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxShadow.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxShadow.Text = "0";
			}

			if (cBxShatteredWeb.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Shattered%20Web%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxShatteredWeb.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxShatteredWeb.Text = "0";
			}

			if (cBxSpectrum.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Spectrum%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxSpectrum.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxSpectrum.Text = "0";
			}

			if (cBxSpectrum2.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Spectrum%202%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxSpectrum2.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxSpectrum2.Text = "0";
			}

			if (cBxWinterOffensive.Checked) {
				await Task.Delay(wait);

				try {
					var response = await client.GetAsync(urlsteammarkt + "Winter%20Offensive%20Weapon%20Case");
					response.EnsureSuccessStatusCode();
					var price = await response.Content.ReadAsStringAsync();

					price = cut(price);

					rTxtBxWinterOffensive.Text = Convert.ToString(price) + "€";
				}
				catch { }
			} else {
				rTxtBxWinterOffensive.Text = "0";
			}

			//auto calculate
			if (cBxAC.Checked) {
				Calculate();
			}


		}

		//Load all Amounts from the XML-File
		public void LoadCases() {
			//amounts a set in the boxes
			var propertyFolder = Application.StartupPath;
			var CaseXML = propertyFolder + "\\files\\cases.xml";

			var xs = new XmlSerializer(typeof(Cases));
			var read = new FileStream(CaseXML, FileMode.Open, FileAccess.Read, FileShare.Read);
			var cases = (Cases) xs.Deserialize(read);

			//if amount is empty, fill with 0
			if (cases.CHROMA_AMOUNT == "" || !int.TryParse(cases.CHROMA_AMOUNT, out aChroma)) {
				cases.CHROMA_AMOUNT = "0";
			}

			if (cases.CHROMA2_AMOUNT == "" || !int.TryParse(cases.CHROMA2_AMOUNT, out aChroma2)) {
				cases.CHROMA2_AMOUNT = "0";
			}

			if (cases.CHROMA3_AMOUNT == "" || !int.TryParse(cases.CHROMA3_AMOUNT, out aChroma3)) {
				cases.CHROMA3_AMOUNT = "0";
			}

			if (cases.CLUTCH_AMOUNT == "" || !int.TryParse(cases.CLUTCH_AMOUNT, out aClutch)) {
				cases.CLUTCH_AMOUNT = "0";
			}

			if (cases.CS20_AMOUNT == "" || !int.TryParse(cases.CS20_AMOUNT, out aCS20)) {
				cases.CS20_AMOUNT = "0";
			}

			if (cases.CSGOWC_AMOUNT == "" || !int.TryParse(cases.CSGOWC_AMOUNT, out aCSGOWC)) {
				cases.CSGOWC_AMOUNT = "0";
			}

			if (cases.CSGOWC2_AMOUNT == "" || !int.TryParse(cases.CSGOWC2_AMOUNT, out aCSGOWC2)) {
				cases.CSGOWC2_AMOUNT = "0";
			}

			if (cases.CSGOWC3_AMOUNT == "" || !int.TryParse(cases.CSGOWC3_AMOUNT, out aCSGOWC3)) {
				cases.CSGOWC3_AMOUNT = "0";
			}

			if (cases.DANGERZONE_AMOUNT == "" || !int.TryParse(cases.DANGERZONE_AMOUNT, out aDangerZone)) {
				cases.DANGERZONE_AMOUNT = "0";
			}

			if (cases.ESPORTS2013_AMOUNT == "" || !int.TryParse(cases.ESPORTS2013_AMOUNT, out aeSports2013)) {
				cases.ESPORTS2013_AMOUNT = "0";
			}

			if (cases.ESPORTS2013WINTER_AMOUNT == "" ||
			    !int.TryParse(cases.ESPORTS2013WINTER_AMOUNT, out aeSports2013Winter)) {
				cases.ESPORTS2013WINTER_AMOUNT = "0";
			}

			if (cases.ESPORTS2014SUMMER_AMOUNT == "" ||
			    !int.TryParse(cases.ESPORTS2014SUMMER_AMOUNT, out aeSports2013)) {
				cases.ESPORTS2014SUMMER_AMOUNT = "0";
			}

			if (cases.FALCHION_AMOUNT == "" || !int.TryParse(cases.FALCHION_AMOUNT, out aFalchion)) {
				cases.FALCHION_AMOUNT = "0";
			}

			if (cases.GAMMA_AMOUNT == "" || !int.TryParse(cases.GAMMA_AMOUNT, out aGamma)) {
				cases.GAMMA_AMOUNT = "0";
			}

			if (cases.GAMMA2_AMOUNT == "" || !int.TryParse(cases.GAMMA2_AMOUNT, out aGamma2)) {
				cases.GAMMA2_AMOUNT = "0";
			}

			if (cases.GLOVE_AMOUNT == "" || !int.TryParse(cases.GLOVE_AMOUNT, out aGlove)) {
				cases.GLOVE_AMOUNT = "0";
			}

			if (cases.HORIZON_AMOUNT == "" || !int.TryParse(cases.HORIZON_AMOUNT, out aHorizon)) {
				cases.HORIZON_AMOUNT = "0";
			}

			if (cases.HUNTSMAN_AMOUNT == "" || !int.TryParse(cases.HUNTSMAN_AMOUNT, out aHuntsman)) {
				cases.HUNTSMAN_AMOUNT = "0";
			}

			if (cases.BRAVO_AMOUNT == "" || !int.TryParse(cases.BRAVO_AMOUNT, out aBravo)) {
				cases.BRAVO_AMOUNT = "0";
			}

			if (cases.BREAKOUT_AMOUNT == "" || !int.TryParse(cases.BREAKOUT_AMOUNT, out aBreakout)) {
				cases.BREAKOUT_AMOUNT = "0";
			}

			if (cases.HYDRA_AMOUNT == "" || !int.TryParse(cases.HYDRA_AMOUNT, out aHydra)) {
				cases.HYDRA_AMOUNT = "0";
			}

			if (cases.PHOENIX_AMOUNT == "" || !int.TryParse(cases.PHOENIX_AMOUNT, out aPhoenix)) {
				cases.PHOENIX_AMOUNT = "0";
			}

			if (cases.VANGUARD_AMOUNT == "" || !int.TryParse(cases.VANGUARD_AMOUNT, out aVanguard)) {
				cases.VANGUARD_AMOUNT = "0";
			}

			if (cases.WILDFIRE_AMOUNT == "" || !int.TryParse(cases.WILDFIRE_AMOUNT, out aWildfire)) {
				cases.WILDFIRE_AMOUNT = "0";
			}

			if (cases.PRISMA_AMOUNT == "" || !int.TryParse(cases.PRISMA_AMOUNT, out aPrisma)) {
				cases.PRISMA_AMOUNT = "0";
			}

			if (cases.PRISMA2_AMOUNT == "" || !int.TryParse(cases.PRISMA2_AMOUNT, out aPrisma2)) {
				cases.PRISMA2_AMOUNT = "0";
			}

			if (cases.REVOLVER_AMOUNT == "" || !int.TryParse(cases.REVOLVER_AMOUNT, out aRevolver)) {
				cases.REVOLVER_AMOUNT = "0";
			}

			if (cases.SHADOW_AMOUNT == "" || !int.TryParse(cases.SHADOW_AMOUNT, out aShadow)) {
				cases.SHADOW_AMOUNT = "0";
			}

			if (cases.SHATTEREDWEB_AMOUNT == "" || !int.TryParse(cases.SHATTEREDWEB_AMOUNT, out aShatteredWeb)) {
				cases.SHATTEREDWEB_AMOUNT = "0";
			}

			if (cases.SPECTRUM_AMOUNT == "" || !int.TryParse(cases.SPECTRUM_AMOUNT, out aSpectrum)) {
				cases.SPECTRUM_AMOUNT = "0";
			}

			if (cases.SPECTRUM2_AMOUNT == "" || !int.TryParse(cases.SPECTRUM2_AMOUNT, out aSpectrum2)) {
				cases.SPECTRUM2_AMOUNT = "0";
			}

			if (cases.WINTEROFFENSIVE_AMOUNT == "" ||
			    !int.TryParse(cases.WINTEROFFENSIVE_AMOUNT, out aWinterOffensive)) {
				cases.WINTEROFFENSIVE_AMOUNT = "0";
			}

			if (cases.FRACTURE_AMOUNT == "" ||
			    !int.TryParse(cases.FRACTURE_AMOUNT, out aFracture))
			{
				cases.FRACTURE_AMOUNT = "0";
			}

			rTxtBxChromaA.Text = cases.CHROMA_AMOUNT;
			rTxtBxChroma2A.Text = cases.CHROMA2_AMOUNT;
			rTxtBxChroma3A.Text = cases.CHROMA3_AMOUNT;
			rTxtBxClutchA.Text = cases.CLUTCH_AMOUNT;
			rTxtBxCS20A.Text = cases.CS20_AMOUNT;
			rTxtBxCSGOWCA.Text = cases.CSGOWC_AMOUNT;
			rTxtBxCSGOWC2A.Text = cases.CSGOWC2_AMOUNT;
			rTxtBxCSGOWC3A.Text = cases.CSGOWC3_AMOUNT;
			rTxtBxDangerZoneA.Text = cases.DANGERZONE_AMOUNT;
			rTxtBxeSports2013A.Text = cases.ESPORTS2013_AMOUNT;
			rTxtBxeSports2013WA.Text = cases.ESPORTS2013WINTER_AMOUNT;
			rTxtBxeSports2014SA.Text = cases.ESPORTS2014SUMMER_AMOUNT;
			rTxtBxFalchionA.Text = cases.FALCHION_AMOUNT;
			rTxtBxGammaA.Text = cases.GAMMA_AMOUNT;
			rTxtBxGamma2A.Text = cases.GAMMA2_AMOUNT;
			rTxtBxGloveA.Text = cases.GLOVE_AMOUNT;
			rTxtBxHorizonA.Text = cases.HORIZON_AMOUNT;
			rTxtBxHuntsmanA.Text = cases.HUNTSMAN_AMOUNT;
			rTxtBxBravoA.Text = cases.BRAVO_AMOUNT;
			rTxtBxBreakoutA.Text = cases.BREAKOUT_AMOUNT;
			rTxtBxHydraA.Text = cases.HYDRA_AMOUNT;
			rTxtBxPhoenixA.Text = cases.PHOENIX_AMOUNT;
			rTxtBxVanguardA.Text = cases.VANGUARD_AMOUNT;
			rTxtBxWildfireA.Text = cases.WILDFIRE_AMOUNT;
			rTxtBxPrismaA.Text = cases.PRISMA_AMOUNT;
			rTxtBxPrisma2A.Text = cases.PRISMA2_AMOUNT;
			rTxtBxRevolverA.Text = cases.REVOLVER_AMOUNT;
			rTxtBxShadowA.Text = cases.SHADOW_AMOUNT;
			rTxtBxShatteredWebA.Text = cases.SHATTEREDWEB_AMOUNT;
			rTxtBxSpectrumA.Text = cases.SPECTRUM_AMOUNT;
			rTxtBxSpectrum2A.Text = cases.SPECTRUM2_AMOUNT;
			rTxtBxWinterOffensiveA.Text = cases.WINTEROFFENSIVE_AMOUNT;
			rTxtBxFractureA.Text = cases.FRACTURE_AMOUNT;

			//calculate Total Case Amount
			rTxtBxTCA.Text = Convert.ToString(aChroma + aChroma2 + aChroma3 + aClutch + aCS20 + aCSGOWC + aCSGOWC2 +
			                                  aCSGOWC3 + aDangerZone + aeSports2013 + aeSports2013Winter +
			                                  aeSports2014Summer + aFalchion + aGamma +
			                                  aGamma2 + aGlove + aHorizon + aHuntsman + aBravo + aBreakout + aHydra +
			                                  aPhoenix + aVanguard + aWildfire + aPrisma + aPrisma2 + aRevolver +
			                                  aShadow + aShatteredWeb + aSpectrum + aSpectrum2 + aWinterOffensive + aFracture);
		}

		public void SaveAllCases() {
			var cases = new Cases {
				CHROMA_AMOUNT = rTxtBxChromaA.Text,
				CHROMA2_AMOUNT = rTxtBxChroma2A.Text,
				CHROMA3_AMOUNT = rTxtBxChroma3A.Text,
				CLUTCH_AMOUNT = rTxtBxClutchA.Text,
				CS20_AMOUNT = rTxtBxCS20A.Text,
				CSGOWC_AMOUNT = rTxtBxCSGOWCA.Text,
				CSGOWC2_AMOUNT = rTxtBxCSGOWC2A.Text,
				CSGOWC3_AMOUNT = rTxtBxCSGOWC3A.Text,
				DANGERZONE_AMOUNT = rTxtBxDangerZoneA.Text,
				ESPORTS2013_AMOUNT = rTxtBxeSports2013A.Text,
				ESPORTS2013WINTER_AMOUNT = rTxtBxeSports2013WA.Text,
				ESPORTS2014SUMMER_AMOUNT = rTxtBxeSports2014SA.Text,
				FALCHION_AMOUNT = rTxtBxFalchionA.Text,
				GAMMA_AMOUNT = rTxtBxGammaA.Text,
				GAMMA2_AMOUNT = rTxtBxGamma2A.Text,
				GLOVE_AMOUNT = rTxtBxGloveA.Text,
				HORIZON_AMOUNT = rTxtBxHorizonA.Text,
				HUNTSMAN_AMOUNT = rTxtBxHuntsmanA.Text,
				BRAVO_AMOUNT = rTxtBxBravoA.Text,
				BREAKOUT_AMOUNT = rTxtBxBreakoutA.Text,
				HYDRA_AMOUNT = rTxtBxHydraA.Text,
				PHOENIX_AMOUNT = rTxtBxPhoenixA.Text,
				VANGUARD_AMOUNT = rTxtBxVanguardA.Text,
				WILDFIRE_AMOUNT = rTxtBxWildfireA.Text,
				PRISMA_AMOUNT = rTxtBxPrismaA.Text,
				PRISMA2_AMOUNT = rTxtBxPrisma2A.Text,
				REVOLVER_AMOUNT = rTxtBxRevolverA.Text,
				SHADOW_AMOUNT = rTxtBxShadowA.Text,
				SHATTEREDWEB_AMOUNT = rTxtBxShatteredWebA.Text,
				SPECTRUM_AMOUNT = rTxtBxSpectrumA.Text,
				SPECTRUM2_AMOUNT = rTxtBxSpectrum2A.Text,
				WINTEROFFENSIVE_AMOUNT = rTxtBxWinterOffensiveA.Text,
				FRACTURE_AMOUNT = rTxtBxFractureA.Text
			};

			//set path for xml-file
			var propertyFolder = Application.StartupPath;
			var CaseXML = propertyFolder + "\\files\\cases.xml";

			//create fill
			SaveCases.SaveDaten(cases, CaseXML);
		}

		public void Calculate() {
			if (int.TryParse(rTxtBxChromaA.Text, out aChroma)) {
				rTxtBxChromaTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxChroma.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aChroma)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxChromaA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxChroma2A.Text, out aChroma2)) {
				rTxtBxChroma2TV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxChroma2.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aChroma2)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxChroma2A.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxChroma3A.Text, out aChroma3)) {
				rTxtBxChroma3TV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxChroma3.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aChroma3)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxChroma3A.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxClutchA.Text, out aClutch)) {
				rTxtBxClutchTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxClutch.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aClutch)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxClutchA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxCS20A.Text, out aCS20)) {
				rTxtBxCS20TV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxCS20.Text.Replace("€", "")) * Convert.ToDecimal(aCS20)) +
					"€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxCS20A.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxCSGOWCA.Text, out aCSGOWC)) {
				rTxtBxCSGOWCTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxCSGOWC.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aCSGOWC)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxCSGOWCA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxCSGOWC2A.Text, out aCSGOWC2)) {
				rTxtBxCSGOWC2TV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxCSGOWC2.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aCSGOWC2)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxCSGOWC2A.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxCSGOWC3A.Text, out aCSGOWC3)) {
				rTxtBxCSGOWC3TV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxCSGOWC3.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aCSGOWC3)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxCSGOWC3A.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxDangerZoneA.Text, out aDangerZone)) {
				rTxtBxDangerZoneTV.Text = Convert.ToString(Convert.ToDecimal(rTxtBxDangerZone.Text.Replace("€", "")) *
				                                           Convert.ToDecimal(aDangerZone)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxDangerZoneA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxeSports2013A.Text, out aeSports2013)) {
				rTxtBxeSports2013TV.Text = Convert.ToString(Convert.ToDecimal(rTxtBxeSports2013.Text.Replace("€", "")) *
				                                            Convert.ToDecimal(aeSports2013)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxeSports2013A.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxeSports2013WA.Text, out aeSports2013Winter)) {
				rTxtBxeSports2013WTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxeSports2013W.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aeSports2013Winter)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxeSports2013WA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxeSports2014SA.Text, out aeSports2014Summer)) {
				rTxtBxeSports2014STV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxeSports2014S.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aeSports2014Summer)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxeSports2014SA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxFalchionA.Text, out aFalchion)) {
				rTxtBxFalchionTV.Text = Convert.ToString(Convert.ToDecimal(rTxtBxFalchion.Text.Replace("€", "")) *
				                                         Convert.ToDecimal(aFalchion)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxFalchionA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!",
					MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxGammaA.Text, out aGamma)) {
				rTxtBxGammaTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxGamma.Text.Replace("€", "")) * Convert.ToDecimal(aGamma)) +
					"€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxGammaA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxGamma2A.Text, out aGamma2)) {
				rTxtBxGamma2TV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxGamma2.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aGamma2)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxGamma2A.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxGloveA.Text, out aGlove)) {
				rTxtBxGloveTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxGlove.Text.Replace("€", "")) * Convert.ToDecimal(aGlove)) +
					"€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxGloveA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxHorizonA.Text, out aHorizon)) {
				rTxtBxHorizonTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxHorizon.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aHorizon)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxHorizonA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxHuntsmanA.Text, out aHuntsman)) {
				rTxtBxHuntsmanTV.Text = Convert.ToString(Convert.ToDecimal(rTxtBxHuntsman.Text.Replace("€", "")) *
				                                         Convert.ToDecimal(aHuntsman)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxHuntsmanA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!",
					MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxBravoA.Text, out aBravo)) {
				rTxtBxBravoTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxBravo.Text.Replace("€", "")) * Convert.ToDecimal(aBravo)) +
					"€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxBravoA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxBreakoutA.Text, out aBreakout)) {
				rTxtBxBreakoutTV.Text = Convert.ToString(Convert.ToDecimal(rTxtBxBreakout.Text.Replace("€", "")) *
				                                         Convert.ToDecimal(aBreakout)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxBreakoutA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!",
					MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxHydraA.Text, out aHydra)) {
				rTxtBxHydraTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxHydra.Text.Replace("€", "")) * Convert.ToDecimal(aHydra)) +
					"€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxHydraA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxPhoenixA.Text, out aPhoenix)) {
				rTxtBxPhoenixTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxPhoenix.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aPhoenix)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxPhoenixA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxVanguardA.Text, out aVanguard)) {
				rTxtBxVanguardTV.Text = Convert.ToString(Convert.ToDecimal(rTxtBxVanguard.Text.Replace("€", "")) *
				                                         Convert.ToDecimal(aVanguard)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxVanguardA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!",
					MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxWildfireA.Text, out aWildfire)) {
				rTxtBxWildfireTV.Text = Convert.ToString(Convert.ToDecimal(rTxtBxWildfire.Text.Replace("€", "")) *
				                                         Convert.ToDecimal(aWildfire)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxWildfireA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!",
					MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxPrismaA.Text, out aPrisma)) {
				rTxtBxPrismaTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxPrisma.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aPrisma)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxPrismaA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxPrisma2A.Text, out aPrisma2)) {
				rTxtBxPrisma2TV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxPrisma2.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aPrisma2)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxPrisma2A.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxRevolverA.Text, out aRevolver)) {
				rTxtBxRevolverTV.Text = Convert.ToString(Convert.ToDecimal(rTxtBxRevolver.Text.Replace("€", "")) *
				                                         Convert.ToDecimal(aRevolver)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxRevolverA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!",
					MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxShadowA.Text, out aShadow)) {
				rTxtBxShadowTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxShadow.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aShadow)) + "€";
			} else {
				MessageBox.Show("Error: \"" + rTxtBxShadowA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxShatteredWebA.Text, out aShatteredWeb)) {
				rTxtBxShatteredWebTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxShatteredWeb.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aShatteredWeb)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxShatteredWebA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxSpectrumA.Text, out aSpectrum)) {
				rTxtBxSpectrumTV.Text = Convert.ToString(Convert.ToDecimal(rTxtBxSpectrum.Text.Replace("€", "")) *
				                                         Convert.ToDecimal(aSpectrum)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxSpectrumA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!",
					MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxSpectrum2A.Text, out aSpectrum2)) {
				rTxtBxSpectrum2TV.Text = Convert.ToString(Convert.ToDecimal(rTxtBxSpectrum2.Text.Replace("€", "")) *
				                                          Convert.ToDecimal(aSpectrum2)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxSpectrum2A.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!",
					MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxWinterOffensiveA.Text, out aWinterOffensive)) {
				rTxtBxWinterOffensiveTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxWinterOffensive.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aWinterOffensive)) + "€";
			} else {
				MessageBox.Show(
					"Error: \"" + rTxtBxWinterOffensiveA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			if (int.TryParse(rTxtBxFractureA.Text, out aFracture))
			{
				rTxtBxFractureTV.Text =
					Convert.ToString(Convert.ToDecimal(rTxtBxFracture.Text.Replace("€", "")) *
					                 Convert.ToDecimal(aFracture)) + "€";
			}
			else
			{
				MessageBox.Show(
					"Error: \"" + rTxtBxFractureA.Text + "\" is not a number! \nPlease enter a valid number",
					"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}

			//check if all amounts are numbers
			var allsave = int.TryParse(rTxtBxChromaA.Text, out aChroma) &&
			              int.TryParse(rTxtBxChroma2A.Text, out aChroma2) &&
			              int.TryParse(rTxtBxChroma3A.Text, out aChroma3) &&
			              int.TryParse(rTxtBxClutchA.Text, out aClutch) &&
			              int.TryParse(rTxtBxCS20A.Text, out aCS20) && int.TryParse(rTxtBxCSGOWCA.Text, out aCSGOWC) &&
			              int.TryParse(rTxtBxCSGOWC2A.Text, out aCSGOWC2) &&
			              int.TryParse(rTxtBxCSGOWC3A.Text, out aCSGOWC3) &&
			              int.TryParse(rTxtBxDangerZoneA.Text, out aDangerZone) &&
			              int.TryParse(rTxtBxeSports2013A.Text, out aeSports2013) &&
			              int.TryParse(rTxtBxeSports2013WA.Text, out aeSports2013Winter) &&
			              int.TryParse(rTxtBxeSports2014SA.Text, out aeSports2014Summer) &&
			              int.TryParse(rTxtBxFalchionA.Text, out aFalchion) &&
			              int.TryParse(rTxtBxGammaA.Text, out aGamma) &&
			              int.TryParse(rTxtBxGamma2A.Text, out aGamma2) &&
			              int.TryParse(rTxtBxGloveA.Text, out aGlove) &&
			              int.TryParse(rTxtBxHorizonA.Text, out aHorizon) &&
			              int.TryParse(rTxtBxHuntsmanA.Text, out aHuntsman) &&
			              int.TryParse(rTxtBxBravoA.Text, out aBravo) &&
			              int.TryParse(rTxtBxBreakoutA.Text, out aBreakout) &&
			              int.TryParse(rTxtBxHydraA.Text, out aHydra) &&
			              int.TryParse(rTxtBxPhoenixA.Text, out aPhoenix) &&
			              int.TryParse(rTxtBxVanguardA.Text, out aVanguard) &&
			              int.TryParse(rTxtBxWildfireA.Text, out aWildfire) &&
			              int.TryParse(rTxtBxPrismaA.Text, out aPrisma) &&
			              int.TryParse(rTxtBxPrisma2A.Text, out aPrisma2) &&
			              int.TryParse(rTxtBxRevolverA.Text, out aRevolver) &&
			              int.TryParse(rTxtBxShadowA.Text, out aShadow) &&
			              int.TryParse(rTxtBxShatteredWebA.Text, out aShatteredWeb) &&
			              int.TryParse(rTxtBxSpectrumA.Text, out aSpectrum) &&
			              int.TryParse(rTxtBxSpectrum2A.Text, out aSpectrum2) &&
			              int.TryParse(rTxtBxWinterOffensiveA.Text, out aWinterOffensive) &&
			              int.TryParse(rTxtBxFractureA.Text, out aFracture);

			if (allsave) {
				//calculate Total Case Value
				rTxtBxTCV.Text = "";
				rTxtBxTCV.Text = Convert.ToString(Convert.ToDecimal(rTxtBxChromaTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxChroma2TV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxChroma3TV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxClutchTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxCS20TV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxCSGOWCTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxCSGOWC2TV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxCSGOWC3TV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxDangerZoneTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxeSports2013TV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxeSports2013WTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxeSports2014STV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxFalchionTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxGammaTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxGamma2TV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxGloveTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxHorizonTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxHuntsmanTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxBravoTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxBreakoutTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxHydraTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxPhoenixTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxVanguardTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxWildfireTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxPrismaTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxPrisma2TV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxRevolverTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxShadowTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxShatteredWebTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxSpectrumTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxSpectrum2TV.Text.Replace("€", "")) + 
				                                  Convert.ToDecimal(rTxtBxWinterOffensiveTV.Text.Replace("€", "")) +
				                                  Convert.ToDecimal(rTxtBxFractureTV.Text.Replace("€", ""))
				                                  ) +  "€";

				//calculate Total Case Amount
				rTxtBxTCA.Text = Convert.ToString(aChroma + aChroma2 + aChroma3 + aClutch + aCS20 + aCSGOWC + aCSGOWC2 +
				                                  aCSGOWC3 + aDangerZone + aeSports2013 + aeSports2013Winter +
				                                  aeSports2014Summer + aFalchion + aGamma +
				                                  aGamma2 + aGlove + aHorizon + aHuntsman + aBravo + aBreakout +
				                                  aHydra + aPhoenix + aVanguard + aWildfire + aPrisma + aPrisma2 +
				                                  aRevolver + aShadow + aShatteredWeb + aSpectrum + aSpectrum2 +
				                                  aWinterOffensive + aFracture);
			}
		}

		//Button to reload all prices
		public async void btnLoad_Click(object sender, EventArgs e) {

			rTxtBxChroma.Text = "";
			rTxtBxChroma2.Text = "";
			rTxtBxChroma3.Text = "";
			rTxtBxClutch.Text = "";
			rTxtBxCS20.Text = "";
			rTxtBxCSGOWC.Text = "";
			rTxtBxCSGOWC2.Text = "";
			rTxtBxCSGOWC3.Text = "";
			rTxtBxDangerZone.Text = "";
			rTxtBxeSports2013.Text = "";
			rTxtBxeSports2013W.Text = "";
			rTxtBxeSports2014S.Text = "";
			rTxtBxFalchion.Text = "";
			rTxtBxGamma.Text = "";
			rTxtBxGamma2.Text = "";
			rTxtBxGlove.Text = "";
			rTxtBxHorizon.Text = "";
			rTxtBxHuntsman.Text = "";
			rTxtBxBravo.Text = "";
			rTxtBxBreakout.Text = "";
			rTxtBxHydra.Text = "";
			rTxtBxPhoenix.Text = "";
			rTxtBxVanguard.Text = "";
			rTxtBxWildfire.Text = "";
			rTxtBxPrisma.Text = "";
			rTxtBxPrisma2.Text = "";
			rTxtBxRevolver.Text = "";
			rTxtBxShadow.Text = "";
			rTxtBxShatteredWeb.Text = "";
			rTxtBxSpectrum.Text = "";
			rTxtBxSpectrum2.Text = "";
			rTxtBxWinterOffensive.Text = "";
			rTxtBxFracture.Text = "";

			await Main();
		}

		//calculate the values
		private void btnRefresh_Click(object sender, EventArgs e) {
			Calculate();
		}

		//save amounts in a xml-file
		private void btnSaveCases_Click(object sender, EventArgs e) {
			try {
				SaveAllCases();
				MessageBox.Show("Cases saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch { }
		}

		//button to load all saved amounts if something went wrong on startup
		public void btnLoadSavedCases_Click(object sender, EventArgs e) {
			//Load all Amounts
			LoadCases();
		}

		//open options window
		private void btnOptns_Click_1(object sender, EventArgs e) {
			new Form_Options().Show();
		}

		private async void Form_Main_Load(object sender, EventArgs e) {
			var propertyFolder = Application.StartupPath;

			//string propertyFolder = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents") + "\\CSGOCC";
			var CaseXML = propertyFolder + "\\files\\cases.xml";

			if (Directory.Exists(propertyFolder + "\\files")) {
				if (File.Exists(CaseXML)) {
					//Load all Amounts
					LoadCases();
				} else {
					//on first startup a file will be create where every amount is set to 0 (to avoid bugs when calculating)
					var casesempty = new Cases {
						CHROMA_AMOUNT = "0",
						CHROMA2_AMOUNT = "0",
						CHROMA3_AMOUNT = "0",
						CLUTCH_AMOUNT = "0",
						CS20_AMOUNT = "0",
						CSGOWC_AMOUNT = "0",
						CSGOWC2_AMOUNT = "0",
						CSGOWC3_AMOUNT = "0",
						DANGERZONE_AMOUNT = "0",
						ESPORTS2013_AMOUNT = "0",
						ESPORTS2013WINTER_AMOUNT = "0",
						ESPORTS2014SUMMER_AMOUNT = "0",
						FALCHION_AMOUNT = "0",
						GAMMA_AMOUNT = "0",
						GAMMA2_AMOUNT = "0",
						GLOVE_AMOUNT = "0",
						HORIZON_AMOUNT = "0",
						HUNTSMAN_AMOUNT = "0",
						BRAVO_AMOUNT = "0",
						BREAKOUT_AMOUNT = "0",
						HYDRA_AMOUNT = "0",
						PHOENIX_AMOUNT = "0",
						VANGUARD_AMOUNT = "0",
						WILDFIRE_AMOUNT = "0",
						PRISMA_AMOUNT = "0",
						PRISMA2_AMOUNT = "0",
						REVOLVER_AMOUNT = "0",
						SHADOW_AMOUNT = "0",
						SHATTEREDWEB_AMOUNT = "0",
						SPECTRUM_AMOUNT = "0",
						SPECTRUM2_AMOUNT = "0",
						WINTEROFFENSIVE_AMOUNT = "0",
						FRACTURE_AMOUNT = "0"
					};

					//create file
					SaveCases.SaveDaten(casesempty, CaseXML);
				}
			} else {
				var directoryInfo = Directory.CreateDirectory(propertyFolder + "\\files");
				var di = directoryInfo;

				//on first startup a file will be create where every amount is set to 0 (to avoid bugs when calculating)
				var casesempty = new Cases {
					CHROMA_AMOUNT = "0",
					CHROMA2_AMOUNT = "0",
					CHROMA3_AMOUNT = "0",
					CLUTCH_AMOUNT = "0",
					CS20_AMOUNT = "0",
					CSGOWC_AMOUNT = "0",
					CSGOWC2_AMOUNT = "0",
					CSGOWC3_AMOUNT = "0",
					DANGERZONE_AMOUNT = "0",
					ESPORTS2013_AMOUNT = "0",
					ESPORTS2013WINTER_AMOUNT = "0",
					ESPORTS2014SUMMER_AMOUNT = "0",
					FALCHION_AMOUNT = "0",
					GAMMA_AMOUNT = "0",
					GAMMA2_AMOUNT = "0",
					GLOVE_AMOUNT = "0",
					HORIZON_AMOUNT = "0",
					HUNTSMAN_AMOUNT = "0",
					BRAVO_AMOUNT = "0",
					BREAKOUT_AMOUNT = "0",
					HYDRA_AMOUNT = "0",
					PHOENIX_AMOUNT = "0",
					VANGUARD_AMOUNT = "0",
					WILDFIRE_AMOUNT = "0",
					PRISMA_AMOUNT = "0",
					PRISMA2_AMOUNT = "0",
					REVOLVER_AMOUNT = "0",
					SHADOW_AMOUNT = "0",
					SHATTEREDWEB_AMOUNT = "0",
					SPECTRUM_AMOUNT = "0",
					SPECTRUM2_AMOUNT = "0",
					WINTEROFFENSIVE_AMOUNT = "0",
					FRACTURE_AMOUNT = "0"
				};

				//create file
				SaveCases.SaveDaten(casesempty, CaseXML);
			}

			//load all amounts on startup
			await Main();
		}

		//Closing the program with asking to save cases ("Closeing" to make it different to the standard Form.Closing() method)
		private void Closeing() {
			var ExitMsgBx = MessageBox.Show("Save cases befor closing?", "Save cases?", MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

			if (ExitMsgBx == DialogResult.Yes) {
				try {
					SaveAllCases();
				}
				catch { }

				Properties.Settings.Default.Save();
				Environment.Exit(0);
			} else if (ExitMsgBx == DialogResult.No) {
				Properties.Settings.Default.Save();
				Environment.Exit(0);
			} else if (ExitMsgBx == DialogResult.Cancel) { }
		}

		private void Form_Main_Exit(object sender, FormClosingEventArgs e) {
			//block closing by the user using the "X"
			e.Cancel = e.CloseReason == CloseReason.UserClosing;

			Closeing();
		}

		public void btnExit_Click(object sender, EventArgs e) {
			Closeing();
		}

		//Links for LinkLabels
		private void lLblChroma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Chroma%20Case");
		}

		private void lLblChroma2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Chroma%202%20Case");
		}

		private void lLblChroma3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Chroma%203%20Case");
		}

		private void lLblClutch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Clutch%20Case");
		}

		private void lLblCS20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "CS20%20Case");
		}

		private void lLblCSGOWC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "CS%3AGO%20Weapon%20Case");
		}

		private void lLblCSGOWC2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "CS%3AGO%20Weapon%20Case%202");
		}

		private void lLblCSGOWC3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "CS%3AGO%20Weapon%20Case%203");
		}

		private void lLblDangerZone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Danger%20Zone%20Case");
		}

		private void lLbleSports2013_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "eSports%202013%20Case");
		}

		private void lLbleSports2013W_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "eSports%202013%20Winter%20Case");
		}

		private void lLbleSports2014S_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "eSports%202014%20Summer%20Case");
		}

		private void lLblFalchion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Falchion%20Case");
		}

		private void lLblGamma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Gamma%20Case");
		}

		private void lLblGamma2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Gamma%202%20Case");
		}

		private void lLblGlove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Glove%20Case");
		}

		private void lLblHorizon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Horizon%20Case");
		}

		private void lLblHuntsman_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Huntsman%20Weapon%20Case");
		}

		private void lLblBravo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Operation%20Bravo%20Case");
		}

		private void lLblBreakout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Operation%20Breakout%20Weapon%20Case");
		}

		private void lLblHydra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Operation%20Hydra%20Case");
		}

		private void lLblPhoenix_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Operation%20Phoenix%20Weapon%20Case");
		}

		private void lLblVanguard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Operation%20Vanguard%20Weapon%20Case");
		}

		private void lLblWildfire_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Operation%20Wildfire%20Case");
		}

		private void lLblPrisma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Prisma%20Case");
		}

		private void lLblPrisma2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Prisma%202%20Case");
		}

		private void lLblRevolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Revolver%20Case");
		}

		private void lLblShadow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Shadow%20Case");
		}

		private void lLblShatteredWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Shattered%20Web%20Case");
		}

		private void lLblSpectrum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Spectrum%20Case");
		}

		private void lLblSpectrum2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Spectrum%202%20Case");
		}

		private void lLblWinterOffensive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Winter%20Offensive%20Weapon%20Case");
		}

		private void lLblFracture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Fracture%20Case");
		}

		//stuff that i don't need and created accidentally
		private void rTxtBxTCA_TextChanged(object sender, EventArgs e) { }

		private void lblTotalCaseValue_Click(object sender, EventArgs e) { }

		private void rTxtBxTCV_TextChanged(object sender, EventArgs e) { }

		private void rTxtBxChromaTV_TextChanged(object sender, EventArgs e) { }

		private void pnl1_Paint(object sender, PaintEventArgs e) { }

		//class to save the amount
		public class SaveCases {

			public static void SaveDaten(object obj, string filename) {
				var sr = new XmlSerializer(obj.GetType());
				TextWriter writer = new StreamWriter(filename);
				sr.Serialize(writer, obj);
				writer.Close();
			}

		}

		//class to creat a string for each case to get saved
		public class Cases {

			public string CHROMA_AMOUNT { get; set; }

			public string CHROMA2_AMOUNT { get; set; }

			public string CHROMA3_AMOUNT { get; set; }

			public string CLUTCH_AMOUNT { get; set; }

			public string CS20_AMOUNT { get; set; }

			public string CSGOWC_AMOUNT { get; set; }

			public string CSGOWC2_AMOUNT { get; set; }

			public string CSGOWC3_AMOUNT { get; set; }

			public string DANGERZONE_AMOUNT { get; set; }

			public string ESPORTS2013_AMOUNT { get; set; }

			public string ESPORTS2013WINTER_AMOUNT { get; set; }

			public string ESPORTS2014SUMMER_AMOUNT { get; set; }

			public string FALCHION_AMOUNT { get; set; }

			public string GAMMA_AMOUNT { get; set; }

			public string GAMMA2_AMOUNT { get; set; }

			public string GLOVE_AMOUNT { get; set; }

			public string HORIZON_AMOUNT { get; set; }

			public string HUNTSMAN_AMOUNT { get; set; }

			public string BRAVO_AMOUNT { get; set; }

			public string BREAKOUT_AMOUNT { get; set; }

			public string HYDRA_AMOUNT { get; set; }

			public string PHOENIX_AMOUNT { get; set; }

			public string VANGUARD_AMOUNT { get; set; }

			public string WILDFIRE_AMOUNT { get; set; }

			public string PRISMA_AMOUNT { get; set; }

			public string PRISMA2_AMOUNT { get; set; }

			public string REVOLVER_AMOUNT { get; set; }

			public string SHADOW_AMOUNT { get; set; }

			public string SHATTEREDWEB_AMOUNT { get; set; }

			public string SPECTRUM_AMOUNT { get; set; }

			public string SPECTRUM2_AMOUNT { get; set; }

			public string WINTEROFFENSIVE_AMOUNT { get; set; }

			public string FRACTURE_AMOUNT { get; set; }

		}
    }
}