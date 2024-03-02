using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxChrome
{
    public partial class Form1 : Form
    {
        bool saveingMode = false;
        string selectedFile = "", backslash = "\\", a = "\"";
        string searchedText = "user_pref(" + "\"" + "toolkit.legacyUserProfileCustomizations.stylesheets" + "\"" + ", true);";
        string[] args, profiles;

        Bitmap tick = FoxChrome.Properties.Resources.check_64_icon;


        public Form1(string[] temp, string[] temp2)
        {
            args = temp;
            profiles = temp2;
            InitializeComponent();
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            loadProfiles(profiles);

            readLUPC();

            ReadAndApplySettings();

            try
            {
                if (System.IO.File.Exists(args[0])) selectFile(args[0]);
            }
            catch (Exception)
            {

                
            }



        }

        public void ReadAndApplySettings() {

            displayNoteToolStripMenuItem.Image = null;
            removeApplicationFilesAfterInstallToolStripMenuItem.Image = null;
            autoAcceptToolStripMenuItem.Image = null;
            blockAutomaticallyToolStripMenuItem.Image = null;
            askForInstallToolStripMenuItem.Image = null;
            enableAutomaticallyToolStripMenuItem.Image = null;
            blockAutomaticallyToolStripMenuItem1.Image = null;
            askForInstallToolStripMenuItem1.Image = null;


            if (Properties.Settings.Default.devNote) displayNoteToolStripMenuItem.Image = tick;
            if (Properties.Settings.Default.clean) removeApplicationFilesAfterInstallToolStripMenuItem.Image = tick;

            if (Properties.Settings.Default.extensionInstallMethod == 1) autoAcceptToolStripMenuItem.Image = tick;
            if (Properties.Settings.Default.extensionInstallMethod == 2) blockAutomaticallyToolStripMenuItem.Image = tick;
            if (Properties.Settings.Default.extensionInstallMethod == 3) askForInstallToolStripMenuItem.Image = tick;

            if (Properties.Settings.Default.configFilesInstallMethod == 1) enableAutomaticallyToolStripMenuItem.Image = tick;
            if (Properties.Settings.Default.configFilesInstallMethod == 2) blockAutomaticallyToolStripMenuItem1.Image = tick;
            if (Properties.Settings.Default.configFilesInstallMethod == 3) askForInstallToolStripMenuItem1.Image = tick;

            if (profileComboBox.Items.Contains(Properties.Settings.Default.lastProfile)) {
                profileComboBox.Text = Properties.Settings.Default.lastProfile;
                readLUPC();
            }
            

        }

        public void loadProfiles(string[] profiles) {

            string DefaultProfile = "";

            foreach (var i in profiles) {

                string profilesFile = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Mozilla\Firefox\profiles.ini");
                profileComboBox.Items.Add(i);
                profileComboBox.Text = i;

                if (profilesFile.Contains(@"Default=Profiles/" + i)) { DefaultProfile = i; }

            }

            if (DefaultProfile != "") { profileComboBox.Text = DefaultProfile; }
            
        }

        private void profileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void profileComboBox_DropDownClosed(object sender, EventArgs e)
        {

            readLUPC();
            Properties.Settings.Default.lastProfile = profileComboBox.Text;
            Properties.Settings.Default.Save();
            ReadAndApplySettings();


        }

        private void LUPCBtn_Click(object sender, EventArgs e)
        {
            LUPCswitch();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {

            Browse();

        }

        public void Browse() {

            OpenFileDialog1.Filter = "FoxChrome Files|*.foxchrome|All files|*.*";
            OpenFileDialog1.Title = "Browse FoxChrome file";
            OpenFileDialog1.FileName = "";

            if (OpenFileDialog1.ShowDialog() == DialogResult.OK) selectFile(OpenFileDialog1.FileName);

        }

        public bool readLUPC() {

            bool temp = false;

            if (File.ReadAllText(getProfileFolder() + backslash + "prefs.js").Contains(searchedText))
            {
                LUPCBtn.Text = "L.U.P.C.: ON";
                LUPCBtn.ForeColor = Color.Green;
                temp = true;
            }
            else {
                LUPCBtn.Text = "L.U.P.C.: OFF";
                LUPCBtn.ForeColor = Color.Red;
            }

            return temp;

        }

        public bool isInstallAllowed() {

            bool installationAllowed = false;

            if (selectedFile != "")
            {
                if (DoesFirefoxRun()) { installationAllowed = false; MessageBox.Show("Install can not beggins because Firefox is running. Please close it!"); }
                else
                {


                    if (Directory.Exists(getProfileFolder() + backslash + "chrome"))
                    {

                        DialogResult dialogResult = MessageBox.Show("CSS customization files found!" + Environment.NewLine + "By continuing the installation the files will be deleted!" + Environment.NewLine + "Do you want to continue?", "Warning!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes) installationAllowed = true;

                    }
                    else installationAllowed = true;



                    if (!File.Exists(Application.StartupPath + @"\Unzipper.exe"))
                    {

                        MessageBox.Show("Unzipper not found");
                        installationAllowed = false;

                    }

                }

            }
            else {

                MessageBox.Show("Please browse a theme file to install!");
                installationAllowed = false;
            }

            

            return installationAllowed;

        }
        private void installBtn_Click(object sender, EventArgs e)
        {

            if (isInstallAllowed()) Install();


        }

        public string removeQuote(string text)
        {
            return text.Replace(a, "");
        }

        public string addQuote(string text) {
            return a + text + a;
        }

        public string optimisePath(string text)
        {
            return addQuote(removeQuote(text));
        }

        public void Install() {

            string ProcessArgs = addQuote("e") + " " + optimisePath(selectedFile) + " " + optimisePath(getProfileFolder() + backslash +"chrome");


            if (Directory.Exists(getProfileFolder() + backslash + "chrome")) Directory.Delete(getProfileFolder() + backslash + "chrome", true);

            ProcessStartInfo(Application.StartupPath + @"\Unzipper.exe", ProcessArgs, ProcessWindowStyle.Hidden);

            installBtn.Text = "Installing...";
            installBtn.Enabled = false;
            ProcessTimer.Start();


        }


        public static bool DoesUnzipperRun()
        {

            Process[] pname = Process.GetProcessesByName("Unzipper");
            if (pname.Length == 0)
                return false;
            else
                return true;
        }

        public static bool DoesFirefoxRun()
        {

            Process[] pname = Process.GetProcessesByName("firefox");
            if (pname.Length == 0)
                return false;
            else
                return true;
        }



        public void ProcessStartInfo(string process, string args, ProcessWindowStyle windowstyle)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(process);
            startInfo.WindowStyle = windowstyle;

            startInfo.Arguments = args;

            Process.Start(startInfo);
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            if (!DoesUnzipperRun()) {

                stopProcessTimer();
                
                if (!saveingMode){

                    if (Properties.Settings.Default.extensionInstallMethod != 2)
                        if (addonsInThePackage()) addonInstallPossibility();

                    ConfigFileInstallAttempt();
                    devNote();
                    clean();
                }

                if (!saveingMode)
                    MessageBox.Show("Installation finished!");
                else MessageBox.Show("File has been saved!");

                installBtn.Text = "Install";
                installBtn.Enabled = true;
                saveingMode = false;

            } 
                

        }

        public void stopProcessTimer() 
        { ProcessTimer.Stop(); }

        private void abouztToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browse();
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedFile == "") MessageBox.Show("Can not open the location of the file because no file is selected!"); else {
                //MessageBox.Show(selectedFile.Split('\\')[selectedFile.Split('\\').Length - 1]);
                //MessageBox.Show(selectedFile.Substring(0, selectedFile.Length-1 - selectedFile.Split('\\')[selectedFile.Split('\\').Length - 1].Length));
                Process.Start(selectedFile.Substring(0, selectedFile.Length-1 - selectedFile.Split('\\')[selectedFile.Split('\\').Length - 1].Length));
            }
        }

        private void openUserjsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(getProfileFolder() + @"\user.js")) Process.Start("openwith.exe", getProfileFolder() + @"\user.js");
            else {

                DialogResult dialogResult = MessageBox.Show("user.js is not exists!" + Environment.NewLine + "Do you want to create it?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {

                    File.WriteAllText(getProfileFolder() + @"\user.js","");
                    Process.Start("openwith.exe", getProfileFolder() + @"\user.js");

                }


            }
        }

        private void openPrefsjsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(getProfileFolder() + @"\prefs.js")) Process.Start("openwith.exe", getProfileFolder() + @"\prefs.js");
            else
            {

                DialogResult dialogResult = MessageBox.Show("prefs.js is not exists!" + Environment.NewLine + "Do you want to create it?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    File.WriteAllText(getProfileFolder() + @"\prefs.js", "");
                    Process.Start("openwith.exe", getProfileFolder() + @"\prefs.js");

                }


            }
        }

        private void openChromeFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(getProfileFolder() + @"\chrome")) Process.Start(getProfileFolder() + @"\chrome");
            else
            {

                DialogResult dialogResult = MessageBox.Show("Chrome folder is not exists!" + Environment.NewLine + "Do you want to create it?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    Directory.CreateDirectory(getProfileFolder() + @"\chrome");

                    DialogResult dialogResult2 = MessageBox.Show("Do you want to create sample files?", "Question", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes) {

                        File.WriteAllText(getProfileFolder() + @"\chrome\userChrome.css","");
                        File.WriteAllText(getProfileFolder() + @"\chrome\userContent.css", "");

                    }



                        Process.Start(getProfileFolder() + @"\chrome");

                }


            }
        }

        private void openFolderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start(getProfileFolder());
        }

        private void unselectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedFile == "")
            {
                MessageBox.Show("Can not unselect the file because no file is selected!");
            }
            else { selectedFile = ""; MessageBox.Show("File unselected succesfully!");
                browseBtn.Text = "Browse";
                browseToolStripMenuItem.Text = "Browse";
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (isServerAvailable())
            {

                downloadClient("none/update_servers/FoxChrome/latest_client.txt", Application.StartupPath +  @"\latest_client.txt", true);


                string latest = File.ReadAllText(Application.StartupPath + @"\latest_client.txt");

                if (Assembly.GetExecutingAssembly().GetName().Version.ToString() != latest)
                {


                    ProcessStartInfo(Application.StartupPath + @"\FoxChrome_Updater.exe", "", ProcessWindowStyle.Minimized);
                    Application.Exit();
                }
                else
                {

                    MessageBox.Show("Update not found!");

                }


            }
            else MessageBox.Show("FoxChrome is unable to search for updates because no internet connection detected!");

        }


        public  bool isServerAvailable()
        {

            return downloadClient("none/update_servers/FoxChrome/latest_client.txt", Application.StartupPath + @"\latest_client.txt", true);
        }


        public  bool downloadClient(string url, string location, bool overwrite)
        {

            if (System.IO.File.Exists(location)) System.IO.File.Delete(location);

            try
            {
                using (var client = new System.Net.WebClient())
                {
                    client.DownloadFile(url, location);
                }
            }
            catch (Exception e)
            {
                return false;
            }



            return true;

        }

        private void applicationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            infoForm form2 = new infoForm();


            form2.Show();
        }

        public string getProfileFolder() {


            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Mozilla\Firefox\Profiles" + backslash + profileComboBox.Text;
            
        }

        public void LUPCswitch() {



            if (readLUPC())
            {

                string temp = File.ReadAllText(getProfileFolder()  + backslash + "prefs.js");

                File.Delete(getProfileFolder()  + backslash + "prefs.js");

                File.WriteAllText(getProfileFolder() + backslash + "prefs.js", temp.Replace(searchedText, ""));


            }
            else {

                string temp = File.ReadAllText(getProfileFolder() + backslash + "prefs.js");

                File.Delete(getProfileFolder() + backslash + "prefs.js");

                File.WriteAllText(getProfileFolder() + backslash + "prefs.js", temp + Environment.NewLine + searchedText);



            }

            readLUPC();

        }

        public void selectFile(string file) {

            selectedFile = file;
            browseBtn.Text = "Change";
            browseToolStripMenuItem.Text = "Change";

        }

        public bool IsDirectoryEmpty(string path)
        {
            IEnumerable<string> items = Directory.EnumerateFileSystemEntries(path);
            using (IEnumerator<string> en = items.GetEnumerator())
            {
                return !en.MoveNext();
            }
        }

        private void autoInstallExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void autoAcceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.extensionInstallMethod = 1;
            Properties.Settings.Default.Save();
            ReadAndApplySettings();

        }

        public void devNote() {

            if (File.Exists( getProfileFolder() + @"\chrome\.foxchrome\note.txt") && Properties.Settings.Default.devNote == true) {
                MessageBox.Show(System.IO.File.ReadAllText(getProfileFolder() + @"\chrome\.foxchrome\note.txt"),"Developer note");
            }

        }

        private void removeApplicationFilesAfterInstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.clean == true)
            {
                Properties.Settings.Default.clean = false;
                removeApplicationFilesAfterInstallToolStripMenuItem.Image = null;

            }
            else { Properties.Settings.Default.clean = true; removeApplicationFilesAfterInstallToolStripMenuItem.Image = tick; }

            Properties.Settings.Default.Save();

            ReadAndApplySettings();
        }

        private void blockAutomaticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.extensionInstallMethod = 2;
            Properties.Settings.Default.Save();
            ReadAndApplySettings();
        }

        private void askForInstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.extensionInstallMethod = 3;
            Properties.Settings.Default.Save();
            ReadAndApplySettings();

        }

        private void enableAutomaticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.configFilesInstallMethod = 1;
            Properties.Settings.Default.Save();
            ReadAndApplySettings();
        }

        private void blockAutomaticallyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.configFilesInstallMethod = 2;
            Properties.Settings.Default.Save();
            ReadAndApplySettings();
        }

        private void displayNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (Properties.Settings.Default.devNote == true)
            {
                Properties.Settings.Default.devNote = false;
                displayNoteToolStripMenuItem.Image = null;

            }
            else { Properties.Settings.Default.devNote = true; displayNoteToolStripMenuItem.Image = tick; }

            Properties.Settings.Default.Save();

            ReadAndApplySettings();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        public bool addonsInThePackage() {
            
            if (Directory.Exists(getProfileFolder() + @"\chrome\.foxchrome\extensions"))
                if (!IsDirectoryEmpty(getProfileFolder() + @"\chrome\.foxchrome\extensions")) {  return true; }

            return false;

        }
        public void addonInstallPossibility()
        {
            string[] fileArray = Directory.GetFiles(getProfileFolder() + @"\chrome\.foxchrome\extensions\", "*.xpi");
            askAddonsForInstall(fileArray);
        }

        public void askAddonsForInstall(string[] files) {

            foreach (var file in files) {

                if (Properties.Settings.Default.extensionInstallMethod == 1) Process.Start(file);

                if (Properties.Settings.Default.extensionInstallMethod == 3){
                    DialogResult dialogResult = MessageBox.Show("Do you want to install the following add-on?" + Environment.NewLine + file.Split('\\')[file.Split('\\').Length - 1] + Environment.NewLine, "Add-on install approval message", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) { Process.Start(file); };
                }


            }

        }

        private void askForInstallToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.configFilesInstallMethod = 3;
            Properties.Settings.Default.Save();
            ReadAndApplySettings();
        }

        private void installToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "FoxChrome Files|*.foxchrome|All files|*.*";
            saveFileDialog1.Title = "Save FoxChrome file";
            saveFileDialog1.FileName = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {

                if (File.Exists(saveFileDialog1.FileName))
                    File.Delete(saveFileDialog1.FileName);

                string ProcessArgs = addQuote("c") + " " + optimisePath(getProfileFolder() + backslash + "chrome") + " " + optimisePath(saveFileDialog1.FileName);


                ProcessStartInfo(Application.StartupPath + @"\Unzipper.exe", ProcessArgs, ProcessWindowStyle.Hidden);

                installBtn.Text = "Saving...";
                installBtn.Enabled = false;
                saveingMode = true;
                ProcessTimer.Start();


            }
                
        }

        private void resetLiveDebuggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This option is designed to resolve issues regarding Firefox Live Debugging. This includes deleting the chrome_debugger_profile folder in your Firefox profile folder!" + Environment.NewLine + "Are you certain you wish to continue?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                if (Directory.Exists(getProfileFolder() + @"\chrome_debugger_profile")){
                    Directory.Delete(getProfileFolder() + @"\chrome_debugger_profile", true);
                }
        }

        public void clean() {

            if (Directory.Exists(getProfileFolder() + @"\chrome\.foxchrome") && Properties.Settings.Default.clean == true) {

                Directory.Delete(getProfileFolder() + @"\chrome\.foxchrome",true);
            }

        }

        public void ConfigFileInstallAttempt() {

            if (File.Exists(getProfileFolder() + @"\chrome\.foxchrome\user.js"))
            {

                if (Properties.Settings.Default.configFilesInstallMethod == 1) installConfigFile();

                if (Properties.Settings.Default.configFilesInstallMethod == 3)
                {

                    DialogResult dialogResult = MessageBox.Show("Do you want to install the new user.js config file that is contained in the package? ", "Config file install approval message", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) installConfigFile();

                }

            }

        }

        public void installConfigFile() {

            bool installationAllowed = true;

            if (File.Exists(getProfileFolder() + @"\user.js")) {

                DialogResult dialogResult = MessageBox.Show("Your profile folder is already contains an user.js configuration file." + Environment.NewLine + "Do you want to overwrite it?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes) installationAllowed = false;

            }

            if (installationAllowed) {

                File.Copy(getProfileFolder() + @"\chrome\.foxchrome\user.js", getProfileFolder() + @"\user.js",true);

            
            }


        
        }



    }
}
