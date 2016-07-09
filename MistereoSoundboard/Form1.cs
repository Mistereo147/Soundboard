using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using IniParser;
using IniParser.Model;




namespace MistereoSoundboard
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);
        IntPtr thisWindow;

        [DllImport("winmm.dll", EntryPoint = "waveOutSetVolume")]
        public static extern int WaveOutSetVolume(IntPtr hwo, uint dwVolume);

        [DllImport("winmm.dll", SetLastError = true)]
        public static extern bool PlaySound(string pszSound, IntPtr hmod, uint fdwSound);


        #region Init
        public Form1()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(DrawOnTab);
        }
        #region Ini Data
        //Initializes Sound Player
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        //Get Paths and initialize the .ini Parser
        string iniPathFavs = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents\\Soundboard\\Favourites.ini");
        string iniDirectory = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents\\Soundboard");
        FileIniDataParser iniParser = new FileIniDataParser();
        IniData iniData;
        IniData iniDataWrite;
        #endregion
        //Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Register Hotkeys
            //Initializes Hotkeys
            thisWindow = FindWindow(null, "Soundboard");
            RegisterHotKey(thisWindow, 1, (uint)fsModifiers.Alt, (uint)Keys.NumPad7);
            RegisterHotKey(thisWindow, 2, (uint)fsModifiers.Alt, (uint)Keys.NumPad8);
            RegisterHotKey(thisWindow, 3, (uint)fsModifiers.Alt, (uint)Keys.NumPad9);
            RegisterHotKey(thisWindow, 4, (uint)fsModifiers.Alt, (uint)Keys.NumPad4);
            RegisterHotKey(thisWindow, 5, (uint)fsModifiers.Alt, (uint)Keys.NumPad5);
            RegisterHotKey(thisWindow, 6, (uint)fsModifiers.Alt, (uint)Keys.NumPad6);
            RegisterHotKey(thisWindow, 7, (uint)fsModifiers.Alt, (uint)Keys.NumPad1);
            RegisterHotKey(thisWindow, 8, (uint)fsModifiers.Alt, (uint)Keys.NumPad2);
            RegisterHotKey(thisWindow, 9, (uint)fsModifiers.Alt, (uint)Keys.NumPad3);
            RegisterHotKey(thisWindow, 10, (uint)fsModifiers.Alt, (uint)Keys.NumPad0);
            #endregion
            
            #region Load/Create Favourites.ini
            //Check if Favourites.ini Exists
            if (File.Exists(iniPathFavs))
            {
                LoadIniFavs();
                LoadIniButtons();
                listBoxFav.Items.Add("--unbind--");
            }
            else
            {
                //Create Path /user/documents/soundboard , if it doesnt exist already
                if (!Directory.Exists(Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents\\Soundboard")))
                {
                    Directory.CreateDirectory(iniDirectory);
                }
                //Create Favourites.ini
                var closeFile = File.Create(iniPathFavs);
                closeFile.Close();
                //Create Sections
                iniDataWrite = iniParser.ReadFile(iniPathFavs);
                iniDataWrite.Sections.AddSection("Buttons");
                iniDataWrite["Buttons"].AddKey("1", "1");
                iniDataWrite["Buttons"].AddKey("2", "2");
                iniDataWrite["Buttons"].AddKey("3", "3");
                iniDataWrite["Buttons"].AddKey("4", "4");
                iniDataWrite["Buttons"].AddKey("5", "5");
                iniDataWrite["Buttons"].AddKey("6", "6");
                iniDataWrite["Buttons"].AddKey("7", "7");
                iniDataWrite["Buttons"].AddKey("8", "8");
                iniDataWrite["Buttons"].AddKey("9", "9");
                iniDataWrite.Sections.AddSection("Listbox");
                iniDataWrite["Listbox"].AddKey("items", "0");
                iniDataWrite.Sections.AddSection("Paths");
                iniParser.WriteFile(iniPathFavs, iniDataWrite);
                iniData = iniParser.ReadFile(iniPathFavs);
                listBoxFav.Items.Add("--unbind--");
            }
            #endregion
        }
        //Hotkey Parameters
        public enum fsModifiers
        {
            Alt = 0x0001,
            Control = 0x0002,
            Shift = 0x0004,
            Window = 0x0008,
        }
        #endregion

        #region Drag Listbox
        string pubItem;
        string itemFav;
        private void listBoxFav_MouseDown(object sender, MouseEventArgs e)
        {
            //write dragged Item to "pubItem"-string
            if (listBoxFav.Items.Count == 0) { return; }
            int indexFav = listBoxFav.IndexFromPoint(e.X, e.Y);
            try { itemFav = listBoxFav.Items[indexFav].ToString(); }
            catch { }
            pubItem = itemFav;
            //display DragDrop Effect
            try { DragDropEffects ddeFav = DoDragDrop(itemFav, DragDropEffects.All); }
            catch { }
        }
        #endregion

        #region Buttons Favs Bindings
        //Change Text and Ini if Item is dropped to Button 1 ( same for Button 2-9 )
        private void buttonFav1_DragDrop(object sender, DragEventArgs e)
        {
            if (itemFav != null)
            {
                if (itemFav == "--unbind--")
                {
                    buttonFav1.Text = "1";
                    iniDataWrite["Buttons"]["1"] = "1";
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
                else
                {
                    buttonFav1.Text = pubItem;
                    iniDataWrite["Buttons"]["1"] = pubItem;
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
            }
            itemFav = "";
        }
        //Display DraggDrop Effect if Item is dragged onto Button 1 ( same for Button 2-9 )
        private void buttonFav1_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.All; }

        private void buttonFav2_DragDrop(object sender, DragEventArgs e)
        {
            if (itemFav != null)
            {
                if (itemFav == "--unbind--")
                {
                    buttonFav2.Text = "2";
                    iniDataWrite["Buttons"]["2"] = "2";
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
                else
                {
                    buttonFav2.Text = pubItem;
                    iniDataWrite["Buttons"]["2"] = pubItem;
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
            }
            itemFav = "";
        }
        private void buttonFav2_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.All; }

        private void buttonFav3_DragDrop(object sender, DragEventArgs e)
        {
            if (itemFav != null)
            {
                if (itemFav == "--unbind--")
                {
                    buttonFav3.Text = "3";
                    iniDataWrite["Buttons"]["3"] = "3";
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
                else
                {
                    buttonFav3.Text = pubItem;
                    iniDataWrite["Buttons"]["3"] = pubItem;
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
            }
            itemFav = "";
        }
        private void buttonFav3_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.All; }

        private void buttonFav4_DragDrop(object sender, DragEventArgs e)
        {
            if (itemFav != null)
            {
                if (itemFav == "--unbind--")
                {
                    buttonFav4.Text = "4";
                    iniDataWrite["Buttons"]["4"] = "4";
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
                else
                {
                    buttonFav4.Text = pubItem;
                    iniDataWrite["Buttons"]["4"] = pubItem;
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
            }
            itemFav = "";
        }
        private void buttonFav4_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.All; }

        private void buttonFav5_DragDrop(object sender, DragEventArgs e)
        {
            if (itemFav != null)
            {
                if (itemFav == "--unbind--")
                {
                    buttonFav5.Text = "5";
                    iniDataWrite["Buttons"]["5"] = "5";
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
                else
                {
                    buttonFav5.Text = pubItem;
                    iniDataWrite["Buttons"]["5"] = pubItem;
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
            }
            itemFav = "";
        }
        private void buttonFav5_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.All; }

        private void buttonFav6_DragDrop(object sender, DragEventArgs e)
        {
            if (itemFav != null)
            {
                if (itemFav == "--unbind--")
                {
                    buttonFav6.Text = "6";
                    iniDataWrite["Buttons"]["6"] = "6";
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
                else
                {
                    buttonFav6.Text = pubItem;
                    iniDataWrite["Buttons"]["6"] = pubItem;
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
            }
            itemFav = "";
        }
        private void buttonFav6_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.All; }

        private void buttonFav7_DragDrop(object sender, DragEventArgs e)
        {
            if (itemFav != null)
            {
                if (itemFav == "--unbind--")
                {
                    buttonFav7.Text = "7";
                    iniDataWrite["Buttons"]["7"] = "7";
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
                else
                {
                    buttonFav7.Text = pubItem;
                    iniDataWrite["Buttons"]["7"] = pubItem;
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
            }
            itemFav = "";
        }
        private void buttonFav7_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.All; }

        private void buttonFav8_DragDrop(object sender, DragEventArgs e)
        {
            if (itemFav != null)
            {
                if (itemFav == "--unbind--")
                {
                    buttonFav8.Text = "8";
                    iniDataWrite["Buttons"]["8"] = "8";
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
                else
                {
                    buttonFav8.Text = pubItem;
                    iniDataWrite["Buttons"]["8"] = pubItem;
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
            }
            itemFav = "";
        }
        private void buttonFav8_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.All; }

        private void buttonFav9_DragDrop(object sender, DragEventArgs e)
        {
            if (itemFav != null)
            {
                if (itemFav == "--unbind--")
                {
                    buttonFav9.Text = "9";
                    iniDataWrite["Buttons"]["9"] = "9";
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
                else
                {
                    buttonFav9.Text = pubItem;
                    iniDataWrite["Buttons"]["9"] = pubItem;
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                }
            }
            itemFav = "";
        }
        private void buttonFav9_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.All; }
        #endregion

        #region WndProc | Hotkeys + Movable Form
        protected override void WndProc(ref Message m)
        {
            //Register Hotkeys
            if ( m.Msg == 0x0312 )
            {
                
                int hotkeyID =(int)m.WParam;
                #region Hotkeys
                if (hotkeyID == 1)
                {
                    playSound = iniData["Paths"][buttonFav1.Text];
                    if (playSound != null)
                    {
                        try
                        {
                            player.SoundLocation = playSound;
                            player.Play();
                        }
                        catch { }
                    }
                }
                else if (hotkeyID == 2)
                {
                    playSound = iniData["Paths"][buttonFav2.Text];
                    if (playSound != null)
                    {
                        try
                        {
                            player.SoundLocation = playSound;
                            player.Play();
                        }
                        catch { }
                    }
                }
                else if (hotkeyID == 3)
                {
                    playSound = iniData["Paths"][buttonFav3.Text];
                    if (playSound != null)
                    {
                        try
                        {
                            player.SoundLocation = playSound;
                            player.Play();
                        }
                        catch { }
                    }
                }
                else if (hotkeyID == 4)
                {
                    playSound = iniData["Paths"][buttonFav4.Text];
                    if (playSound != null)
                    {
                        try
                        {
                            player.SoundLocation = playSound;
                            player.Play();
                        }
                        catch { }
                    }
                }
                else if (hotkeyID == 5)
                {
                    playSound = iniData["Paths"][buttonFav5.Text];
                    if (playSound != null)
                    {
                        try
                        {
                            player.SoundLocation = playSound;
                            player.Play();
                        }
                        catch { }
                    }
                }
                else if (hotkeyID == 6)
                {
                    playSound = iniData["Paths"][buttonFav6.Text];
                    if (playSound != null)
                    {
                        try
                        {
                            player.SoundLocation = playSound;
                            player.Play();
                        }
                        catch { }
                    }
                }
                else if (hotkeyID == 7)
                {
                    playSound = iniData["Paths"][buttonFav7.Text];
                    if (playSound != null)
                    {
                        try
                        {
                            player.SoundLocation = playSound;
                            player.Play();
                        }
                        catch { }
                    }
                }
                else if (hotkeyID == 8)
                {
                    playSound = iniData["Paths"][buttonFav8.Text];
                    if (playSound != null)
                    {
                        try
                        {
                            player.SoundLocation = playSound;
                            player.Play();
                        }
                        catch { }
                    }
                }
                else if (hotkeyID == 9)
                {
                    playSound = iniData["Paths"][buttonFav9.Text];
                    if (playSound != null)
                    {
                        try
                        {
                            player.SoundLocation = playSound;
                            player.Play();
                        }
                        catch { }
                    }
                }
                else if (hotkeyID == 10) { player.Stop(); }
                #endregion
            }
            base.WndProc(ref m);
            //Movable Form
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        //Movable Form Param
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        #endregion

        #region Custom Tab Control
        private Region tabRegion;
        private Rectangle tabArea1;
        private Rectangle tabArea2;
        private Rectangle tabArea1Txt;
        private Rectangle tabArea2Txt;
        /*
        private Rectangle tabArea3;
        private Rectangle tabArea4;
        private Rectangle tabArea5;

        private Rectangle tabArea3Txt;
        private Rectangle tabArea4Txt;
        private Rectangle tabArea5Txt;
        */
        private void DrawOnTab(object sender, DrawItemEventArgs e)
        {
            //Define Tab Regions for Text and Background
            tabRegion = new Region();
            tabArea1 = tabControl1.GetTabRect(0);
            tabArea1.X += 4;
            tabArea1.Width -= 4;
            tabArea2 = tabControl1.GetTabRect(1);
            /*
            tabArea3 = tabControl1.GetTabRect(2);
            tabArea4 = tabControl1.GetTabRect(3);
            tabArea5 = tabControl1.GetTabRect(4);
            tabArea5.Width -= 3;
            */
            tabArea1Txt = tabArea1;
            tabArea1Txt.X += 8;
            tabArea1Txt.Y += 2;
            tabArea2Txt = tabArea2;
            tabArea2Txt.X += 8;
            tabArea2Txt.Y += 2;
            /*
            tabArea3Txt = tabArea3;
            tabArea3Txt.X += 8;
            tabArea3Txt.Y += 2;
            tabArea4Txt = tabArea4;
            tabArea4Txt.X += 8;
            tabArea4Txt.Y += 2;
            tabArea5Txt = tabArea5;
            tabArea5Txt.X += 8;
            tabArea5Txt.Y += 2;
            */
            //Draw "Custom" Tabs
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.FromArgb(55, 55, 55));
            p.Width += 2;
            Font font = new Font("Impact", 10.0f);
            SolidBrush brushText = new SolidBrush(Color.FromArgb(200, 200, 200));
            SolidBrush brushBG = new SolidBrush(Color.FromArgb(40, 40, 40));
            g.FillRegion(brushBG, tabRegion);
            g.DrawString("Favourites", font, brushText, tabArea1Txt);
            g.DrawRectangle(p, tabArea1);
            g.DrawString("Options", font, brushText, tabArea2Txt);
            g.DrawRectangle(p, tabArea2);
            /*
            g.DrawString("Tab 1", font, brushText, tabArea3Txt);
            g.DrawRectangle(p, tabArea3);
            g.DrawString("Tab 2", font, brushText, tabArea4Txt);
            g.DrawRectangle(p, tabArea4);
            g.DrawString("Tab 3", font, brushText, tabArea5Txt);
            g.DrawRectangle(p, tabArea5);
            */
        }
        #endregion

        #region Basic Buttons
        //EXIT Button
        private void buttonExit_Click(object sender, EventArgs e) { Close(); }
        //Minimize Button
        private void buttonMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
            //notifyIcon1.Visible = true;
            //notifyIcon1.ShowBalloonTip(3000);
            //this.ShowInTaskbar = false;
        }
        //System Tray
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }
        //Play Sounds
        string sPlay;
        private void buttonFavPlay_Click(object sender, EventArgs e)
        {
            if (listBoxFav.SelectedItem != null)
            {
                sPlay = iniData["Paths"][listBoxFav.SelectedItem.ToString()];
                if (sPlay != null)
                {
                    try
                    {
                        player.SoundLocation = sPlay;
                        player.Play();
                    }
                    catch { }
                }
            }
        }        
        private void buttonOptionsPlay_Click(object sender, EventArgs e)
        {
            if (listBoxOptions.SelectedItem != null)
            {
                sPlay = iniData["Paths"][listBoxOptions.SelectedItem.ToString()];
                if (sPlay != null)
                {
                    try
                    {
                        player.SoundLocation = sPlay;
                        player.Play();
                    }
                    catch { }
                }
            }
        }
        // Stop Playback
        private void buttonFavStop_Click(object sender, EventArgs e) { player.Stop(); }
        private void buttonOptionsStop_Click(object sender, EventArgs e) { player.Stop(); }
        //Directory Link
        private void linkOptionsDirectory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { System.Diagnostics.Process.Start(iniDirectory); }
        #endregion

        #region Save/Load
        string iniFavsItemsRead;
        int iniFavsItems;
        //Loads Listbox items from Favourites.ini
        private void LoadIniFavs()
        {
            iniData = iniParser.ReadFile(iniPathFavs);
            iniDataWrite = iniParser.ReadFile(iniPathFavs);
            iniFavsItemsRead = iniData["Listbox"]["items"];
            iniFavsItems = Convert.ToInt32(iniFavsItemsRead);
            int i = 0;
            if (iniFavsItems > 0)
            {
                while (i < iniFavsItems)
                {
                    listBoxFav.Items.Add(iniData["Listbox"][i.ToString()]);
                    listBoxOptions.Items.Add(iniData["Listbox"][i.ToString()]);
                    i++;
                }
            }
        }
        //Loads Favourites Buttons Names from Favourites.ini
        private void LoadIniButtons()
        {
            buttonFav1.Text = iniDataWrite["Buttons"]["1"];
            buttonFav2.Text = iniDataWrite["Buttons"]["2"];
            buttonFav3.Text = iniDataWrite["Buttons"]["3"];
            buttonFav4.Text = iniDataWrite["Buttons"]["4"];
            buttonFav5.Text = iniDataWrite["Buttons"]["5"];
            buttonFav6.Text = iniDataWrite["Buttons"]["6"];
            buttonFav7.Text = iniDataWrite["Buttons"]["7"];
            buttonFav8.Text = iniDataWrite["Buttons"]["8"];
            buttonFav9.Text = iniDataWrite["Buttons"]["9"];
        }
        private void reloadIni()
        {
            int i = 0;
            int c = listBoxOptions.Items.Count;
            string rName;
            iniDataWrite["Listbox"]["items"] = c.ToString();
            while ( i < c)
            {
                rName = listBoxOptions.Items[i].ToString();
                iniDataWrite["Listbox"][i.ToString()] = rName;
                i++;
            }
            iniParser.WriteFile(iniPathFavs, iniDataWrite);
            iniData = iniParser.ReadFile(iniPathFavs);
            if (listBoxFav.Items[0].ToString() != "--unbind--") { listBoxFav.Items.Add("--unbind--"); }
            
        }
        #endregion
 
        #region Buttons SB Favoutires
        string playSound;
        private void buttonFav1_Click(object sender, EventArgs e)
        {
            playSound = iniData["Paths"][buttonFav1.Text];
            if (playSound != null)
            {
                try
                {
                    player.SoundLocation = playSound;
                    player.Play();
                }
                catch { }
            }
        }
        private void buttonFav2_Click(object sender, EventArgs e)
        {
            playSound = iniData["Paths"][buttonFav2.Text];
            if (playSound != null)
            {
                try
                {
                    player.SoundLocation = playSound;
                    player.Play();
                }
                catch { }
            }
        }
        private void buttonFav3_Click(object sender, EventArgs e)
        {
            playSound = iniData["Paths"][buttonFav3.Text];
            if (playSound != null)
            {
                try
                {
                    player.SoundLocation = playSound;
                    player.Play();
                }
                catch { }
            }
        }
        private void buttonFav4_Click(object sender, EventArgs e)
        {
            playSound = iniData["Paths"][buttonFav4.Text];
            if (playSound != null)
            {
                try
                {
                    player.SoundLocation = playSound;
                    player.Play();
                }
                catch { }
            }
        }
        private void buttonFav5_Click(object sender, EventArgs e)
        {
            playSound = iniData["Paths"][buttonFav5.Text];
            if (playSound != null)
            {
                try
                {
                    player.SoundLocation = playSound;
                    player.Play();
                }
                catch { }
            }
        }
        private void buttonFav6_Click(object sender, EventArgs e)
        {
            playSound = iniData["Paths"][buttonFav6.Text];
            if (playSound != null)
            {
                try
                {
                    player.SoundLocation = playSound;
                    player.Play();
                }
                catch { }
            }
        }
        private void buttonFav7_Click(object sender, EventArgs e)
        {
            playSound = iniData["Paths"][buttonFav7.Text];
            if (playSound != null)
            {
                try
                {
                    player.SoundLocation = playSound;
                    player.Play();
                }
                catch { }
            }
        }
        private void buttonFav8_Click(object sender, EventArgs e)
        {
            playSound = iniData["Paths"][buttonFav8.Text];
            if (playSound != null)
            {
                try
                {
                    player.SoundLocation = playSound;
                    player.Play();
                }
                catch { }
            }
        }
        private void buttonFav9_Click(object sender, EventArgs e)
        {
            playSound = iniData["Paths"][buttonFav9.Text];
            if (playSound != null)
            {
                try
                {
                    player.SoundLocation = playSound;
                    player.Play();
                }
                catch { }
            }
        }
        #endregion

        #region Listbox Options Add Items 
        //Create vars
        string iniPathAdd;
        //string iniItemRead;
        //int iniItemCount;
        DialogResult listPathAdd;
        //Add File via Dialog
        private void buttonOptionsPath_Click(object sender, EventArgs e)
        {
            listPathAdd = openFileDialogSound.ShowDialog();
            if (listPathAdd == DialogResult.OK)
            {
                iniPathAdd = openFileDialogSound.FileName;
                textBoxOptionsPath.Text = iniPathAdd;
            }
        }
        //DragDrop Animation for PATH button
        private void fillName(string fPath)
        {
            string[] fSplit = fPath.Split(new char[] { '\\' });
            fPath = fSplit[(fSplit.Length - 1)];
            fPath = fPath.Remove(fPath.IndexOf('.'));
            if ( fPath.Length > 12 ) { fPath = fPath.Substring(0, 12); }
            textBoxOptionsName.Text = fPath;
            fPath = "";
        }
        private void buttonOptionsPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        //Add File via DragDrop
        private void buttonOptionsPath_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if ( files.Length == 1 )
            {
                foreach (string filePath in files)
                {
                    if (filePath.EndsWith(".wav"))
                    {
                        iniPathAdd = filePath;
                        textBoxOptionsPath.Text = iniPathAdd;
                        fillName(iniPathAdd);
                    }
                }
            }
        }
        // Add file to Listbox and ini
        private void buttonOptionsAdd_Click(object sender, EventArgs e)
        {
            if (textBoxOptionsName.Text.Length >= 2 & textBoxOptionsPath.Text.Length > 2)
            {
                if (!listBoxOptions.Items.Contains(textBoxOptionsName.Text))
                    {
                    //iniItemCount = Convert.ToInt32(iniItemRead);
                    listBoxFav.Items.Add(textBoxOptionsName.Text);
                    listBoxOptions.Items.Add(textBoxOptionsName.Text);
                    //Add Name to Listbox ini
                    /*
                    iniDataWrite["Listbox"][iniItemCount.ToString()] = textBoxOptionsName.Text;
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                    iniItemCount++;
                    iniDataWrite["Listbox"]["items"] = iniItemCount.ToString();
                    */
                    //Add Path to ini
                    iniDataWrite["Paths"][textBoxOptionsName.Text] = iniPathAdd;
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                    //Clear Textboxes
                    textBoxOptionsPath.Text = "";
                    textBoxOptionsName.Text = "";
                    iniData = iniParser.ReadFile(iniPathFavs);
                    //fillName(iniPathAdd);
                    iniPathAdd = "";
                    reloadIni();
                }
            }
        }
        #endregion

        #region Listbox Options Remove Items
        private void buttonOptionsRemove_Click(object sender, EventArgs e)
        {
            string selectedItem = "";
            int selectedIndex = -1;
            //int sIniSlot = -1;
            if (listBoxOptions.SelectedIndex != -1)
            {
                selectedItem = listBoxOptions.SelectedItem.ToString();
                if (selectedItem != null)
                {
                    //Remove Item from Listboxes
                    selectedIndex = listBoxOptions.SelectedIndex;
                    iniDataWrite["Listbox"].RemoveKey((listBoxOptions.Items.Count-1).ToString());
                    listBoxOptions.Items.Remove(selectedItem);
                    listBoxFav.Items.Remove(selectedItem);
                    //Remove Item from "Paths" ini
                    iniDataWrite["Paths"].RemoveKey(selectedItem);
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                    reloadIni();
                    //Remove Item from "Listbox" ini
                    /*
                    sIniSlot = Convert.ToInt32(iniData["Listbox"]["items"]);
                    sIniSlot--;
                    iniDataWrite["Listbox"][selectedIndex.ToString()] = iniData["Listbox"][sIniSlot.ToString()];
                    iniDataWrite["Listbox"].RemoveKey(sIniSlot.ToString());
                    iniDataWrite["Listbox"]["items"] = sIniSlot.ToString();
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                    listBoxOptions.Items.Clear();
                    listBoxFav.Items.Clear();
                    LoadIniFavs();
                    */
                    ButtonReload(selectedItem);
                    if (listBoxOptions.Items.Count > 0)
                    {
                        if (selectedIndex > (listBoxOptions.Items.Count-1)) { listBoxOptions.SelectedIndex = (listBoxOptions.Items.Count - 1); }
                        else { listBoxOptions.SelectedIndex = selectedIndex; }
                    }
                }
            }
        }
       

        private void ButtonReload(string bName)
        {
            if (buttonFav1.Text == bName)
            {
                buttonFav1.Text = "1";
                iniDataWrite["Buttons"]["1"] = "1";
            }
            if (buttonFav2.Text == bName)
            {
                buttonFav2.Text = "2";
                iniDataWrite["Buttons"]["2"] = "2";
            }
            if (buttonFav3.Text == bName)
            {
                buttonFav3.Text = "3";
                iniDataWrite["Buttons"]["3"] = "3";
            }
            if (buttonFav4.Text == bName)
            {
                buttonFav4.Text = "4";
                iniDataWrite["Buttons"]["4"] = "4";
            }
            if (buttonFav5.Text == bName)
            {
                buttonFav5.Text = "5";
                iniDataWrite["Buttons"]["5"] = "5";
            }
            if (buttonFav6.Text == bName)
            {
                buttonFav6.Text = "6";
                iniDataWrite["Buttons"]["6"] = "6";
            }
            if (buttonFav7.Text == bName)
            {
                buttonFav7.Text = "7";
                iniDataWrite["Buttons"]["7"] = "7";
            }
            if (buttonFav8.Text == bName)
            {
                buttonFav8.Text = "8";
                iniDataWrite["Buttons"]["8"] = "8";
            }
            if (buttonFav9.Text == bName)
            {
                buttonFav9.Text = "9";
                iniDataWrite["Buttons"]["9"] = "9";
            }
            iniParser.WriteFile(iniPathFavs, iniDataWrite);
        }
        #endregion

        #region Unregister Hotkeys
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnregisterHotKey(thisWindow, 1);
            UnregisterHotKey(thisWindow, 2);
            UnregisterHotKey(thisWindow, 3);
            UnregisterHotKey(thisWindow, 4);
            UnregisterHotKey(thisWindow, 5);
            UnregisterHotKey(thisWindow, 6);
            UnregisterHotKey(thisWindow, 7);
            UnregisterHotKey(thisWindow, 8);
            UnregisterHotKey(thisWindow, 9);
        }
        #endregion

        #region Mass Import
        //Display mass Drag/Drop effect
        private void panel1_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.All; }
        //Get all Paths from dropped files
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach(string file in files) {
                massDrop(file);
                
            }
            reloadIni();
        }
        //add each Item to the Soundboard
        private void massDrop(string mPath)
        {
                string mName;
                //int mIndex;
            if (mPath.EndsWith(".wav"))
            {
                string[] fSplit = mPath.Split(new char[] { '\\' });
                mName = fSplit[(fSplit.Length - 1)];
                mName = mName.Remove(mName.IndexOf('.'));
                if (mName.Length > 12) { mName = mName.Substring(0, 12); }
                if (!listBoxOptions.Items.Contains(mName))
                {
                    listBoxFav.Items.Add(mName);
                    listBoxOptions.Items.Add(mName);
                    //mIndex = Convert.ToInt32(iniData["Listbox"]["items"]);
                    iniDataWrite["Paths"][mName] = mPath;
                    /*
                    iniDataWrite["Listbox"][mIndex.ToString()] = mName;
                    mIndex++;
                    iniDataWrite["Listbox"]["items"] = mIndex.ToString();
                    */
                    iniParser.WriteFile(iniPathFavs, iniDataWrite);
                    iniData = iniParser.ReadFile(iniPathFavs);
                }
            }
        }
        #endregion
    }
}

