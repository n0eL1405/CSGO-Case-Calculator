using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;

namespace CSGO_Case_Calculator
{

    public partial class Form_Options : Form {

		private int TimerTime;

		public Form_Options() {
			InitializeComponent();
		}

		//button to import old xml-file
		public void btnImportOldXML_Click(object sender, EventArgs e) {
			var Form_Main = new Form_Main();

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
						XmlElement FRACTURE = xmldoc.CreateElement("FRACTURE_AMOUNT");
						FRACTURE.InnerText = "0";
						xmldoc.DocumentElement.AppendChild(FRACTURE);

						var settings = new XmlWriterSettings();
						settings.Indent = true;
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

					Form_Main main = new Form_Main();

					//set the textfields of the amounts to read only to block the user from making changes
					main.rTxtBxChroma.ReadOnly = true;

					calcTimer.Enabled = true;

                    Timer.streamWriterTimer.BaseStream.Seek(0, SeekOrigin.End);
					Timer.streamWriterTimer.WriteLine("=========== Timer has been started! ===========" +
					                                  "\nStart Date: " + DateTime.Now.ToLongDateString() +
													  "\nStart Time: " + DateTime.Now.ToLongTimeString() +
					                                  "\nInterval: " + rTxtBxTimerTime.Text + " minutes");
					Timer.streamWriterTimer.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
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

			calcTimer.Interval = (int)TimerTime*60000; //calculation for minutes in milliseconds

			writeFile();
		}

		public async void writeFile() {

			Form_Main main = new Form_Main();

            await main.getPricesAsync();

			//TODO: Price anpassen & Amounts werden nicht geladen

			Timer.streamWriterTimer.WriteLine("Chroma Case: " +
			                                  "\n\tAmount: " + main.aChroma +
			                                  "\n\tPrice: " + main.pChroma +
			                                  "\n\tTotal value: " + main.rTxtBxChromaTV.Text);

			Timer.streamWriterTimer.WriteLine("Chroma 2 Case: " +
											  "\n\tAmount: " + main.aChroma2 +
											  "\n\tPrice: " + main.pChroma2 +
											  "\n\tTotal value: " + main.rTxtBxChroma2TV.Text);

			Timer.streamWriterTimer.WriteLine("Chroma 3 Case: " +
											  "\n\tAmount: " + main.aChroma3 +
											  "\n\tPrice: " + main.pChroma3 +
											  "\n\tTotal value: " + main.rTxtBxChroma3TV.Text);

			Timer.streamWriterTimer.WriteLine("Clutch Case: " +
											  "\n\tAmount: " + main.rTxtBxClutchA.Text +
											  "\n\tPrice: " + main.pClutch +
											  "\n\tTotal value: " + main.rTxtBxClutchTV.Text);

			Timer.streamWriterTimer.WriteLine("CS20 Case: " +
											  "\n\tAmount: " + main.rTxtBxCS20A.Text +
											  "\n\tPrice: " + main.rTxtBxCS20.Text +
											  "\n\tTotal value: " + main.rTxtBxCS20TV.Text);

			Timer.streamWriterTimer.WriteLine("CS:GO Weapon Case: " +
											  "\n\tAmount: " + main.rTxtBxCSGOWCA.Text +
											  "\n\tPrice: " + main.rTxtBxCSGOWC.Text +
											  "\n\tTotal value: " + main.rTxtBxCSGOWCTV.Text);

			Timer.streamWriterTimer.WriteLine("CS:GO Weapon Case 2: " +
											  "\n\tAmount: " + main.rTxtBxCSGOWC2A.Text +
											  "\n\tPrice: " + main.rTxtBxCSGOWC2.Text +
											  "\n\tTotal value: " + main.rTxtBxCSGOWC2TV.Text);

			Timer.streamWriterTimer.WriteLine("CS:GO Weapon Case 3: " +
											  "\n\tAmount: " + main.rTxtBxCSGOWC3A.Text +
											  "\n\tPrice: " + main.rTxtBxCSGOWC3.Text +
											  "\n\tTotal value: " + main.rTxtBxCSGOWC3TV.Text);

			Timer.streamWriterTimer.WriteLine("Danger Zone Case: " +
											  "\n\tAmount: " + main.rTxtBxDangerZoneA.Text +
											  "\n\tPrice: " + main.rTxtBxDangerZone.Text +
											  "\n\tTotal value: " + main.rTxtBxDangerZoneTV.Text);

			Timer.streamWriterTimer.WriteLine("eSports 2013 Case: " +
											  "\n\tAmount: " + main.rTxtBxeSports2013A.Text +
											  "\n\tPrice: " + main.rTxtBxeSports2013.Text +
											  "\n\tTotal value: " + main.rTxtBxeSports2013TV.Text);

			Timer.streamWriterTimer.WriteLine("eSprts 2013 Winter Case: " +
											  "\n\tAmount: " + main.rTxtBxeSports2013WA.Text +
											  "\n\tPrice: " + main.rTxtBxeSports2013W.Text +
											  "\n\tTotal value: " + main.rTxtBxeSports2013WTV.Text);

			Timer.streamWriterTimer.WriteLine("eSports 2014 Summer Case: " +
											  "\n\tAmount: " + main.rTxtBxeSports2014SA.Text +
											  "\n\tPrice: " + main.rTxtBxeSports2014S.Text +
											  "\n\tTotal value: " + main.rTxtBxeSports2014STV.Text);

			Timer.streamWriterTimer.WriteLine("Falchion Case: " +
											  "\n\tAmount: " + main.rTxtBxFalchionA.Text +
											  "\n\tPrice: " + main.rTxtBxFalchion.Text +
											  "\n\tTotal value: " + main.rTxtBxFalchionTV.Text);

			Timer.streamWriterTimer.WriteLine("Fracture Case: " +
											  "\n\tAmount: " + main.rTxtBxFractureA.Text +
											  "\n\tPrice: " + main.rTxtBxFracture.Text +
											  "\n\tTotal value: " + main.rTxtBxFractureTV.Text);

			Timer.streamWriterTimer.WriteLine("Gamma Case: " +
											  "\n\tAmount: " + main.rTxtBxGammaA.Text +
											  "\n\tPrice: " + main.rTxtBxGamma.Text +
											  "\n\tTotal value: " + main.rTxtBxGammaTV.Text);

			Timer.streamWriterTimer.WriteLine("Gamma 2 Case: " +
											  "\n\tAmount: " + main.rTxtBxGamma2A.Text +
											  "\n\tPrice: " + main.rTxtBxGamma2.Text +
											  "\n\tTotal value: " + main.rTxtBxGamma2TV.Text);

			Timer.streamWriterTimer.WriteLine("Glove Case: " +
											  "\n\tAmount: " + main.rTxtBxGloveA.Text +
											  "\n\tPrice: " + main.rTxtBxGlove.Text +
											  "\n\tTotal value: " + main.rTxtBxGloveTV.Text);

			Timer.streamWriterTimer.WriteLine("Horizon Case: " +
											  "\n\tAmount: " + main.rTxtBxHorizonA.Text +
											  "\n\tPrice: " + main.rTxtBxHorizon.Text +
											  "\n\tTotal value: " + main.rTxtBxHorizonTV.Text);

			Timer.streamWriterTimer.WriteLine("Huntsman Weapon Case: " +
											  "\n\tAmount: " + main.rTxtBxHuntsmanA.Text +
											  "\n\tPrice: " + main.rTxtBxHuntsman.Text +
											  "\n\tTotal value: " + main.rTxtBxHuntsmanTV.Text);

			Timer.streamWriterTimer.WriteLine("Operation Bravo Case: " +
											  "\n\tAmount: " + main.rTxtBxBravoA.Text +
											  "\n\tPrice: " + main.rTxtBxBravo.Text +
											  "\n\tTotal value: " + main.rTxtBxBravoTV.Text);

			Timer.streamWriterTimer.WriteLine("Operation Breakout Weapon Case: " +
											  "\n\tAmount: " + main.rTxtBxBreakoutA.Text +
											  "\n\tPrice: " + main.rTxtBxBreakout.Text +
											  "\n\tTotal value: " + main.rTxtBxBreakoutTV.Text);

			Timer.streamWriterTimer.WriteLine("Operation Hydra Case: " +
											  "\n\tAmount: " + main.rTxtBxHydraA.Text +
											  "\n\tPrice: " + main.rTxtBxHydra.Text +
											  "\n\tTotal value: " + main.rTxtBxHydraTV.Text);

			Timer.streamWriterTimer.WriteLine("Operation Phoenix Weapon Case: " +
											  "\n\tAmount: " + main.rTxtBxPhoenixA.Text +
											  "\n\tPrice: " + main.rTxtBxPhoenix.Text +
											  "\n\tTotal value: " + main.rTxtBxPhoenixTV.Text);

			Timer.streamWriterTimer.WriteLine("Operation Vanguard Weapon Case: " +
											  "\n\tAmount: " + main.rTxtBxVanguardA.Text +
											  "\n\tPrice: " + main.rTxtBxVanguard.Text +
											  "\n\tTotal value: " + main.rTxtBxVanguardTV.Text);

			Timer.streamWriterTimer.WriteLine("Operation Wildfire Case: " +
											  "\n\tAmount: " + main.rTxtBxWildfireA.Text +
											  "\n\tPrice: " + main.rTxtBxWildfire.Text +
											  "\n\tTotal value: " + main.rTxtBxWildfireTV.Text);

			Timer.streamWriterTimer.WriteLine("Prisma Case: " +
											  "\n\tAmount: " + main.rTxtBxPrismaA.Text +
											  "\n\tPrice: " + main.rTxtBxPrisma.Text +
											  "\n\tTotal value: " + main.rTxtBxPrismaTV.Text);

			Timer.streamWriterTimer.WriteLine("Prisma 2 Case: " +
											  "\n\tAmount: " + main.rTxtBxPrisma2A.Text +
											  "\n\tPrice: " + main.rTxtBxPrisma2.Text +
											  "\n\tTotal value: " + main.rTxtBxPrisma2TV.Text);

			Timer.streamWriterTimer.WriteLine("Revolver Case: " +
											  "\n\tAmount: " + main.rTxtBxRevolverA.Text +
											  "\n\tPrice: " + main.rTxtBxRevolver.Text +
											  "\n\tTotal value: " + main.rTxtBxRevolverTV.Text);

			Timer.streamWriterTimer.WriteLine("Shadow Case: " +
											  "\n\tAmount: " + main.rTxtBxShadowA.Text +
											  "\n\tPrice: " + main.rTxtBxShadow.Text +
											  "\n\tTotal value: " + main.rTxtBxShadowTV.Text);

			Timer.streamWriterTimer.WriteLine("Shattered Web Case: " +
											  "\n\tAmount: " + main.rTxtBxShatteredWebA.Text +
											  "\n\tPrice: " + main.rTxtBxShatteredWeb.Text +
											  "\n\tTotal value: " + main.rTxtBxShatteredWebTV.Text);

			Timer.streamWriterTimer.WriteLine("Spectrum Case: " +
											  "\n\tAmount: " + main.rTxtBxSpectrumA.Text +
											  "\n\tPrice: " + main.rTxtBxSpectrum.Text +
											  "\n\tTotal value: " + main.rTxtBxSpectrumTV.Text);

			Timer.streamWriterTimer.WriteLine("Spectrum 2 Case: " +
											  "\n\tAmount: " + main.rTxtBxSpectrum2A.Text +
											  "\n\tPrice: " + main.rTxtBxSpectrum2.Text +
											  "\n\tTotal value: " + main.rTxtBxSpectrum2TV.Text);

			Timer.streamWriterTimer.WriteLine("Winter Offensive Weapon Case: " +
											  "\n\tAmount: " + main.rTxtBxWinterOffensiveA.Text +
											  "\n\tPrice: " + main.rTxtBxWinterOffensive.Text +
											  "\n\tTotal value: " + main.rTxtBxWinterOffensiveTV.Text);

			Timer.streamWriterTimer.WriteLine("\n\t\tTotal Cases: " + main.rTxtBxTCA.Text +
											  "\n\t\tTotal Case Value: " + main.rTxtBxTCV.Text +
											  "\n\tTime: " + DateTime.Now.ToLongTimeString());

			Timer.streamWriterTimer.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
			Timer.streamWriterTimer.Flush();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start("https://twitter.com/noel_the_N00B");
		}

		private void lLblDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start("https://www.paypal.com/donate/?hosted_button_id=XGUUPFYJ9FPYU");
		}

		private void btnStop_Click(object sender, EventArgs e) {

	        Form_Main main = new Form_Main();

	        main.rTxtBxChroma.ReadOnly = false;

			calcTimer.Enabled = false;

			Timer.streamWriterTimer.WriteLine("Timer has been stopped!" +
			                                  "\nEnd Date: " + DateTime.Now.ToLongDateString() +
			                                  "\nEnd Time: " + DateTime.Now.ToLongTimeString() +
			                                  "\n==============================================\n");

			MessageBox.Show("The timer has been stopped!", "Timer has been stopped!", MessageBoxButtons.OK);
        }

        private void Form_Options_Exit(object sender, FormClosingEventArgs e) {
	        if (calcTimer.Enabled) {
		        //block closing by the user while the timmer is running
		        e.Cancel = e.CloseReason == CloseReason.UserClosing;

		        MessageBox.Show("ERROR: The timer is still running!\nPlease stop the timer first!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }

        private void Form_Options_Load(object sender, EventArgs e)
        { }
    }
}