using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CSGO_Case_Calculator
{

    public partial class Form_Options : Form {

	    private Form_Main main = new Form_Main();

	    private int TimerTime;

		public Form_Options() {
			InitializeComponent();
		}

		//button to import old xml-file
		public void btnImportOldXML_Click(object sender, EventArgs e) {

			var openOldXMLfile = new OpenFileDialog();

			openOldXMLfile.FileName = "cases.xml";
			openOldXMLfile.Filter = "Cases XML-file|*.xml";

			if (openOldXMLfile.ShowDialog() == DialogResult.OK) {
				var MsgBxWrng =
					MessageBox.Show(
						"WARNING!\nIf you already have an XML file, it will be replaced.\nThis cannot be undone.",
						"WARNING!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
						MessageBoxDefaultButton.Button2);

				if (MsgBxWrng == DialogResult.OK) {
					try {
						var OLDcasesXML = openOldXMLfile.FileName;
						var NEWcasesXML = Application.StartupPath + "\\files\\cases.xml";

						var xmldoc = new XmlDocument();
						xmldoc.Load(OLDcasesXML);

						//when new case:
						if (!OLDcasesXML.Contains("FRACTURE_AMOUNT")) {
							var FRACTURE = xmldoc.CreateElement("FRACTURE_AMOUNT");
							FRACTURE.InnerText = "0";
							xmldoc.DocumentElement.AppendChild(FRACTURE);
						}

						if (!OLDcasesXML.Contains("BROKEN_FANG_AMOUNT")) {
							var BROKEN_FANG = xmldoc.CreateElement("BROKEN_FANG_AMOUNT");
							BROKEN_FANG.InnerText = "0";
							xmldoc.DocumentElement.AppendChild(BROKEN_FANG);
						}

						if (!OLDcasesXML.Contains("SNAKEBITE_AMOUNT"))
						{
							var SNAKEBITE_AMOUNT = xmldoc.CreateElement("SNAKEBITE_AMOUNT");
							SNAKEBITE_AMOUNT.InnerText = "0";
							xmldoc.DocumentElement.AppendChild(SNAKEBITE_AMOUNT);
						}

						var settings = new XmlWriterSettings();
						settings.Indent = true;
						File.Delete(NEWcasesXML);
						var writer = XmlWriter.Create(NEWcasesXML, settings);
						xmldoc.Save(writer);
						writer.Close();

						MessageBox.Show("Success!\nPlease click on 'Load Saved Cases' to load the new XML-file.",
							"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch {
						MessageBox.Show("Oops. Something went wrong.\nPlease try again.", "Something went wrong",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btnHelpTimer_Click(object sender, EventArgs e) {
			MessageBox.Show(
				"Enter an integer between 5 and 60. This will be the interval between the price reloads and calculations.\n\nPress 'Start' to start the Calculation Timer and 'Stop' to stop the Calculation Timer.",
				"Calculation Timer Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}

		private void rTxtBxTimerTime_TextChanged(object sender, EventArgs e) { }

		private void btnStart_Click(object sender, EventArgs e) {
			//check if input is an integer
			if (int.TryParse(rTxtBxTimerTime.Text, out TimerTime)) {
				//check if number is between 5 and 60
				if (TimerTime >= 5 && TimerTime <= 60) {

					calcTimer.Enabled = true;

					Timer.streamWriterTimer.BaseStream.Seek(0, SeekOrigin.End);

					Timer.streamWriterTimer.WriteLine("=========== Timer has been started! ===========" +
					                                  "\nStart Date: " + DateTime.Now.ToLongDateString() +
					                                  "\nStart Time: " + DateTime.Now.ToLongTimeString() +
					                                  "\nInterval: " + rTxtBxTimerTime.Text + " minutes");

					Timer.streamWriterTimer.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Timer.streamWriterTimer.Flush();

				} else {
					MessageBox.Show("Error: \"" + rTxtBxTimerTime.Text + "\" is not between 5 and 60!", "ERROR",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} else {
				MessageBox.Show("Error: \"" + rTxtBxTimerTime.Text + "\" is not an integer!", "ERROR",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void CalcTimer_Tick(object sender, EventArgs e) {

			calcTimer.Interval = TimerTime * 60000; //calculation for minutes in milliseconds

			writeFile();
		}

		public async void writeFile() {

			await main.loadPrices();

			main.LoadCases();

			main.Calculate();

			Timer.streamWriterTimer.WriteLine("Chroma Case: " +
			                                  "\n\tAmount: " + main.aChroma +
			                                  "\n\tPrice: " + main.pChroma +
			                                  "\n\tTotal value: " + main.tvChroma);

			Timer.streamWriterTimer.WriteLine("Chroma 2 Case: " +
			                                  "\n\tAmount: " + main.aChroma2 +
			                                  "\n\tPrice: " + main.pChroma2 +
			                                  "\n\tTotal value: " + main.tvChroma2);

			Timer.streamWriterTimer.WriteLine("Chroma 3 Case: " +
			                                  "\n\tAmount: " + main.aChroma3 +
			                                  "\n\tPrice: " + main.pChroma3 +
			                                  "\n\tTotal value: " + main.tvChroma3);

			Timer.streamWriterTimer.WriteLine("Clutch Case: " +
			                                  "\n\tAmount: " + main.aClutch +
			                                  "\n\tPrice: " + main.pClutch +
			                                  "\n\tTotal value: " + main.tvClutch);

			Timer.streamWriterTimer.WriteLine("CS20 Case: " +
			                                  "\n\tAmount: " + main.aCS20 +
			                                  "\n\tPrice: " + main.pCS20 +
			                                  "\n\tTotal value: " + main.tvCS20);

			Timer.streamWriterTimer.WriteLine("CS:GO Weapon Case: " +
			                                  "\n\tAmount: " + main.aCSGOWC +
			                                  "\n\tPrice: " + main.pCSGOWC +
			                                  "\n\tTotal value: " + main.tvCSGOWC);

			Timer.streamWriterTimer.WriteLine("CS:GO Weapon Case 2: " +
			                                  "\n\tAmount: " + main.aCSGOWC2 +
			                                  "\n\tPrice: " + main.pCSGOWC2 +
			                                  "\n\tTotal value: " + main.tvCSGOWC2);

			Timer.streamWriterTimer.WriteLine("CS:GO Weapon Case 3: " +
			                                  "\n\tAmount: " + main.aCSGOWC3 +
			                                  "\n\tPrice: " + main.pCSGOWC3 +
			                                  "\n\tTotal value: " + main.tvCSGOWC3);

			Timer.streamWriterTimer.WriteLine("Danger Zone Case: " +
			                                  "\n\tAmount: " + main.aDangerZone +
			                                  "\n\tPrice: " + main.pDangerZone +
			                                  "\n\tTotal value: " + main.tvDangerZone);

			Timer.streamWriterTimer.WriteLine("eSports 2013 Case: " +
			                                  "\n\tAmount: " + main.aeSports2013 +
			                                  "\n\tPrice: " + main.peSports2013 +
			                                  "\n\tTotal value: " + main.tveSports2013);

			Timer.streamWriterTimer.WriteLine("eSprts 2013 Winter Case: " +
			                                  "\n\tAmount: " + main.aeSports2013Winter +
			                                  "\n\tPrice: " + main.peSports2013Winter +
			                                  "\n\tTotal value: " + main.tveSports2013Winter);

			Timer.streamWriterTimer.WriteLine("eSports 2014 Summer Case: " +
			                                  "\n\tAmount: " + main.aeSports2014Summer +
			                                  "\n\tPrice: " + main.peSports2014Summer +
			                                  "\n\tTotal value: " + main.tveSports2014Summer);

			Timer.streamWriterTimer.WriteLine("Falchion Case: " +
			                                  "\n\tAmount: " + main.aFalchion +
			                                  "\n\tPrice: " + main.pFalchion +
			                                  "\n\tTotal value: " + main.tvFalchion);

			Timer.streamWriterTimer.WriteLine("Fracture Case: " +
			                                  "\n\tAmount: " + main.aFracture +
			                                  "\n\tPrice: " + main.pFracture +
			                                  "\n\tTotal value: " + main.tvFracture);

			Timer.streamWriterTimer.WriteLine("Gamma Case: " +
			                                  "\n\tAmount: " + main.aGamma +
			                                  "\n\tPrice: " + main.pGamma +
			                                  "\n\tTotal value: " + main.tvGamma);

			Timer.streamWriterTimer.WriteLine("Gamma 2 Case: " +
			                                  "\n\tAmount: " + main.aGamma2 +
			                                  "\n\tPrice: " + main.pGamma2 +
			                                  "\n\tTotal value: " + main.tvGamma2);

			Timer.streamWriterTimer.WriteLine("Glove Case: " +
			                                  "\n\tAmount: " + main.aGlove +
			                                  "\n\tPrice: " + main.pGlove +
			                                  "\n\tTotal value: " + main.tvGlove);

			Timer.streamWriterTimer.WriteLine("Horizon Case: " +
			                                  "\n\tAmount: " + main.aHorizon +
			                                  "\n\tPrice: " + main.pHorizon +
			                                  "\n\tTotal value: " + main.tvHorizon);

			Timer.streamWriterTimer.WriteLine("Huntsman Weapon Case: " +
			                                  "\n\tAmount: " + main.aHuntsman +
			                                  "\n\tPrice: " + main.pHuntsman +
			                                  "\n\tTotal value: " + main.tvHuntsman);

			Timer.streamWriterTimer.WriteLine("Operation Bravo Case: " +
			                                  "\n\tAmount: " + main.aBravo +
			                                  "\n\tPrice: " + main.pBravo +
			                                  "\n\tTotal value: " + main.tvBravo);

			Timer.streamWriterTimer.WriteLine("Operation Breakout Weapon Case: " +
			                                  "\n\tAmount: " + main.aBreakout +
			                                  "\n\tPrice: " + main.pBreakout +
			                                  "\n\tTotal value: " + main.tvBreakout);

			Timer.streamWriterTimer.WriteLine("Operation Broken Fang Case: " +
			                                  "\n\tAmount: " + main.aBrokenFang +
			                                  "\n\tPrice: " + main.pBrokenFang +
			                                  "\n\tTotal value: " + main.tvBrokenFang);

			Timer.streamWriterTimer.WriteLine("Operation Hydra Case: " +
			                                  "\n\tAmount: " + main.aHydra +
			                                  "\n\tPrice: " + main.pHydra +
			                                  "\n\tTotal value: " + main.tvHydra);

			Timer.streamWriterTimer.WriteLine("Operation Phoenix Weapon Case: " +
			                                  "\n\tAmount: " + main.aPhoenix +
			                                  "\n\tPrice: " + main.pPhoenix +
			                                  "\n\tTotal value: " + main.tvPhoenix);

			Timer.streamWriterTimer.WriteLine("Operation Vanguard Weapon Case: " +
			                                  "\n\tAmount: " + main.aVanguard +
			                                  "\n\tPrice: " + main.pVanguard +
			                                  "\n\tTotal value: " + main.tvVanguard);

			Timer.streamWriterTimer.WriteLine("Operation Wildfire Case: " +
			                                  "\n\tAmount: " + main.aWildfire +
			                                  "\n\tPrice: " + main.pWildfire +
			                                  "\n\tTotal value: " + main.tvWildfire);

			Timer.streamWriterTimer.WriteLine("Prisma Case: " +
			                                  "\n\tAmount: " + main.aPrisma +
			                                  "\n\tPrice: " + main.pPrisma +
			                                  "\n\tTotal value: " + main.tvPrisma);

			Timer.streamWriterTimer.WriteLine("Prisma 2 Case: " +
			                                  "\n\tAmount: " + main.aPrisma2 +
			                                  "\n\tPrice: " + main.pPrisma2 +
			                                  "\n\tTotal value: " + main.tvPrisma2);

			Timer.streamWriterTimer.WriteLine("Revolver Case: " +
			                                  "\n\tAmount: " + main.aRevolver +
			                                  "\n\tPrice: " + main.pRevolver +
			                                  "\n\tTotal value: " + main.tvRevolver);

			Timer.streamWriterTimer.WriteLine("Shadow Case: " +
			                                  "\n\tAmount: " + main.aShadow +
			                                  "\n\tPrice: " + main.pShadow +
			                                  "\n\tTotal value: " + main.tvShadow);

			Timer.streamWriterTimer.WriteLine("Shattered Web Case: " +
			                                  "\n\tAmount: " + main.aShatteredWeb +
			                                  "\n\tPrice: " + main.pShatteredWeb +
			                                  "\n\tTotal value: " + main.tvShatteredWeb);

			Timer.streamWriterTimer.WriteLine("Snakebite Case: " +
			                                  "\n\tAmount: " + main.aSnakebite +
			                                  "\n\tPrice: " + main.pSnakebite +
			                                  "\n\tTotal value: " + main.tvSnakebite);

			Timer.streamWriterTimer.WriteLine("Spectrum Case: " +
			                                  "\n\tAmount: " + main.aSpectrum +
			                                  "\n\tPrice: " + main.pSpectrum +
			                                  "\n\tTotal value: " + main.tvSpectrum);

			Timer.streamWriterTimer.WriteLine("Spectrum 2 Case: " +
			                                  "\n\tAmount: " + main.aSpectrum2 +
			                                  "\n\tPrice: " + main.pSpectrum2 +
			                                  "\n\tTotal value: " + main.tvSpectrum2);

			Timer.streamWriterTimer.WriteLine("Winter Offensive Weapon Case: " +
			                                  "\n\tAmount: " + main.aWinterOffensive +
			                                  "\n\tPrice: " + main.pWinterOffensive +
			                                  "\n\tTotal value: " + main.tvWinterOffensive);

			Timer.streamWriterTimer.WriteLine("\n\t\tTotal Cases: " + main.totalCaseAmount +
			                                  "\n\t\tTotal Case Value: " + main.totalCaseValue);

			Timer.streamWriterTimer.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
			Timer.streamWriterTimer.Flush();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start("https://twitter.com/noel_the_N00B");
		}

		private void lLblDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start("https://www.paypal.com/donate/?hosted_button_id=XGUUPFYJ9FPYU");
		}

		private void btnStop_Click(object sender, EventArgs e) {

			calcTimer.Enabled = false;

			Timer.streamWriterTimer.WriteLine("Timer has been stopped!" +
			                                  "\nEnd Date: " + DateTime.Now.ToLongDateString() +
			                                  "\nEnd Time: " + DateTime.Now.ToLongTimeString() +
			                                  "\n===============================================\n");

			MessageBox.Show("The timer has been stopped!", "Timer has been stopped!", MessageBoxButtons.OK);
			
			Timer.streamWriterTimer.Close();
		}

		private void Form_Options_Exit(object sender, FormClosingEventArgs e) {
			if (calcTimer.Enabled) {
				//block closing by the user while the timmer is running
				e.Cancel = e.CloseReason == CloseReason.UserClosing;

				MessageBox.Show("ERROR: The timer is still running!\nPlease stop the timer first!", "ERROR",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void btnChangeCurrency_Click(object sender, EventArgs e) {

	        var UserSettings = new UserSettings();

			var restartProgrammMsgBx = MessageBox.Show("To apply changes, the program needs to restart.\nBe sure that your cases are saved!",
				"Restart",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Information,
				MessageBoxDefaultButton.Button1);

			if (restartProgrammMsgBx == DialogResult.OK) {

				UserSettings.currency = cmbBxCurrency.GetItemText(cmbBxCurrency.SelectedItem);
				UserSettings.saveSettings();

				Application.Restart();
			}
		}
    }
}
