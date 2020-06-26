using System;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace CSGO_Case_Calculator
{
    public partial class Form_Options : Form
    {
        int TimerTime;

        public Form_Options()
        {
            InitializeComponent();
        }

        //button to import old xml-file
        public void btnImportOldXML_Click(object sender, EventArgs e)
        {

            var Form_Main = new Form_Main();

            OpenFileDialog openOldXMLfile = new OpenFileDialog();


            openOldXMLfile.FileName = "cases.xml";
            openOldXMLfile.Filter = "Cases XML-file|*.xml";
            

            if (openOldXMLfile.ShowDialog() == DialogResult.OK)
            {

                var MsgBxWrng = MessageBox.Show("WARNING!\nIf you already have an XML file, it will be replaced.\nThis cannot be undone.", "WARNING!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (MsgBxWrng == DialogResult.OK)
                {

                    try
                    {

                        string OLDcasesXML = openOldXMLfile.FileName;
                        string NEWcasesXML = Application.StartupPath + "\\files\\cases.xml";

                        XmlDocument xmldoc = new XmlDocument();
                        xmldoc.Load(OLDcasesXML);

                        //when new case:
                        //XmlElement NAME_OF_CASE = xmldoc.CreateElement("NAME_LIKE_IN_'FORM_MAIN.CASES'");
                        //NAME_OF_CASE.InnerText = "0";
                        //xmldoc.DocumentElement.AppendChild(NAME_OF_CASE);

                        XmlWriterSettings settings = new XmlWriterSettings();
                        settings.Indent = true;
                        XmlWriter writer = XmlWriter.Create(NEWcasesXML, settings);
                        xmldoc.Save(writer);
                        writer.Close();

                        MessageBox.Show("Success!\nPlease click on 'Load Saved Cases' to load the new XML-file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {

                        MessageBox.Show("Oops. Something went wrong.\nPlease try again.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    
                }
            }

        }

        private void btnHelpTimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter an integer between 5 and 60. This will be the interval between the price reloads and calculations.\n\nPress 'Start' to start the Calculation Timer and 'Stop' to stop the Calculation Timer.", "Calculation Timer Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void rTxtBxTimerTime_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //check if input is an integer
            if (Int32.TryParse(rTxtBxTimerTime.Text, out TimerTime))
            {
                //check if number is between 5 and 60
                if (TimerTime >= 5 && TimerTime <= 60)
                {
                    //code to set the timer


                }
                else
                {
                    MessageBox.Show("Error: \"" + rTxtBxTimerTime.Text + "\" is not between 5 and 60!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxTimerTime.Text + "\" is not an integer!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
