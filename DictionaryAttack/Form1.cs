﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiddler;
using HtmlAgilityPack;
using ScintillaNET;

namespace DictionaryAttack
{
    public partial class Form1 : Form
    {
        private Credentials credentials = new Credentials();

        delegate void updateTextBox();

        public Form1()
        {
            InitializeComponent();
            webBrowser.Navigate(textBoxUrl.Text);

            comboBoxHash.SelectedIndex = 0;
            comboBoxHashTypeDictionary.SelectedIndex = 0;
            comboBoxStopConditions.SelectedIndex = 0;
            comboBoxStopConditionsID.SelectedIndex = 0;
            comboBoxHashUtilities.SelectedIndex = 0;

            updateIDs("//input", listBoxInputID);
            updateIDs("//button", listBoxButtonID);

            toolTip.SetToolTip(listBoxInputID, "Click on an item to copy it to the clipboard.");
            toolTip.SetToolTip(listBoxButtonID, "Click on an item to copy it to the clipboard.");

            ScintillaConfig.loadHtmlStyleConfig(scintillaDocumentTextBox);
            scintillaDocumentTextBox.Text = webBrowser.DocumentText;
        }


        private void updatePostURL()
        {
            string login = (comboBoxHash.SelectedIndex > 0) 
                ? hashString(textBoxLogin.Text, comboBoxHash.SelectedIndex)
                : textBoxLogin.Text;

             login = (checkBoxLogin.Checked)
                ? encodeString(login)
                : login;

            string password = (comboBoxHash.SelectedIndex > 0)
                ? hashString(textBoxPassword.Text, comboBoxHash.SelectedIndex)
                : textBoxPassword.Text;

            password = (checkBoxPassword.Checked)
                ? encodeString(password)
                : password;


            if (!String.IsNullOrEmpty(textBoxLogin.Text) && !String.IsNullOrEmpty(textBoxPassword.Text))
                textBoxPostString.Text = "login=" + login + "&password=" + password;

            else if (!String.IsNullOrEmpty(textBoxLogin.Text))
                textBoxPostString.Text = "login=" + login;

            else if (!String.IsNullOrEmpty(textBoxPassword.Text))
                textBoxPostString.Text = "password=" + password;
            else
                textBoxPostString.Text = "";
        }

        private string hashString(string plaintext, int index)
        {
            switch (index)
            {
                // UPERCASE HASHES
                case 1:
                    return EncodeUtilities.md5(plaintext, "X2");
                case 2:
                    return EncodeUtilities.ripemd160(plaintext, "X2");
                case 3:
                    return EncodeUtilities.sha1(plaintext, "X2");
                case 4:
                    return EncodeUtilities.sha256(plaintext, "X2");
                case 5:
                    return EncodeUtilities.sha384(plaintext, "X2");
                case 6:
                    return EncodeUtilities.sha512(plaintext, "X2");
                //LOWERCASE HASHES
                case 7:
                    return EncodeUtilities.md5(plaintext, "x2");
                case 8:
                    return EncodeUtilities.ripemd160(plaintext, "x2");
                case 9:
                    return EncodeUtilities.sha1(plaintext, "x2");
                case 10:
                    return EncodeUtilities.sha256(plaintext, "x2");
                case 11:
                    return EncodeUtilities.sha384(plaintext, "x2");
                case 12:
                    return EncodeUtilities.sha512(plaintext, "x2");

                default: return plaintext;
            }
        }

        private string encodeString(string text)
        {
            return EncodeUtilities.base64Encode(text);
        }

        private string decodeString(string text)
        {
            string output = "DECODE ERROR";
            try
            {
                output = EncodeUtilities.base64Decode(text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return output;
        }


        private void buttonGo_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(textBoxUrl.Text);
        }

        private void Navigate(string address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }

            try
            {
                webBrowser.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void textBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(textBoxUrl.Text);
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            string postData = textBoxPostString.Text;
            string postUrl = textBoxPostUrl.Text;
            byte[] postDataByte = Encoding.UTF8.GetBytes(postData);
            string AdditionalHeaders = "Content-Type: application/x-www-form-urlencoded" + Environment.NewLine;
            webBrowser.Navigate(postUrl, "", postDataByte, AdditionalHeaders);
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (textBoxUrl.Text != e.Url.ToString())
            {
                textBoxUrl.Text = e.Url.ToString();
                scintillaDocumentTextBox.Text = webBrowser.DocumentText;
                //Highlighter.highlightHTMLText(richTextBoxDocumentText);
                updateIDs("//input", listBoxInputID);
                updateIDs("//button", listBoxButtonID);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            updatePostURL();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            updatePostURL();
        }

        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
        {
            updatePostURL();
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            updatePostURL();
        }

        private void comboBoxEncode_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePostURL();
        }

        private void comboBoxStopConditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStopConditions.SelectedIndex == 1)
                textBoxRequestedUrl.Visible = true;
            else
                textBoxRequestedUrl.Visible = false;
        }

        //    private void buttonLoadFromFile_Click(object sender, EventArgs e, Button button)
        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            loadFromFile(buttonStart);
        }

        private void loadFromFile(Button button)
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                credentials.loadCredentialsFormFile(filePath);

                if (credentials.ListOfCredentials.Count > 0)
                {
                    button.Enabled = true;
                    richTextBoxLog.AppendText(getTime() + ' ' + "-! Dictionary loaded from file !-\n");
                    richTextBoxLog.AppendText(credentials.credentialsListToString()); // load to log container
                }
            }
        }

        private string getTime()
        {
            return DateTime.Now.ToString("hh:mm:ss");
        }

        private async Task PageLoad(int timeOut, int delay)
        {
            TaskCompletionSource<bool> pageLoaded = null;
            pageLoaded = new TaskCompletionSource<bool>();
            int timeElapsed = 0;
            webBrowser.DocumentCompleted += (s, e) =>
            {
                if (webBrowser.ReadyState != WebBrowserReadyState.Complete)
                    return;
                if (pageLoaded.Task.IsCompleted)
                    return;

                pageLoaded.SetResult(true);
            };

            while (pageLoaded.Task.Status != TaskStatus.RanToCompletion)
            {
                await Task.Delay(delay);
                timeElapsed++;
                if (timeElapsed >= timeOut * 100)
                    pageLoaded.TrySetResult(true);
            }
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            string postUrl = textBoxPostUrlDictionary.Text;
            string AdditionalHeaders = "Content-Type: application/x-www-form-urlencoded" + Environment.NewLine;
            string documentTextStartPage = webBrowser.DocumentText;
            string startUrl = webBrowser.Url.ToString();
            bool isSuccess = false;

            LinkedList<Credential> hashedCredentials = hashCredentials();
            LinkedList<Credential> encodedCredentials = encodeCredentials(hashedCredentials);

            //show new dictionary
            if (!encodedCredentials.Equals(credentials.ListOfCredentials))
            {
                richTextBoxLog.AppendText("\n" + getTime() + " Dictionary after processing [login:password]" +
                                          Environment.NewLine);
                richTextBoxLog.AppendText(listToString(encodedCredentials) + Environment.NewLine);
            }

            richTextBoxLog.AppendText(getTime() + " -! Performing post attack !-\r\n");

            for (int i = 0; i < encodedCredentials.Count; i++)
            {
                string postData = textBoxPostStringSyntax.Text
                    .Replace("$0", encodedCredentials.ElementAt(i).Login)
                    .Replace("$1", encodedCredentials.ElementAt(i).Password);

                byte[] postDataByte = Encoding.UTF8.GetBytes(postData);

                webBrowser.Navigate(postUrl, "", postDataByte, AdditionalHeaders);
                string postLog = "credential [" + credentials.ListOfCredentials.ElementAt(i).Login +
                                 ':' + credentials.ListOfCredentials.ElementAt(i).Password + "]\r\npost string= \"" +
                                 postData + "\"";

                richTextBoxLog.AppendText(getTime() + " For " + postLog + Environment.NewLine);

                try
                {
                    await PageLoad(1000, int.Parse(textBoxPostDelay.Text));
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                //execute stop conditions - dictionary attack success
                if (isStopCondition(comboBoxStopConditions.SelectedIndex, documentTextStartPage,
                    textBoxRequestedUrl.Text, startUrl, webBrowser))
                {
                    isSuccess = true;
                    string successLog = "Login success for " + postLog;
                    richTextBoxLog.AppendText("\r\n" + getTime() + " -! " + successLog + " !-\r\n");
                    MessageBox.Show(successLog, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            // dictionary attack fail
                if (!isSuccess)
                {
                    string fail = "Dictionary attack failed";
                    richTextBoxLog.AppendText("\r\n" + getTime() + " -! " + fail + " !-\r\n");
                    MessageBox.Show(fail + '.', "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //save log to file
                showSaveLogMessage();
        }
        
    
        private void showSaveLogMessage()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save the log to a file?",
                "Save log to file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    richTextBoxLog.SaveFile(filePath, RichTextBoxStreamType.UnicodePlainText);

                    richTextBoxLog.AppendText(Environment.NewLine + " -! Log file saved to file: " + filePath +
                                              " !-\r\n");
                }
            }
        }

        private LinkedList<Credential> hashCredentials()
        {
            LinkedList<Credential> hashedCredentials = new LinkedList<Credential>();

            if (comboBoxHashTypeDictionary.SelectedIndex == 0) //plaintext
                return credentials.ListOfCredentials;

            foreach (var item in credentials.ListOfCredentials)
            {
                hashedCredentials.AddLast(new Credential (hashString(item.Login, comboBoxHashTypeDictionary.SelectedIndex),
                                                        hashString(item.Password, comboBoxHashTypeDictionary.SelectedIndex)));
            }
            return hashedCredentials;
        }

        private LinkedList<Credential> encodeCredentials(LinkedList<Credential> credentials)
        {
            LinkedList<Credential> encodeCredentials = new LinkedList<Credential>();
            foreach (var item in credentials)
            {
                if (!checkBoxLoginEncodeDictionary.Checked && !checkBoxPasswordEncodeDictionary.Checked) // none
                    return credentials;

                else if (!checkBoxLoginEncodeDictionary.Checked && checkBoxPasswordEncodeDictionary.Checked
                ) // only password
                    encodeCredentials.AddLast(new Credential(
                        item.Login,
                        encodeString(item.Password)));

                else if (checkBoxLoginEncodeDictionary.Checked && !checkBoxPasswordEncodeDictionary.Checked
                ) // only login
                    encodeCredentials.AddLast(new Credential(
                        encodeString(item.Login),
                        item.Password));
                else // both
                    encodeCredentials.AddLast(new Credential(
                        encodeString(item.Login),
                        encodeString(item.Password)));
            }
            return encodeCredentials;
        }

        private string listToString(LinkedList<Credential> list)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in list)
            {
                builder.AppendLine('\t' + item.Login + ':' + item.Password);
            }

            return builder.ToString();
        }

        private bool isStopCondition(int index, string documentTextStartPage, string destinationURL, string startUrl,
            WebBrowser webBrowser)
        {
            bool isStop = false;
            switch (index)
            {
                case 0:
                    isStop = webBrowser.DocumentText.Equals(documentTextStartPage)
                        ? false
                        : true; // param documentText of startingPage
                    break;
                case 1:
                    isStop = webBrowser.Url.ToString().Equals(destinationURL) ? true : false; // param = destinationURL 
                    break;
                case 2:
                    isStop = webBrowser.Url.ToString().Equals(startUrl) ? false : true; // param = startUrl
                    break;
            }

            return isStop;
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox textBox = sender as RichTextBox;
            textBox.SelectionStart = textBox.Text.Length;
            textBox.ScrollToCaret();
        }

        private void startFiddler()
        {
            FiddlerApplication.AfterSessionComplete += FiddlerApplication_AfterSessionComplete;
            FiddlerApplication.Startup(8888, true, true, true);
            InstallCertificate();
        }
        
        public bool InstallCertificate()
        {
            if (!CertMaker.createRootCert())
                    return false;

            if (!CertMaker.trustRootCert())
                    return false;

            return true;
        }

        private void FiddlerApplication_AfterSessionComplete(Session session)
        {
            string output = "";

            if (session.RequestMethod == "POST")
            {
                string headers = session.oRequest.headers.ToString();
                var reqBody = session.GetRequestBodyAsString();

                string firstLine = session.RequestMethod + " " + session.fullUrl + " " +
                                   session.oRequest.headers.HTTPVersion;
                int at = headers.IndexOf("\r\n");
                if (at < 0)
                    return;
                headers = firstLine + "\r\n" + headers.Substring(at + 1);
                string separator = new String('-', 200);

                output = headers + "\r\n" +
                         (!string.IsNullOrEmpty(reqBody) ? reqBody + "\r\n" : string.Empty) +
                         separator + "\r\n\r\n";
            }

            richTextBoxPOST.Invoke(new updateTextBox(() => { richTextBoxPOST.AppendText(output); }));
        }

        private void stopFiddler()
        {
            FiddlerApplication.AfterSessionComplete -= FiddlerApplication_AfterSessionComplete;
            FiddlerApplication.Shutdown();
            CertMaker.removeFiddlerGeneratedCerts();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopFiddler();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startFiddler();
        }

        private void updateIDs(string xpath, ListBox listBox)
        {
            listBox.Items.Clear();
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.Load(new StringReader(webBrowser.DocumentText));
            HtmlNodeCollection inputIDs = document.DocumentNode.SelectNodes(xpath);

            if (inputIDs != null)
            {
                foreach (var item in inputIDs)
                {
                    if (!String.IsNullOrEmpty(item.GetAttributeValue("id", "")))
                        listBox.Items.Add(item.GetAttributeValue("id", ""));

                }
            }
        }

        private void listBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            try
            {
                Clipboard.SetText(listBox.GetItemText(listBox.SelectedItem));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

        }

        private void buttonSingleIDAttack_Click(object sender, EventArgs e)
        {
            HtmlElement password = null;
            HtmlElement login = null;
            HtmlElement submit = null;

            // login with username (program can also perform login in without username [special cases]) 
            if (!String.IsNullOrEmpty(textBoxLoginID.Text))
            {
                try
                {
                    login = webBrowser.Document.GetElementById(textBoxLoginID.Text);
                    login.SetAttribute("value", textBoxLogin_SIdA.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Wrong Login ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Console.WriteLine(exception.ToString());
                }
            }

            // perform password section
            try
            {
                password = webBrowser.Document.GetElementById(textBoxPasswordID.Text);
                password.SetAttribute("value", textBoxPassword_SIdA.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Wrong Password ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(exception.ToString());
            }

            // perform button section and click button
            try
            {
                submit = webBrowser.Document.GetElementById(textBoxButtonID.Text);
                submit.InvokeMember("click");

                //log
                richTextBoxLog.AppendText(getTime() + " -! Performing Logging in using ID !-\r\n");
                richTextBoxLog.AppendText("\tLogin id = " + textBoxLoginID.Text + Environment.NewLine);
                richTextBoxLog.AppendText("\tLogin = " + textBoxLogin_SIdA.Text + Environment.NewLine);
                richTextBoxLog.AppendText("\tPassword id = " + textBoxPasswordID.Text + Environment.NewLine);
                richTextBoxLog.AppendText("\tPassword = " + textBoxPassword_SIdA.Text + Environment.NewLine);
                richTextBoxLog.AppendText("\tButton id = " + textBoxButtonID.Text + new string('\n', 2));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Wrong Button ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(exception.ToString());
            }



            //      Logical stucture
            // login = webBrowser.Document.GetElementById(textBoxLoginID.Text);
            // password = webBrowser.Document.GetElementById(textBoxPasswordID.Text);
            // submit = webBrowser.Document.GetElementById(textBoxButtonID.Text);
            // login.SetAttribute("value", textBoxLogin_SIdA.Text);
            // password.SetAttribute("value", textBoxPassword_SIdA.Text);
            // submit.InvokeMember("click");
        }

        private void textBoxButtonID_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxButtonID.Text))
                buttonSingleIDAttack.Enabled = true;
            else
                buttonSingleIDAttack.Enabled = false;
        }

        private async void buttonStartIdAttack_Click(object sender, EventArgs e)
        {
            HtmlElement password = null;
            HtmlElement login = null;
            HtmlElement submit = null;
            bool isSuccess = false;
            string documentTextStartPage = webBrowser.DocumentText;
            string startUrl = webBrowser.Url.ToString();

            //start log
            richTextBoxLog.AppendText(getTime() + " -! Performing Logging in using ID !-\r\n");
            richTextBoxLog.AppendText("\tLogin id = " + textBoxLoginIdDictionary.Text + Environment.NewLine);
            richTextBoxLog.AppendText("\tPassword id = " + textBoxPasswordIdDictionary.Text + Environment.NewLine);
            richTextBoxLog.AppendText("\tButton id = " + textBoxButtonIdDictionary.Text + new string('\n', 2));

            foreach (var credential in credentials.ListOfCredentials)
            {
                // attack with login
                if (!checkBoxPasswordsOnly.Checked)
                {
                    try
                    {
                        login = webBrowser.Document.GetElementById(textBoxLoginIdDictionary.Text);
                        login.SetAttribute("value", credential.Login);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Wrong Login ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine(exception.ToString());
                    }
                }

                //set password
                try
                {
                    password = webBrowser.Document.GetElementById(textBoxPasswordIdDictionary.Text);
                    password.SetAttribute("value", credential.Password);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Wrong Password ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Console.WriteLine(exception.ToString());
                }

                //invoke button click
                try
                {
                    submit = webBrowser.Document.GetElementById(textBoxButtonIdDictionary.Text);
                    submit.InvokeMember("click");

                    //log
                    richTextBoxLog.AppendText(getTime() + " Signing in using credential: "
                                                        + credential.Login + ':' + credential.Password +
                                                        Environment.NewLine);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Wrong Button ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Console.WriteLine(exception.ToString());
                }

                //wait for response from webbrowser
                try
                {
                    await PageLoad(1000, int.Parse(textBoxDelayID.Text));
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                //execute stop conditions - dictionary attack success
                if (isStopCondition(comboBoxStopConditionsID.SelectedIndex, documentTextStartPage,
                    textBoxRequestedUrlID.Text, startUrl, webBrowser))
                {
                    isSuccess = true;
                    string successLog = "Login success for credential " + credential.Login + ":" + credential.Password;
                    richTextBoxLog.AppendText("\r\n" + getTime() + " -! " + successLog + " !-\r\n");
                    MessageBox.Show(successLog, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
            //atack failed
            if (!isSuccess)
            {
                string fail = "Dictionary attack failed";
                richTextBoxLog.AppendText("\r\n" + getTime() + " -! " + fail + " !-\r\n");
                MessageBox.Show(fail + '.', "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //save log
            showSaveLogMessage();
        }

        private void buttonLoadDictionaryID_Click(object sender, EventArgs e)
        {
            loadFromFile(buttonStartIdAttack);
        }

        private void comboBoxStopConditionsID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStopConditionsID.SelectedIndex == 1)
                textBoxRequestedUrlID.Visible = true;
            else
                textBoxRequestedUrlID.Visible = false;
        }

        private void buttonFindHash_Click(object sender, EventArgs e)
        {
            string hashResult = "";
            string encodeResult = "";
            string log = "No solution found for hashes supported by the program.";
            bool success = false;
            int i = 0;
            int hashCount = comboBoxHash.Items.Count;

            while (i < hashCount && !success)
            {
                hashResult = hashString(textBoxInputPlaintextAuto.Text, i);

                // hash found
                if (hashResult.Equals(textBoxOutput.Text))
                {
                    log = "Hash = " + comboBoxHash.Items[i];
                    success = true;
                    break;
                }

                // 0 for plaintext = found only encode
                //hash + encode found

                encodeResult = encodeString(hashResult);

                if (encodeResult.Equals(textBoxOutput.Text))
                {
                    log = "Hash = " + comboBoxHash.Items[i] + Environment.NewLine +
                        "Encode = Base64";
                    success = true;
                    break;
                }

                // 0 for plaintext = found only decode
                //hash + decode found

                encodeResult = decodeString(textBoxOutput.Text);

                if (encodeResult.Equals(textBoxOutput.Text))
                {
                    log = "Hash = " + comboBoxHash.Items[i] + Environment.NewLine +
                          "Decode = Base64";
                    success = true;
                    break;
                }

                i++;
            }

            MessageBox.Show(log, (success==true) ? "Success!" : "Fail!", MessageBoxButtons.OK,
                (success == true) ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        private void updateHashOutput()
        {
            // hash text
            if (!String.IsNullOrEmpty(textBoxInputPlaintext.Text))
                textBoxOutput.Text = hashString(textBoxInputPlaintext.Text, comboBoxHashUtilities.SelectedIndex);

            // encode hash
            if (checkBoxEncode.Checked)
                textBoxOutput.Text = encodeString(textBoxOutput.Text);

            // decode hash
            if (checkBoxDecode.Checked)
                textBoxOutput.Text = decodeString(textBoxOutput.Text);
        }

        private void comboBoxHashUtilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateHashOutput();
        }

        private void textBoxInputPlaintext_TextChanged(object sender, EventArgs e)
        {
            updateHashOutput();
        }

        private void checkBoxEncode_CheckedChanged(object sender, EventArgs e)
        {
            updateHashOutput();
        }

        private void checkBoxDecode_CheckedChanged(object sender, EventArgs e)
        {
            updateHashOutput();
        }

      
    }
}
