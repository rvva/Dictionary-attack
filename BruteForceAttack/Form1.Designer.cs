namespace BruteForceAttack
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageBrowser = new System.Windows.Forms.TabPage();
            this.tabPageDocumentText = new System.Windows.Forms.TabPage();
            this.richTextBoxDocumentText = new System.Windows.Forms.RichTextBox();
            this.tabControlAttack = new System.Windows.Forms.TabControl();
            this.tabPageSingleAttack = new System.Windows.Forms.TabPage();
            this.labelPostString = new System.Windows.Forms.Label();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.textBoxPostString = new System.Windows.Forms.TextBox();
            this.checkBoxLogin = new System.Windows.Forms.CheckBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelPostUrl = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelEncode = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPostUrl = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.comboBoxEncode = new System.Windows.Forms.ComboBox();
            this.tabPageDictionaryAttack = new System.Windows.Forms.TabPage();
            this.textBoxRequestedUrl = new System.Windows.Forms.TextBox();
            this.textBoxPostDelay = new System.Windows.Forms.TextBox();
            this.labelPostDelay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.labelLoadFromFile = new System.Windows.Forms.Label();
            this.comboBoxStopConditions = new System.Windows.Forms.ComboBox();
            this.labelStopConditions = new System.Windows.Forms.Label();
            this.checkBoxPasswordEncodeDictionary = new System.Windows.Forms.CheckBox();
            this.checkBoxLoginEncodeDictionary = new System.Windows.Forms.CheckBox();
            this.labelEncodeTypeDictionary = new System.Windows.Forms.Label();
            this.comboBoxEncodeTypeDictionary = new System.Windows.Forms.ComboBox();
            this.labelPostStringSytax = new System.Windows.Forms.Label();
            this.textBoxPostStringSyntax = new System.Windows.Forms.TextBox();
            this.labelPostUrlDictionary = new System.Windows.Forms.Label();
            this.textBoxPostUrlDictionary = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPageBrowser.SuspendLayout();
            this.tabPageDocumentText.SuspendLayout();
            this.tabControlAttack.SuspendLayout();
            this.tabPageSingleAttack.SuspendLayout();
            this.tabPageDictionaryAttack.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(947, 453);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(12, 12);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(368, 20);
            this.textBoxUrl.TabIndex = 1;
            this.textBoxUrl.Text = "http://tendawifi.com/login.html";
            this.textBoxUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUrl_KeyDown);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(386, 9);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "GO";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(467, 8);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 3;
            this.buttonPrevious.Text = "<<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(548, 8);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(629, 8);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageBrowser);
            this.tabControl.Controls.Add(this.tabPageDocumentText);
            this.tabControl.Location = new System.Drawing.Point(12, 242);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(961, 485);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageBrowser
            // 
            this.tabPageBrowser.Controls.Add(this.webBrowser);
            this.tabPageBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPageBrowser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageBrowser.Location = new System.Drawing.Point(4, 22);
            this.tabPageBrowser.Name = "tabPageBrowser";
            this.tabPageBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBrowser.Size = new System.Drawing.Size(953, 459);
            this.tabPageBrowser.TabIndex = 0;
            this.tabPageBrowser.Text = "Web Browser";
            this.tabPageBrowser.UseVisualStyleBackColor = true;
            // 
            // tabPageDocumentText
            // 
            this.tabPageDocumentText.Controls.Add(this.richTextBoxDocumentText);
            this.tabPageDocumentText.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocumentText.Name = "tabPageDocumentText";
            this.tabPageDocumentText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocumentText.Size = new System.Drawing.Size(953, 459);
            this.tabPageDocumentText.TabIndex = 1;
            this.tabPageDocumentText.Text = "Document Text";
            this.tabPageDocumentText.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDocumentText
            // 
            this.richTextBoxDocumentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDocumentText.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxDocumentText.Name = "richTextBoxDocumentText";
            this.richTextBoxDocumentText.Size = new System.Drawing.Size(947, 453);
            this.richTextBoxDocumentText.TabIndex = 0;
            this.richTextBoxDocumentText.Text = "";
            // 
            // tabControlAttack
            // 
            this.tabControlAttack.Controls.Add(this.tabPageSingleAttack);
            this.tabControlAttack.Controls.Add(this.tabPageDictionaryAttack);
            this.tabControlAttack.Location = new System.Drawing.Point(12, 38);
            this.tabControlAttack.Name = "tabControlAttack";
            this.tabControlAttack.SelectedIndex = 0;
            this.tabControlAttack.Size = new System.Drawing.Size(692, 198);
            this.tabControlAttack.TabIndex = 19;
            // 
            // tabPageSingleAttack
            // 
            this.tabPageSingleAttack.Controls.Add(this.labelPostString);
            this.tabPageSingleAttack.Controls.Add(this.checkBoxPassword);
            this.tabPageSingleAttack.Controls.Add(this.textBoxPostString);
            this.tabPageSingleAttack.Controls.Add(this.checkBoxLogin);
            this.tabPageSingleAttack.Controls.Add(this.buttonPost);
            this.tabPageSingleAttack.Controls.Add(this.labelPostUrl);
            this.tabPageSingleAttack.Controls.Add(this.textBoxLogin);
            this.tabPageSingleAttack.Controls.Add(this.labelEncode);
            this.tabPageSingleAttack.Controls.Add(this.textBoxPassword);
            this.tabPageSingleAttack.Controls.Add(this.labelPassword);
            this.tabPageSingleAttack.Controls.Add(this.textBoxPostUrl);
            this.tabPageSingleAttack.Controls.Add(this.labelLogin);
            this.tabPageSingleAttack.Controls.Add(this.comboBoxEncode);
            this.tabPageSingleAttack.Location = new System.Drawing.Point(4, 22);
            this.tabPageSingleAttack.Name = "tabPageSingleAttack";
            this.tabPageSingleAttack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSingleAttack.Size = new System.Drawing.Size(684, 172);
            this.tabPageSingleAttack.TabIndex = 2;
            this.tabPageSingleAttack.Text = "Single attack";
            this.tabPageSingleAttack.UseVisualStyleBackColor = true;
            // 
            // labelPostString
            // 
            this.labelPostString.AutoSize = true;
            this.labelPostString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPostString.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPostString.Location = new System.Drawing.Point(56, 125);
            this.labelPostString.Name = "labelPostString";
            this.labelPostString.Size = new System.Drawing.Size(87, 15);
            this.labelPostString.TabIndex = 8;
            this.labelPostString.Text = "POST string:";
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(375, 42);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(111, 17);
            this.checkBoxPassword.TabIndex = 18;
            this.checkBoxPassword.Text = "Password encode";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // textBoxPostString
            // 
            this.textBoxPostString.Location = new System.Drawing.Point(149, 124);
            this.textBoxPostString.Name = "textBoxPostString";
            this.textBoxPostString.Size = new System.Drawing.Size(215, 20);
            this.textBoxPostString.TabIndex = 6;
            // 
            // checkBoxLogin
            // 
            this.checkBoxLogin.AutoSize = true;
            this.checkBoxLogin.Location = new System.Drawing.Point(375, 17);
            this.checkBoxLogin.Name = "checkBoxLogin";
            this.checkBoxLogin.Size = new System.Drawing.Size(91, 17);
            this.checkBoxLogin.TabIndex = 17;
            this.checkBoxLogin.Text = "Login encode";
            this.checkBoxLogin.UseVisualStyleBackColor = true;
            this.checkBoxLogin.CheckedChanged += new System.EventHandler(this.checkBoxLogin_CheckedChanged);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(375, 64);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(106, 80);
            this.buttonPost.TabIndex = 7;
            this.buttonPost.Text = "POST";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // labelPostUrl
            // 
            this.labelPostUrl.AutoSize = true;
            this.labelPostUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPostUrl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPostUrl.Location = new System.Drawing.Point(64, 99);
            this.labelPostUrl.Name = "labelPostUrl";
            this.labelPostUrl.Size = new System.Drawing.Size(79, 15);
            this.labelPostUrl.TabIndex = 16;
            this.labelPostUrl.Text = "POST URL:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(149, 17);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(215, 20);
            this.textBoxLogin.TabIndex = 9;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // labelEncode
            // 
            this.labelEncode.AutoSize = true;
            this.labelEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEncode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelEncode.Location = new System.Drawing.Point(64, 72);
            this.labelEncode.Name = "labelEncode";
            this.labelEncode.Size = new System.Drawing.Size(81, 15);
            this.labelEncode.TabIndex = 15;
            this.labelEncode.Text = "Ecode type:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(149, 43);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(215, 20);
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPassword.Location = new System.Drawing.Point(70, 44);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 15);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPostUrl
            // 
            this.textBoxPostUrl.Location = new System.Drawing.Point(149, 98);
            this.textBoxPostUrl.Name = "textBoxPostUrl";
            this.textBoxPostUrl.Size = new System.Drawing.Size(215, 20);
            this.textBoxPostUrl.TabIndex = 11;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLogin.Location = new System.Drawing.Point(96, 17);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 15);
            this.labelLogin.TabIndex = 13;
            this.labelLogin.Text = "Login:";
            // 
            // comboBoxEncode
            // 
            this.comboBoxEncode.FormattingEnabled = true;
            this.comboBoxEncode.Items.AddRange(new object[] {
            "Plaintext",
            "Base64"});
            this.comboBoxEncode.Location = new System.Drawing.Point(149, 71);
            this.comboBoxEncode.Name = "comboBoxEncode";
            this.comboBoxEncode.Size = new System.Drawing.Size(215, 21);
            this.comboBoxEncode.TabIndex = 12;
            this.comboBoxEncode.SelectedIndexChanged += new System.EventHandler(this.comboBoxEncode_SelectedIndexChanged);
            // 
            // tabPageDictionaryAttack
            // 
            this.tabPageDictionaryAttack.Controls.Add(this.textBoxRequestedUrl);
            this.tabPageDictionaryAttack.Controls.Add(this.textBoxPostDelay);
            this.tabPageDictionaryAttack.Controls.Add(this.labelPostDelay);
            this.tabPageDictionaryAttack.Controls.Add(this.label1);
            this.tabPageDictionaryAttack.Controls.Add(this.buttonStart);
            this.tabPageDictionaryAttack.Controls.Add(this.buttonLoadFromFile);
            this.tabPageDictionaryAttack.Controls.Add(this.labelLoadFromFile);
            this.tabPageDictionaryAttack.Controls.Add(this.comboBoxStopConditions);
            this.tabPageDictionaryAttack.Controls.Add(this.labelStopConditions);
            this.tabPageDictionaryAttack.Controls.Add(this.checkBoxPasswordEncodeDictionary);
            this.tabPageDictionaryAttack.Controls.Add(this.checkBoxLoginEncodeDictionary);
            this.tabPageDictionaryAttack.Controls.Add(this.labelEncodeTypeDictionary);
            this.tabPageDictionaryAttack.Controls.Add(this.comboBoxEncodeTypeDictionary);
            this.tabPageDictionaryAttack.Controls.Add(this.labelPostStringSytax);
            this.tabPageDictionaryAttack.Controls.Add(this.textBoxPostStringSyntax);
            this.tabPageDictionaryAttack.Controls.Add(this.labelPostUrlDictionary);
            this.tabPageDictionaryAttack.Controls.Add(this.textBoxPostUrlDictionary);
            this.tabPageDictionaryAttack.Location = new System.Drawing.Point(4, 22);
            this.tabPageDictionaryAttack.Name = "tabPageDictionaryAttack";
            this.tabPageDictionaryAttack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDictionaryAttack.Size = new System.Drawing.Size(684, 172);
            this.tabPageDictionaryAttack.TabIndex = 1;
            this.tabPageDictionaryAttack.Text = "Dictionary Attack";
            this.tabPageDictionaryAttack.UseVisualStyleBackColor = true;
            // 
            // textBoxRequestedUrl
            // 
            this.textBoxRequestedUrl.Location = new System.Drawing.Point(425, 90);
            this.textBoxRequestedUrl.Name = "textBoxRequestedUrl";
            this.textBoxRequestedUrl.Size = new System.Drawing.Size(239, 20);
            this.textBoxRequestedUrl.TabIndex = 33;
            this.textBoxRequestedUrl.Text = "type requested url";
            this.textBoxRequestedUrl.Visible = false;
            // 
            // textBoxPostDelay
            // 
            this.textBoxPostDelay.Location = new System.Drawing.Point(566, 146);
            this.textBoxPostDelay.Name = "textBoxPostDelay";
            this.textBoxPostDelay.Size = new System.Drawing.Size(70, 20);
            this.textBoxPostDelay.TabIndex = 32;
            this.textBoxPostDelay.Text = "200";
            // 
            // labelPostDelay
            // 
            this.labelPostDelay.AutoSize = true;
            this.labelPostDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPostDelay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPostDelay.Location = new System.Drawing.Point(441, 147);
            this.labelPostDelay.Name = "labelPostDelay";
            this.labelPostDelay.Size = new System.Drawing.Size(118, 15);
            this.labelPostDelay.TabIndex = 31;
            this.labelPostDelay.Tag = "";
            this.labelPostDelay.Text = "POST delay (ms):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(87, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 30;
            this.label1.Tag = "";
            this.label1.Text = "Perform attack:";
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(240, 144);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(124, 23);
            this.buttonStart.TabIndex = 29;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(240, 117);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(124, 23);
            this.buttonLoadFromFile.TabIndex = 28;
            this.buttonLoadFromFile.Text = "Load...";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // labelLoadFromFile
            // 
            this.labelLoadFromFile.AutoSize = true;
            this.labelLoadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoadFromFile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLoadFromFile.Location = new System.Drawing.Point(58, 119);
            this.labelLoadFromFile.Name = "labelLoadFromFile";
            this.labelLoadFromFile.Size = new System.Drawing.Size(170, 15);
            this.labelLoadFromFile.TabIndex = 27;
            this.labelLoadFromFile.Tag = "";
            this.labelLoadFromFile.Text = "Load dictionary from file: ";
            // 
            // comboBoxStopConditions
            // 
            this.comboBoxStopConditions.FormattingEnabled = true;
            this.comboBoxStopConditions.Items.AddRange(new object[] {
            "Document text changed",
            "Reaching the requested url",
            "Redirected to another site"});
            this.comboBoxStopConditions.Location = new System.Drawing.Point(195, 90);
            this.comboBoxStopConditions.Name = "comboBoxStopConditions";
            this.comboBoxStopConditions.Size = new System.Drawing.Size(215, 21);
            this.comboBoxStopConditions.TabIndex = 26;
            this.comboBoxStopConditions.SelectedIndexChanged += new System.EventHandler(this.comboBoxStopConditions_SelectedIndexChanged);
            // 
            // labelStopConditions
            // 
            this.labelStopConditions.AutoSize = true;
            this.labelStopConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStopConditions.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelStopConditions.Location = new System.Drawing.Point(81, 91);
            this.labelStopConditions.Name = "labelStopConditions";
            this.labelStopConditions.Size = new System.Drawing.Size(110, 15);
            this.labelStopConditions.TabIndex = 25;
            this.labelStopConditions.Tag = "";
            this.labelStopConditions.Text = "Stop conditions:";
            // 
            // checkBoxPasswordEncodeDictionary
            // 
            this.checkBoxPasswordEncodeDictionary.AutoSize = true;
            this.checkBoxPasswordEncodeDictionary.Location = new System.Drawing.Point(525, 69);
            this.checkBoxPasswordEncodeDictionary.Name = "checkBoxPasswordEncodeDictionary";
            this.checkBoxPasswordEncodeDictionary.Size = new System.Drawing.Size(111, 17);
            this.checkBoxPasswordEncodeDictionary.TabIndex = 24;
            this.checkBoxPasswordEncodeDictionary.Text = "Password encode";
            this.checkBoxPasswordEncodeDictionary.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoginEncodeDictionary
            // 
            this.checkBoxLoginEncodeDictionary.AutoSize = true;
            this.checkBoxLoginEncodeDictionary.Location = new System.Drawing.Point(425, 69);
            this.checkBoxLoginEncodeDictionary.Name = "checkBoxLoginEncodeDictionary";
            this.checkBoxLoginEncodeDictionary.Size = new System.Drawing.Size(91, 17);
            this.checkBoxLoginEncodeDictionary.TabIndex = 23;
            this.checkBoxLoginEncodeDictionary.Text = "Login encode";
            this.checkBoxLoginEncodeDictionary.UseVisualStyleBackColor = true;
            // 
            // labelEncodeTypeDictionary
            // 
            this.labelEncodeTypeDictionary.AutoSize = true;
            this.labelEncodeTypeDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEncodeTypeDictionary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelEncodeTypeDictionary.Location = new System.Drawing.Point(110, 63);
            this.labelEncodeTypeDictionary.Name = "labelEncodeTypeDictionary";
            this.labelEncodeTypeDictionary.Size = new System.Drawing.Size(81, 15);
            this.labelEncodeTypeDictionary.TabIndex = 22;
            this.labelEncodeTypeDictionary.Text = "Ecode type:";
            // 
            // comboBoxEncodeTypeDictionary
            // 
            this.comboBoxEncodeTypeDictionary.FormattingEnabled = true;
            this.comboBoxEncodeTypeDictionary.Items.AddRange(new object[] {
            "Plaintext",
            "Base64"});
            this.comboBoxEncodeTypeDictionary.Location = new System.Drawing.Point(195, 62);
            this.comboBoxEncodeTypeDictionary.Name = "comboBoxEncodeTypeDictionary";
            this.comboBoxEncodeTypeDictionary.Size = new System.Drawing.Size(215, 21);
            this.comboBoxEncodeTypeDictionary.TabIndex = 21;
            // 
            // labelPostStringSytax
            // 
            this.labelPostStringSytax.AutoSize = true;
            this.labelPostStringSytax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPostStringSytax.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPostStringSytax.Location = new System.Drawing.Point(58, 36);
            this.labelPostStringSytax.Name = "labelPostStringSytax";
            this.labelPostStringSytax.Size = new System.Drawing.Size(131, 15);
            this.labelPostStringSytax.TabIndex = 20;
            this.labelPostStringSytax.Text = "POST string syntax:";
            // 
            // textBoxPostStringSyntax
            // 
            this.textBoxPostStringSyntax.Location = new System.Drawing.Point(195, 35);
            this.textBoxPostStringSyntax.Name = "textBoxPostStringSyntax";
            this.textBoxPostStringSyntax.Size = new System.Drawing.Size(215, 20);
            this.textBoxPostStringSyntax.TabIndex = 19;
            this.textBoxPostStringSyntax.Text = "login=$0&password=$1";
            // 
            // labelPostUrlDictionary
            // 
            this.labelPostUrlDictionary.AutoSize = true;
            this.labelPostUrlDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPostUrlDictionary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPostUrlDictionary.Location = new System.Drawing.Point(110, 10);
            this.labelPostUrlDictionary.Name = "labelPostUrlDictionary";
            this.labelPostUrlDictionary.Size = new System.Drawing.Size(79, 15);
            this.labelPostUrlDictionary.TabIndex = 18;
            this.labelPostUrlDictionary.Text = "POST URL:";
            // 
            // textBoxPostUrlDictionary
            // 
            this.textBoxPostUrlDictionary.Location = new System.Drawing.Point(195, 9);
            this.textBoxPostUrlDictionary.Name = "textBoxPostUrlDictionary";
            this.textBoxPostUrlDictionary.Size = new System.Drawing.Size(215, 20);
            this.textBoxPostUrlDictionary.TabIndex = 17;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.richTextBoxLog);
            this.groupBox.Location = new System.Drawing.Point(710, 8);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(263, 228);
            this.groupBox.TabIndex = 20;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Log";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLog.Location = new System.Drawing.Point(6, 16);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(251, 206);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 739);
            this.Controls.Add(this.tabControlAttack);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.groupBox);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPageBrowser.ResumeLayout(false);
            this.tabPageDocumentText.ResumeLayout(false);
            this.tabControlAttack.ResumeLayout(false);
            this.tabPageSingleAttack.ResumeLayout(false);
            this.tabPageSingleAttack.PerformLayout();
            this.tabPageDictionaryAttack.ResumeLayout(false);
            this.tabPageDictionaryAttack.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageBrowser;
        private System.Windows.Forms.TabPage tabPageDocumentText;
        private System.Windows.Forms.RichTextBox richTextBoxDocumentText;
        private System.Windows.Forms.TabControl tabControlAttack;
        private System.Windows.Forms.TabPage tabPageDictionaryAttack;
        private System.Windows.Forms.TabPage tabPageSingleAttack;
        private System.Windows.Forms.Label labelPostString;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.TextBox textBoxPostString;
        private System.Windows.Forms.CheckBox checkBoxLogin;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label labelPostUrl;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelEncode;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPostUrl;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.ComboBox comboBoxEncode;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Label labelLoadFromFile;
        private System.Windows.Forms.ComboBox comboBoxStopConditions;
        private System.Windows.Forms.Label labelStopConditions;
        private System.Windows.Forms.CheckBox checkBoxPasswordEncodeDictionary;
        private System.Windows.Forms.CheckBox checkBoxLoginEncodeDictionary;
        private System.Windows.Forms.Label labelEncodeTypeDictionary;
        private System.Windows.Forms.ComboBox comboBoxEncodeTypeDictionary;
        private System.Windows.Forms.Label labelPostStringSytax;
        private System.Windows.Forms.TextBox textBoxPostStringSyntax;
        private System.Windows.Forms.Label labelPostUrlDictionary;
        private System.Windows.Forms.TextBox textBoxPostUrlDictionary;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelPostDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPostDelay;
        private System.Windows.Forms.TextBox textBoxRequestedUrl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

