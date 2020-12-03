using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using CSGO_Case_Calculator.Properties;

namespace CSGO_Case_Calculator {

	public partial class Form_Main : Form {

		//create httpclients
		private static readonly HttpClient client = new HttpClient();

		//implements UserSettings.cs
		public static UserSettings userSettings = new UserSettings();

		private readonly string steammarktcsgo = "https://steamcommunity.com/market/listings/730/";

		private readonly int wait = 3000;

		//strings for the website infos and amount of cases
		public int aBravo;
		public int aBreakout;
		public int aBrokenFang;
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
		public int aFracture;
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

		//prices
		public string pBravo = "0";
		public string pBreakout = "0";
		public string pBrokenFang = "0";
		public string pChroma = "0";
		public string pChroma2 = "0";
		public string pChroma3 = "0";
		public string pClutch = "0";
		public string pCS20 = "0";
		public string pCSGOWC = "0";
		public string pCSGOWC2 = "0";
		public string pCSGOWC3 = "0";
		public string pDangerZone = "0";
		public string peSports2013 = "0";
		public string peSports2013Winter = "0";
		public string peSports2014Summer = "0";
		public string pFalchion = "0";
		public string pFracture = "0";
		public string pGamma = "0";
		public string pGamma2 = "0";
		public string pGlove = "0";
		public string pHorizon = "0";
		public string pHuntsman = "0";
		public string pHydra = "0";
		public string pPhoenix = "0";
		public string pPrisma = "0";
		public string pPrisma2 = "0";
		public string pRevolver = "0";
		public string pShadow = "0";
		public string pShatteredWeb = "0";
		public string pSpectrum = "0";
		public string pSpectrum2 = "0";
		public string pVanguard = "0";
		public string pWildfire = "0";
		public string pWinterOffensive = "0";

		public string totalCaseAmount;
		public string totalCaseValue;

		//total values
		public string tvBravo = "0";
		public string tvBreakout = "0";
		public string tvBrokenFang = "0";
		public string tvChroma = "0";
		public string tvChroma2 = "0";
		public string tvChroma3 = "0";
		public string tvClutch = "0";
		public string tvCS20 = "0";
		public string tvCSGOWC = "0";
		public string tvCSGOWC2 = "0";
		public string tvCSGOWC3 = "0";
		public string tvDangerZone = "0";
		public string tveSports2013 = "0";
		public string tveSports2013Winter = "0";
		public string tveSports2014Summer = "0";
		public string tvFalchion = "0";
		public string tvFracture = "0";
		public string tvGamma = "0";
		public string tvGamma2 = "0";
		public string tvGlove = "0";
		public string tvHorizon = "0";
		public string tvHuntsman = "0";
		public string tvHydra = "0";
		public string tvPhoenix = "0";
		public string tvPrisma = "0";
		public string tvPrisma2 = "0";
		public string tvRevolver = "0";
		public string tvShadow = "0";
		public string tvShatteredWeb = "0";
		public string tvSpectrum = "0";
		public string tvSpectrum2 = "0";
		public string tvVanguard = "0";
		public string tvWildfire = "0";
		public string tvWinterOffensive = "0";

		public Form_Main() {

			InitializeComponent();
		}

		//save website in string and extract the price
		public async void Main() {

			await loadPrices();

			//auto calculate
			if (cBxAC.Checked) {
				Calculate();
			}
		}

		public async Task<string> getPrice(String url) {

			userSettings.loadSettings();

			var response = await client.GetAsync(url);
			response.EnsureSuccessStatusCode();
			string price = await response.Content.ReadAsStringAsync();

			//cut the price
			price = price.Remove(0, 32);
			price = price.Remove(price.IndexOf("\""));
			price = price.Replace(userSettings.currency, "");
			price = price.Replace(".", ",");

			//replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
			price = price.Replace("--", "00");

			return price;
		}

		//load all the prices
		public async Task loadPrices() {
			userSettings.loadSettings();

			var urlsteammarkt =
				"https://steamcommunity.com/market/priceoverview/?appid=730&currency=" + userSettings.currencyCode +
				"&market_hash_name=";

			if (cBxChroma.Checked) {
				try {
					string price = await getPrice(urlsteammarkt + "Chroma%20Case");
					pChroma = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pChroma = "0";
			}

			writePrices();

			if (cBxChroma2.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Chroma%202%20Case");
					pChroma2 = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pChroma2 = "0";
			}

			writePrices();

			if (cBxChroma3.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Chroma%203%20Case");
					pChroma3 = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pChroma3 = "0";
			}

			writePrices();

			if (cBxClutch.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Clutch%20Case");
					pClutch = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pClutch = "0";
			}

			writePrices();

			if (cBxCS20.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "CS20%20Case");
					pCS20 = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pCS20 = "0";
			}

			writePrices();

			if (cBxCSGOWC.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "CS%3AGO%20Weapon%20Case");
					pCSGOWC = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pCSGOWC2 = "0";
			}

			writePrices();

			if (cBxCSGOWC2.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "CS%3AGO%20Weapon%20Case%202");
					pCSGOWC2 = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pCSGOWC2 = "0";
			}

			writePrices();

			if (cBxCSGOWC3.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "CS%3AGO%20Weapon%20Case%203");
					pCSGOWC3 = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pCSGOWC3 = "0";
			}

			writePrices();

			if (cBxDangerZone.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Danger%20Zone%20Case");
					pDangerZone = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pDangerZone = "0";
			}

			writePrices();

			if (cBxeSports2013.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "eSports%202013%20Case");
					peSports2013 = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				peSports2013 = "0";
			}

			writePrices();

			if (cBxeSports2013W.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "eSports%202013%20Winter%20Case");
					peSports2013Winter = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				peSports2013Winter = "0";
			}

			writePrices();

			if (cBxeSports2014S.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "eSports%202014%20Summer%20Case");
					peSports2014Summer = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				peSports2014Summer = "0";
			}

			writePrices();

			if (cBxFalchion.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Falchion%20Case");
					pFalchion = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pFalchion = "0";
			}

			writePrices();

			if (cBxFracture.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Fracture%20Case");
					pFracture = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pFracture = "0";
			}

			writePrices();

			if (cBxGamma.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Gamma%20Case");
					pGamma = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pGamma = "0";
			}

			writePrices();

			if (cBxGamma2.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Gamma%202%20Case");
					pGamma2 = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pGamma2 = "0";
			}

			writePrices();

			if (cBxGlove.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Glove%20Case");
					pGlove = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pGlove = "0";
			}

			writePrices();

			if (cBxHorizon.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Horizon%20Case");
					pHorizon = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pHorizon = "0";
			}

			writePrices();

			if (cBxHuntsman.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Huntsman%20Weapon%20Case");
					pHuntsman = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pHuntsman = "0";
			}

			writePrices();

			if (cBxBravo.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Operation%20Bravo%20Case");
					pBravo = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pBravo = "0";
			}

			writePrices();

			if (cBxBreakout.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Operation%20Breakout%20Weapon%20Case");
					pBreakout = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pBreakout = "0";
			}

			writePrices();

			if (cBxBrokenFang.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Operation%20Broken%20Fang%20Case");
					pBrokenFang = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pBrokenFang = "0";
			}

			writePrices();

			if (cBxHydra.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Operation%20Hydra%20Case");
					pHydra = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pHydra = "0";
			}

			writePrices();

			if (cBxPhoenix.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Operation%20Phoenix%20Weapon%20Case");
					pPhoenix = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pPhoenix = "0";
			}

			writePrices();

			if (cBxVanguard.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Operation%20Vanguard%20Weapon%20Case");
					pVanguard = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pVanguard = "0";
			}

			writePrices();

			if (cBxWildfire.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Operation%20Wildfire%20Case");
					pWildfire = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pWildfire = "0";
			}

			writePrices();

			if (cBxPrisma.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Prisma%20Case");
					pPrisma = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pPrisma = "0";
			}

			writePrices();

			if (cBxPrisma2.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Prisma%202%20Case");
					pPrisma2 = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pPrisma2 = "0";
			}

			writePrices();

			if (cBxRevolver.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Revolver%20Case");
					pRevolver = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pRevolver = "0";
			}

			writePrices();

			if (cBxShadow.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Shadow%20Case");
					pShadow = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pShadow = "0";
			}

			writePrices();

			if (cBxShatteredWeb.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Shattered%20Web%20Case");
					pShatteredWeb = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pShatteredWeb = "0";
			}

			writePrices();

			if (cBxSpectrum.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Spectrum%20Case");
					pSpectrum = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pSpectrum = "0";
			}

			writePrices();

			if (cBxSpectrum2.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Spectrum%202%20Case");
					pSpectrum2 = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pSpectrum2 = "0";
			}

			writePrices();

			if (cBxWinterOffensive.Checked) {
				await Task.Delay(wait);

				try {
					string price = await getPrice(urlsteammarkt + "Winter%20Offensive%20Weapon%20Case");
					pWinterOffensive = Convert.ToString(price) + userSettings.currency;
				}
				catch { }
			} else {
				pWinterOffensive = "0";
			}

			writePrices();
		}

        //write all prices in text boxes
        public void writePrices() {

			rTxtBxChroma.Text = pChroma;
			rTxtBxChroma2.Text = pChroma2;
			rTxtBxChroma3.Text = pChroma3;
			rTxtBxClutch.Text = pClutch;
			rTxtBxCS20.Text = pCS20;
			rTxtBxCSGOWC.Text = pCSGOWC;
			rTxtBxCSGOWC2.Text = pCSGOWC2;
			rTxtBxCSGOWC3.Text = pCSGOWC3;
			rTxtBxDangerZone.Text = pDangerZone;
			rTxtBxeSports2013.Text = peSports2013;
			rTxtBxeSports2013W.Text = peSports2013Winter;
			rTxtBxeSports2014S.Text = peSports2014Summer;
			rTxtBxFalchion.Text = pFalchion;
			rTxtBxFracture.Text = pFracture;
			rTxtBxGamma.Text = pGamma;
			rTxtBxGamma2.Text = pGamma2;
			rTxtBxGlove.Text = pGlove;
			rTxtBxHorizon.Text = pHorizon;
			rTxtBxHuntsman.Text = pHuntsman;
			rTxtBxBravo.Text = pBravo;
			rTxtBxBreakout.Text = pBreakout;
			rTxtBxBrokenFang.Text = pBrokenFang;
			rTxtBxHydra.Text = pHydra;
			rTxtBxPhoenix.Text = pPhoenix;
			rTxtBxVanguard.Text = pVanguard;
			rTxtBxWildfire.Text = pWildfire;
			rTxtBxPrisma.Text = pPrisma;
			rTxtBxPrisma2.Text = pPrisma2;
			rTxtBxRevolver.Text = pRevolver;
			rTxtBxShadow.Text = pShadow;
			rTxtBxShatteredWeb.Text = pShatteredWeb;
			rTxtBxSpectrum.Text = pSpectrum;
			rTxtBxSpectrum2.Text = pSpectrum2;
			rTxtBxWinterOffensive.Text = pWinterOffensive;
		}

		//load all Amounts from the XML-File
		public void LoadCases() {
			//amounts a set in the boxes
			var propertyFolder = Application.StartupPath;
			var CaseXML = @propertyFolder + "\\files\\cases.xml";

			var xs = new XmlSerializer(typeof(Cases));
			var read = new FileStream(CaseXML, FileMode.Open, FileAccess.Read, FileShare.Read);
			var cases = (Cases) xs.Deserialize(read);

			//if amount is empty or not a number, fill with 0
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

			if (cases.BROKEN_FANG_AMOUNT == "" || !int.TryParse(cases.BROKEN_FANG_AMOUNT, out aBrokenFang))
			{
				cases.BROKEN_FANG_AMOUNT = "0";
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
			    !int.TryParse(cases.FRACTURE_AMOUNT, out aFracture)) {
				cases.FRACTURE_AMOUNT = "0";
			}

			aChroma = int.Parse(cases.CHROMA_AMOUNT);
			aChroma2 = int.Parse(cases.CHROMA2_AMOUNT);
			aChroma3 = int.Parse(cases.CHROMA3_AMOUNT);
			aClutch = int.Parse(cases.CLUTCH_AMOUNT);
			aCS20 = int.Parse(cases.CS20_AMOUNT);
			aCSGOWC = int.Parse(cases.CSGOWC_AMOUNT);
			aCSGOWC2 = int.Parse(cases.CSGOWC2_AMOUNT);
			aCSGOWC3 = int.Parse(cases.CSGOWC3_AMOUNT);
			aDangerZone = int.Parse(cases.DANGERZONE_AMOUNT);
			aeSports2013 = int.Parse(cases.ESPORTS2013_AMOUNT);
			aeSports2013Winter = int.Parse(cases.ESPORTS2013WINTER_AMOUNT);
			aeSports2014Summer = int.Parse(cases.ESPORTS2014SUMMER_AMOUNT);
			aFalchion = int.Parse(cases.FALCHION_AMOUNT);
			aGamma = int.Parse(cases.GAMMA_AMOUNT);
			aGamma2 = int.Parse(cases.GAMMA2_AMOUNT);
			aGlove = int.Parse(cases.GLOVE_AMOUNT);
			aHorizon = int.Parse(cases.HORIZON_AMOUNT);
			aHuntsman = int.Parse(cases.HUNTSMAN_AMOUNT);
			aBravo = int.Parse(cases.BRAVO_AMOUNT);
			aBreakout = int.Parse(cases.BREAKOUT_AMOUNT);
			aBrokenFang = int.Parse(cases.BROKEN_FANG_AMOUNT);
			aHydra = int.Parse(cases.HYDRA_AMOUNT);
			aPhoenix = int.Parse(cases.PHOENIX_AMOUNT);
			aVanguard = int.Parse(cases.VANGUARD_AMOUNT);
			aWildfire = int.Parse(cases.WILDFIRE_AMOUNT);
			aPrisma = int.Parse(cases.PRISMA_AMOUNT);
			aPrisma2 = int.Parse(cases.PRISMA2_AMOUNT);
			aRevolver = int.Parse(cases.REVOLVER_AMOUNT);
			aShadow = int.Parse(cases.SHADOW_AMOUNT);
			aShatteredWeb = int.Parse(cases.SHATTEREDWEB_AMOUNT);
			aSpectrum = int.Parse(cases.SPECTRUM_AMOUNT);
			aSpectrum2 = int.Parse(cases.SPECTRUM2_AMOUNT);
			aWinterOffensive = int.Parse(cases.WINTEROFFENSIVE_AMOUNT);
			aFracture = int.Parse(cases.FRACTURE_AMOUNT);

			writeAmounts();

			//calculate Total Case Amount
			totalCaseAmount = Convert.ToString(aChroma + aChroma2 + aChroma3 + aClutch + aCS20 + aCSGOWC + aCSGOWC2 +
			                                   aCSGOWC3 + aDangerZone + aeSports2013 + aeSports2013Winter +
			                                   aeSports2014Summer + aFalchion + aGamma +
			                                   aGamma2 + aGlove + aHorizon + aHuntsman + aBravo + aBreakout + aBrokenFang + aHydra +
			                                   aPhoenix + aVanguard + aWildfire + aPrisma + aPrisma2 + aRevolver +
			                                   aShadow + aShatteredWeb + aSpectrum + aSpectrum2 + aWinterOffensive +
			                                   aFracture);

			rTxtBxTCA.Text = totalCaseAmount;
		}

		//save the amounts from the public variables in the variables of the cases class
		public void SaveAllCases() {
			var cases = new Cases {
				CHROMA_AMOUNT = aChroma.ToString(),
				CHROMA2_AMOUNT = aChroma2.ToString(),
				CHROMA3_AMOUNT = aChroma3.ToString(),
				CLUTCH_AMOUNT = aClutch.ToString(),
				CS20_AMOUNT = aCS20.ToString(),
				CSGOWC_AMOUNT = aCSGOWC.ToString(),
				CSGOWC2_AMOUNT = aCSGOWC2.ToString(),
				CSGOWC3_AMOUNT = aCSGOWC3.ToString(),
				DANGERZONE_AMOUNT = aDangerZone.ToString(),
				ESPORTS2013_AMOUNT = aeSports2013.ToString(),
				ESPORTS2013WINTER_AMOUNT = aeSports2013Winter.ToString(),
				ESPORTS2014SUMMER_AMOUNT = aeSports2014Summer.ToString(),
				FALCHION_AMOUNT = aFalchion.ToString(),
				GAMMA_AMOUNT = aGamma.ToString(),
				GAMMA2_AMOUNT = aGamma2.ToString(),
				GLOVE_AMOUNT = aGlove.ToString(),
				HORIZON_AMOUNT = aHorizon.ToString(),
				HUNTSMAN_AMOUNT = aHuntsman.ToString(),
				BRAVO_AMOUNT = aBravo.ToString(),
				BREAKOUT_AMOUNT = aBreakout.ToString(),
				BROKEN_FANG_AMOUNT = aBrokenFang.ToString(),
				HYDRA_AMOUNT = aHydra.ToString(),
				PHOENIX_AMOUNT = aPhoenix.ToString(),
				VANGUARD_AMOUNT = aVanguard.ToString(),
				WILDFIRE_AMOUNT = aWildfire.ToString(),
				PRISMA_AMOUNT = aPrisma.ToString(),
				PRISMA2_AMOUNT = aPrisma2.ToString(),
				REVOLVER_AMOUNT = aRevolver.ToString(),
				SHADOW_AMOUNT = aShadow.ToString(),
				SHATTEREDWEB_AMOUNT = aShatteredWeb.ToString(),
				SPECTRUM_AMOUNT = aSpectrum.ToString(),
				SPECTRUM2_AMOUNT = aSpectrum2.ToString(),
				WINTEROFFENSIVE_AMOUNT = aWinterOffensive.ToString(),
				FRACTURE_AMOUNT = aFracture.ToString()
			};

			//set path for xml-file
			var propertyFolder = Application.StartupPath;
			var CaseXML = propertyFolder + "\\files\\cases.xml";

			//create fill
			SaveCases.SaveDaten(cases, CaseXML);
		}

		//write all amounts in text boxes
		public void writeAmounts() {
			rTxtBxChromaA.Text = aChroma.ToString();
			rTxtBxChroma2A.Text = aChroma2.ToString();
			rTxtBxChroma3A.Text = aChroma3.ToString();
			rTxtBxClutchA.Text = aClutch.ToString();
			rTxtBxCS20A.Text = aCS20.ToString();
			rTxtBxCSGOWCA.Text = aCSGOWC.ToString();
			rTxtBxCSGOWC2A.Text = aCSGOWC2.ToString();
			rTxtBxCSGOWC3A.Text = aCSGOWC3.ToString();
			rTxtBxDangerZoneA.Text = aDangerZone.ToString();
			rTxtBxeSports2013A.Text = aeSports2013.ToString();
			rTxtBxeSports2013WA.Text = aeSports2013Winter.ToString();
			rTxtBxeSports2014SA.Text = aeSports2014Summer.ToString();
			rTxtBxFalchionA.Text = aFalchion.ToString();
			rTxtBxGammaA.Text = aGamma.ToString();
			rTxtBxGamma2A.Text = aGamma2.ToString();
			rTxtBxGloveA.Text = aGlove.ToString();
			rTxtBxHorizonA.Text = aHorizon.ToString();
			rTxtBxHuntsmanA.Text = aHuntsman.ToString();
			rTxtBxBravoA.Text = aBravo.ToString();
			rTxtBxBreakoutA.Text = aBreakout.ToString();
			rTxtBxBrokenFangA.Text = aBrokenFang.ToString();
			rTxtBxHydraA.Text = aHydra.ToString();
			rTxtBxPhoenixA.Text = aPhoenix.ToString();
			rTxtBxVanguardA.Text = aVanguard.ToString();
			rTxtBxWildfireA.Text = aWildfire.ToString();
			rTxtBxPrismaA.Text = aPrisma.ToString();
			rTxtBxPrisma2A.Text = aPrisma2.ToString();
			rTxtBxRevolverA.Text = aRevolver.ToString();
			rTxtBxShadowA.Text = aShadow.ToString();
			rTxtBxShatteredWebA.Text = aShatteredWeb.ToString();
			rTxtBxSpectrumA.Text = aSpectrum.ToString();
			rTxtBxSpectrum2A.Text = aSpectrum2.ToString();
			rTxtBxWinterOffensiveA.Text = aWinterOffensive.ToString();
			rTxtBxFractureA.Text = aFracture.ToString();
		}

		//calculates the prices
		public void Calculate() {
			userSettings.loadSettings();

			//get the ürices from strings, remove the currency, convert it into a number (decimal), calculate price times amount,
			//convert the result in a string, add the currency and put it in a variable
			tvChroma = Convert.ToString(Convert.ToDecimal(pChroma.Replace(userSettings.currency, "")) *
			                            Convert.ToDecimal(aChroma)) + userSettings.currency;

			tvChroma2 = Convert.ToString(Convert.ToDecimal(pChroma2.Replace(userSettings.currency, "")) *
			                             Convert.ToDecimal(aChroma2)) +
			            userSettings.currency;

			tvChroma3 = Convert.ToString(Convert.ToDecimal(pChroma3.Replace(userSettings.currency, "")) *
			                             Convert.ToDecimal(aChroma3)) +
			            userSettings.currency;

			tvClutch = Convert.ToString(Convert.ToDecimal(pClutch.Replace(userSettings.currency, "")) *
			                            Convert.ToDecimal(aClutch)) + userSettings.currency;

			tvCS20 = Convert.ToString(Convert.ToDecimal(pCS20.Replace(userSettings.currency, "")) *
			                          Convert.ToDecimal(aCS20)) + userSettings.currency;

			tvCSGOWC = Convert.ToString(Convert.ToDecimal(pCSGOWC.Replace(userSettings.currency, "")) *
			                            Convert.ToDecimal(aCSGOWC)) + userSettings.currency;

			tvCSGOWC2 = Convert.ToString(Convert.ToDecimal(pCSGOWC2.Replace(userSettings.currency, "")) *
			                             Convert.ToDecimal(aCSGOWC2)) +
			            userSettings.currency;

			tvCSGOWC3 = Convert.ToString(Convert.ToDecimal(pCSGOWC3.Replace(userSettings.currency, "")) *
			                             Convert.ToDecimal(aCSGOWC3)) +
			            userSettings.currency;

			tvDangerZone =
				Convert.ToString(Convert.ToDecimal(pDangerZone.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aDangerZone)) +
				userSettings.currency;

			tveSports2013 =
				Convert.ToString(Convert.ToDecimal(peSports2013.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aeSports2013)) +
				userSettings.currency;

			tveSports2013Winter = Convert.ToString(
				Convert.ToDecimal(peSports2013Winter.Replace(userSettings.currency, "")) *
				Convert.ToDecimal(aeSports2013Winter)) + userSettings.currency;

			tveSports2014Summer = Convert.ToString(
				Convert.ToDecimal(peSports2014Summer.Replace(userSettings.currency, "")) *
				Convert.ToDecimal(aeSports2014Summer)) + userSettings.currency;

			tvFalchion =
				Convert.ToString(Convert.ToDecimal(pFalchion.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aFalchion)) + userSettings.currency;

			tvGamma = Convert.ToString(Convert.ToDecimal(pGamma.Replace(userSettings.currency, "")) *
			                           Convert.ToDecimal(aGamma)) + userSettings.currency;

			tvGamma2 = Convert.ToString(Convert.ToDecimal(pGamma2.Replace(userSettings.currency, "")) *
			                            Convert.ToDecimal(aGamma2)) + userSettings.currency;

			tvGlove = Convert.ToString(Convert.ToDecimal(pGlove.Replace(userSettings.currency, "")) *
			                           Convert.ToDecimal(aGlove)) + userSettings.currency;

			tvHorizon = Convert.ToString(Convert.ToDecimal(pHorizon.Replace(userSettings.currency, "")) *
			                             Convert.ToDecimal(aHorizon)) +
			            userSettings.currency;

			tvHuntsman =
				Convert.ToString(Convert.ToDecimal(pHuntsman.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aHuntsman)) + userSettings.currency;

			tvBravo = Convert.ToString(Convert.ToDecimal(pBravo.Replace(userSettings.currency, "")) *
			                           Convert.ToDecimal(aBravo)) + userSettings.currency;

			tvBreakout =
				Convert.ToString(Convert.ToDecimal(pBreakout.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aBreakout)) + userSettings.currency;

			tvBrokenFang =
				Convert.ToString(Convert.ToDecimal(pBrokenFang.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aBrokenFang)) + userSettings.currency;

			tvHydra = Convert.ToString(Convert.ToDecimal(pHydra.Replace(userSettings.currency, "")) *
			                           Convert.ToDecimal(aHydra)) + userSettings.currency;

			tvPhoenix = Convert.ToString(Convert.ToDecimal(pPhoenix.Replace(userSettings.currency, "")) *
			                             Convert.ToDecimal(aPhoenix)) +
			            userSettings.currency;

			tvVanguard =
				Convert.ToString(Convert.ToDecimal(pVanguard.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aVanguard)) + userSettings.currency;

			tvWildfire =
				Convert.ToString(Convert.ToDecimal(pWildfire.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aWildfire)) + userSettings.currency;

			tvPrisma = Convert.ToString(Convert.ToDecimal(pPrisma.Replace(userSettings.currency, "")) *
			                            Convert.ToDecimal(aPrisma)) + userSettings.currency;

			tvPrisma2 = Convert.ToString(Convert.ToDecimal(pPrisma2.Replace(userSettings.currency, "")) *
			                             Convert.ToDecimal(aPrisma2)) +
			            userSettings.currency;

			tvRevolver =
				Convert.ToString(Convert.ToDecimal(pRevolver.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aRevolver)) + userSettings.currency;

			tvShadow = Convert.ToString(Convert.ToDecimal(pShadow.Replace(userSettings.currency, "")) *
			                            Convert.ToDecimal(aShadow)) + userSettings.currency;

			tvShatteredWeb =
				Convert.ToString(Convert.ToDecimal(pShatteredWeb.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aShatteredWeb)) +
				userSettings.currency;

			tvSpectrum =
				Convert.ToString(Convert.ToDecimal(pSpectrum.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aSpectrum)) + userSettings.currency;

			tvSpectrum2 =
				Convert.ToString(Convert.ToDecimal(pSpectrum2.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aSpectrum2)) + userSettings.currency;

			tvWinterOffensive = Convert.ToString(
				Convert.ToDecimal(pWinterOffensive.Replace(userSettings.currency, "")) *
				Convert.ToDecimal(aWinterOffensive)) + userSettings.currency;

			tvFracture =
				Convert.ToString(Convert.ToDecimal(pFracture.Replace(userSettings.currency, "")) *
				                 Convert.ToDecimal(aFracture)) + userSettings.currency;

			writeTotalValues();

			//calculate Total Case Value
			rTxtBxTCV.Text = "";

			totalCaseValue = Convert.ToString(Convert.ToDecimal(tvChroma.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvChroma2.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvChroma3.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvClutch.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvCS20.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvCSGOWC.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvCSGOWC2.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvCSGOWC3.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvDangerZone.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tveSports2013.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(
				                                  tveSports2013Winter.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(
				                                  tveSports2014Summer.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvFalchion.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvGamma.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvGamma2.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvGlove.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvHorizon.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvHuntsman.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvBravo.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvBreakout.Replace(userSettings.currency, "")) +
											  Convert.ToDecimal(tvBrokenFang.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvHydra.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvPhoenix.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvVanguard.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvWildfire.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvPrisma.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvPrisma2.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvRevolver.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvShadow.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvShatteredWeb.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvSpectrum.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvSpectrum2.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvWinterOffensive.Replace(userSettings.currency, "")) +
			                                  Convert.ToDecimal(tvFracture.Replace(userSettings.currency, ""))
			) + userSettings.currency;

			rTxtBxTCV.Text = totalCaseValue;

			//calculate Total Case Amount
			totalCaseAmount = Convert.ToString(aChroma + aChroma2 + aChroma3 + aClutch + aCS20 + aCSGOWC + aCSGOWC2 +
			                                   aCSGOWC3 + aDangerZone + aeSports2013 + aeSports2013Winter +
			                                   aeSports2014Summer + aFalchion + aGamma +
			                                   aGamma2 + aGlove + aHorizon + aHuntsman + aBravo + aBreakout + aBrokenFang +
			                                   aHydra + aPhoenix + aVanguard + aWildfire + aPrisma + aPrisma2 +
			                                   aRevolver + aShadow + aShatteredWeb + aSpectrum + aSpectrum2 +
			                                   aWinterOffensive + aFracture);

			rTxtBxTCA.Text = totalCaseAmount;

		}

		//write all the total prices in text boxes
		public void writeTotalValues() {

			rTxtBxChromaTV.Text = tvChroma;
			rTxtBxChroma2TV.Text = tvChroma2;
			rTxtBxChroma3TV.Text = tvChroma3;
			rTxtBxClutchTV.Text = tvClutch;
			rTxtBxCS20TV.Text = tvCS20;
			rTxtBxCSGOWCTV.Text = tvCSGOWC;
			rTxtBxCSGOWC2TV.Text = tvCSGOWC2;
			rTxtBxCSGOWC3TV.Text = tvCSGOWC3;
			rTxtBxDangerZoneTV.Text = tvDangerZone;
			rTxtBxeSports2013TV.Text = tveSports2013;
			rTxtBxeSports2013WTV.Text = tveSports2013Winter;
			rTxtBxeSports2014STV.Text = tveSports2014Summer;
			rTxtBxFalchionTV.Text = tvFalchion;
			rTxtBxFractureTV.Text = tvFracture;
			rTxtBxGammaTV.Text = tvGamma;
			rTxtBxGamma2TV.Text = tvGamma2;
			rTxtBxGloveTV.Text = tvGlove;
			rTxtBxHorizonTV.Text = tvHorizon;
			rTxtBxHuntsmanTV.Text = tvHuntsman;
			rTxtBxBravoTV.Text = tvBravo;
			rTxtBxBreakoutTV.Text = tvBreakout;
			rTxtBxBrokenFangTV.Text = tvBrokenFang;
			rTxtBxHydraTV.Text = tvHydra;
			rTxtBxPhoenixTV.Text = tvPhoenix;
			rTxtBxVanguardTV.Text = tvVanguard;
			rTxtBxWildfireTV.Text = tvWildfire;
			rTxtBxPrismaTV.Text = tvPrisma;
			rTxtBxPrisma2TV.Text = tvPrisma2;
			rTxtBxRevolverTV.Text = tvRevolver;
			rTxtBxShadowTV.Text = tvShadow;
			rTxtBxShatteredWebTV.Text = tvShatteredWeb;
			rTxtBxSpectrumTV.Text = tvSpectrum;
			rTxtBxSpectrum2TV.Text = tvSpectrum2;
			rTxtBxWinterOffensiveTV.Text = tvWinterOffensive;
		}

		//button to reload all prices
		public void btnLoad_Click(object sender, EventArgs e) {

			pBravo = "0";
			pBreakout = "0";
			pBrokenFang = "0";
			pChroma = "0";
			pChroma2 = "0";
			pChroma3 = "0";
			pClutch = "0";
			pCS20 = "0";
			pCSGOWC = "0";
			pCSGOWC2 = "0";
			pCSGOWC3 = "0";
			pDangerZone = "0";
			peSports2013 = "0";
			peSports2013Winter = "0";
			peSports2014Summer = "0";
			pFalchion = "0";
			pGamma = "0";
			pGamma2 = "0";
			pGlove = "0";
			pHorizon = "0";
			pHuntsman = "0";
			pHydra = "0";
			pPhoenix = "0";
			pPrisma = "0";
			pPrisma2 = "0";
			pRevolver = "0";
			pShadow = "0";
			pShatteredWeb = "0";
			pSpectrum = "0";
			pSpectrum2 = "0";
			pVanguard = "0";
			pWildfire = "0";
			pWinterOffensive = "0";
			pFracture = "0";

			Main();
		}

		//button to calculate the values
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

		//button to load all saved amounts, if something went wrong on startup
		public void btnLoadSavedCases_Click(object sender, EventArgs e) {
			//Load all Amounts
			LoadCases();
		}

		//open options window
		private void btnOptns_Click_1(object sender, EventArgs e) {
			new Form_Options().Show();
		}

		//when the main window is loading/opening
		private void Form_Main_Load(object sender, EventArgs e) {

			//check for Updates
			var Updater = new Updater();
			Updater.checkForUpdate();

			//get the path where the application is running/the exe is located
			var propertyFolder = Application.StartupPath;

			//string propertyFolder = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents") + "\\CSGOCC";
			var CaseXML = @propertyFolder + "\\files\\cases.xml";

			//check if there is already a file with saved cases
			if (File.Exists(CaseXML)) {
				//if it is so: load the file
				LoadCases();
			} else {
				//if not: create a file with 0 cases (will happen on first startup)
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
					BROKEN_FANG_AMOUNT = "0",
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

				//create the direction and save the file
				Directory.CreateDirectory(propertyFolder + "\\files");

				if (!Directory.Exists(propertyFolder + "\\files")) {
					MessageBox.Show(
						"ERROR: Can't create directory for settings and cases file!" +
						"\nPlease restart the programm with admin permisson or install it in a not protected directory.",
						"ERROR!",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);

				} else {

					SaveCases.SaveDaten(casesempty, CaseXML);
				}
			}

			//load all amounts on startup
			Main();
		}

		//closing the program with asking to save cases ("Closeing" to make it different to the standard Form.Closing() method)
		//close without knowing the clse reason
		private void Closeing() {

			var ExitMsgBx = MessageBox.Show("Save cases befor closing?", "Save cases?", MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

			if (ExitMsgBx == DialogResult.Yes) {
				try {
					SaveAllCases();
					userSettings.saveSettings();
				}
				catch { }

				Settings.Default.Save();
				Environment.Exit(0);
			} else if (ExitMsgBx == DialogResult.No) {
				Settings.Default.Save();
				Environment.Exit(0);
			} else if (ExitMsgBx == DialogResult.Cancel) { }

		}

		//clsoe with knowing the close reason
		private void Closeing(FormClosingEventArgs e) {

			//if the user closes the programm
			if (e.CloseReason == CloseReason.UserClosing) {

				var ExitMsgBx = MessageBox.Show("Save cases befor closing?", "Save cases?",
					MessageBoxButtons.YesNoCancel,
					MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

				if (ExitMsgBx == DialogResult.Yes) {
					try {
						SaveAllCases();
						userSettings.saveSettings();
					}
					catch { }

					Settings.Default.Save();
					Environment.Exit(0);
				} else if (ExitMsgBx == DialogResult.No) {
					Settings.Default.Save();
					Environment.Exit(0);
				} else if (ExitMsgBx == DialogResult.Cancel) { }
			} else { //if the programm closes itself (when restarting after changing the currency)
				e.Cancel = false;
			}
		}

		private void Form_Main_Exit(object sender, FormClosingEventArgs e) {
			//block closing by the user using the "X"
			e.Cancel = e.CloseReason == CloseReason.UserClosing;

			Closeing(e);
		}

		//the exit button
		public void btnExit_Click(object sender, EventArgs e) {
			Closeing();
		}

		//links for link labels
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

		private void lLblBrokenFang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(steammarktcsgo + "Operation%20Broken%20Fang%20Case");
		}

		//message box when an amount does contain something else then a number
		public void amountErrorBox(string msgBxTxt) {

			MessageBox.Show("Error: \"" + msgBxTxt + "\" is not a number! \nPlease enter a valid number",
				"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
		}

		//test if input in amounts text box are only numbers
		private int testAmounts(string txtBxTxt, int amountInt) {

			if (txtBxTxt.Equals("") || txtBxTxt == null) {

			} else {

				if (int.TryParse(txtBxTxt, out amountInt))
				{

					amountInt = int.Parse(txtBxTxt);

				}
				else
				{

					amountErrorBox(txtBxTxt);
				}
			}

			return amountInt;
		}

		private void rTxtBxChromaA_TextChanged(object sender, EventArgs e) {

			aChroma = testAmounts(rTxtBxChromaA.Text, aChroma);
		}

		private void rTxtBxChroma2A_TextChanged(object sender, EventArgs e) {

			aChroma2 = testAmounts(rTxtBxChroma2A.Text, aChroma2);
		}

		private void rTxtBxChroma3A_TextChanged(object sender, EventArgs e) {

			aChroma3 = testAmounts(rTxtBxChroma3A.Text, aChroma3);
		}

		private void rTxtBxClutchA_TextChanged(object sender, EventArgs e) {

			aClutch = testAmounts(rTxtBxClutchA.Text, aClutch);
		}

		private void rTxtBxCS20A_TextChanged(object sender, EventArgs e) {

			aCS20 = testAmounts(rTxtBxCS20A.Text, aCS20);
		}

		private void rTxtBxCSGOWCA_TextChanged(object sender, EventArgs e) {

			aCSGOWC = testAmounts(rTxtBxCSGOWCA.Text, aCSGOWC);
		}

		private void rTxtBxCSGOWC2A_TextChanged(object sender, EventArgs e) {

			aCSGOWC2 = testAmounts(rTxtBxCSGOWC2A.Text, aCSGOWC2);
		}

		private void rTxtBxCSGOWC3A_TextChanged(object sender, EventArgs e) {

			aCSGOWC3 = testAmounts(rTxtBxCSGOWC3A.Text, aCSGOWC3);
		}

		private void rTxtBxDangerZoneA_TextChanged(object sender, EventArgs e) {

			aDangerZone = testAmounts(rTxtBxDangerZoneA.Text, aDangerZone);
		}

		private void rTxtBxeSports2013A_TextChanged(object sender, EventArgs e) {

			aeSports2013 = testAmounts(rTxtBxeSports2013A.Text, aeSports2013);
		}

		private void rTxtBxeSports2013WA_TextChanged(object sender, EventArgs e) {

			aeSports2013Winter = testAmounts(rTxtBxeSports2013WA.Text, aeSports2013Winter);
		}

		private void rTxtBxeSports2014SA_TextChanged(object sender, EventArgs e) {

			aeSports2014Summer = testAmounts(rTxtBxeSports2014SA.Text, aeSports2014Summer);
		}

		private void rTxtBxFalchionA_TextChanged(object sender, EventArgs e) {

			aFalchion = testAmounts(rTxtBxFalchionA.Text, aFalchion);
		}

		private void rTxtBxFractureA_TextChanged(object sender, EventArgs e) {

			aFracture = testAmounts(rTxtBxFractureA.Text, aFracture);
		}

		private void rTxtBxGammaA_TextChanged(object sender, EventArgs e) {

			aGamma = testAmounts(rTxtBxGammaA.Text, aGamma);
		}

		private void rTxtBxGamma2A_TextChanged(object sender, EventArgs e) {

			aGamma2 = testAmounts(rTxtBxGamma2A.Text, aGamma2);
		}

		private void rTxtBxGloveA_TextChanged(object sender, EventArgs e) {

			aGlove = testAmounts(rTxtBxGloveA.Text, aGlove);
		}

		private void rTxtBxHorizonA_TextChanged(object sender, EventArgs e) {

			aHorizon = testAmounts(rTxtBxHorizonA.Text, aHorizon);
		}

		private void rTxtBxHuntsmanA_TextChanged(object sender, EventArgs e) {

			aHuntsman = testAmounts(rTxtBxHuntsmanA.Text, aHuntsman);
		}

		private void rTxtBxBravoA_TextChanged(object sender, EventArgs e) {

			aBravo = testAmounts(rTxtBxBravoA.Text, aBravo);
		}

		private void rTxtBxBreakoutA_TextChanged(object sender, EventArgs e) {

			aBreakout = testAmounts(rTxtBxBreakoutA.Text, aBreakout);
		}

		private void rTxtBxBrokenFangA_TextChanged(object sender, EventArgs e) {

			aBrokenFang = testAmounts(rTxtBxBrokenFangA.Text, aBrokenFang);
		}

		private void rTxtBxHydraA_TextChanged(object sender, EventArgs e) {

			aHydra = testAmounts(rTxtBxHydraA.Text, aHydra);
		}

		private void rTxtBxPhoenixA_TextChanged(object sender, EventArgs e) {

			aPhoenix = testAmounts(rTxtBxPhoenixA.Text, aPhoenix);
		}

		private void rTxtBxVanguardA_TextChanged(object sender, EventArgs e) {

			aVanguard = testAmounts(rTxtBxVanguardA.Text, aVanguard);
		}

		private void rTxtBxWildfireA_TextChanged(object sender, EventArgs e) {

			aWildfire = testAmounts(rTxtBxWildfireA.Text, aWildfire);
		}

		private void rTxtBxPrismaA_TextChanged(object sender, EventArgs e) {

			aPrisma = testAmounts(rTxtBxPrismaA.Text, aPrisma);
		}

		private void rTxtBxPrisma2A_TextChanged(object sender, EventArgs e) {

			aPrisma2 = testAmounts(rTxtBxPrisma2A.Text, aPrisma2);
		}

		private void rTxtBxRevolverA_TextChanged(object sender, EventArgs e) {

			aRevolver = testAmounts(rTxtBxRevolverA.Text, aRevolver);
		}

		private void rTxtBxShadowA_TextChanged(object sender, EventArgs e) {

			aShadow = testAmounts(rTxtBxShadowA.Text, aShadow);
		}

		private void rTxtBxShatteredWebA_TextChanged(object sender, EventArgs e) {

			aShatteredWeb = testAmounts(rTxtBxShatteredWebA.Text, aShatteredWeb);
		}

		private void rTxtBxSpectrumA_TextChanged(object sender, EventArgs e) {

			aSpectrum = testAmounts(rTxtBxSpectrumA.Text, aSpectrum);
		}

		private void rTxtBxSpectrum2A_TextChanged(object sender, EventArgs e) {

			aSpectrum2 = testAmounts(rTxtBxSpectrum2A.Text, aSpectrum2);
		}

		private void rTxtBxWinterOffensiveA_TextChanged(object sender, EventArgs e) {

			aWinterOffensive = testAmounts(rTxtBxWinterOffensiveA.Text, aWinterOffensive);
		}

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

			public string BROKEN_FANG_AMOUNT { get; set; }

		}

    }

}
