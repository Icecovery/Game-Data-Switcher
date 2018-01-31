using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameDataSwitcher
{
    public partial class MainWindow : Form
    {
        string[] GamedataList = new string[999];

        public void ReloadList()
        {
            List.Items.Clear();
            int Counter = 0;
            DirectoryInfo dir = new DirectoryInfo(@".//");
            foreach (DirectoryInfo dChild in dir.GetDirectories("GameData*"))
            {
                if (File.Exists(Environment.CurrentDirectory + "/" + dChild + "/GameDataData.data") == true)
                {
                    GamedataList[Counter] = dChild.Name;
                    List.Items.Add(dChild.Name);
                    Counter++;
                }
            }
            ViewGameData.Enabled = false;
            RenameOriginalName.Enabled = false;
            SelectItem.Enabled = false;
            GameDataDataInformation.Enabled = false;
            SetAsDefault.Enabled = false;
            DeleteGameData.Enabled = false;
            SelectItem.Text = "";
            GameDataDataInformation.Text = "";
        }
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ReloadList();

            //check ksp_x64.exe
            if(File.Exists(Environment.CurrentDirectory + "/" + "KSP_x64.exe") == true)
            {
                checkBoxX64.Checked = true;
            }
            else if(File.Exists(Environment.CurrentDirectory + "/" + "KSP_x64.exe") == false)
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
            if (File.Exists(Environment.CurrentDirectory + "/" + "KSP_x64.exe") == false && File.Exists(Environment.CurrentDirectory + "/" + "KSP.exe") == false)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Cannot found executable file of KSP, please make sure this application is under KSP root folder, and try again.\nApplication will exit.", Microsoft.VisualBasic.MsgBoxStyle.Critical, "File Not Found");
                Environment.Exit(0);
            }

            //check GameDataData.data
            if (!File.Exists(Environment.CurrentDirectory + "/GameData/GameDataData.data"))
            {
                using (FileStream fs = File.Create(Environment.CurrentDirectory + "/GameData/GameDataData.data"))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("original");
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List.SelectedIndex == -1)
            {
                goto exit;
            }
            ViewGameData.Enabled = true;
            RenameOriginalName.Enabled = true;
            SelectItem.Enabled = true;
            GameDataDataInformation.Enabled = true;
            SetAsDefault.Enabled = true;
            DeleteGameData.Enabled = true;
            SelectItem.Text = GamedataList[List.SelectedIndex];

            if (GamedataList[List.SelectedIndex] == "GameData")
            {
                SetAsDefault.Enabled = false;
            }
                        
            StreamReader dataFile = new StreamReader(@".//" + GamedataList[List.SelectedIndex] + "/GameDataData.data");
            GameDataDataInformation.Text = dataFile.ReadLine();
            dataFile.Close();
            exit:;
        }

        private void ViewGameData_Click(object sender, EventArgs e)//view folder
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory +"/"+ GamedataList[List.SelectedIndex]);
        }

        private void RenameOriginalName_Click(object sender, EventArgs e)//rename folder
        {
            string newname = GameDataDataInformation.Text;
            newname= Microsoft.VisualBasic.Interaction.InputBox("Input a new name:", "Rename", GameDataDataInformation.Text);
            if (newname == "" || newname == GameDataDataInformation.Text)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("New name cannot same with existing name.", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Rename Failed");
                goto exit;
            }
            if (Directory.Exists(Environment.CurrentDirectory + "/" + "GameData_" + newname) == true)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Duplicate name.", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Rename Failed");
                goto exit;
            }

            StreamWriter dataFile = new StreamWriter(@".//" + GamedataList[List.SelectedIndex] + "/GameDataData.data");
            dataFile.Write(newname);
            dataFile.Close();
            
            if (GamedataList[List.SelectedIndex] != "GameData")
            {
                Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(Environment.CurrentDirectory + "/" + GamedataList[List.SelectedIndex], "GameData_" + newname);
            }
            Microsoft.VisualBasic.Interaction.MsgBox("Done.", Microsoft.VisualBasic.MsgBoxStyle.Information, "Rename");
            //Reload List
            exit:
            List.Items.Clear();
            int Counter = 0;
            DirectoryInfo dir = new DirectoryInfo(@".//");
            foreach (DirectoryInfo dChild in dir.GetDirectories("GameData*"))
            {
                GamedataList[Counter] = dChild.Name;
                List.Items.Add(dChild.Name);
                Counter++;
            }
            ViewGameData.Enabled = false;
            RenameOriginalName.Enabled = false;
            SelectItem.Enabled = false;
            GameDataDataInformation.Enabled = false;
            SelectItem.Text = "";
            GameDataDataInformation.Text = "";
        }

        private void NewGameData_Click(object sender, EventArgs e)//new gamedata
        {
            string newFolderName = "";
            newFolderName = Microsoft.VisualBasic.Interaction.InputBox("Input a new GameData name:", "New GameData", "NewGameData");
            if (Directory.Exists(Environment.CurrentDirectory + "/" + "GameData_" + newFolderName) == true)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Duplicate name.", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Create Failed");
                goto exit;
            }
            if (newFolderName == "")
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Please enter the name.", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Create Failed");
                goto exit;
            }
            Directory.CreateDirectory(Environment.CurrentDirectory + "/" + "GameData_" + newFolderName);
            
            //create GameDataData.data
            using (FileStream fs = File.Create(Environment.CurrentDirectory + "/" + "GameData_" + newFolderName + "/GameDataData.data"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(newFolderName);
                fs.Write(info, 0, info.Length);
            }
            Microsoft.VisualBasic.Interaction.MsgBox("Copying Squad Folder, it may take a while.", Microsoft.VisualBasic.MsgBoxStyle.Information, "New GameData");      

            //copy squad
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(Environment.CurrentDirectory + "/GameData/Squad", Environment.CurrentDirectory + "/" + "GameData_" + newFolderName + "/Squad", true);
            Microsoft.VisualBasic.Interaction.MsgBox("Done.", Microsoft.VisualBasic.MsgBoxStyle.Information, "New GameData");
            //Reload List
            ReloadList();
            exit:;
        }

        private void Refresh_Click(object sender, EventArgs e)//refresh
        {
            ReloadList();
            List.Enabled = true;
            Refresh.Text = "Refresh";
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadList();
            List.Enabled = true;
            Refresh.Text = "Refresh";
        }

        private void DeleteGameData_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.MsgBox("For the safety reason, I will open the game root folder for you, and you can delete it by your own.", Microsoft.VisualBasic.MsgBoxStyle.Information, "Delete GameData");
            System.Diagnostics.Process.Start(Environment.CurrentDirectory);
        }

        private void LaunchKSP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process ksp = new System.Diagnostics.Process();
            if (checkBoxX64.Checked)
            {
                ksp.StartInfo.FileName = Environment.CurrentDirectory + "/" + "KSP_x64.exe";
            }
            else if (!checkBoxX64.Checked)
            {
                ksp.StartInfo.FileName = Environment.CurrentDirectory + "/" + "KSP.exe";
            }
            if (radioButtonnone.Checked)
            {
                ksp.StartInfo.Arguments = "-single-instance";
            }
            else if (radioButtond3d11.Checked)
            {
                ksp.StartInfo.Arguments = "-force-d3d11 -single-instance";
            }
            else if (radioButtond3d9.Checked)
            {
                ksp.StartInfo.Arguments = "-force-d3d9 -single-instance";
            }
            else if (radioButtonopengl.Checked)
            {
                ksp.StartInfo.Arguments = "-force-opengl -single-instance";
            }
            try
            {
                ksp.Start();
            }
            catch
            {

            }
            if (checkBoxExit.Checked)
            {
                Environment.Exit(0);
            }
        }

        private void SetAsDefault_Click(object sender, EventArgs e)//set as default
        {
            for (int i = 0; i < List.Items.Count; i++)
            {
                StreamReader dataFile = new StreamReader(@".//" + GamedataList[i] + "/GameDataData.data");
                string folderName = dataFile.ReadLine();
                dataFile.Close();
                if ("GameData_" + folderName != GamedataList[i])
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(Environment.CurrentDirectory + "/" + GamedataList[i], "GameData_" + folderName);
                    Refresh();
                }
            }
            //GamedataList[List.SelectedIndex]
            Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(Environment.CurrentDirectory + "/" + GamedataList[List.SelectedIndex], "GameData");
            System.Threading.Thread.Sleep(1000);
            Refresh();
            List.Enabled = false;
            ViewGameData.Enabled = false;
            RenameOriginalName.Enabled = false;
            SelectItem.Enabled = false;
            GameDataDataInformation.Enabled = false;
            SetAsDefault.Enabled = false;
            DeleteGameData.Enabled = false;
            SelectItem.Text = "";
            GameDataDataInformation.Text = "";
            Refresh.Text = "Please Refresh";
            Microsoft.VisualBasic.Interaction.MsgBox("Done.\n"+ GamedataList[List.SelectedIndex] + " already set as the default GameData.", Microsoft.VisualBasic.MsgBoxStyle.Information, "Set as Default");
        }

        private void TestList_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox f = new AboutBox();
            f.Show();
        }

        private void reportAIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Icecovery/Game-Data-Switcher/issues/new");
        }
    }
}