using ScintillaNET;

namespace DictionaryAttack
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
            this.components = new System.ComponentModel.Container();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageBrowser = new System.Windows.Forms.TabPage();
            this.tabPagePOST = new System.Windows.Forms.TabPage();
            this.richTextBoxPOST = new System.Windows.Forms.RichTextBox();
            this.tabPageDocumentText = new System.Windows.Forms.TabPage();
            this.scintillaDocumentTextBox = new ScintillaNET.Scintilla();
            this.tabPageHTMLInputID = new System.Windows.Forms.TabPage();
            this.listBoxInputID = new System.Windows.Forms.ListBox();
            this.tabPageHTMLButtonID = new System.Windows.Forms.TabPage();
            this.listBoxButtonID = new System.Windows.Forms.ListBox();
            this.tabControlAttack = new System.Windows.Forms.TabControl();
            this.tabPageSingleAttack = new System.Windows.Forms.TabPage();
            this.labelPostString = new System.Windows.Forms.Label();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.textBoxPostString = new System.Windows.Forms.TextBox();
            this.checkBoxLogin = new System.Windows.Forms.CheckBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelPostUrl = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelHash = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPostUrl = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.comboBoxHash = new System.Windows.Forms.ComboBox();
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
            this.labelHashTypeDictionary = new System.Windows.Forms.Label();
            this.comboBoxHashTypeDictionary = new System.Windows.Forms.ComboBox();
            this.labelPostStringSytax = new System.Windows.Forms.Label();
            this.textBoxPostStringSyntax = new System.Windows.Forms.TextBox();
            this.labelPostUrlDictionary = new System.Windows.Forms.Label();
            this.textBoxPostUrlDictionary = new System.Windows.Forms.TextBox();
            this.tabPageIDAttack = new System.Windows.Forms.TabPage();
            this.buttonSingleIDAttack = new System.Windows.Forms.Button();
            this.labelPassword_SIdA = new System.Windows.Forms.Label();
            this.labelLogin_SIdA = new System.Windows.Forms.Label();
            this.labelButtonID = new System.Windows.Forms.Label();
            this.labelPasswordInputID = new System.Windows.Forms.Label();
            this.labelLoginInputID = new System.Windows.Forms.Label();
            this.textBoxPassword_SIdA = new System.Windows.Forms.TextBox();
            this.textBoxLogin_SIdA = new System.Windows.Forms.TextBox();
            this.textBoxButtonID = new System.Windows.Forms.TextBox();
            this.textBoxPasswordID = new System.Windows.Forms.TextBox();
            this.textBoxLoginID = new System.Windows.Forms.TextBox();
            this.tabPageIDDictionaryAttack = new System.Windows.Forms.TabPage();
            this.textBoxRequestedUrlID = new System.Windows.Forms.TextBox();
            this.labelStopConditionsID = new System.Windows.Forms.Label();
            this.comboBoxStopConditionsID = new System.Windows.Forms.ComboBox();
            this.textBoxDelayID = new System.Windows.Forms.TextBox();
            this.labelDelayID = new System.Windows.Forms.Label();
            this.buttonStartIdAttack = new System.Windows.Forms.Button();
            this.labelPerformIdAttack = new System.Windows.Forms.Label();
            this.checkBoxPasswordsOnly = new System.Windows.Forms.CheckBox();
            this.buttonLoadFormFileID = new System.Windows.Forms.Button();
            this.labelLoadDictionaryFromFileID = new System.Windows.Forms.Label();
            this.labelButtonIdDictionary = new System.Windows.Forms.Label();
            this.labelPasswordIdDictionary = new System.Windows.Forms.Label();
            this.textBoxButtonIdDictionary = new System.Windows.Forms.TextBox();
            this.textBoxPasswordIdDictionary = new System.Windows.Forms.TextBox();
            this.textBoxLoginIdDictionary = new System.Windows.Forms.TextBox();
            this.labelLoginIdDictionary = new System.Windows.Forms.Label();
            this.tabPageHash = new System.Windows.Forms.TabPage();
            this.groupBoxAutomatic = new System.Windows.Forms.GroupBox();
            this.buttonFindHash = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInputPlaintextAuto = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxInputPlaintextAuto = new System.Windows.Forms.TextBox();
            this.groupBoxManual = new System.Windows.Forms.GroupBox();
            this.checkBoxDecode = new System.Windows.Forms.CheckBox();
            this.checkBoxEncode = new System.Windows.Forms.CheckBox();
            this.labelBase64 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.comboBoxHashUtilities = new System.Windows.Forms.ComboBox();
            this.labelHashType = new System.Windows.Forms.Label();
            this.labelInputPlaintext = new System.Windows.Forms.Label();
            this.textBoxInputPlaintext = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabPageBrowser.SuspendLayout();
            this.tabPagePOST.SuspendLayout();
            this.tabPageDocumentText.SuspendLayout();
            this.tabPageHTMLInputID.SuspendLayout();
            this.tabPageHTMLButtonID.SuspendLayout();
            this.tabControlAttack.SuspendLayout();
            this.tabPageSingleAttack.SuspendLayout();
            this.tabPageDictionaryAttack.SuspendLayout();
            this.tabPageIDAttack.SuspendLayout();
            this.tabPageIDDictionaryAttack.SuspendLayout();
            this.tabPageHash.SuspendLayout();
            this.groupBoxAutomatic.SuspendLayout();
            this.groupBoxManual.SuspendLayout();
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
            this.textBoxUrl.Text = "bing.com";
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
            this.tabControl.Controls.Add(this.tabPagePOST);
            this.tabControl.Controls.Add(this.tabPageDocumentText);
            this.tabControl.Controls.Add(this.tabPageHTMLInputID);
            this.tabControl.Controls.Add(this.tabPageHTMLButtonID);
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
            // tabPagePOST
            // 
            this.tabPagePOST.Controls.Add(this.richTextBoxPOST);
            this.tabPagePOST.Location = new System.Drawing.Point(4, 22);
            this.tabPagePOST.Name = "tabPagePOST";
            this.tabPagePOST.Size = new System.Drawing.Size(953, 459);
            this.tabPagePOST.TabIndex = 2;
            this.tabPagePOST.Text = "POST Requests";
            this.tabPagePOST.UseVisualStyleBackColor = true;
            // 
            // richTextBoxPOST
            // 
            this.richTextBoxPOST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxPOST.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxPOST.Name = "richTextBoxPOST";
            this.richTextBoxPOST.Size = new System.Drawing.Size(953, 459);
            this.richTextBoxPOST.TabIndex = 0;
            this.richTextBoxPOST.Text = "";
            this.richTextBoxPOST.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // tabPageDocumentText
            // 
            this.tabPageDocumentText.Controls.Add(this.scintillaDocumentTextBox);
            this.tabPageDocumentText.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocumentText.Name = "tabPageDocumentText";
            this.tabPageDocumentText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocumentText.Size = new System.Drawing.Size(953, 459);
            this.tabPageDocumentText.TabIndex = 1;
            this.tabPageDocumentText.Text = "Document Text";
            this.tabPageDocumentText.UseVisualStyleBackColor = true;
            // 
            // scintillaDocumentTextBox
            // 
            this.scintillaDocumentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaDocumentTextBox.FontQuality = ScintillaNET.FontQuality.LcdOptimized;
            this.scintillaDocumentTextBox.Location = new System.Drawing.Point(3, 3);
            this.scintillaDocumentTextBox.Name = "scintillaDocumentTextBox";
            this.scintillaDocumentTextBox.Size = new System.Drawing.Size(947, 453);
            this.scintillaDocumentTextBox.TabIndex = 1;
            // 
            // tabPageHTMLInputID
            // 
            this.tabPageHTMLInputID.Controls.Add(this.listBoxInputID);
            this.tabPageHTMLInputID.Location = new System.Drawing.Point(4, 22);
            this.tabPageHTMLInputID.Name = "tabPageHTMLInputID";
            this.tabPageHTMLInputID.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHTMLInputID.Size = new System.Drawing.Size(953, 459);
            this.tabPageHTMLInputID.TabIndex = 3;
            this.tabPageHTMLInputID.Text = "HTML Input IDs";
            this.tabPageHTMLInputID.UseVisualStyleBackColor = true;
            // 
            // listBoxInputID
            // 
            this.listBoxInputID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInputID.FormattingEnabled = true;
            this.listBoxInputID.Location = new System.Drawing.Point(3, 3);
            this.listBoxInputID.Name = "listBoxInputID";
            this.listBoxInputID.Size = new System.Drawing.Size(947, 453);
            this.listBoxInputID.TabIndex = 0;
            this.listBoxInputID.SelectedIndexChanged += new System.EventHandler(this.listBoxID_SelectedIndexChanged);
            // 
            // tabPageHTMLButtonID
            // 
            this.tabPageHTMLButtonID.Controls.Add(this.listBoxButtonID);
            this.tabPageHTMLButtonID.Location = new System.Drawing.Point(4, 22);
            this.tabPageHTMLButtonID.Name = "tabPageHTMLButtonID";
            this.tabPageHTMLButtonID.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHTMLButtonID.Size = new System.Drawing.Size(953, 459);
            this.tabPageHTMLButtonID.TabIndex = 4;
            this.tabPageHTMLButtonID.Text = "HTML Button IDs";
            this.tabPageHTMLButtonID.UseVisualStyleBackColor = true;
            // 
            // listBoxButtonID
            // 
            this.listBoxButtonID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxButtonID.FormattingEnabled = true;
            this.listBoxButtonID.Location = new System.Drawing.Point(3, 3);
            this.listBoxButtonID.Name = "listBoxButtonID";
            this.listBoxButtonID.Size = new System.Drawing.Size(947, 453);
            this.listBoxButtonID.TabIndex = 0;
            this.listBoxButtonID.SelectedIndexChanged += new System.EventHandler(this.listBoxID_SelectedIndexChanged);
            // 
            // tabControlAttack
            // 
            this.tabControlAttack.Controls.Add(this.tabPageSingleAttack);
            this.tabControlAttack.Controls.Add(this.tabPageDictionaryAttack);
            this.tabControlAttack.Controls.Add(this.tabPageIDAttack);
            this.tabControlAttack.Controls.Add(this.tabPageIDDictionaryAttack);
            this.tabControlAttack.Controls.Add(this.tabPageHash);
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
            this.tabPageSingleAttack.Controls.Add(this.labelHash);
            this.tabPageSingleAttack.Controls.Add(this.textBoxPassword);
            this.tabPageSingleAttack.Controls.Add(this.labelPassword);
            this.tabPageSingleAttack.Controls.Add(this.textBoxPostUrl);
            this.tabPageSingleAttack.Controls.Add(this.labelLogin);
            this.tabPageSingleAttack.Controls.Add(this.comboBoxHash);
            this.tabPageSingleAttack.Location = new System.Drawing.Point(4, 22);
            this.tabPageSingleAttack.Name = "tabPageSingleAttack";
            this.tabPageSingleAttack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSingleAttack.Size = new System.Drawing.Size(684, 172);
            this.tabPageSingleAttack.TabIndex = 2;
            this.tabPageSingleAttack.Text = "Single POST";
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
            this.textBoxPostString.Multiline = true;
            this.textBoxPostString.Name = "textBoxPostString";
            this.textBoxPostString.Size = new System.Drawing.Size(337, 20);
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
            this.buttonPost.Location = new System.Drawing.Point(501, 67);
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
            // labelHash
            // 
            this.labelHash.AutoSize = true;
            this.labelHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHash.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelHash.Location = new System.Drawing.Point(64, 72);
            this.labelHash.Name = "labelHash";
            this.labelHash.Size = new System.Drawing.Size(74, 15);
            this.labelHash.TabIndex = 15;
            this.labelHash.Text = "Hash type:";
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
            this.textBoxPostUrl.Size = new System.Drawing.Size(337, 20);
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
            // comboBoxHash
            // 
            this.comboBoxHash.FormattingEnabled = true;
            this.comboBoxHash.Items.AddRange(new object[] {
            "Plaintext",
            "MD5",
            "RMD-160",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512",
            "md5",
            "rmd-160",
            "sha1",
            "sha256",
            "sha384",
            "sha512"});
            this.comboBoxHash.Location = new System.Drawing.Point(149, 71);
            this.comboBoxHash.Name = "comboBoxHash";
            this.comboBoxHash.Size = new System.Drawing.Size(215, 21);
            this.comboBoxHash.TabIndex = 12;
            this.comboBoxHash.SelectedIndexChanged += new System.EventHandler(this.comboBoxEncode_SelectedIndexChanged);
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
            this.tabPageDictionaryAttack.Controls.Add(this.labelHashTypeDictionary);
            this.tabPageDictionaryAttack.Controls.Add(this.comboBoxHashTypeDictionary);
            this.tabPageDictionaryAttack.Controls.Add(this.labelPostStringSytax);
            this.tabPageDictionaryAttack.Controls.Add(this.textBoxPostStringSyntax);
            this.tabPageDictionaryAttack.Controls.Add(this.labelPostUrlDictionary);
            this.tabPageDictionaryAttack.Controls.Add(this.textBoxPostUrlDictionary);
            this.tabPageDictionaryAttack.Location = new System.Drawing.Point(4, 22);
            this.tabPageDictionaryAttack.Name = "tabPageDictionaryAttack";
            this.tabPageDictionaryAttack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDictionaryAttack.Size = new System.Drawing.Size(684, 172);
            this.tabPageDictionaryAttack.TabIndex = 1;
            this.tabPageDictionaryAttack.Text = "POST Dictionary";
            this.tabPageDictionaryAttack.UseVisualStyleBackColor = true;
            // 
            // textBoxRequestedUrl
            // 
            this.textBoxRequestedUrl.Location = new System.Drawing.Point(411, 89);
            this.textBoxRequestedUrl.Name = "textBoxRequestedUrl";
            this.textBoxRequestedUrl.Size = new System.Drawing.Size(254, 20);
            this.textBoxRequestedUrl.TabIndex = 33;
            this.textBoxRequestedUrl.Text = "type requested url";
            this.textBoxRequestedUrl.Visible = false;
            // 
            // textBoxPostDelay
            // 
            this.textBoxPostDelay.Location = new System.Drawing.Point(566, 145);
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
            this.labelPostDelay.Location = new System.Drawing.Point(441, 146);
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
            this.label1.Location = new System.Drawing.Point(87, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 30;
            this.label1.Tag = "";
            this.label1.Text = "Perform attack:";
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(240, 143);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(124, 23);
            this.buttonStart.TabIndex = 29;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(240, 116);
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
            this.labelLoadFromFile.Location = new System.Drawing.Point(58, 118);
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
            this.comboBoxStopConditions.Location = new System.Drawing.Point(195, 89);
            this.comboBoxStopConditions.Name = "comboBoxStopConditions";
            this.comboBoxStopConditions.Size = new System.Drawing.Size(199, 21);
            this.comboBoxStopConditions.TabIndex = 26;
            this.comboBoxStopConditions.SelectedIndexChanged += new System.EventHandler(this.comboBoxStopConditions_SelectedIndexChanged);
            // 
            // labelStopConditions
            // 
            this.labelStopConditions.AutoSize = true;
            this.labelStopConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStopConditions.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelStopConditions.Location = new System.Drawing.Point(81, 90);
            this.labelStopConditions.Name = "labelStopConditions";
            this.labelStopConditions.Size = new System.Drawing.Size(110, 15);
            this.labelStopConditions.TabIndex = 25;
            this.labelStopConditions.Tag = "";
            this.labelStopConditions.Text = "Stop conditions:";
            // 
            // checkBoxPasswordEncodeDictionary
            // 
            this.checkBoxPasswordEncodeDictionary.AutoSize = true;
            this.checkBoxPasswordEncodeDictionary.Location = new System.Drawing.Point(508, 63);
            this.checkBoxPasswordEncodeDictionary.Name = "checkBoxPasswordEncodeDictionary";
            this.checkBoxPasswordEncodeDictionary.Size = new System.Drawing.Size(111, 17);
            this.checkBoxPasswordEncodeDictionary.TabIndex = 24;
            this.checkBoxPasswordEncodeDictionary.Text = "Password encode";
            this.checkBoxPasswordEncodeDictionary.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoginEncodeDictionary
            // 
            this.checkBoxLoginEncodeDictionary.AutoSize = true;
            this.checkBoxLoginEncodeDictionary.Location = new System.Drawing.Point(411, 63);
            this.checkBoxLoginEncodeDictionary.Name = "checkBoxLoginEncodeDictionary";
            this.checkBoxLoginEncodeDictionary.Size = new System.Drawing.Size(91, 17);
            this.checkBoxLoginEncodeDictionary.TabIndex = 23;
            this.checkBoxLoginEncodeDictionary.Text = "Login encode";
            this.checkBoxLoginEncodeDictionary.UseVisualStyleBackColor = true;
            // 
            // labelHashTypeDictionary
            // 
            this.labelHashTypeDictionary.AutoSize = true;
            this.labelHashTypeDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHashTypeDictionary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelHashTypeDictionary.Location = new System.Drawing.Point(110, 62);
            this.labelHashTypeDictionary.Name = "labelHashTypeDictionary";
            this.labelHashTypeDictionary.Size = new System.Drawing.Size(74, 15);
            this.labelHashTypeDictionary.TabIndex = 22;
            this.labelHashTypeDictionary.Text = "Hash type:";
            // 
            // comboBoxHashTypeDictionary
            // 
            this.comboBoxHashTypeDictionary.FormattingEnabled = true;
            this.comboBoxHashTypeDictionary.Items.AddRange(new object[] {
            "Plaintext",
            "MD5",
            "RMD-160",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512",
            "md5",
            "rmd-160",
            "sha1",
            "sha256",
            "sha384",
            "sha512"});
            this.comboBoxHashTypeDictionary.Location = new System.Drawing.Point(195, 61);
            this.comboBoxHashTypeDictionary.Name = "comboBoxHashTypeDictionary";
            this.comboBoxHashTypeDictionary.Size = new System.Drawing.Size(199, 21);
            this.comboBoxHashTypeDictionary.TabIndex = 21;
            // 
            // labelPostStringSytax
            // 
            this.labelPostStringSytax.AutoSize = true;
            this.labelPostStringSytax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPostStringSytax.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPostStringSytax.Location = new System.Drawing.Point(58, 35);
            this.labelPostStringSytax.Name = "labelPostStringSytax";
            this.labelPostStringSytax.Size = new System.Drawing.Size(131, 15);
            this.labelPostStringSytax.TabIndex = 20;
            this.labelPostStringSytax.Text = "POST string syntax:";
            // 
            // textBoxPostStringSyntax
            // 
            this.textBoxPostStringSyntax.Location = new System.Drawing.Point(195, 34);
            this.textBoxPostStringSyntax.Name = "textBoxPostStringSyntax";
            this.textBoxPostStringSyntax.Size = new System.Drawing.Size(441, 20);
            this.textBoxPostStringSyntax.TabIndex = 19;
            this.textBoxPostStringSyntax.Text = "login=$0&password=$1";
            // 
            // labelPostUrlDictionary
            // 
            this.labelPostUrlDictionary.AutoSize = true;
            this.labelPostUrlDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPostUrlDictionary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPostUrlDictionary.Location = new System.Drawing.Point(110, 9);
            this.labelPostUrlDictionary.Name = "labelPostUrlDictionary";
            this.labelPostUrlDictionary.Size = new System.Drawing.Size(79, 15);
            this.labelPostUrlDictionary.TabIndex = 18;
            this.labelPostUrlDictionary.Text = "POST URL:";
            // 
            // textBoxPostUrlDictionary
            // 
            this.textBoxPostUrlDictionary.Location = new System.Drawing.Point(195, 8);
            this.textBoxPostUrlDictionary.Name = "textBoxPostUrlDictionary";
            this.textBoxPostUrlDictionary.Size = new System.Drawing.Size(441, 20);
            this.textBoxPostUrlDictionary.TabIndex = 17;
            // 
            // tabPageIDAttack
            // 
            this.tabPageIDAttack.Controls.Add(this.buttonSingleIDAttack);
            this.tabPageIDAttack.Controls.Add(this.labelPassword_SIdA);
            this.tabPageIDAttack.Controls.Add(this.labelLogin_SIdA);
            this.tabPageIDAttack.Controls.Add(this.labelButtonID);
            this.tabPageIDAttack.Controls.Add(this.labelPasswordInputID);
            this.tabPageIDAttack.Controls.Add(this.labelLoginInputID);
            this.tabPageIDAttack.Controls.Add(this.textBoxPassword_SIdA);
            this.tabPageIDAttack.Controls.Add(this.textBoxLogin_SIdA);
            this.tabPageIDAttack.Controls.Add(this.textBoxButtonID);
            this.tabPageIDAttack.Controls.Add(this.textBoxPasswordID);
            this.tabPageIDAttack.Controls.Add(this.textBoxLoginID);
            this.tabPageIDAttack.Location = new System.Drawing.Point(4, 22);
            this.tabPageIDAttack.Name = "tabPageIDAttack";
            this.tabPageIDAttack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIDAttack.Size = new System.Drawing.Size(684, 172);
            this.tabPageIDAttack.TabIndex = 3;
            this.tabPageIDAttack.Text = "Single login using ID";
            this.tabPageIDAttack.UseVisualStyleBackColor = true;
            // 
            // buttonSingleIDAttack
            // 
            this.buttonSingleIDAttack.Enabled = false;
            this.buttonSingleIDAttack.Location = new System.Drawing.Point(469, 101);
            this.buttonSingleIDAttack.Name = "buttonSingleIDAttack";
            this.buttonSingleIDAttack.Size = new System.Drawing.Size(138, 47);
            this.buttonSingleIDAttack.TabIndex = 10;
            this.buttonSingleIDAttack.Text = "Log in";
            this.buttonSingleIDAttack.UseVisualStyleBackColor = true;
            this.buttonSingleIDAttack.Click += new System.EventHandler(this.buttonSingleIDAttack_Click);
            // 
            // labelPassword_SIdA
            // 
            this.labelPassword_SIdA.AutoSize = true;
            this.labelPassword_SIdA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword_SIdA.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPassword_SIdA.Location = new System.Drawing.Point(123, 131);
            this.labelPassword_SIdA.Name = "labelPassword_SIdA";
            this.labelPassword_SIdA.Size = new System.Drawing.Size(73, 15);
            this.labelPassword_SIdA.TabIndex = 9;
            this.labelPassword_SIdA.Text = "Password:";
            // 
            // labelLogin_SIdA
            // 
            this.labelLogin_SIdA.AutoSize = true;
            this.labelLogin_SIdA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin_SIdA.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLogin_SIdA.Location = new System.Drawing.Point(154, 104);
            this.labelLogin_SIdA.Name = "labelLogin_SIdA";
            this.labelLogin_SIdA.Size = new System.Drawing.Size(42, 13);
            this.labelLogin_SIdA.TabIndex = 8;
            this.labelLogin_SIdA.Text = "Login:";
            // 
            // labelButtonID
            // 
            this.labelButtonID.AutoSize = true;
            this.labelButtonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelButtonID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelButtonID.Location = new System.Drawing.Point(132, 74);
            this.labelButtonID.Name = "labelButtonID";
            this.labelButtonID.Size = new System.Drawing.Size(70, 15);
            this.labelButtonID.TabIndex = 7;
            this.labelButtonID.Text = "Button ID:";
            // 
            // labelPasswordInputID
            // 
            this.labelPasswordInputID.AutoSize = true;
            this.labelPasswordInputID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordInputID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPasswordInputID.Location = new System.Drawing.Point(75, 47);
            this.labelPasswordInputID.Name = "labelPasswordInputID";
            this.labelPasswordInputID.Size = new System.Drawing.Size(127, 15);
            this.labelPasswordInputID.TabIndex = 6;
            this.labelPasswordInputID.Text = "Password input ID:";
            // 
            // labelLoginInputID
            // 
            this.labelLoginInputID.AutoSize = true;
            this.labelLoginInputID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginInputID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLoginInputID.Location = new System.Drawing.Point(101, 21);
            this.labelLoginInputID.Name = "labelLoginInputID";
            this.labelLoginInputID.Size = new System.Drawing.Size(101, 15);
            this.labelLoginInputID.TabIndex = 5;
            this.labelLoginInputID.Text = "Login input ID:";
            // 
            // textBoxPassword_SIdA
            // 
            this.textBoxPassword_SIdA.Location = new System.Drawing.Point(208, 128);
            this.textBoxPassword_SIdA.Name = "textBoxPassword_SIdA";
            this.textBoxPassword_SIdA.Size = new System.Drawing.Size(237, 20);
            this.textBoxPassword_SIdA.TabIndex = 4;
            // 
            // textBoxLogin_SIdA
            // 
            this.textBoxLogin_SIdA.Location = new System.Drawing.Point(208, 101);
            this.textBoxLogin_SIdA.Name = "textBoxLogin_SIdA";
            this.textBoxLogin_SIdA.Size = new System.Drawing.Size(237, 20);
            this.textBoxLogin_SIdA.TabIndex = 3;
            // 
            // textBoxButtonID
            // 
            this.textBoxButtonID.Location = new System.Drawing.Point(208, 74);
            this.textBoxButtonID.Name = "textBoxButtonID";
            this.textBoxButtonID.Size = new System.Drawing.Size(237, 20);
            this.textBoxButtonID.TabIndex = 2;
            this.textBoxButtonID.TextChanged += new System.EventHandler(this.textBoxButtonID_TextChanged);
            // 
            // textBoxPasswordID
            // 
            this.textBoxPasswordID.Location = new System.Drawing.Point(208, 47);
            this.textBoxPasswordID.Name = "textBoxPasswordID";
            this.textBoxPasswordID.Size = new System.Drawing.Size(237, 20);
            this.textBoxPasswordID.TabIndex = 1;
            // 
            // textBoxLoginID
            // 
            this.textBoxLoginID.Location = new System.Drawing.Point(208, 20);
            this.textBoxLoginID.Name = "textBoxLoginID";
            this.textBoxLoginID.Size = new System.Drawing.Size(237, 20);
            this.textBoxLoginID.TabIndex = 0;
            // 
            // tabPageIDDictionaryAttack
            // 
            this.tabPageIDDictionaryAttack.Controls.Add(this.textBoxRequestedUrlID);
            this.tabPageIDDictionaryAttack.Controls.Add(this.labelStopConditionsID);
            this.tabPageIDDictionaryAttack.Controls.Add(this.comboBoxStopConditionsID);
            this.tabPageIDDictionaryAttack.Controls.Add(this.textBoxDelayID);
            this.tabPageIDDictionaryAttack.Controls.Add(this.labelDelayID);
            this.tabPageIDDictionaryAttack.Controls.Add(this.buttonStartIdAttack);
            this.tabPageIDDictionaryAttack.Controls.Add(this.labelPerformIdAttack);
            this.tabPageIDDictionaryAttack.Controls.Add(this.checkBoxPasswordsOnly);
            this.tabPageIDDictionaryAttack.Controls.Add(this.buttonLoadFormFileID);
            this.tabPageIDDictionaryAttack.Controls.Add(this.labelLoadDictionaryFromFileID);
            this.tabPageIDDictionaryAttack.Controls.Add(this.labelButtonIdDictionary);
            this.tabPageIDDictionaryAttack.Controls.Add(this.labelPasswordIdDictionary);
            this.tabPageIDDictionaryAttack.Controls.Add(this.textBoxButtonIdDictionary);
            this.tabPageIDDictionaryAttack.Controls.Add(this.textBoxPasswordIdDictionary);
            this.tabPageIDDictionaryAttack.Controls.Add(this.textBoxLoginIdDictionary);
            this.tabPageIDDictionaryAttack.Controls.Add(this.labelLoginIdDictionary);
            this.tabPageIDDictionaryAttack.Location = new System.Drawing.Point(4, 22);
            this.tabPageIDDictionaryAttack.Name = "tabPageIDDictionaryAttack";
            this.tabPageIDDictionaryAttack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIDDictionaryAttack.Size = new System.Drawing.Size(684, 172);
            this.tabPageIDDictionaryAttack.TabIndex = 4;
            this.tabPageIDDictionaryAttack.Text = "Dictionary ID Attack";
            this.tabPageIDDictionaryAttack.UseVisualStyleBackColor = true;
            // 
            // textBoxRequestedUrlID
            // 
            this.textBoxRequestedUrlID.Location = new System.Drawing.Point(429, 89);
            this.textBoxRequestedUrlID.Name = "textBoxRequestedUrlID";
            this.textBoxRequestedUrlID.Size = new System.Drawing.Size(242, 20);
            this.textBoxRequestedUrlID.TabIndex = 15;
            this.textBoxRequestedUrlID.Text = "type requested url";
            this.textBoxRequestedUrlID.Visible = false;
            // 
            // labelStopConditionsID
            // 
            this.labelStopConditionsID.AutoSize = true;
            this.labelStopConditionsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStopConditionsID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelStopConditionsID.Location = new System.Drawing.Point(90, 88);
            this.labelStopConditionsID.Name = "labelStopConditionsID";
            this.labelStopConditionsID.Size = new System.Drawing.Size(112, 15);
            this.labelStopConditionsID.TabIndex = 14;
            this.labelStopConditionsID.Text = "Stop Conditions:";
            // 
            // comboBoxStopConditionsID
            // 
            this.comboBoxStopConditionsID.FormattingEnabled = true;
            this.comboBoxStopConditionsID.Items.AddRange(new object[] {
            "Document text changed",
            "Reaching the requested url",
            "Redirected to another site"});
            this.comboBoxStopConditionsID.Location = new System.Drawing.Point(208, 88);
            this.comboBoxStopConditionsID.Name = "comboBoxStopConditionsID";
            this.comboBoxStopConditionsID.Size = new System.Drawing.Size(215, 21);
            this.comboBoxStopConditionsID.TabIndex = 13;
            this.comboBoxStopConditionsID.SelectedIndexChanged += new System.EventHandler(this.comboBoxStopConditionsID_SelectedIndexChanged);
            // 
            // textBoxDelayID
            // 
            this.textBoxDelayID.Location = new System.Drawing.Point(560, 132);
            this.textBoxDelayID.Name = "textBoxDelayID";
            this.textBoxDelayID.Size = new System.Drawing.Size(70, 20);
            this.textBoxDelayID.TabIndex = 12;
            this.textBoxDelayID.Text = "300";
            // 
            // labelDelayID
            // 
            this.labelDelayID.AutoSize = true;
            this.labelDelayID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDelayID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDelayID.Location = new System.Drawing.Point(474, 132);
            this.labelDelayID.Name = "labelDelayID";
            this.labelDelayID.Size = new System.Drawing.Size(80, 15);
            this.labelDelayID.TabIndex = 11;
            this.labelDelayID.Text = "Delay (ms):";
            // 
            // buttonStartIdAttack
            // 
            this.buttonStartIdAttack.Enabled = false;
            this.buttonStartIdAttack.Location = new System.Drawing.Point(208, 140);
            this.buttonStartIdAttack.Name = "buttonStartIdAttack";
            this.buttonStartIdAttack.Size = new System.Drawing.Size(98, 23);
            this.buttonStartIdAttack.TabIndex = 10;
            this.buttonStartIdAttack.Text = "START";
            this.buttonStartIdAttack.UseVisualStyleBackColor = true;
            this.buttonStartIdAttack.Click += new System.EventHandler(this.buttonStartIdAttack_Click);
            // 
            // labelPerformIdAttack
            // 
            this.labelPerformIdAttack.AutoSize = true;
            this.labelPerformIdAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPerformIdAttack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPerformIdAttack.Location = new System.Drawing.Point(98, 143);
            this.labelPerformIdAttack.Name = "labelPerformIdAttack";
            this.labelPerformIdAttack.Size = new System.Drawing.Size(104, 15);
            this.labelPerformIdAttack.TabIndex = 9;
            this.labelPerformIdAttack.Text = "Perform attack:";
            // 
            // checkBoxPasswordsOnly
            // 
            this.checkBoxPasswordsOnly.AutoSize = true;
            this.checkBoxPasswordsOnly.Location = new System.Drawing.Point(324, 118);
            this.checkBoxPasswordsOnly.Name = "checkBoxPasswordsOnly";
            this.checkBoxPasswordsOnly.Size = new System.Drawing.Size(99, 17);
            this.checkBoxPasswordsOnly.TabIndex = 8;
            this.checkBoxPasswordsOnly.Text = "Passwords only";
            this.checkBoxPasswordsOnly.UseVisualStyleBackColor = true;
            // 
            // buttonLoadFormFileID
            // 
            this.buttonLoadFormFileID.Location = new System.Drawing.Point(208, 114);
            this.buttonLoadFormFileID.Name = "buttonLoadFormFileID";
            this.buttonLoadFormFileID.Size = new System.Drawing.Size(98, 23);
            this.buttonLoadFormFileID.TabIndex = 7;
            this.buttonLoadFormFileID.Text = "Load...";
            this.buttonLoadFormFileID.UseVisualStyleBackColor = true;
            this.buttonLoadFormFileID.Click += new System.EventHandler(this.buttonLoadDictionaryID_Click);
            // 
            // labelLoadDictionaryFromFileID
            // 
            this.labelLoadDictionaryFromFileID.AutoSize = true;
            this.labelLoadDictionaryFromFileID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoadDictionaryFromFileID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLoadDictionaryFromFileID.Location = new System.Drawing.Point(36, 114);
            this.labelLoadDictionaryFromFileID.Name = "labelLoadDictionaryFromFileID";
            this.labelLoadDictionaryFromFileID.Size = new System.Drawing.Size(166, 15);
            this.labelLoadDictionaryFromFileID.TabIndex = 6;
            this.labelLoadDictionaryFromFileID.Text = "Load dictionary from file:";
            // 
            // labelButtonIdDictionary
            // 
            this.labelButtonIdDictionary.AutoSize = true;
            this.labelButtonIdDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelButtonIdDictionary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelButtonIdDictionary.Location = new System.Drawing.Point(132, 64);
            this.labelButtonIdDictionary.Name = "labelButtonIdDictionary";
            this.labelButtonIdDictionary.Size = new System.Drawing.Size(70, 15);
            this.labelButtonIdDictionary.TabIndex = 5;
            this.labelButtonIdDictionary.Text = "Button ID:";
            // 
            // labelPasswordIdDictionary
            // 
            this.labelPasswordIdDictionary.AutoSize = true;
            this.labelPasswordIdDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordIdDictionary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPasswordIdDictionary.Location = new System.Drawing.Point(75, 37);
            this.labelPasswordIdDictionary.Name = "labelPasswordIdDictionary";
            this.labelPasswordIdDictionary.Size = new System.Drawing.Size(127, 15);
            this.labelPasswordIdDictionary.TabIndex = 4;
            this.labelPasswordIdDictionary.Text = "Password input ID:";
            // 
            // textBoxButtonIdDictionary
            // 
            this.textBoxButtonIdDictionary.Location = new System.Drawing.Point(208, 63);
            this.textBoxButtonIdDictionary.Name = "textBoxButtonIdDictionary";
            this.textBoxButtonIdDictionary.Size = new System.Drawing.Size(215, 20);
            this.textBoxButtonIdDictionary.TabIndex = 3;
            // 
            // textBoxPasswordIdDictionary
            // 
            this.textBoxPasswordIdDictionary.Location = new System.Drawing.Point(208, 36);
            this.textBoxPasswordIdDictionary.Name = "textBoxPasswordIdDictionary";
            this.textBoxPasswordIdDictionary.Size = new System.Drawing.Size(215, 20);
            this.textBoxPasswordIdDictionary.TabIndex = 2;
            // 
            // textBoxLoginIdDictionary
            // 
            this.textBoxLoginIdDictionary.Location = new System.Drawing.Point(208, 9);
            this.textBoxLoginIdDictionary.Name = "textBoxLoginIdDictionary";
            this.textBoxLoginIdDictionary.Size = new System.Drawing.Size(215, 20);
            this.textBoxLoginIdDictionary.TabIndex = 1;
            // 
            // labelLoginIdDictionary
            // 
            this.labelLoginIdDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginIdDictionary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLoginIdDictionary.Location = new System.Drawing.Point(100, 12);
            this.labelLoginIdDictionary.Name = "labelLoginIdDictionary";
            this.labelLoginIdDictionary.Size = new System.Drawing.Size(102, 20);
            this.labelLoginIdDictionary.TabIndex = 0;
            this.labelLoginIdDictionary.Text = "Login input ID:";
            // 
            // tabPageHash
            // 
            this.tabPageHash.Controls.Add(this.groupBoxAutomatic);
            this.tabPageHash.Controls.Add(this.groupBoxManual);
            this.tabPageHash.Location = new System.Drawing.Point(4, 22);
            this.tabPageHash.Name = "tabPageHash";
            this.tabPageHash.Size = new System.Drawing.Size(684, 172);
            this.tabPageHash.TabIndex = 6;
            this.tabPageHash.Text = "Encode/ Hash Utilities ";
            this.tabPageHash.UseVisualStyleBackColor = true;
            // 
            // groupBoxAutomatic
            // 
            this.groupBoxAutomatic.Controls.Add(this.buttonFindHash);
            this.groupBoxAutomatic.Controls.Add(this.label3);
            this.groupBoxAutomatic.Controls.Add(this.labelInputPlaintextAuto);
            this.groupBoxAutomatic.Controls.Add(this.textBox3);
            this.groupBoxAutomatic.Controls.Add(this.textBoxInputPlaintextAuto);
            this.groupBoxAutomatic.Location = new System.Drawing.Point(339, 4);
            this.groupBoxAutomatic.Name = "groupBoxAutomatic";
            this.groupBoxAutomatic.Size = new System.Drawing.Size(332, 156);
            this.groupBoxAutomatic.TabIndex = 1;
            this.groupBoxAutomatic.TabStop = false;
            this.groupBoxAutomatic.Text = "Automatic mode";
            // 
            // buttonFindHash
            // 
            this.buttonFindHash.Location = new System.Drawing.Point(90, 105);
            this.buttonFindHash.Name = "buttonFindHash";
            this.buttonFindHash.Size = new System.Drawing.Size(227, 30);
            this.buttonFindHash.TabIndex = 4;
            this.buttonFindHash.Text = "Detect hash/encode function";
            this.buttonFindHash.UseVisualStyleBackColor = true;
            this.buttonFindHash.Click += new System.EventHandler(this.buttonFindHash_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output \r\nCiphertext:";
            // 
            // labelInputPlaintextAuto
            // 
            this.labelInputPlaintextAuto.AutoSize = true;
            this.labelInputPlaintextAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInputPlaintextAuto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelInputPlaintextAuto.Location = new System.Drawing.Point(8, 30);
            this.labelInputPlaintextAuto.Name = "labelInputPlaintextAuto";
            this.labelInputPlaintextAuto.Size = new System.Drawing.Size(66, 30);
            this.labelInputPlaintextAuto.TabIndex = 2;
            this.labelInputPlaintextAuto.Text = "Input \r\nplaintext:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBoxInputPlaintextAuto
            // 
            this.textBoxInputPlaintextAuto.Location = new System.Drawing.Point(90, 35);
            this.textBoxInputPlaintextAuto.Name = "textBoxInputPlaintextAuto";
            this.textBoxInputPlaintextAuto.Size = new System.Drawing.Size(227, 20);
            this.textBoxInputPlaintextAuto.TabIndex = 0;
            // 
            // groupBoxManual
            // 
            this.groupBoxManual.Controls.Add(this.checkBoxDecode);
            this.groupBoxManual.Controls.Add(this.checkBoxEncode);
            this.groupBoxManual.Controls.Add(this.labelBase64);
            this.groupBoxManual.Controls.Add(this.label2);
            this.groupBoxManual.Controls.Add(this.textBoxOutput);
            this.groupBoxManual.Controls.Add(this.comboBoxHashUtilities);
            this.groupBoxManual.Controls.Add(this.labelHashType);
            this.groupBoxManual.Controls.Add(this.labelInputPlaintext);
            this.groupBoxManual.Controls.Add(this.textBoxInputPlaintext);
            this.groupBoxManual.Location = new System.Drawing.Point(14, 4);
            this.groupBoxManual.Name = "groupBoxManual";
            this.groupBoxManual.Size = new System.Drawing.Size(319, 157);
            this.groupBoxManual.TabIndex = 0;
            this.groupBoxManual.TabStop = false;
            this.groupBoxManual.Text = "Manual mode";
            // 
            // checkBoxDecode
            // 
            this.checkBoxDecode.AutoSize = true;
            this.checkBoxDecode.Location = new System.Drawing.Point(188, 90);
            this.checkBoxDecode.Name = "checkBoxDecode";
            this.checkBoxDecode.Size = new System.Drawing.Size(62, 17);
            this.checkBoxDecode.TabIndex = 8;
            this.checkBoxDecode.Text = "decode";
            this.checkBoxDecode.UseVisualStyleBackColor = true;
            this.checkBoxDecode.CheckedChanged += new System.EventHandler(this.checkBoxDecode_CheckedChanged);
            // 
            // checkBoxEncode
            // 
            this.checkBoxEncode.AutoSize = true;
            this.checkBoxEncode.Location = new System.Drawing.Point(111, 90);
            this.checkBoxEncode.Name = "checkBoxEncode";
            this.checkBoxEncode.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEncode.TabIndex = 7;
            this.checkBoxEncode.Text = "encode";
            this.checkBoxEncode.UseVisualStyleBackColor = true;
            this.checkBoxEncode.CheckedChanged += new System.EventHandler(this.checkBoxEncode_CheckedChanged);
            // 
            // labelBase64
            // 
            this.labelBase64.AutoSize = true;
            this.labelBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBase64.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelBase64.Location = new System.Drawing.Point(46, 89);
            this.labelBase64.Name = "labelBase64";
            this.labelBase64.Size = new System.Drawing.Size(59, 15);
            this.labelBase64.TabIndex = 6;
            this.labelBase64.Text = "Base64:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(65, 115);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(245, 20);
            this.textBoxOutput.TabIndex = 4;
            // 
            // comboBoxHashUtilities
            // 
            this.comboBoxHashUtilities.FormattingEnabled = true;
            this.comboBoxHashUtilities.Items.AddRange(new object[] {
            "Plaintext",
            "MD5",
            "RMD-160",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512",
            "md5",
            "rmd-160",
            "sha1",
            "sha256",
            "sha384",
            "sha512"});
            this.comboBoxHashUtilities.Location = new System.Drawing.Point(111, 60);
            this.comboBoxHashUtilities.Name = "comboBoxHashUtilities";
            this.comboBoxHashUtilities.Size = new System.Drawing.Size(199, 21);
            this.comboBoxHashUtilities.TabIndex = 3;
            this.comboBoxHashUtilities.SelectedIndexChanged += new System.EventHandler(this.comboBoxHashUtilities_SelectedIndexChanged);
            // 
            // labelHashType
            // 
            this.labelHashType.AutoSize = true;
            this.labelHashType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHashType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelHashType.Location = new System.Drawing.Point(31, 64);
            this.labelHashType.Name = "labelHashType";
            this.labelHashType.Size = new System.Drawing.Size(74, 15);
            this.labelHashType.TabIndex = 2;
            this.labelHashType.Text = "Hash type:";
            // 
            // labelInputPlaintext
            // 
            this.labelInputPlaintext.AutoSize = true;
            this.labelInputPlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInputPlaintext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelInputPlaintext.Location = new System.Drawing.Point(3, 37);
            this.labelInputPlaintext.Name = "labelInputPlaintext";
            this.labelInputPlaintext.Size = new System.Drawing.Size(102, 15);
            this.labelInputPlaintext.TabIndex = 1;
            this.labelInputPlaintext.Text = "Input plaintext:";
            // 
            // textBoxInputPlaintext
            // 
            this.textBoxInputPlaintext.Location = new System.Drawing.Point(111, 34);
            this.textBoxInputPlaintext.Name = "textBoxInputPlaintext";
            this.textBoxInputPlaintext.Size = new System.Drawing.Size(199, 20);
            this.textBoxInputPlaintext.TabIndex = 0;
            this.textBoxInputPlaintext.TextChanged += new System.EventHandler(this.textBoxInputPlaintext_TextChanged);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 7000;
            this.toolTip.InitialDelay = 1;
            this.toolTip.ReshowDelay = 1;
            this.toolTip.ShowAlways = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
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
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
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
            this.Text = "Dictionary Attack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageBrowser.ResumeLayout(false);
            this.tabPagePOST.ResumeLayout(false);
            this.tabPageDocumentText.ResumeLayout(false);
            this.tabPageHTMLInputID.ResumeLayout(false);
            this.tabPageHTMLButtonID.ResumeLayout(false);
            this.tabControlAttack.ResumeLayout(false);
            this.tabPageSingleAttack.ResumeLayout(false);
            this.tabPageSingleAttack.PerformLayout();
            this.tabPageDictionaryAttack.ResumeLayout(false);
            this.tabPageDictionaryAttack.PerformLayout();
            this.tabPageIDAttack.ResumeLayout(false);
            this.tabPageIDAttack.PerformLayout();
            this.tabPageIDDictionaryAttack.ResumeLayout(false);
            this.tabPageIDDictionaryAttack.PerformLayout();
            this.tabPageHash.ResumeLayout(false);
            this.groupBoxAutomatic.ResumeLayout(false);
            this.groupBoxAutomatic.PerformLayout();
            this.groupBoxManual.ResumeLayout(false);
            this.groupBoxManual.PerformLayout();
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
        private Scintilla scintillaDocumentTextBox;
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
        private System.Windows.Forms.Label labelHash;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPostUrl;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.ComboBox comboBoxHash;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Label labelLoadFromFile;
        private System.Windows.Forms.ComboBox comboBoxStopConditions;
        private System.Windows.Forms.Label labelStopConditions;
        private System.Windows.Forms.CheckBox checkBoxPasswordEncodeDictionary;
        private System.Windows.Forms.CheckBox checkBoxLoginEncodeDictionary;
        private System.Windows.Forms.Label labelHashTypeDictionary;
        private System.Windows.Forms.ComboBox comboBoxHashTypeDictionary;
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
        private System.Windows.Forms.TabPage tabPagePOST;
        private System.Windows.Forms.RichTextBox richTextBoxPOST;
        private System.Windows.Forms.TabPage tabPageHTMLInputID;
        private System.Windows.Forms.ListBox listBoxInputID;
        private System.Windows.Forms.TabPage tabPageHTMLButtonID;
        private System.Windows.Forms.ListBox listBoxButtonID;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tabPageIDAttack;
        private System.Windows.Forms.Label labelPassword_SIdA;
        private System.Windows.Forms.Label labelLogin_SIdA;
        private System.Windows.Forms.Label labelButtonID;
        private System.Windows.Forms.Label labelPasswordInputID;
        private System.Windows.Forms.Label labelLoginInputID;
        private System.Windows.Forms.TextBox textBoxPassword_SIdA;
        private System.Windows.Forms.TextBox textBoxLogin_SIdA;
        private System.Windows.Forms.TextBox textBoxButtonID;
        private System.Windows.Forms.TextBox textBoxPasswordID;
        private System.Windows.Forms.TextBox textBoxLoginID;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonSingleIDAttack;
        private System.Windows.Forms.TabPage tabPageIDDictionaryAttack;
        private System.Windows.Forms.Label labelLoginIdDictionary;
        private System.Windows.Forms.TextBox textBoxPasswordIdDictionary;
        private System.Windows.Forms.TextBox textBoxLoginIdDictionary;
        private System.Windows.Forms.TextBox textBoxButtonIdDictionary;
        private System.Windows.Forms.Label labelButtonIdDictionary;
        private System.Windows.Forms.Label labelPasswordIdDictionary;
        private System.Windows.Forms.Button buttonStartIdAttack;
        private System.Windows.Forms.Label labelPerformIdAttack;
        private System.Windows.Forms.CheckBox checkBoxPasswordsOnly;
        private System.Windows.Forms.Button buttonLoadFormFileID;
        private System.Windows.Forms.Label labelLoadDictionaryFromFileID;
        private System.Windows.Forms.Label labelDelayID;
        private System.Windows.Forms.TextBox textBoxDelayID;
        private System.Windows.Forms.Label labelStopConditionsID;
        private System.Windows.Forms.ComboBox comboBoxStopConditionsID;
        private System.Windows.Forms.TextBox textBoxRequestedUrlID;
        private System.Windows.Forms.TabPage tabPageHash;
        private System.Windows.Forms.GroupBox groupBoxAutomatic;
        private System.Windows.Forms.GroupBox groupBoxManual;
        private System.Windows.Forms.Label labelBase64;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.ComboBox comboBoxHashUtilities;
        private System.Windows.Forms.Label labelHashType;
        private System.Windows.Forms.Label labelInputPlaintext;
        private System.Windows.Forms.TextBox textBoxInputPlaintext;
        private System.Windows.Forms.CheckBox checkBoxDecode;
        private System.Windows.Forms.CheckBox checkBoxEncode;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxInputPlaintextAuto;
        private System.Windows.Forms.Button buttonFindHash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInputPlaintextAuto;
    }
}

