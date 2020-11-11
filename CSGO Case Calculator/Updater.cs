using System.Diagnostics;
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

        public async Task<string> getLatestVersion() {
	        var client = new GitHubClient(new ProductHeaderValue(name));
			var releases = await client.Repository.Release.GetAll(owner, name);
	        var latest = releases[0];

	        return latestVersion = latest.TagName;
        }

        public async void checkForUpdate() {

			await getLatestVersion();

	        if (latestVersion != currentVersion) {
				var newVersionMsgBx = MessageBox.Show("New version " + latestVersion + " is available!\nYour current version is " + currentVersion +".\nDo you want to open the release page in your browser?",
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
