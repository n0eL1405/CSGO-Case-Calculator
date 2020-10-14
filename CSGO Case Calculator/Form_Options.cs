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
					Timer.streamWriterTimer.WriteLine("Timer has been started!" +
					                                  "\nDate: " + DateTime.Now.ToLongDateString() +
													  "\nTime: " + DateTime.Now.ToLongTimeString() +
					                                  "\nInterval: " + rTxtBxTimerTime.Text + " minutes");
					Timer.streamWriterTimer.WriteLine("===================================== \n");
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

		public void calcTimer_Tick(object sender, EventArgs e) {

			Form_Main main = new Form_Main();

			Timer.streamWriterTimer.WriteLine("Chroma Case: " +
			                                  "\n\tAmount: " + main.rTxtBxChromaA.Text +
			                                  "\n\tPrice: " + main.rTxtBxChroma.Text +
			                                  "\n\tTotal value: " + main.rTxtBxChromaTV.Text);

			Timer.streamWriterTimer.Flush();
			calcTimer.Interval = TimerTime * 60000; //calculation for minutes in milliseconds
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start("https://twitter.com/noel_the_N00B");
		}

        private void btnStop_Click(object sender, EventArgs e) {

	        Form_Main main = new Form_Main();

	        main.rTxtBxChroma.ReadOnly = false;

			calcTimer.Enabled = false;


	        MessageBox.Show("The timer has been stopped!", "Timer has been stopped!", MessageBoxButtons.OK);
        }

        private void Form_Options_Exit(object sender, FormClosingEventArgs e) {
	        if (calcTimer.Enabled) {
		        //block closing by the user while the timmer is running
		        e.Cancel = e.CloseReason == CloseReason.UserClosing;

		        MessageBox.Show("ERROR: The timer is still running!\nPlease stop the timer first!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        } else {
		        this.Close();
			}
        }

        private void Form_Options_Load(object sender, EventArgs e)
        { }
	}
}