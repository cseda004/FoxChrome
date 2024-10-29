using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringTable
{
    public class MessageBoxes
    {
        //internal string Error_FirefoxIsRunning { get; set; }
        public static string Error_FirefoxIsRunning_LUPC = "Changes cannot be applied as an instance of Firefox is running. Please exit your browser before performing any action that would result in prefs.js settings changing!";
        public static string Error_FirefoxRunning = "In order to proceed with the installation you need to exit Firefox.\nIn case of Firefox showing no sign of running check the Task Manager. It might be running in the background.\nPlease make sure Firefox is closed, then try again!";
        public static string CSS_CustomizaionFilesFound = "Already existing CSS customization files have been found!\nBy continuing the installation said files will be replaced by the new ones or deleted as needed! Please proceed with caution!\nDo you want to continue?";
        public static string AwaitingThemeFile = "Please browse a theme file to install!"; //
        public static string InstallationFinished = "Installation finished!";
        public static string FileSaved = "File has been saved!";
        public static string UserJsMissing_CreationChoice = "user.js does not exist!\nDo you want to create it?";
        public static string FileLocNotSet = "Can not open the location of the file because no file is selected!";
        public static string PrefsJsNotFound = "prefs.js is not exists!\nDo you want to create it?";
        public static string ChromeFolderNotFond = "Chrome folder is not exists!\nDo you want to create it?";
        public static string SampleFiles_Choice = "Do you want to create sample files?";
        public static string ThemeFileNotSelected = "Could not unselect the file as no Theme File has been selected!";
        public static string FileUnselected = "File succesfully unselected!";
        public static string UpdateNotFound = "Update not found!";
        public static string UpdateSearchFailed = "FoxChrome is unable to search for updates as your computer is not connected to the internet. If it does then the issue may be due to the servers being inaccesible!";
        public static string ConfirmAddonInstallation = "Do you want to install the following add-on?\n";
        public static string LiveDebugginResetConfirmation = "This option is designed to resolve issues regarding Firefox Live Debugging. This includes deleting the chrome_debugger_profile folder in your Firefox profile folder!\nAre you certain you wish to continue?";
        public static string UserJsInstallationWarning = "Do you want to install the new user.js config file that is contained in the package?";
        public static string ConfigFileOverWrite_Choice = "Your profile folder already contains an user.js configuration file.\nDo you want to overwrite it?";
    }

    public class ExceptionHandling {
        public static string UnzipperNotFound = "Unzipper.exe is missing therefore the selected theme file could not be extracted!";
    }

    public class Internal { 

    }

    public class UI_Defaults { 
        public static string LUPCBtn_Text = "L.U.P.C.: OFF";
        public static string BrowseBtn_Text = "Browse";
        public static string installBtn_Text = "Install";
    }

}
