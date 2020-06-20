using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Reflection;

namespace CSGO_Case_Calculator
{
    public partial class Form1 : Form
    {
        int wait = 3000;

        string steammarktcsgo = "https://steamcommunity.com/market/listings/730/";

        //strings for the website infos and amount of cases
        int aChroma;
        int aChroma2;
        int aChroma3;
        int aClutch;
        int aCS20;
        int aCSGOWC;
        int aCSGOWC2;
        int aCSGOWC3;
        int aDangerZone;
        int aeSports2013;
        int aeSports2013Winter;
        int aeSports2014Summer;
        int aFalchion;
        int aGamma;
        int aGamma2;
        int aGlove;
        int aHorizon;
        int aHuntsman;
        int aBravo;
        int aBreakout;
        int aHydra;
        int aPhoenix;
        int aVanguard;
        int aWildfire;
        int aPrisma;
        int aPrisma2;
        int aRevolver;
        int aShadow;
        int aShatteredWeb;
        int aSpectrum;
        int aSpectrum2;
        int aWinterOffensive;

        //create httpclients
        static readonly HttpClient client = new HttpClient();


        //save website in string and extract the price
        public async Task Main()
        {
            string urlsteammarkt = "https://steamcommunity.com/market/priceoverview/?appid=730&currency=3&market_hash_name=";

            if (cBxChroma.Checked)
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Chroma%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxChroma.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {

                this.rTxtBxChroma.Text = "0";

            }

            if (cBxChroma2.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Chroma%202%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxChroma2.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxChroma2.Text = "0";
            }

            if (cBxChroma3.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Chroma%203%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxChroma3.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxChroma3.Text = "0";
            }

            if (cBxClutch.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Clutch%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxClutch.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxClutch.Text = "0";
            }

            if (cBxCS20.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "CS20%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxCS20.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxCS20.Text = "0";
            }

            if (cBxCSGOWC.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "CS%3AGO%20Weapon%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxCSGOWC.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxCSGOWC.Text = "0";
            }

            if (cBxCSGOWC2.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "CS%3AGO%20Weapon%20Case%202");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxCSGOWC2.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxCSGOWC2.Text = "0";
            }

            if (cBxCSGOWC3.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "CS%3AGO%20Weapon%20Case%203");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxCSGOWC3.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxCSGOWC3.Text = "0";
            }

            if (cBxDangerZone.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Danger%20Zone%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxDangerZone.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxDangerZone.Text = "0";
            }

            if (cBxeSports2013.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "eSports%202013%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxeSports2013.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxeSports2013.Text = "0";
            }

            if (cBxeSports2013W.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "eSports%202013%20Winter%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxeSports2013W.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxeSports2013W.Text = "0";
            }

            if (cBxeSports2014S.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "eSports%202014%20Summer%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxeSports2014S.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxeSports2014S.Text = "0";
            }

            if (cBxFalchion.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Falchion%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxFalchion.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxFalchion.Text = "0";
            }

            if (cBxGamma.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Gamma%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxGamma.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxGamma.Text = "0";
            }

            if (cBxGamma2.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Gamma%202%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxGamma2.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxGamma2.Text = "0";
            }

            if (cBxGlove.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Glove%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxGlove.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxGlove.Text = "0";
            }

            if (cBxHorizon.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Horizon%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxHorizon.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxHorizon.Text = "0";
            }

            if (cBxHuntsman.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Huntsman%20Weapon%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxHuntsman.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxHuntsman.Text = "0";
            }

            if (cBxBravo.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Operation%20Bravo%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxBravo.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxBravo.Text = "0";
            }

            if (cBxBreakout.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Operation%20Breakout%20Weapon%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxBreakout.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxBreakout.Text = "0";
            }

            if (cBxHydra.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Operation%20Hydra%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxHydra.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxHydra.Text = "0";
            }

            if (cBxPhoenix.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Operation%20Phoenix%20Weapon%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxPhoenix.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxPhoenix.Text = "0";
            }

            if (cBxVanguard.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Operation%20Vanguard%20Weapon%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxVanguard.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxVanguard.Text = "0";
            }

            if (cBxWildfire.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Operation%20Wildfire%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxWildfire.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxWildfire.Text = "0";
            }

            if (cBxPrisma.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Prisma%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxPrisma.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxPrisma.Text = "0";
            }

            if (cBxPrisma2.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Prisma%202%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxPrisma2.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxPrisma2.Text = "0";
            }

            if (cBxRevolver.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Revolver%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxRevolver.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxRevolver.Text = "0";
            }

            if (cBxShadow.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Shadow%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxShadow.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxShadow.Text = "0";
            }

            if (cBxShatteredWeb.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Shattered%20Web%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxShatteredWeb.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxShatteredWeb.Text = "0";
            }

            if (cBxSpectrum.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Spectrum%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxSpectrum.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxSpectrum.Text = "0";
            }

            if (cBxSpectrum2.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Spectrum%202%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxSpectrum2.Text = Convert.ToString(price) + "€";
                }
                catch { }

            } else
            {
                this.rTxtBxSpectrum2.Text = "0";
            }

            if (cBxWinterOffensive.Checked)
            {
                await Task.Delay(wait);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(urlsteammarkt + "Winter%20Offensive%20Weapon%20Case");
                    response.EnsureSuccessStatusCode();
                    string price = await response.Content.ReadAsStringAsync();
                    //cute out the min price
                    price = price.Remove(0, 32);
                    price = price.Remove(price.IndexOf('\\'));
                    //replace -- when it's a round price (e.g. 13€ will be displayed as 13,--)
                    price = price.Replace("--", "00");

                    this.rTxtBxWinterOffensive.Text = Convert.ToString(price) + "€";
                }
                catch { }
            } else
            {
                this.rTxtBxWinterOffensive.Text = "0";
            }

            //auto calculate
            if (cBxAC.Checked)
            {
                SaveAllCases();
            }
        }

        //Load all Amounts from the XML-File
        public void LoadCases()
        {
            try
            {
                //amounts a set in the boxes
                string ExePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"CSGO Case Calculator.exe");
                string propertyFile = @ExePath;
                string propertyFolder = propertyFile.Substring(0, propertyFile.LastIndexOf("\\") + 1);
                string CaseXML = propertyFolder + "cases.xml";

                XmlSerializer xs = new XmlSerializer(typeof(Cases));
                FileStream read = new FileStream(CaseXML, FileMode.Open, FileAccess.Read, FileShare.Read);
                Cases cases = (Cases)xs.Deserialize(read);

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

                //calculate Total Case Amount
                this.rTxtBxTCA.Text = Convert.ToString(aChroma + aChroma2 + aChroma3 + aClutch + aCS20 + aCSGOWC + aCSGOWC2 + aCSGOWC3 + aDangerZone + aeSports2013 + aeSports2013Winter + aeSports2014Summer + aFalchion + aGamma +
                    aGamma2 + aGlove + aHorizon + aHuntsman + aBravo + aBreakout + aBreakout + aHydra + aPhoenix + aVanguard + aWildfire + aPrisma + aPrisma2 + aRevolver + aShadow + aShatteredWeb + aSpectrum + aSpectrum2 + aWinterOffensive);
            }
            catch
            {

            }
        }

        public void SaveAllCases()
        {
            Cases cases = new Cases
            {
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
            };

            //set path for xml-file
            string ExePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"CSGO Case Calculator.exe");
            string propertyFile = @ExePath;
            string propertyFolder = propertyFile.Substring(0, propertyFile.LastIndexOf("\\") + 1);
            string CaseXML = propertyFolder + "cases.xml";

            //create fill
            SaveCases.SaveDaten(cases, CaseXML);
        }

        public Form1() => InitializeComponent();

        //Button to reload all prices
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            this.rTxtBxChroma2.Text = "";
            this.rTxtBxChroma2.Text = "";
            this.rTxtBxChroma3.Text = "";
            this.rTxtBxClutch.Text = "";
            this.rTxtBxCS20.Text = "";
            this.rTxtBxCSGOWC.Text = "";
            this.rTxtBxCSGOWC2.Text = "";
            this.rTxtBxCSGOWC3.Text = "";
            this.rTxtBxDangerZone.Text = "";
            this.rTxtBxeSports2013.Text = "";
            this.rTxtBxeSports2013W.Text = "";
            this.rTxtBxeSports2014S.Text = "";
            this.rTxtBxFalchion.Text = "";
            this.rTxtBxGamma.Text = "";
            this.rTxtBxGamma2.Text = "";
            this.rTxtBxGlove.Text = "";
            this.rTxtBxHorizon.Text = "";
            this.rTxtBxHuntsman.Text = "";
            this.rTxtBxBravo.Text = "";
            this.rTxtBxBreakout.Text = "";
            this.rTxtBxHydra.Text = "";
            this.rTxtBxPhoenix.Text = "";
            this.rTxtBxVanguard.Text = "";
            this.rTxtBxWildfire.Text = "";
            this.rTxtBxPrisma.Text = "";
            this.rTxtBxPrisma2.Text = "";
            this.rTxtBxRevolver.Text = "";
            this.rTxtBxShadow.Text = "";
            this.rTxtBxShatteredWeb.Text = "";
            this.rTxtBxSpectrum.Text = "";
            this.rTxtBxSpectrum2.Text = "";
            this.rTxtBxWinterOffensive.Text = "";

            await Main();
        }

        //calculate the values
        private void btnRefresh_Click(object sender, EventArgs e)
        {

            if (Int32.TryParse(this.rTxtBxChromaA.Text, out aChroma))
            {                                                       
                this.rTxtBxChromaTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxChroma.Text.Replace("€", "")) * Convert.ToDecimal(aChroma)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxChromaA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxChroma2A.Text, out aChroma2))
            {
                this.rTxtBxChroma2TV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxChroma2.Text.Replace("€", "")) * Convert.ToDecimal(aChroma2)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxChroma2A.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            //if (this.rTxtBxChroma.Text = "null")

            if (Int32.TryParse(this.rTxtBxChroma3A.Text, out aChroma3))
            {
                this.rTxtBxChroma3TV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxChroma3.Text.Replace("€", "")) * Convert.ToDecimal(aChroma3)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxChroma3A.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxClutchA.Text, out aClutch))
            {
                this.rTxtBxClutchTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxClutch.Text.Replace("€", "")) * Convert.ToDecimal(aClutch)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxClutchA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxCS20A.Text, out aCS20))
            {
                this.rTxtBxCS20TV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxCS20.Text.Replace("€", "")) * Convert.ToDecimal(aCS20)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxCS20A.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxCSGOWCA.Text, out aCSGOWC))
            {
                this.rTxtBxCSGOWCTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxCSGOWC.Text.Replace("€", "")) * Convert.ToDecimal(aCSGOWC)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxCSGOWCA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxCSGOWC2A.Text, out aCSGOWC2))
            {
                this.rTxtBxCSGOWC2TV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxCSGOWC2.Text.Replace("€", "")) * Convert.ToDecimal(aCSGOWC2)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxCSGOWC2A.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxCSGOWC3A.Text, out aCSGOWC3))
            {
                this.rTxtBxCSGOWC3TV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxCSGOWC3.Text.Replace("€", "")) * Convert.ToDecimal(aCSGOWC3)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxCSGOWC3A.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxDangerZoneA.Text, out aDangerZone))
            {
                this.rTxtBxDangerZoneTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxDangerZone.Text.Replace("€", "")) * Convert.ToDecimal(aDangerZone)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxDangerZoneA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxeSports2013A.Text, out aeSports2013))
            {
                this.rTxtBxeSports2013TV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxeSports2013.Text.Replace("€", "")) * Convert.ToDecimal(aeSports2013)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxeSports2013A.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxeSports2013WA.Text, out aeSports2013Winter))
            {
                this.rTxtBxeSports2013WTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxeSports2013W.Text.Replace("€", "")) * Convert.ToDecimal(aeSports2013Winter)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxeSports2013WA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxeSports2014SA.Text, out aeSports2014Summer))
            {
                this.rTxtBxeSports2014STV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxeSports2014S.Text.Replace("€", "")) * Convert.ToDecimal(aeSports2014Summer)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxeSports2014SA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxFalchionA.Text, out aFalchion))
            {
                this.rTxtBxFalchionTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxFalchion.Text.Replace("€", "")) * Convert.ToDecimal(aFalchion)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxFalchionA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxGammaA.Text, out aGamma))
            {
                this.rTxtBxGammaTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxGamma.Text.Replace("€", "")) * Convert.ToDecimal(aGamma)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxGammaA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxGamma2A.Text, out aGamma2))
            {
                this.rTxtBxGamma2TV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxGamma2.Text.Replace("€", "")) * Convert.ToDecimal(aGamma2)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxGamma2A.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxGloveA.Text, out aGlove))
            {
                this.rTxtBxGloveTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxGlove.Text.Replace("€", "")) * Convert.ToDecimal(aGlove)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxGloveA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxHorizonA.Text, out aHorizon))
            {
                this.rTxtBxHorizonTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxHorizon.Text.Replace("€", "")) * Convert.ToDecimal(aHorizon)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxHorizonA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxHuntsmanA.Text, out aHuntsman))
            {
                this.rTxtBxHuntsmanTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxHuntsman.Text.Replace("€", "")) * Convert.ToDecimal(aHuntsman)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxHuntsmanA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxBravoA.Text, out aBravo))
            {
                this.rTxtBxBravoTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxBravo.Text.Replace("€", "")) * Convert.ToDecimal(aBravo)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxBravoA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxBreakoutA.Text, out aBreakout))
            {
                this.rTxtBxBreakoutTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxBreakout.Text.Replace("€", "")) * Convert.ToDecimal(aBreakout)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxBreakoutA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxHydraA.Text, out aHydra))
            {
                this.rTxtBxHydraTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxHydra.Text.Replace("€", "")) * Convert.ToDecimal(aHydra)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxHydraA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxPhoenixA.Text, out aPhoenix))
            {
                this.rTxtBxPhoenixTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxPhoenix.Text.Replace("€", "")) * Convert.ToDecimal(aPhoenix)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxPhoenixA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxVanguardA.Text, out aVanguard))
            {
                this.rTxtBxVanguardTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxVanguard.Text.Replace("€", "")) * Convert.ToDecimal(aVanguard)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxVanguardA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxWildfireA.Text, out aWildfire))
            {
                this.rTxtBxWildfireTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxWildfire.Text.Replace("€", "")) * Convert.ToDecimal(aWildfire)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxWildfireA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxPrismaA.Text, out aPrisma))
            {
                this.rTxtBxPrismaTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxPrisma.Text.Replace("€", "")) * Convert.ToDecimal(aPrisma)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxPrismaA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxPrisma2A.Text, out aPrisma2))
            {
                this.rTxtBxPrisma2TV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxPrisma2.Text.Replace("€", "")) * Convert.ToDecimal(aPrisma2)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxPrisma2A.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxRevolverA.Text, out aRevolver))
            {
                this.rTxtBxRevolverTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxRevolver.Text.Replace("€", "")) * Convert.ToDecimal(aRevolver)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxRevolverA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxShadowA.Text, out aShadow))
            {
                this.rTxtBxShadowTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxShadow.Text.Replace("€", "")) * Convert.ToDecimal(aShadow)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxShadowA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxShatteredWebA.Text, out aShatteredWeb))
            {
                this.rTxtBxShatteredWebTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxShatteredWeb.Text.Replace("€", "")) * Convert.ToDecimal(aShatteredWeb)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxShatteredWebA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxSpectrumA.Text, out aSpectrum))
            {
                this.rTxtBxSpectrumTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxSpectrum.Text.Replace("€", "")) * Convert.ToDecimal(aSpectrum)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxSpectrumA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxSpectrum2A.Text, out aSpectrum2))
            {
                this.rTxtBxSpectrum2TV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxSpectrum2.Text.Replace("€", "")) * Convert.ToDecimal(aSpectrum2)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxSpectrum2A.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (Int32.TryParse(this.rTxtBxWinterOffensiveA.Text, out aWinterOffensive))
            {
                this.rTxtBxWinterOffensiveTV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxWinterOffensive.Text.Replace("€", "")) * Convert.ToDecimal(aWinterOffensive)) + "€";
            }
            else
            {
                MessageBox.Show("Error: \"" + rTxtBxWinterOffensiveA.Text + "\" is not a number! \nPlease enter a valid number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


            //check if all amounts are numbers
            bool allsave = Int32.TryParse(this.rTxtBxChromaA.Text, out aChroma) && Int32.TryParse(this.rTxtBxChroma2A.Text, out aChroma2) && Int32.TryParse(this.rTxtBxChroma3A.Text, out aChroma3) && Int32.TryParse(this.rTxtBxClutchA.Text, out aClutch) &&
                Int32.TryParse(this.rTxtBxCS20A.Text, out aCS20) && Int32.TryParse(this.rTxtBxCSGOWCA.Text, out aCSGOWC) && Int32.TryParse(this.rTxtBxCSGOWC2A.Text, out aCSGOWC2) && Int32.TryParse(this.rTxtBxCSGOWC3A.Text, out aCSGOWC3) &&
                Int32.TryParse(this.rTxtBxDangerZoneA.Text, out aDangerZone) && Int32.TryParse(this.rTxtBxeSports2013A.Text, out aeSports2013) && Int32.TryParse(this.rTxtBxeSports2013WA.Text, out aeSports2013Winter) &&
                Int32.TryParse(this.rTxtBxeSports2014SA.Text, out aeSports2014Summer) && Int32.TryParse(this.rTxtBxFalchionA.Text, out aFalchion) && Int32.TryParse(this.rTxtBxGammaA.Text, out aGamma) &&
                Int32.TryParse(this.rTxtBxGamma2A.Text, out aGamma2) && Int32.TryParse(this.rTxtBxGloveA.Text, out aGlove) && Int32.TryParse(this.rTxtBxHorizonA.Text, out aHorizon) && Int32.TryParse(this.rTxtBxHuntsmanA.Text, out aHuntsman) &&
                Int32.TryParse(this.rTxtBxBravoA.Text, out aBravo) && Int32.TryParse(this.rTxtBxBreakoutA.Text, out aBreakout) && Int32.TryParse(this.rTxtBxHydraA.Text, out aHydra) && Int32.TryParse(this.rTxtBxPhoenixA.Text, out aPhoenix) &&
                Int32.TryParse(this.rTxtBxVanguardA.Text, out aVanguard) && Int32.TryParse(this.rTxtBxWildfireA.Text, out aWildfire) && Int32.TryParse(this.rTxtBxPrismaA.Text, out aPrisma) && Int32.TryParse(this.rTxtBxPrisma2A.Text, out aPrisma2) &&
                Int32.TryParse(this.rTxtBxRevolverA.Text, out aRevolver) && Int32.TryParse(this.rTxtBxShadowA.Text, out aShadow) && Int32.TryParse(this.rTxtBxShatteredWebA.Text, out aShatteredWeb) && Int32.TryParse(this.rTxtBxSpectrumA.Text, out aSpectrum) &&
                Int32.TryParse(this.rTxtBxSpectrum2A.Text, out aSpectrum2) && Int32.TryParse(this.rTxtBxWinterOffensiveA.Text, out aWinterOffensive);

            if (allsave)
            {
                //calculate Total Case Value
                this.rTxtBxTCV.Text = Convert.ToString(Convert.ToDecimal(this.rTxtBxChromaTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxChroma2TV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxChroma3TV.Text.Replace("€", "")) +
                    Convert.ToDecimal(this.rTxtBxClutchTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxCS20TV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxCSGOWCTV.Text.Replace("€", "")) +
                    Convert.ToDecimal(this.rTxtBxCSGOWC2TV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxCSGOWC3TV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxDangerZoneTV.Text.Replace("€", "")) +
                    Convert.ToDecimal(this.rTxtBxeSports2013TV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxeSports2013WTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxeSports2014STV.Text.Replace("€", "")) +
                    Convert.ToDecimal(this.rTxtBxFalchionTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxGammaTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxGamma2TV.Text.Replace("€", "")) +
                    Convert.ToDecimal(this.rTxtBxGloveTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxHorizonTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxHuntsmanTV.Text.Replace("€", "")) +
                    Convert.ToDecimal(this.rTxtBxBravoTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxBreakoutTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxHydraTV.Text.Replace("€", "")) +
                    Convert.ToDecimal(this.rTxtBxPhoenixTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxVanguardTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxWildfireTV.Text.Replace("€", "")) +
                    Convert.ToDecimal(this.rTxtBxPrismaTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxPrisma2TV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxRevolverTV.Text.Replace("€", "")) +
                    Convert.ToDecimal(this.rTxtBxShadowTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxShatteredWebTV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxSpectrumTV.Text.Replace("€", "")) +
                    Convert.ToDecimal(this.rTxtBxSpectrum2TV.Text.Replace("€", "")) + Convert.ToDecimal(this.rTxtBxWinterOffensiveTV.Text.Replace("€", ""))) + "€";

                //calculate Total Case Amount
                this.rTxtBxTCA.Text = Convert.ToString(aChroma + aChroma2 + aChroma3 + aClutch + aCS20 + aCSGOWC + aCSGOWC2 + aCSGOWC3 + aDangerZone + aeSports2013 + aeSports2013Winter + aeSports2014Summer + aFalchion + aGamma +
                    aGamma2 + aGlove + aHorizon + aHuntsman + aBravo + aBreakout + aBreakout + aHydra + aPhoenix + aVanguard + aWildfire + aPrisma + aPrisma2 + aRevolver + aShadow + aShatteredWeb + aSpectrum + aSpectrum2 + aWinterOffensive);
            } else { }
        }

        //class to save the amount
        public class SaveCases
        {
            public static void SaveDaten(object obj, string filename)
            {
                XmlSerializer sr = new XmlSerializer(obj.GetType());
                TextWriter writer = new StreamWriter(filename);
                sr.Serialize(writer, obj);
                writer.Close();
            }
        }

        //class to creat a string for each case to get saved
        public class Cases
        {
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
        }

        //save amounts in a xml-file
        private void btnSaveCases_Click(object sender, EventArgs e)
        {
            try
            {
                SaveAllCases();
            }
            catch
            {
                MessageBox.Show("Cases saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //button to load all saved amounts if something went wrong on startup
        private void btnLoadSavedCases_Click(object sender, EventArgs e)
        {
            //Load all Amounts
            LoadCases();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string ExePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"CSGO Case Calculator.exe");
            string propertyFile = @ExePath;
            string propertyFolder = propertyFile.Substring(0, propertyFile.LastIndexOf("\\") + 1);
            string CaseXML = propertyFolder + "cases.xml";

            if (File.Exists(CaseXML))
            {
                //Load all Amounts
                LoadCases();
            
            } else {

                //on first startup a file will be create where every amount is set to 0 (to avoid bugs when calculating)
                Cases casesempty = new Cases
                {
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
                };

                //create file
                SaveCases.SaveDaten(casesempty, CaseXML);

            }

            //load all amounts on startup
            await Main();

        }

        //Links for LinkLabels
        private void lLblChroma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Chroma%20Case");
        }

        private void lLblChroma2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Chroma%202%20Case");
        }

        private void lLblChroma3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Chroma%203%20Case");
        }

        private void lLblClutch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Clutch%20Case");
        }

        private void lLblCS20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "CS20%20Case");
        }

        private void lLblCSGOWC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "CS%3AGO%20Weapon%20Case");
        }

        private void lLblCSGOWC2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "CS%3AGO%20Weapon%20Case%202");
        }

        private void lLblCSGOWC3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "CS%3AGO%20Weapon%20Case%203");
        }

        private void lLblDangerZone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Danger%20Zone%20Case");
        }

        private void lLbleSports2013_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "eSports%202013%20Case");
        }

        private void lLbleSports2013W_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "eSports%202013%20Winter%20Case");
        }

        private void lLbleSports2014S_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "eSports%202014%20Summer%20Case");
        }

        private void lLblFalchion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Falchion%20Case");
        }

        private void lLblGamma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Gamma%20Case");
        }

        private void lLblGamma2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Gamma%202%20Case");
        }

        private void lLblGlove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Glove%20Case");
        }

        private void lLblHorizon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Horizon%20Case");
        }

        private void lLblHuntsman_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Huntsman%20Weapon%20Case");
        }

        private void lLblBravo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Operation%20Bravo%20Case");
        }

        private void lLblBreakout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Operation%20Breakout%20Weapon%20Case");
        }

        private void lLblHydra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Operation%20Hydra%20Case");
        }

        private void lLblPhoenix_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Operation%20Phoenix%20Weapon%20Case");
        }

        private void lLblVanguard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Operation%20Vanguard%20Weapon%20Case");
        }

        private void lLblWildfire_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Operation%20Wildfire%20Case");
        }

        private void lLblPrisma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Prisma%20Case");
        }

        private void lLblPrisma2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Prisma%202%20Case");
        }

        private void lLblRevolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Revolver%20Case");
        }

        private void lLblShadow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Shadow%20Case");
        }

        private void lLblShatteredWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Shattered%20Web%20Case");
        }

        private void lLblSpectrum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Spectrum%20Case");
        }

        private void lLblSpectrum2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Spectrum%202%20Case");
        }

        private void lLblWinterOffensive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(steammarktcsgo + "Winter%20Offensive%20Weapon%20Case");
        }


        //stuff that i don't need and created accidentally
        private void rTxtBxTCA_TextChanged(object sender, EventArgs e)
        { }

        private void lblTotalCaseValue_Click(object sender, EventArgs e)
        { }

        private void rTxtBxTCV_TextChanged(object sender, EventArgs e)
        { }

        private void rTxtBxChromaTV_TextChanged(object sender, EventArgs e)
        { }
    }
}