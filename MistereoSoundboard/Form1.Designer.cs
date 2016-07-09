namespace MistereoSoundboard
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelFavInfo2 = new System.Windows.Forms.Label();
            this.labelFavInfo1 = new System.Windows.Forms.Label();
            this.buttonFavStop = new System.Windows.Forms.Button();
            this.buttonFav9 = new System.Windows.Forms.Button();
            this.buttonFav8 = new System.Windows.Forms.Button();
            this.buttonFav7 = new System.Windows.Forms.Button();
            this.buttonFav6 = new System.Windows.Forms.Button();
            this.buttonFav5 = new System.Windows.Forms.Button();
            this.buttonFav4 = new System.Windows.Forms.Button();
            this.buttonFav3 = new System.Windows.Forms.Button();
            this.buttonFav2 = new System.Windows.Forms.Button();
            this.buttonFav1 = new System.Windows.Forms.Button();
            this.buttonFavPlay = new System.Windows.Forms.Button();
            this.listBoxFav = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.labelOptions3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOptionsInfo4 = new System.Windows.Forms.Label();
            this.linkOptionsDirectory = new System.Windows.Forms.LinkLabel();
            this.buttonOptionsStop = new System.Windows.Forms.Button();
            this.labelOptionsInfo2 = new System.Windows.Forms.Label();
            this.textBoxOptionsPath = new System.Windows.Forms.TextBox();
            this.labelOptionsInfo1 = new System.Windows.Forms.Label();
            this.buttonOptionsPath = new System.Windows.Forms.Button();
            this.buttonOptionsAdd = new System.Windows.Forms.Button();
            this.labelOptionsName = new System.Windows.Forms.Label();
            this.labelOptionsPath = new System.Windows.Forms.Label();
            this.textBoxOptionsName = new System.Windows.Forms.TextBox();
            this.buttonOptionsRemove = new System.Windows.Forms.Button();
            this.buttonOptionsPlay = new System.Windows.Forms.Button();
            this.listBoxOptions = new System.Windows.Forms.ListBox();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.openFileDialogSound = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.SlateBlue;
            this.buttonExit.Location = new System.Drawing.Point(3, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(22, 22);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(126, 24);
            this.tabControl1.Location = new System.Drawing.Point(-5, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 427);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tabPage1.Controls.Add(this.labelFavInfo2);
            this.tabPage1.Controls.Add(this.labelFavInfo1);
            this.tabPage1.Controls.Add(this.buttonFavStop);
            this.tabPage1.Controls.Add(this.buttonFav9);
            this.tabPage1.Controls.Add(this.buttonFav8);
            this.tabPage1.Controls.Add(this.buttonFav7);
            this.tabPage1.Controls.Add(this.buttonFav6);
            this.tabPage1.Controls.Add(this.buttonFav5);
            this.tabPage1.Controls.Add(this.buttonFav4);
            this.tabPage1.Controls.Add(this.buttonFav3);
            this.tabPage1.Controls.Add(this.buttonFav2);
            this.tabPage1.Controls.Add(this.buttonFav1);
            this.tabPage1.Controls.Add(this.buttonFavPlay);
            this.tabPage1.Controls.Add(this.listBoxFav);
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.SlateBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Favourites";
            // 
            // labelFavInfo2
            // 
            this.labelFavInfo2.AutoSize = true;
            this.labelFavInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.labelFavInfo2.Location = new System.Drawing.Point(211, 212);
            this.labelFavInfo2.Name = "labelFavInfo2";
            this.labelFavInfo2.Size = new System.Drawing.Size(300, 13);
            this.labelFavInfo2.TabIndex = 20;
            this.labelFavInfo2.Text = "Drag a sound from the list onto a button to assgn it";
            // 
            // labelFavInfo1
            // 
            this.labelFavInfo1.AutoSize = true;
            this.labelFavInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.labelFavInfo1.Location = new System.Drawing.Point(211, 225);
            this.labelFavInfo1.Name = "labelFavInfo1";
            this.labelFavInfo1.Size = new System.Drawing.Size(374, 13);
            this.labelFavInfo1.TabIndex = 19;
            this.labelFavInfo1.Text = "Hotkeys are bound to Alt+ Num1-9 . Alt+Num0 to stop playback";
            // 
            // buttonFavStop
            // 
            this.buttonFavStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonFavStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFavStop.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFavStop.ForeColor = System.Drawing.Color.SlateBlue;
            this.buttonFavStop.Location = new System.Drawing.Point(172, 326);
            this.buttonFavStop.Name = "buttonFavStop";
            this.buttonFavStop.Size = new System.Drawing.Size(24, 24);
            this.buttonFavStop.TabIndex = 18;
            this.buttonFavStop.TabStop = false;
            this.buttonFavStop.Text = "￭";
            this.buttonFavStop.UseVisualStyleBackColor = false;
            this.buttonFavStop.Click += new System.EventHandler(this.buttonFavStop_Click);
            // 
            // buttonFav9
            // 
            this.buttonFav9.AllowDrop = true;
            this.buttonFav9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonFav9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFav9.Location = new System.Drawing.Point(475, 167);
            this.buttonFav9.Name = "buttonFav9";
            this.buttonFav9.Size = new System.Drawing.Size(120, 42);
            this.buttonFav9.TabIndex = 17;
            this.buttonFav9.TabStop = false;
            this.buttonFav9.Text = "9";
            this.buttonFav9.UseVisualStyleBackColor = false;
            this.buttonFav9.Click += new System.EventHandler(this.buttonFav9_Click);
            this.buttonFav9.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonFav9_DragDrop);
            this.buttonFav9.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonFav9_DragEnter);
            // 
            // buttonFav8
            // 
            this.buttonFav8.AllowDrop = true;
            this.buttonFav8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonFav8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFav8.Location = new System.Drawing.Point(334, 167);
            this.buttonFav8.Name = "buttonFav8";
            this.buttonFav8.Size = new System.Drawing.Size(120, 42);
            this.buttonFav8.TabIndex = 16;
            this.buttonFav8.TabStop = false;
            this.buttonFav8.Text = "8";
            this.buttonFav8.UseVisualStyleBackColor = false;
            this.buttonFav8.Click += new System.EventHandler(this.buttonFav8_Click);
            this.buttonFav8.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonFav8_DragDrop);
            this.buttonFav8.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonFav8_DragEnter);
            // 
            // buttonFav7
            // 
            this.buttonFav7.AllowDrop = true;
            this.buttonFav7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonFav7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFav7.Location = new System.Drawing.Point(195, 167);
            this.buttonFav7.Name = "buttonFav7";
            this.buttonFav7.Size = new System.Drawing.Size(120, 42);
            this.buttonFav7.TabIndex = 15;
            this.buttonFav7.TabStop = false;
            this.buttonFav7.Text = "7";
            this.buttonFav7.UseVisualStyleBackColor = false;
            this.buttonFav7.Click += new System.EventHandler(this.buttonFav7_Click);
            this.buttonFav7.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonFav7_DragDrop);
            this.buttonFav7.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonFav7_DragEnter);
            // 
            // buttonFav6
            // 
            this.buttonFav6.AllowDrop = true;
            this.buttonFav6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonFav6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFav6.Location = new System.Drawing.Point(475, 98);
            this.buttonFav6.Name = "buttonFav6";
            this.buttonFav6.Size = new System.Drawing.Size(120, 42);
            this.buttonFav6.TabIndex = 14;
            this.buttonFav6.TabStop = false;
            this.buttonFav6.Text = "6";
            this.buttonFav6.UseVisualStyleBackColor = false;
            this.buttonFav6.Click += new System.EventHandler(this.buttonFav6_Click);
            this.buttonFav6.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonFav6_DragDrop);
            this.buttonFav6.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonFav6_DragEnter);
            // 
            // buttonFav5
            // 
            this.buttonFav5.AllowDrop = true;
            this.buttonFav5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonFav5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFav5.Location = new System.Drawing.Point(334, 98);
            this.buttonFav5.Name = "buttonFav5";
            this.buttonFav5.Size = new System.Drawing.Size(120, 42);
            this.buttonFav5.TabIndex = 13;
            this.buttonFav5.TabStop = false;
            this.buttonFav5.Text = "5";
            this.buttonFav5.UseVisualStyleBackColor = false;
            this.buttonFav5.Click += new System.EventHandler(this.buttonFav5_Click);
            this.buttonFav5.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonFav5_DragDrop);
            this.buttonFav5.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonFav5_DragEnter);
            // 
            // buttonFav4
            // 
            this.buttonFav4.AllowDrop = true;
            this.buttonFav4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonFav4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFav4.Location = new System.Drawing.Point(195, 98);
            this.buttonFav4.Name = "buttonFav4";
            this.buttonFav4.Size = new System.Drawing.Size(120, 42);
            this.buttonFav4.TabIndex = 12;
            this.buttonFav4.TabStop = false;
            this.buttonFav4.Text = "4";
            this.buttonFav4.UseVisualStyleBackColor = false;
            this.buttonFav4.Click += new System.EventHandler(this.buttonFav4_Click);
            this.buttonFav4.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonFav4_DragDrop);
            this.buttonFav4.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonFav4_DragEnter);
            // 
            // buttonFav3
            // 
            this.buttonFav3.AllowDrop = true;
            this.buttonFav3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonFav3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFav3.Location = new System.Drawing.Point(475, 31);
            this.buttonFav3.Name = "buttonFav3";
            this.buttonFav3.Size = new System.Drawing.Size(120, 42);
            this.buttonFav3.TabIndex = 11;
            this.buttonFav3.TabStop = false;
            this.buttonFav3.Text = "3";
            this.buttonFav3.UseVisualStyleBackColor = false;
            this.buttonFav3.Click += new System.EventHandler(this.buttonFav3_Click);
            this.buttonFav3.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonFav3_DragDrop);
            this.buttonFav3.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonFav3_DragEnter);
            // 
            // buttonFav2
            // 
            this.buttonFav2.AllowDrop = true;
            this.buttonFav2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonFav2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFav2.Location = new System.Drawing.Point(334, 31);
            this.buttonFav2.Name = "buttonFav2";
            this.buttonFav2.Size = new System.Drawing.Size(120, 42);
            this.buttonFav2.TabIndex = 10;
            this.buttonFav2.TabStop = false;
            this.buttonFav2.Text = "2";
            this.buttonFav2.UseVisualStyleBackColor = false;
            this.buttonFav2.Click += new System.EventHandler(this.buttonFav2_Click);
            this.buttonFav2.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonFav2_DragDrop);
            this.buttonFav2.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonFav2_DragEnter);
            // 
            // buttonFav1
            // 
            this.buttonFav1.AllowDrop = true;
            this.buttonFav1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonFav1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFav1.Location = new System.Drawing.Point(195, 31);
            this.buttonFav1.Name = "buttonFav1";
            this.buttonFav1.Size = new System.Drawing.Size(120, 42);
            this.buttonFav1.TabIndex = 9;
            this.buttonFav1.TabStop = false;
            this.buttonFav1.Text = "1";
            this.buttonFav1.UseVisualStyleBackColor = false;
            this.buttonFav1.Click += new System.EventHandler(this.buttonFav1_Click);
            this.buttonFav1.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonFav1_DragDrop);
            this.buttonFav1.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonFav1_DragEnter);
            // 
            // buttonFavPlay
            // 
            this.buttonFavPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonFavPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFavPlay.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFavPlay.ForeColor = System.Drawing.Color.SlateBlue;
            this.buttonFavPlay.Location = new System.Drawing.Point(172, 356);
            this.buttonFavPlay.Name = "buttonFavPlay";
            this.buttonFavPlay.Size = new System.Drawing.Size(24, 24);
            this.buttonFavPlay.TabIndex = 6;
            this.buttonFavPlay.TabStop = false;
            this.buttonFavPlay.Text = "▶";
            this.buttonFavPlay.UseVisualStyleBackColor = false;
            this.buttonFavPlay.Click += new System.EventHandler(this.buttonFavPlay_Click);
            // 
            // listBoxFav
            // 
            this.listBoxFav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBoxFav.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.listBoxFav.FormattingEnabled = true;
            this.listBoxFav.Location = new System.Drawing.Point(13, 16);
            this.listBoxFav.Name = "listBoxFav";
            this.listBoxFav.ScrollAlwaysVisible = true;
            this.listBoxFav.Size = new System.Drawing.Size(153, 364);
            this.listBoxFav.Sorted = true;
            this.listBoxFav.TabIndex = 5;
            this.listBoxFav.TabStop = false;
            this.listBoxFav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxFav_MouseDown);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tabPage5.Controls.Add(this.labelOptions3);
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.Controls.Add(this.linkOptionsDirectory);
            this.tabPage5.Controls.Add(this.buttonOptionsStop);
            this.tabPage5.Controls.Add(this.labelOptionsInfo2);
            this.tabPage5.Controls.Add(this.textBoxOptionsPath);
            this.tabPage5.Controls.Add(this.labelOptionsInfo1);
            this.tabPage5.Controls.Add(this.buttonOptionsPath);
            this.tabPage5.Controls.Add(this.buttonOptionsAdd);
            this.tabPage5.Controls.Add(this.labelOptionsName);
            this.tabPage5.Controls.Add(this.labelOptionsPath);
            this.tabPage5.Controls.Add(this.textBoxOptionsName);
            this.tabPage5.Controls.Add(this.buttonOptionsRemove);
            this.tabPage5.Controls.Add(this.buttonOptionsPlay);
            this.tabPage5.Controls.Add(this.listBoxOptions);
            this.tabPage5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(626, 395);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Options";
            // 
            // labelOptions3
            // 
            this.labelOptions3.AutoSize = true;
            this.labelOptions3.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptions3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.labelOptions3.Location = new System.Drawing.Point(86, 213);
            this.labelOptions3.Name = "labelOptions3";
            this.labelOptions3.Size = new System.Drawing.Size(275, 12);
            this.labelOptions3.TabIndex = 17;
            this.labelOptions3.Text = "Or drag multiple .wav files onto the panel above";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.labelOptionsInfo4);
            this.panel1.Location = new System.Drawing.Point(138, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 34);
            this.panel1.TabIndex = 16;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // labelOptionsInfo4
            // 
            this.labelOptionsInfo4.AutoSize = true;
            this.labelOptionsInfo4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptionsInfo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.labelOptionsInfo4.Location = new System.Drawing.Point(49, 10);
            this.labelOptionsInfo4.Name = "labelOptionsInfo4";
            this.labelOptionsInfo4.Size = new System.Drawing.Size(63, 13);
            this.labelOptionsInfo4.TabIndex = 18;
            this.labelOptionsInfo4.Text = "drag here";
            // 
            // linkOptionsDirectory
            // 
            this.linkOptionsDirectory.ActiveLinkColor = System.Drawing.Color.BlueViolet;
            this.linkOptionsDirectory.AutoSize = true;
            this.linkOptionsDirectory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkOptionsDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.linkOptionsDirectory.LinkArea = new System.Windows.Forms.LinkArea(6, 4);
            this.linkOptionsDirectory.LinkColor = System.Drawing.Color.MediumPurple;
            this.linkOptionsDirectory.Location = new System.Drawing.Point(138, 366);
            this.linkOptionsDirectory.Name = "linkOptionsDirectory";
            this.linkOptionsDirectory.Size = new System.Drawing.Size(234, 18);
            this.linkOptionsDirectory.TabIndex = 15;
            this.linkOptionsDirectory.TabStop = true;
            this.linkOptionsDirectory.Text = "Click HERE to open the .ini directory";
            this.linkOptionsDirectory.UseCompatibleTextRendering = true;
            this.linkOptionsDirectory.UseMnemonic = false;
            this.linkOptionsDirectory.VisitedLinkColor = System.Drawing.Color.MediumPurple;
            this.linkOptionsDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOptionsDirectory_LinkClicked);
            // 
            // buttonOptionsStop
            // 
            this.buttonOptionsStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonOptionsStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptionsStop.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold);
            this.buttonOptionsStop.ForeColor = System.Drawing.Color.SlateBlue;
            this.buttonOptionsStop.Location = new System.Drawing.Point(487, 358);
            this.buttonOptionsStop.Name = "buttonOptionsStop";
            this.buttonOptionsStop.Size = new System.Drawing.Size(24, 24);
            this.buttonOptionsStop.TabIndex = 14;
            this.buttonOptionsStop.TabStop = false;
            this.buttonOptionsStop.Text = "￭";
            this.buttonOptionsStop.UseVisualStyleBackColor = false;
            this.buttonOptionsStop.Click += new System.EventHandler(this.buttonOptionsStop_Click);
            // 
            // labelOptionsInfo2
            // 
            this.labelOptionsInfo2.AutoSize = true;
            this.labelOptionsInfo2.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptionsInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.labelOptionsInfo2.Location = new System.Drawing.Point(250, 49);
            this.labelOptionsInfo2.Name = "labelOptionsInfo2";
            this.labelOptionsInfo2.Size = new System.Drawing.Size(122, 12);
            this.labelOptionsInfo2.TabIndex = 13;
            this.labelOptionsInfo2.Text = "Max. 2-12 characters";
            // 
            // textBoxOptionsPath
            // 
            this.textBoxOptionsPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxOptionsPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOptionsPath.Enabled = false;
            this.textBoxOptionsPath.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptionsPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxOptionsPath.Location = new System.Drawing.Point(88, 103);
            this.textBoxOptionsPath.MaxLength = 1028;
            this.textBoxOptionsPath.Name = "textBoxOptionsPath";
            this.textBoxOptionsPath.Size = new System.Drawing.Size(311, 19);
            this.textBoxOptionsPath.TabIndex = 12;
            this.textBoxOptionsPath.TabStop = false;
            // 
            // labelOptionsInfo1
            // 
            this.labelOptionsInfo1.AutoSize = true;
            this.labelOptionsInfo1.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptionsInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.labelOptionsInfo1.Location = new System.Drawing.Point(171, 80);
            this.labelOptionsInfo1.Name = "labelOptionsInfo1";
            this.labelOptionsInfo1.Size = new System.Drawing.Size(228, 12);
            this.labelOptionsInfo1.TabIndex = 11;
            this.labelOptionsInfo1.Text = "Or drag/drop a .wav file onto the button";
            // 
            // buttonOptionsPath
            // 
            this.buttonOptionsPath.AllowDrop = true;
            this.buttonOptionsPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonOptionsPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptionsPath.ForeColor = System.Drawing.Color.SlateBlue;
            this.buttonOptionsPath.Location = new System.Drawing.Point(88, 73);
            this.buttonOptionsPath.Name = "buttonOptionsPath";
            this.buttonOptionsPath.Size = new System.Drawing.Size(80, 24);
            this.buttonOptionsPath.TabIndex = 10;
            this.buttonOptionsPath.TabStop = false;
            this.buttonOptionsPath.Text = "Open File";
            this.buttonOptionsPath.UseVisualStyleBackColor = false;
            this.buttonOptionsPath.Click += new System.EventHandler(this.buttonOptionsPath_Click);
            this.buttonOptionsPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonOptionsPath_DragDrop);
            this.buttonOptionsPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonOptionsPath_DragEnter);
            // 
            // buttonOptionsAdd
            // 
            this.buttonOptionsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonOptionsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptionsAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOptionsAdd.ForeColor = System.Drawing.Color.SlateBlue;
            this.buttonOptionsAdd.Location = new System.Drawing.Point(88, 130);
            this.buttonOptionsAdd.Name = "buttonOptionsAdd";
            this.buttonOptionsAdd.Size = new System.Drawing.Size(80, 24);
            this.buttonOptionsAdd.TabIndex = 9;
            this.buttonOptionsAdd.TabStop = false;
            this.buttonOptionsAdd.Text = "Add";
            this.buttonOptionsAdd.UseVisualStyleBackColor = false;
            this.buttonOptionsAdd.Click += new System.EventHandler(this.buttonOptionsAdd_Click);
            // 
            // labelOptionsName
            // 
            this.labelOptionsName.AutoSize = true;
            this.labelOptionsName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptionsName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelOptionsName.Location = new System.Drawing.Point(37, 47);
            this.labelOptionsName.Name = "labelOptionsName";
            this.labelOptionsName.Size = new System.Drawing.Size(45, 14);
            this.labelOptionsName.TabIndex = 8;
            this.labelOptionsName.Text = "Name";
            // 
            // labelOptionsPath
            // 
            this.labelOptionsPath.AutoSize = true;
            this.labelOptionsPath.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptionsPath.Location = new System.Drawing.Point(45, 104);
            this.labelOptionsPath.Name = "labelOptionsPath";
            this.labelOptionsPath.Size = new System.Drawing.Size(37, 14);
            this.labelOptionsPath.TabIndex = 7;
            this.labelOptionsPath.Text = "Path";
            // 
            // textBoxOptionsName
            // 
            this.textBoxOptionsName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxOptionsName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOptionsName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOptionsName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxOptionsName.Location = new System.Drawing.Point(88, 46);
            this.textBoxOptionsName.MaxLength = 12;
            this.textBoxOptionsName.Name = "textBoxOptionsName";
            this.textBoxOptionsName.Size = new System.Drawing.Size(156, 21);
            this.textBoxOptionsName.TabIndex = 5;
            this.textBoxOptionsName.TabStop = false;
            // 
            // buttonOptionsRemove
            // 
            this.buttonOptionsRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonOptionsRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptionsRemove.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOptionsRemove.ForeColor = System.Drawing.Color.SlateBlue;
            this.buttonOptionsRemove.Location = new System.Drawing.Point(517, 358);
            this.buttonOptionsRemove.Name = "buttonOptionsRemove";
            this.buttonOptionsRemove.Size = new System.Drawing.Size(64, 24);
            this.buttonOptionsRemove.TabIndex = 3;
            this.buttonOptionsRemove.TabStop = false;
            this.buttonOptionsRemove.Text = "Remove";
            this.buttonOptionsRemove.UseVisualStyleBackColor = false;
            this.buttonOptionsRemove.Click += new System.EventHandler(this.buttonOptionsRemove_Click);
            // 
            // buttonOptionsPlay
            // 
            this.buttonOptionsPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonOptionsPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptionsPlay.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold);
            this.buttonOptionsPlay.ForeColor = System.Drawing.Color.SlateBlue;
            this.buttonOptionsPlay.Location = new System.Drawing.Point(457, 358);
            this.buttonOptionsPlay.Name = "buttonOptionsPlay";
            this.buttonOptionsPlay.Size = new System.Drawing.Size(24, 24);
            this.buttonOptionsPlay.TabIndex = 1;
            this.buttonOptionsPlay.TabStop = false;
            this.buttonOptionsPlay.Text = "▶";
            this.buttonOptionsPlay.UseVisualStyleBackColor = false;
            this.buttonOptionsPlay.Click += new System.EventHandler(this.buttonOptionsPlay_Click);
            // 
            // listBoxOptions
            // 
            this.listBoxOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBoxOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.listBoxOptions.FormattingEnabled = true;
            this.listBoxOptions.ItemHeight = 14;
            this.listBoxOptions.Location = new System.Drawing.Point(423, 14);
            this.listBoxOptions.Name = "listBoxOptions";
            this.listBoxOptions.ScrollAlwaysVisible = true;
            this.listBoxOptions.Size = new System.Drawing.Size(194, 336);
            this.listBoxOptions.Sorted = true;
            this.listBoxOptions.TabIndex = 0;
            this.listBoxOptions.TabStop = false;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.SlateBlue;
            this.buttonMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMinimize.Location = new System.Drawing.Point(31, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(22, 22);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Text = "─";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // openFileDialogSound
            // 
            this.openFileDialogSound.Filter = ".wav Sound Files|*.wav";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "The Soundboard has been minimized to Tray";
            this.notifyIcon1.BalloonTipTitle = "Soundboard";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Soundboard by Mistereo";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Soundboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonOptionsRemove;
        private System.Windows.Forms.Button buttonOptionsPlay;
        private System.Windows.Forms.ListBox listBoxOptions;
        private System.Windows.Forms.Button buttonFavPlay;
        private System.Windows.Forms.ListBox listBoxFav;
        private System.Windows.Forms.Button buttonFav9;
        private System.Windows.Forms.Button buttonFav8;
        private System.Windows.Forms.Button buttonFav7;
        private System.Windows.Forms.Button buttonFav6;
        private System.Windows.Forms.Button buttonFav5;
        private System.Windows.Forms.Button buttonFav4;
        private System.Windows.Forms.Button buttonFav3;
        private System.Windows.Forms.Button buttonFav2;
        private System.Windows.Forms.Button buttonFav1;
        private System.Windows.Forms.Button buttonOptionsAdd;
        private System.Windows.Forms.Label labelOptionsName;
        private System.Windows.Forms.Label labelOptionsPath;
        private System.Windows.Forms.TextBox textBoxOptionsName;
        private System.Windows.Forms.Button buttonOptionsPath;
        private System.Windows.Forms.Label labelOptionsInfo1;
        private System.Windows.Forms.TextBox textBoxOptionsPath;
        private System.Windows.Forms.Label labelOptionsInfo2;
        private System.Windows.Forms.OpenFileDialog openFileDialogSound;
        private System.Windows.Forms.Button buttonOptionsStop;
        private System.Windows.Forms.Button buttonFavStop;
        private System.Windows.Forms.Label labelFavInfo1;
        private System.Windows.Forms.LinkLabel linkOptionsDirectory;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label labelFavInfo2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelOptions3;
        private System.Windows.Forms.Label labelOptionsInfo4;
    }
}

