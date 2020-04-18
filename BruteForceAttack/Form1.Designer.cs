using ScintillaNET;

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
            this.buttonStartIdAttack = new System.Windows.Forms.Button();
            this.labelPerformIdAttack = new System.Windows.Forms.Label();
            this.checkBoxPasswordsOnly = new System.Windows.Forms.CheckBox();
            this.buttonLoadDictionaryID = new System.Windows.Forms.Button();
            this.labelLoadDictionaryFromFileID = new System.Windows.Forms.Label();
            this.labelButtonIdDictionary = new System.Windows.Forms.Label();
            this.labelPasswordIdDictionary = new System.Windows.Forms.Label();
            this.textBoxButtonIdDictionary = new System.Windows.Forms.TextBox();
            this.textBoxPasswordIdDictionary = new System.Windows.Forms.TextBox();
            this.textBoxLoginIdDictionary = new System.Windows.Forms.TextBox();
            this.labelLoginIdDictionary = new System.Windows.Forms.Label();
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
            this.buttonLoadFromFile.Click += new System.EventHandler((sender, e) => buttonLoadFromFile_Click(sender, e, buttonStart));
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
            this.tabPageIDAttack.Text = "Single ID Attack";
            this.tabPageIDAttack.UseVisualStyleBackColor = true;
            // 
            // buttonSingleIDAttack
            // 
            this.buttonSingleIDAttack.Enabled = false;
            this.buttonSingleIDAttack.Location = new System.Drawing.Point(451, 101);
            this.buttonSingleIDAttack.Name = "buttonSingleIDAttack";
            this.buttonSingleIDAttack.Size = new System.Drawing.Size(130, 47);
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
            this.textBoxPassword_SIdA.Size = new System.Drawing.Size(215, 20);
            this.textBoxPassword_SIdA.TabIndex = 4;
            // 
            // textBoxLogin_SIdA
            // 
            this.textBoxLogin_SIdA.Location = new System.Drawing.Point(208, 101);
            this.textBoxLogin_SIdA.Name = "textBoxLogin_SIdA";
            this.textBoxLogin_SIdA.Size = new System.Drawing.Size(215, 20);
            this.textBoxLogin_SIdA.TabIndex = 3;
            // 
            // textBoxButtonID
            // 
            this.textBoxButtonID.Location = new System.Drawing.Point(208, 74);
            this.textBoxButtonID.Name = "textBoxButtonID";
            this.textBoxButtonID.Size = new System.Drawing.Size(215, 20);
            this.textBoxButtonID.TabIndex = 2;
            this.textBoxButtonID.TextChanged += new System.EventHandler(this.textBoxButtonID_TextChanged);
            // 
            // textBoxPasswordID
            // 
            this.textBoxPasswordID.Location = new System.Drawing.Point(208, 47);
            this.textBoxPasswordID.Name = "textBoxPasswordID";
            this.textBoxPasswordID.Size = new System.Drawing.Size(215, 20);
            this.textBoxPasswordID.TabIndex = 1;
            // 
            // textBoxLoginID
            // 
            this.textBoxLoginID.Location = new System.Drawing.Point(208, 20);
            this.textBoxLoginID.Name = "textBoxLoginID";
            this.textBoxLoginID.Size = new System.Drawing.Size(215, 20);
            this.textBoxLoginID.TabIndex = 0;
            // 
            // tabPageIDDictionaryAttack
            // 
            this.tabPageIDDictionaryAttack.Controls.Add(this.buttonStartIdAttack);
            this.tabPageIDDictionaryAttack.Controls.Add(this.labelPerformIdAttack);
            this.tabPageIDDictionaryAttack.Controls.Add(this.checkBoxPasswordsOnly);
            this.tabPageIDDictionaryAttack.Controls.Add(this.buttonLoadDictionaryID);
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
            // buttonStartIdAttack
            // 
            this.buttonStartIdAttack.Location = new System.Drawing.Point(223, 124);
            this.buttonStartIdAttack.Name = "buttonStartIdAttack";
            this.buttonStartIdAttack.Size = new System.Drawing.Size(98, 23);
            this.buttonStartIdAttack.TabIndex = 10;
            this.buttonStartIdAttack.Text = "START";
            this.buttonStartIdAttack.UseVisualStyleBackColor = true;
            // 
            // labelPerformIdAttack
            // 
            this.labelPerformIdAttack.AutoSize = true;
            this.labelPerformIdAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPerformIdAttack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPerformIdAttack.Location = new System.Drawing.Point(113, 127);
            this.labelPerformIdAttack.Name = "labelPerformIdAttack";
            this.labelPerformIdAttack.Size = new System.Drawing.Size(104, 15);
            this.labelPerformIdAttack.TabIndex = 9;
            this.labelPerformIdAttack.Text = "Perform attack:";
            // 
            // checkBoxPasswordsOnly
            // 
            this.checkBoxPasswordsOnly.AutoSize = true;
            this.checkBoxPasswordsOnly.Location = new System.Drawing.Point(339, 102);
            this.checkBoxPasswordsOnly.Name = "checkBoxPasswordsOnly";
            this.checkBoxPasswordsOnly.Size = new System.Drawing.Size(99, 17);
            this.checkBoxPasswordsOnly.TabIndex = 8;
            this.checkBoxPasswordsOnly.Text = "Passwords only";
            this.checkBoxPasswordsOnly.UseVisualStyleBackColor = true;
            // 
            // buttonLoadDictionaryID
            // 
            this.buttonLoadDictionaryID.Location = new System.Drawing.Point(223, 98);
            this.buttonLoadDictionaryID.Name = "buttonLoadDictionaryID";
            this.buttonLoadDictionaryID.Size = new System.Drawing.Size(98, 23);
            this.buttonLoadDictionaryID.TabIndex = 7;
            this.buttonLoadDictionaryID.Text = "Load...";
            this.buttonLoadDictionaryID.UseVisualStyleBackColor = true;
            // 
            // labelLoadDictionaryFromFileID
            // 
            this.labelLoadDictionaryFromFileID.AutoSize = true;
            this.labelLoadDictionaryFromFileID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoadDictionaryFromFileID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLoadDictionaryFromFileID.Location = new System.Drawing.Point(51, 98);
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
            this.labelButtonIdDictionary.Location = new System.Drawing.Point(147, 73);
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
            this.labelPasswordIdDictionary.Location = new System.Drawing.Point(90, 46);
            this.labelPasswordIdDictionary.Name = "labelPasswordIdDictionary";
            this.labelPasswordIdDictionary.Size = new System.Drawing.Size(127, 15);
            this.labelPasswordIdDictionary.TabIndex = 4;
            this.labelPasswordIdDictionary.Text = "Password input ID:";
            // 
            // textBoxButtonIdDictionary
            // 
            this.textBoxButtonIdDictionary.Location = new System.Drawing.Point(223, 72);
            this.textBoxButtonIdDictionary.Name = "textBoxButtonIdDictionary";
            this.textBoxButtonIdDictionary.Size = new System.Drawing.Size(215, 20);
            this.textBoxButtonIdDictionary.TabIndex = 3;
            // 
            // textBoxPasswordIdDictionary
            // 
            this.textBoxPasswordIdDictionary.Location = new System.Drawing.Point(223, 45);
            this.textBoxPasswordIdDictionary.Name = "textBoxPasswordIdDictionary";
            this.textBoxPasswordIdDictionary.Size = new System.Drawing.Size(215, 20);
            this.textBoxPasswordIdDictionary.TabIndex = 2;
            // 
            // textBoxLoginIdDictionary
            // 
            this.textBoxLoginIdDictionary.Location = new System.Drawing.Point(223, 18);
            this.textBoxLoginIdDictionary.Name = "textBoxLoginIdDictionary";
            this.textBoxLoginIdDictionary.Size = new System.Drawing.Size(215, 20);
            this.textBoxLoginIdDictionary.TabIndex = 1;
            // 
            // labelLoginIdDictionary
            // 
            this.labelLoginIdDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginIdDictionary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLoginIdDictionary.Location = new System.Drawing.Point(115, 21);
            this.labelLoginIdDictionary.Name = "labelLoginIdDictionary";
            this.labelLoginIdDictionary.Size = new System.Drawing.Size(102, 20);
            this.labelLoginIdDictionary.TabIndex = 0;
            this.labelLoginIdDictionary.Text = "Login input ID:";
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
            this.Text = "Form1";
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
        private System.Windows.Forms.Label labelEncode;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPostUrl;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.ComboBox comboBoxEncode;
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
        private System.Windows.Forms.Button buttonLoadDictionaryID;
        private System.Windows.Forms.Label labelLoadDictionaryFromFileID;
    }
}

