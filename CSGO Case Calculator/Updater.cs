using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace CSGO_Case_Calculator
{
    class Updater {

	    private static string name = "CSGO-Case-Calculator";
	    private static string owner = "NoelTheN00B";
	    private static string currentVersion = "v1.2";
	    private static string latestVersion;

        public async void getLatestVersion() {
	        var client = new GitHubClient(new ProductHeaderValue(name));
			var releases = await client.Repository.Release.GetAll(owner, name);
	        var latest = releases[0];

	        latestVersion = latest.TagName;
        }

        public void checkForUpdate() {

			getLatestVersion();

	        if (latestVersion != currentVersion) {
				var newVersionMsgBx = MessageBox.Show("New version " + latestVersion + " is available!\nDo you want to open the release page in your browser?",
					"There's an update!",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Information,
					MessageBoxDefaultButton.Button1);

				if (newVersionMsgBx == DialogResult.Yes) {
					Process.Start("https://github.com/" + owner + "/" + name + "/releases/tag/" + latestVersion);
				}
	        }
        }
    }
}
