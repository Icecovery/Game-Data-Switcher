using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;


//thanks for the help form linuxgurugamer!
namespace GameDataSwitcher
{
    public partial class MainWindow : Form
    {
        #region stupid stuff
        string[] GamedataList = new string[999];
        //what the hell happened makes you have more than 999 GameData, Huh?
        //i know this is a stupid solution but what else?
        //if you have some idea plz tell me on GitHub or Forum
        //thanks :D
        string LOC = Environment.CurrentDirectory;

        //files of CKAN
        string[] registry_json = new string[15]
        {   "{",
            "	\"registry_version\": 3,",
            "	\"sorted_repositories\": {",
            "		\"default\": {",
            "			\"name\": \"default\",",
            "			\"uri\": \"https://github.com/KSP-CKAN/CKAN-meta/archive/master.tar.gz\",",
            "			\"priority\": 0,",
            "			\"ckan_mirror\": false",
            "		}",
            "	},",
            "	\"available_modules\": {},",
            "	\"installed_dlls\": {},",
            "	\"installed_modules\": {},",
            "	\"installed_files\": {}",
            "}"
        };
        string[] installed_default_ckan = new string[10]
        {
            "{",
            "	\"kind\": \"metapackage\",",
            "	\"abstract\": \"A list of modules installed on the default KSP instance\",",
            "	\"name\": \"installed-default\",",
            "	\"license\": \"unknown\",",
            "	\"version\": \"1970.01.01.00.00.00\",",
            "	\"identifier\": \"installed-default\",",
            "	\"spec_version\": \"v0.0\",",
            "	\"depends\": []",
            "}"
        };

        #endregion

        public void ReloadList()//reload List
        {
            List.Items.Clear();
            int Counter = 0;
            DirectoryInfo dir = new DirectoryInfo(@".//");
            foreach (DirectoryInfo dChild in dir.GetDirectories("GameData*"))
            {
                if (File.Exists(LOC + "/" + dChild + "/GameDataData.data") == true)
                {
                    GamedataList[Counter] = dChild.Name;
                    List.Items.Add(dChild.Name);
                    Counter++;
                }
            }
            Counter = 0;
            /*
            foreach (DirectoryInfo dChild in dir.GetDirectories("saves*"))
            {
                    SavesList[Counter] = dChild.Name;
                    Counter++;
            }
            */
            ViewGameData.Enabled = false;
            RenameOriginalName.Enabled = false;
            SelectItem.Enabled = false;
            GameDataDataInformation.Enabled = false;
            SetAsDefault.Enabled = false;
            DeleteGameData.Enabled = false;
            CloneGameData.Enabled = false;
            SelectItem.Text = "";
            GameDataDataInformation.Text = "";
        }
        
        public MainWindow()//main window
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)//when application start
        {
            //load the list
            ReloadList();

            //check ksp_x64.exe
            if(File.Exists(LOC + "/" + "KSP_x64.exe") == true)
            {
                checkBoxX64.Checked = true;
            }
            else if(File.Exists(LOC + "/" + "KSP_x64.exe") == false)
            {
                checkBoxX64.Checked = false;
                checkBoxX64.Enabled = false;
                checkBoxX64.Text = "No KSP_x64.exe";
            }
            bool type;
            type = Environment.Is64BitOperatingSystem;
            if(!type)
            {
                checkBoxX64.Checked = false;
                checkBoxX64.Enabled = false;
                checkBoxX64.Text = "Not 64-bit system";
            }
            if (File.Exists(LOC + "/" + "KSP_x64.exe") == false && File.Exists(LOC + "/" + "KSP.exe") == false)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Cannot found executable file of KSP, please make sure this application is under KSP root folder, and try again.\nApplication will exit.", Microsoft.VisualBasic.MsgBoxStyle.Critical, "File Not Found");
                Environment.Exit(0);
            }

            //check GameDataData.data
            if (!File.Exists(LOC + "/GameData/GameDataData.data"))
            {
                using (FileStream fs = File.Create(LOC + "/GameData/GameDataData.data"))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("original");
                    fs.Write(info, 0, info.Length);
                }
            }

            #region read setting
            read:
            string _buff;
            if (File.Exists(LOC + "/GameDataSwitcherSetting.data"))
            {
                using (StreamReader setting = new StreamReader(LOC + "/GameDataSwitcherSetting.data"))
                {
                    _buff = setting.ReadToEnd();
                }
                Regex _reg = new Regex(@"[a-zA-Z_]\w*\s*=\s*(\d+(?!\.|x|e|d|m)u?)|^0x([\da-f]+(?!\.|x|m)u?)");
                MatchCollection mc = _reg.Matches(_buff);
                Dictionary<string, int> _mydic = new Dictionary<string, int>();
                foreach (Match nObj in mc)
                {
                    string _obj = nObj.Value;
                    _obj = _obj.Replace(" ", "");
                    _mydic.Add(_obj.Split('=')[0], Convert.ToInt32(_obj.Split('=')[1]));

                }
                comboBoxHardware.SelectedIndex = _mydic["Hardware"];
                comboBoxWindow.SelectedIndex = _mydic["Window"];
                if (_mydic["X64"] == 1)
                {
                    checkBoxX64.Checked = true;
                }
                else
                {
                    checkBoxX64.Checked = false;
                }
                if (_mydic["Exit"] == 1)
                {
                    checkBoxExit.Checked = true;
                }
                else
                {
                    checkBoxExit.Checked = false;

                }
            }
            else
            {
                using (FileStream fs = File.Create(LOC + "/GameDataSwitcherSetting.data"))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("\n\n\n\n");
                    fs.Write(info, 0, info.Length);
                }
                string[] temp = File.ReadAllLines(LOC + "/GameDataSwitcherSetting.data");
                temp[0] = "Hardware = 0";
                temp[1] = "Window = 0";
                temp[2] = "X64 = 1";
                temp[3] = "Exit = 0";
                File.WriteAllLines(LOC + "/GameDataSwitcherSetting.data", temp);
                goto read;
            }
            #endregion
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)//when user choose a gamedata
        {            
            if (List.SelectedIndex != -1)//if you didn't choose any thing, than do nothing
            {
                ViewGameData.Enabled = true;
                RenameOriginalName.Enabled = true;
                SelectItem.Enabled = true;
                GameDataDataInformation.Enabled = true;
                SetAsDefault.Enabled = true;
                DeleteGameData.Enabled = true;
                CloneGameData.Enabled = false;
                SelectItem.Text = GamedataList[List.SelectedIndex];

                if (GamedataList[List.SelectedIndex] == "GameData")
                {
                    SetAsDefault.Enabled = false;
                    DeleteGameData.Enabled = false;
                    CloneGameData.Enabled = true;
                }
                StreamReader dataFile = new StreamReader(@".//" + GamedataList[List.SelectedIndex] + "/GameDataData.data");
                GameDataDataInformation.Text = dataFile.ReadLine();
                dataFile.Close();
            }
        }

        private void ViewGameData_Click(object sender, EventArgs e)//view folder
        {
            //just open that folder
            System.Diagnostics.Process.Start(LOC +"/"+ GamedataList[List.SelectedIndex]);
        }

        private void RenameOriginalName_Click(object sender, EventArgs e)//rename folder
        {
            //input
            string newname = GameDataDataInformation.Text;
            newname = Microsoft.VisualBasic.Interaction.InputBox("Input a new name:", "Rename", GameDataDataInformation.Text);


            #region boring checking things
            if (newname == "")
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Rename canceled.", Microsoft.VisualBasic.MsgBoxStyle.Information, "Rename canceled");
                goto exit;
            }
            if (newname == GameDataDataInformation.Text)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("New name cannot be same with existing GameData.", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Rename Failed");
                goto exit;
            }
            if (Directory.Exists(LOC + "/" + "GameData_" + newname) == true)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Duplicate name.", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Rename Failed");
                goto exit;
            }
            #endregion

            //rewrite GameDataData.data
            StreamWriter dataFile = new StreamWriter(LOC + "/" + GamedataList[List.SelectedIndex] + "/GameDataData.data");
            dataFile.Write(newname);
            dataFile.Close();
            
            //rename folder
            if (GamedataList[List.SelectedIndex] != "GameData")
            {
                Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(LOC + "/" + GamedataList[List.SelectedIndex], "GameData_" + newname);
                Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(LOC + "/" + "saves_" + GameDataDataInformation.Text, "saves_" + newname);

                if (Directory.Exists(LOC + "/CKAN"))
                {
                    /*
                    try
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/CKAN/" + GameDataDataInformation.Text + "_compatible_ksp_versions.json", newname + "_compatible_ksp_versions.json");
                    }
                    catch { }
                    try
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/CKAN/" + GameDataDataInformation.Text + "_GUIConfig.xml", newname + "_GUIConfig.xml");
                    }
                    catch { }
                    */
                    try
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/CKAN/" + GameDataDataInformation.Text + "_installed-default.ckan", newname + "_installed-default.ckan");
                    }
                    catch { }
                    try
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/CKAN/" + GameDataDataInformation.Text + "_registry.json", newname + "_registry.json");
                    }
                    catch { }
                }
                //buildID
                try
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/" + GameDataDataInformation.Text + "_buildID.txt",  newname + "_buildID.txt");
                }
                catch { }
                try
                {
                    if (Environment.Is64BitOperatingSystem)
                        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/" + GameDataDataInformation.Text + "_buildID64.txt",  newname + "_buildID64.txt");
                }
                catch { }
            }

            //Message box
            Microsoft.VisualBasic.Interaction.MsgBox("Done.", Microsoft.VisualBasic.MsgBoxStyle.Information, "Rename");
            
            //Reload List
            exit:
            ReloadList();
        }

        private void NewGameData_Click(object sender, EventArgs e)//new gamedata
        {
            //input
            string newFolderName = "";
            newFolderName = Microsoft.VisualBasic.Interaction.InputBox("Input a new GameData name:", "New GameData", "NewGameData");

            #region boring checking things
            if (Directory.Exists(LOC + "/" + "GameData_" + newFolderName) == true)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Duplicate name.", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Create Failed");
                goto exit;
            }
            if (newFolderName == "")
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Please enter the name.", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Create Failed");
                goto exit;
            }
            #endregion

            //create New Gamedata
            Directory.CreateDirectory(LOC + "/" + "GameData_" + newFolderName);
            Directory.CreateDirectory(LOC + "/" + "saves_" + newFolderName);

            //create GameDataData.data
            using (FileStream fs = File.Create(LOC + "/" + "GameData_" + newFolderName + "/GameDataData.data"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(newFolderName);
                fs.Write(info, 0, info.Length);
            }
            Microsoft.VisualBasic.Interaction.MsgBox("Copying stock scenarios, training and Squad Folder, it may take a while.", Microsoft.VisualBasic.MsgBoxStyle.Information, "New GameData");      

            //copy squad
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(LOC + "/GameData/Squad", LOC + "/" + "GameData_" + newFolderName + "/Squad", true);
            
            //copy scenarios and training
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(LOC + "/saves/scenarios", LOC + "/" + "saves_" + newFolderName + "/scenarios", true);
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(LOC + "/saves/training", LOC + "/" + "saves_" + newFolderName + "/training", true);

            //CKAN Support
            if (Directory.Exists(LOC + "/CKAN"))
            {
                //FileStream file1 = File.Create(LOC + "/CKAN/" + newFolderName + "_compatible_ksp_versions.json");
                //FileStream file2 = File.Create(LOC + "/CKAN/" + newFolderName + "_GUIConfig.xml");
                FileStream file3 = File.Create(LOC + "/CKAN/" + newFolderName + "_installed-default.ckan");
                FileStream file4 = File.Create(LOC + "/CKAN/" + newFolderName + "_registry.json");              
                //file1.Close();
                //file2.Close();
                file3.Close();
                file4.Close();
                File.WriteAllLines(LOC + "/CKAN/" + newFolderName + "_installed-default.ckan", installed_default_ckan);
                File.WriteAllLines(LOC + "/CKAN/" + newFolderName + "_registry.json", registry_json);
            }

            //buildID
            try
            { 
                Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(LOC + "/buildID.txt", LOC + "/" + newFolderName + "_buildID.txt", true);
            }
            catch { }
            try
            {
                if (Environment.Is64BitOperatingSystem)
                    Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(LOC + "/buildID64.txt", LOC + "/" + newFolderName + "_buildID64.txt", true);
            }
            catch { }

            //Message box
            Microsoft.VisualBasic.Interaction.MsgBox("Done.", Microsoft.VisualBasic.MsgBoxStyle.Information, "New GameData");
            
            //Reload List
            ReloadList();
            exit:;
        }

        private void SetAsDefault_Click(object sender, EventArgs e)//set as default
        {
            string folderName;

            // Test for a locked registry, if so, abort
            if (Directory.Exists(LOC + "/CKAN") && File.Exists(LOC + "/CKAN/registry.locked"))
            {
                //throw new System.InvalidOperationException("GameData cannot be changed while CKAN is open");
                Microsoft.VisualBasic.Interaction.MsgBox("GameData cannot be changed while CKAN is open.", Microsoft.VisualBasic.MsgBoxStyle.Critical, "Error");
                return;
            }

            //make backup logs 
            #region make backup logs
            try
            {
                Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(LOC + "/KSP.log", LOC + "/KSP_backup_" + GamedataList[List.SelectedIndex] + ".log", true);
            }
            catch { }
            try
            {
                Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(LOC + "/KSP_Data/output_log.txt", LOC + "/KSP_Data/output_log_backup_" + GamedataList[List.SelectedIndex] + ".txt", true);
            }
            catch { }
            try
            {
                Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(LOC + "/KSP_x64_Data/output_log.txt", LOC + "/KSP_x64_Data/output_log_backup_" + GamedataList[List.SelectedIndex] + ".txt", true);
            }
            catch { }
            #endregion

            //all name set to normal
            for (int i = 0; i < List.Items.Count; i++)
            {
                if (GamedataList[i] == "GameData")
                {
                    StreamReader dataFile = new StreamReader(@".//" + GamedataList[i] + "/GameDataData.data");
                    folderName = dataFile.ReadLine();
                    dataFile.Close();
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(LOC + "/" + "GameData", "GameData_" + folderName);
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(LOC + "/" + "saves", "saves_" + folderName);
                    if (Directory.Exists(LOC + "/CKAN"))
                    {
                        /*
                        try
                        {
                            Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/CKAN/compatible_ksp_versions.json", folderName + "_compatible_ksp_versions.json");
                        }
                        catch { }
                        try
                        {
                            Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/CKAN/GUIConfig.xml", folderName + "_GUIConfig.xml");
                        }
                        catch { }
                        */
                        try
                        {
                            Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/CKAN/installed-default.ckan", folderName + "_installed-default.ckan");
                        }
                        catch { }
                        try
                        {
                            Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/CKAN/registry.json", folderName + "_registry.json");
                        }
                        catch { }
                                           
                    }
                    //buildID
                    try
                    { 
                        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/buildID.txt", folderName + "_buildID.txt");
                    }
                    catch { }
                    try
                    {
                        if (Environment.Is64BitOperatingSystem)
                            Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/buildID64.txt", folderName + "_buildID64.txt");
                    }
                    catch { }
                }               
            }

            //set the name you choose as the format that KSP can read
            Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(LOC + "/" + GamedataList[List.SelectedIndex], "GameData");
            Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(LOC + "/" + "saves_" + GameDataDataInformation.Text, "saves");
            

            //CKAN Support
            if (Directory.Exists(LOC + "/CKAN"))
            {
                /*
                try
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/CKAN/" + GameDataDataInformation.Text + "_compatible_ksp_versions.json", "compatible_ksp_versions.json");
                }
                catch
                { }
                try
                {                   
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/CKAN/" + GameDataDataInformation.Text + "_GUIConfig.xml", "GUIConfig.xml");
                }
                catch
                { }
                */
                try
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/CKAN/" + GameDataDataInformation.Text + "_installed-default.ckan", "installed-default.ckan");
                }
                catch
                { }
                try
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(LOC + "/CKAN/" + GameDataDataInformation.Text + "_registry.json", "registry.json");
                }
                catch
                { }
            }

            //buildID
            try
            { 
                Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(GameDataDataInformation.Text + "_buildID.txt", "buildID.txt");
            }
            catch { }
            try
            {
                if (Environment.Is64BitOperatingSystem)
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(GameDataDataInformation.Text + "_buildID64.txt", "buildID64.txt");
            }
            catch { }
            //done.
            Microsoft.VisualBasic.Interaction.MsgBox("Done.\n" + GamedataList[List.SelectedIndex] + " set as the default GameData.\n" + "saves_" + GameDataDataInformation.Text + " set as the default Saves.\nMade backup for all logs", Microsoft.VisualBasic.MsgBoxStyle.Information, "Set as Default");
            ReloadList();            
        }

        private void Refresh_Click(object sender, EventArgs e)//refresh
        {
            ReloadList();
        }

        private void CloneGameData_Click(object sender, EventArgs e)//clone
        {
            //input
            string newFolderName = "";
            newFolderName = Microsoft.VisualBasic.Interaction.InputBox("Input a new GameData name:", "Clone GameData", GameDataDataInformation.Text + "_Clone");

            #region boring checking things
            if (Directory.Exists(LOC + "/" + "GameData_" + newFolderName) == true)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Duplicate name.", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Clone Failed");
                goto exit;
            }
            if (newFolderName == "")
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Please enter the name.", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Clone Failed");
                goto exit;
            }
            #endregion

            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(LOC + "/GameData", LOC + "/GameData_" + newFolderName, true);
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(LOC + "/saves", LOC + "/saves_" + newFolderName, true);

            StreamWriter dataFile = new StreamWriter(LOC + "/GameData_" + newFolderName + "/GameDataData.data");
            dataFile.Write(newFolderName);
            dataFile.Close();

            //buildID
            try
            { 
                Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(LOC + "/buildID.txt", LOC + "/" + newFolderName + "_buildID.txt", true);
            }
            catch { }

            try
            {
                if (Environment.Is64BitOperatingSystem)
                    Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(LOC + "/buildID64.txt", LOC + "/" + newFolderName + "_buildID64.txt", true);
            }
            catch { }

            //CKAN Support
            if (Directory.Exists(LOC + "/CKAN"))
            {
                Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(LOC + "/CKAN/installed-default.ckan", LOC + "/CKAN/" + newFolderName + "_installed-default.ckan");
                Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(LOC + "/CKAN/registry.json", LOC + "/CKAN/" + newFolderName + "_registry.json");
            }

            //Message box
            Microsoft.VisualBasic.Interaction.MsgBox("Done.", Microsoft.VisualBasic.MsgBoxStyle.Information, "Clone GameData");

            //Reload List
            ReloadList();
            exit:;
        }

        private void DeleteGameData_Click(object sender, EventArgs e)//delete game data
        {                       
            string msg = "";
            msg = msg + "/" + "GameData_" + GameDataDataInformation.Text + "\n";
            msg = msg + "/" + "saves_" + GameDataDataInformation.Text + "\n";
            msg = msg + "/" + GameDataDataInformation.Text + "_buildID.txt" + "\n";
            msg = msg + "/" + GameDataDataInformation.Text + "_buildID64.txt" + "\n";
            if (Directory.Exists(LOC + "/CKAN"))
            {
                /*
                msg = msg + "/CKAN/" + GameDataDataInformation.Text + "_compatible_ksp_versions.json" + "\n";
                msg = msg + "/CKAN/" + GameDataDataInformation.Text + "_GUIConfig.xml" + "\n";
                */
                msg = msg + "/CKAN/" + GameDataDataInformation.Text + "_installed-default.ckan" + "\n";
                msg = msg + "/CKAN/" + GameDataDataInformation.Text + "_registry.json" + "\n";
            }            
            Microsoft.VisualBasic.MsgBoxResult ANS = Microsoft.VisualBasic.Interaction.MsgBox("Are you sure you want DELETE\n" + msg + "?\nThis operation CANNOT be undone.", (Microsoft.VisualBasic.MsgBoxStyle)292, "Delete GameData");
            if (ANS == Microsoft.VisualBasic.MsgBoxResult.Yes)
            {
                System.Diagnostics.Process.Start(LOC);
                string Return = Microsoft.VisualBasic.Interaction.InputBox("Here is the game root folder,\nPlease check again and enter the name of this GameData below:", "Delete GameData");
                if (Return == GameDataDataInformation.Text)
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(LOC + "/GameData_" + GameDataDataInformation.Text,Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents);
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(LOC + "/saves_" + GameDataDataInformation.Text, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents);
                    try
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(LOC + "/" + GameDataDataInformation.Text + "_buildID.txt");
                    }
                    catch { }
                    try
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(LOC + "/" + GameDataDataInformation.Text + "_buildID64.txt");
                    }
                    catch { }
                    if (Directory.Exists(LOC + "/CKAN"))
                    {
                        /*
                        try
                        {
                            Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(LOC + "/CKAN/" + GameDataDataInformation.Text + "_compatible_ksp_versions.json");
                        }
                        catch { }
                        try
                        {
                            Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(LOC + "/CKAN/" + GameDataDataInformation.Text + "_GUIConfig.xml");
                        }
                        catch { }
                        */
                        try
                        {
                            Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(LOC + "/CKAN/" + GameDataDataInformation.Text + "_installed-default.ckan");
                        }
                        catch { }
                        try
                        {
                            Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(LOC + "/CKAN/" + GameDataDataInformation.Text + "_registry.json");
                        }
                        catch { }                 
                    }
                    //done.
                    Microsoft.VisualBasic.Interaction.MsgBox("Done.", Microsoft.VisualBasic.MsgBoxStyle.Information, "Delete GameData");
                    ReloadList();
                }
                else if (Return=="")
                {
                    goto exit;
                }
                else
                {
                    Microsoft.VisualBasic.Interaction.MsgBox("Wrong name, files and folders will not be delete.", Microsoft.VisualBasic.MsgBoxStyle.Information, "Delete GameData");
                    goto exit;
                }
            }
            else if (ANS == Microsoft.VisualBasic.MsgBoxResult.No)
            {
                goto exit;
            }
            exit:;
        }

        private void LaunchKSP_Click(object sender, EventArgs e)//launch KSP
        {
            #region save setting
            string[] temp = File.ReadAllLines(LOC + "/GameDataSwitcherSetting.data");
            temp[0] = "Hardware = "+ comboBoxHardware.SelectedIndex;
            temp[1] = "Window = " + comboBoxWindow.SelectedIndex;
            if (checkBoxX64.Checked)
            {
                temp[2] = "X64 = 1";
            }
            else
            {
                temp[2] = "X64 = 0";
            }
            if (checkBoxExit.Checked)
            {
                temp[3] = "Exit = 1";
            }
            else
            {
                temp[3] = "Exit = 0";
            }
            File.WriteAllLines(LOC + "/GameDataSwitcherSetting.data", temp);
            #endregion

            bool exit = checkBoxExit.Checked;
            System.Diagnostics.Process ksp = new System.Diagnostics.Process();
            if (checkBoxX64.Checked && Environment.Is64BitOperatingSystem)
            {
                ksp.StartInfo.FileName = LOC + "/" + "KSP_x64.exe";
            }
            else
            {
                ksp.StartInfo.FileName = LOC + "/" + "KSP.exe";
            }
            switch (comboBoxHardware.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    ksp.StartInfo.Arguments = "-force-opengl";
                    break;
                case 2:
                    ksp.StartInfo.Arguments = "-force-d3d9";
                    break;
                case 3:
                    ksp.StartInfo.Arguments = "-force-d3d11";
                    break;
                default:
                    break;
            }
            switch (comboBoxWindow.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    ksp.StartInfo.Arguments = ksp.StartInfo.Arguments + " -window";
                    break;
                case 2:
                    ksp.StartInfo.Arguments = ksp.StartInfo.Arguments + " -popupwindow";
                    break;
                case 3:
                    ksp.StartInfo.Arguments = ksp.StartInfo.Arguments + " -fullscreen";
                    break;
                default:
                    break;
            }
            ksp.StartInfo.Arguments = ksp.StartInfo.Arguments + " -single-instance";
            try
            {
                ksp.Start();
            }
            catch
            {
                Microsoft.VisualBasic.Interaction.MsgBox("KSP Launch Failed.\nPlease try to open it manually.", Microsoft.VisualBasic.MsgBoxStyle.Critical, "Failed");
                exit = false;
            }
            if (exit)
            {
                Environment.Exit(0);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)//exit
        {
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)//about
        {
            AboutBox form = new AboutBox();
            form.Show();
        }

        private void reportAIssueToolStripMenuItem_Click(object sender, EventArgs e)//report
        {
            System.Diagnostics.Process.Start("https://github.com/Icecovery/Game-Data-Switcher/issues/new");
        }

        #region nvm about those things
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)//nothing
        { }
        private void TestList_Click(object sender, EventArgs e)//nothing
        { }
        #endregion
        
    }
}